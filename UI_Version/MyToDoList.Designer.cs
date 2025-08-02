namespace To_Do_list_with_UI
{
    partial class MyToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonUpdateTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.labelSelectetTitle = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttinAddTask = new System.Windows.Forms.Button();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTitle.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(420, 531);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(382, 36);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUpdateTask
            // 
            this.buttonUpdateTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUpdateTask.AutoSize = true;
            this.buttonUpdateTask.Location = new System.Drawing.Point(561, 569);
            this.buttonUpdateTask.Name = "buttonUpdateTask";
            this.buttonUpdateTask.Size = new System.Drawing.Size(92, 34);
            this.buttonUpdateTask.TabIndex = 2;
            this.buttonUpdateTask.Text = "Update Task\r\n";
            this.buttonUpdateTask.UseVisualStyleBackColor = true;
            this.buttonUpdateTask.Click += new System.EventHandler(this.buttonUpdateTask_Click);
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemoveTask.AutoSize = true;
            this.buttonRemoveTask.Location = new System.Drawing.Point(668, 569);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(92, 34);
            this.buttonRemoveTask.TabIndex = 3;
            this.buttonRemoveTask.Text = "Remove Task\r\n";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // labelSelectetTitle
            // 
            this.labelSelectetTitle.AutoSize = true;
            this.labelSelectetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectetTitle.Location = new System.Drawing.Point(404, 34);
            this.labelSelectetTitle.Name = "labelSelectetTitle";
            this.labelSelectetTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSelectetTitle.Size = new System.Drawing.Size(0, 25);
            this.labelSelectetTitle.TabIndex = 5;
            this.labelSelectetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(612, 62);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(607, 636);
            this.textBoxDescription.TabIndex = 6;
            // 
            // buttinAddTask
            // 
            this.buttinAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttinAddTask.AutoSize = true;
            this.buttinAddTask.Location = new System.Drawing.Point(453, 569);
            this.buttinAddTask.Name = "buttinAddTask";
            this.buttinAddTask.Size = new System.Drawing.Size(92, 34);
            this.buttinAddTask.TabIndex = 8;
            this.buttinAddTask.Text = "Add Task\r\n";
            this.buttinAddTask.UseVisualStyleBackColor = true;
            this.buttinAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewTasks.AutoArrange = false;
            this.listViewTasks.BackColor = System.Drawing.SystemColors.Info;
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTasks.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(0, 62);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Scrollable = false;
            this.listViewTasks.Size = new System.Drawing.Size(606, 636);
            this.listViewTasks.TabIndex = 9;
            this.listViewTasks.TileSize = new System.Drawing.Size(1, 1);
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = " Things To Do ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(797, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 38);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = " Description ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyToDoList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1219, 698);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttinAddTask);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.buttonUpdateTask);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelSelectetTitle);
            this.Name = "MyToDoList";
            this.RightToLeftLayout = true;
            this.Text = "MyToDoList";
            this.Load += new System.EventHandler(this.MyToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonUpdateTask;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Label labelSelectetTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttinAddTask;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

