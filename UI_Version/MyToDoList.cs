using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace To_Do_list_with_UI
{
    public partial class MyToDoList : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        private List<TaskItem> tasks = new List<TaskItem>();

        private const int checkboxSize = 20;
        private const int checkboxMargin = 4;
        private readonly string savePath = "tasks.json";

        public MyToDoList()
        {
            InitializeComponent();
            SetPlaceholder(textBoxTitle, "Enter task");
            SetPlaceholder(textBoxDescription, "Enter task description");
            SetupListView();
            LoadTasks();
            RefreshTaskList();
            this.FormClosing += Form1_FormClosing;
            this.Resize += (s, e) => AdjustColumnWidth();
        }

        private void SetupListView()
        {
            listViewTasks.View = View.Details;
            listViewTasks.CheckBoxes = false;
            listViewTasks.FullRowSelect = true;
            listViewTasks.OwnerDraw = true;
            listViewTasks.Columns.Clear();
            listViewTasks.Columns.Add("Task");
            listViewTasks.Scrollable = true;
            listViewTasks.HeaderStyle = ColumnHeaderStyle.None;
            AdjustColumnWidth();

            listViewTasks.DrawItem += ListViewTasks_DrawItem;
            listViewTasks.MouseClick += ListViewTasks_MouseClick;
            listViewTasks.SelectedIndexChanged += ListViewTasks_SelectedIndexChanged;
            listViewTasks.Font = new Font(listViewTasks.Font.FontFamily, 14);
        }

        private void AdjustColumnWidth()
        {
            if (listViewTasks.Columns.Count > 0)
            {
                listViewTasks.Columns[0].Width = listViewTasks.ClientSize.Width - 4;
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, placeholder);
        }

        private void RefreshTaskList()
        {
            listViewTasks.Items.Clear();
            foreach (var task in tasks)
            {
                var lvi = new ListViewItem();
                lvi.Tag = task;
                listViewTasks.Items.Add(lvi);
            }
            ClearTaskDetails();
        }

        private void ClearTaskDetails()
        {
            textBoxTitle.Text = "";
            textBoxDescription.Text = "";
            listViewTasks.SelectedItems.Clear();
            buttonRemoveTask.Enabled = false;
            buttonUpdateTask.Enabled = false;
        }

        private void ListViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedTask = (TaskItem)listViewTasks.SelectedItems[0].Tag;
                textBoxTitle.Text = selectedTask.Title;
                textBoxDescription.Text = selectedTask.Description;
                buttonRemoveTask.Enabled = true;
                buttonUpdateTask.Enabled = true;
            }
            else
            {
                ClearTaskDetails();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Task title cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = new TaskItem { Title = title, Description = textBoxDescription.Text.Trim(), Completed = false };
            tasks.Add(task);
            RefreshTaskList();
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedTask = (TaskItem)listViewTasks.SelectedItems[0].Tag;
                tasks.Remove(selectedTask);
                RefreshTaskList();
            }
        }

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedTask = (TaskItem)listViewTasks.SelectedItems[0].Tag;
                string newTitle = textBoxTitle.Text.Trim();
                if (string.IsNullOrEmpty(newTitle))
                {
                    MessageBox.Show("Task title cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                selectedTask.Title = newTitle;
                selectedTask.Description = textBoxDescription.Text.Trim();
                RefreshTaskList();

                foreach (ListViewItem lvi in listViewTasks.Items)
                {
                    if (lvi.Tag == selectedTask)
                    {
                        lvi.Selected = true;
                        break;
                    }
                }
            }
        }

        private void ListViewTasks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
            var task = (TaskItem)e.Item.Tag;

            Rectangle checkboxRect = new Rectangle(
                e.Bounds.Left + checkboxMargin,
                e.Bounds.Top + (e.Bounds.Height - checkboxSize) / 2,
                checkboxSize,
                checkboxSize);

            ControlPaint.DrawCheckBox(e.Graphics, checkboxRect,
                task.Completed ? ButtonState.Checked : ButtonState.Normal);

            Rectangle textRect = new Rectangle(
                checkboxRect.Right + checkboxMargin,
                e.Bounds.Top,
                e.Bounds.Width - checkboxSize - checkboxMargin * 3,
                e.Bounds.Height);

            string displayText = $"{task.Title}";
            TextRenderer.DrawText(e.Graphics, displayText, e.Item.Font, textRect, e.Item.ForeColor,
                TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter);

            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                e.DrawFocusRectangle();
            }
        }

        private void ListViewTasks_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listViewTasks.Items)
            {
                Rectangle bounds = item.Bounds;
                Rectangle checkboxRect = new Rectangle(
                    bounds.Left + checkboxMargin,
                    bounds.Top + (bounds.Height - checkboxSize) / 2,
                    checkboxSize,
                    checkboxSize);

                if (checkboxRect.Contains(e.Location))
                {
                    var task = (TaskItem)item.Tag;
                    task.Completed = !task.Completed;
                    listViewTasks.Invalidate(item.Bounds);

                    if (item.Selected)
                    {
                        textBoxTitle.Text = task.Title;
                        textBoxDescription.Text = task.Description;
                    }
                    break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
        }

        private void SaveTasks()
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks);
                File.WriteAllText(savePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tasks: {ex.Message}");
            }
        }

        private void LoadTasks()
        {
            try
            {
                if (File.Exists(savePath))
                {
                    string json = File.ReadAllText(savePath);
                    tasks = JsonSerializer.Deserialize<List<TaskItem>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}");
            }
        }

        private void MyToDoList_Load(object sender, EventArgs e)
        {

        }
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; } = "";
        public bool Completed { get; set; } = false;
    }
}
