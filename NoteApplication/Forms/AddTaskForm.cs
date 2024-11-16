using NoteApplication.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NoteApplication.Controllers;
using NoteApplication.DAO;
using NoteApplication.Data;
using NoteApplication.Services;

namespace NoteApplication.Forms
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskController _taskController;
        public event Action TaskAdded;
        public AddTaskForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var taskRepository = new TaskRepository(context);
            var taskService = new TaskService(taskRepository);
            _taskController = new TaskController(taskService);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string description = rtxtDescription.Text;


            _taskController.UpdateTask(taskName, description);
            MessageBox.Show("Added Successfully", "Information");


            TaskAdded?.Invoke();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
