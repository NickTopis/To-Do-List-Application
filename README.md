# To-Do List Application

A simple and practical To-Do List app built using **C#**, **.NET**, and **Windows Forms** with JSON-based task persistence.

---

## Project Overview

This project demonstrates how to create a user-friendly task management application with two interfaces:

- **Command Line Interface (CLI)** version for lightweight, text-based interaction.
- **Windows Forms UI** version featuring a clean graphical interface with:
  - Task titles and descriptions.
  - Custom checkboxes to mark tasks as completed.
  - Automatic saving/loading of tasks in JSON format.

---

## Technologies Used

- **C#**: The core programming language powering the app logic.
- **.NET**: The framework used to build and run the application.
- **Windows Forms**: Provides the graphical UI components for the user-friendly version.
- **JSON Serialization**:
  - Tasks are saved and loaded as JSON files for persistence.
  - Both `System.Text.Json` and `Newtonsoft.Json` libraries are demonstrated to handle serialization/deserialization.
- **WinAPI**: Utilized to add placeholder text in input fields for better UX.

---

## Features

- Add, update, and remove tasks with titles and descriptions.
- Mark tasks as completed using visually enhanced checkboxes.
- Tasks are automatically saved when exiting the UI application and loaded on startup.
- Seamless user experience with immediate visual feedback.
- Demonstrates practical use of serialization in desktop apps.

---

## Getting Started

### CLI Version

- Run the console app executable to manage tasks via command line.

### Windows Forms UI Version

- Launch the UI executable to manage tasks with a graphical interface.
- Task list saves automatically when you close the app.

---

## Summary

This project is a practical example of building desktop apps with .NET and C#, featuring:

- Clear separation between UI and data logic.
- Working knowledge of JSON serialization techniques.
- Custom UI drawing techniques for enhanced control visuals.
- Simple but effective task persistence strategy.

---

Feel free to explore the code and customize it for your own needs!
