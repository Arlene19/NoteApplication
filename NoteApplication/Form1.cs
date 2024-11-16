using NoteApplication.Controllers;
using NoteApplication.DAO;
using NoteApplication.Data;
using NoteApplication.Forms;
using NoteApplication.Models;
using NoteApplication.Services;

namespace NoteApplication
{
    public partial class Form1 : Form
    {
        public readonly TaskController _taskController;
        public Form1()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var taskRepository = new TaskRepository(context);
            var taskService = new TaskService(taskRepository);
            _taskController = new TaskController(taskService);
            
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            addTaskForm.TaskAdded += LoadTasks;
            addTaskForm.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void LoadTasks()
        {
            var tasks = _taskController.GetAllTasks();
            tasksPanel.Controls.Clear();
            foreach (var task in tasks)
            {
                AddTaskCard(task);
            }
        }

        private void AddTaskCard(TaskItem taskItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.MintCream,
                Margin = new Padding(11),
                Padding = new Padding(10)
            };

            // Delete Icon (Text-Based)
            var deleteIcon = new Label
            {
                Text = "Delete", // Unicode character for 'X' symbol
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 80, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteTask(taskItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "Edit", // Unicode character for pencil
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 110, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateTask(taskItem);
            cardPanel.Controls.Add(editIcon);

            var courseLabel = new Label
            {
                Text = $"{taskItem.TaskName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);

            var nameLabel = new Label
            {
                Text = $"{taskItem.TaskDescription}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(nameLabel);


            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };
            // Calculate the position for bottom right corner
            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowTaskDetails(taskItem);
            cardPanel.Controls.Add(viewDetails);

            tasksPanel.Controls.Add(cardPanel);
        }

        private void ShowTaskDetails(TaskItem taskItem)
        {
            MessageBox.Show(taskItem.TaskDescription, taskItem.TaskName);
        }

        private void UpdateTask(TaskItem taskItem)
        {
            // Logic to update the subject
            var updateTaskForm = new UpdateTaskForm(taskItem, _taskController);
            var task = _taskController.GetTaskById(taskItem.Id);
             updateTaskForm.UpdateTask += LoadTasks;
            updateTaskForm.ShowDialog();
        }

        private void DeleteTask(TaskItem taskItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {taskItem.TaskName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _taskController.DeleteTask(taskItem.Id);
                LoadTasks(); // Refresh the subjects list
            }

        }

        private void tasksPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
