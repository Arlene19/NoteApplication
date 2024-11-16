using NoteApplication.Controllers;
using NoteApplication.DAO;
using NoteApplication.Data;
using NoteApplication.Models;
using NoteApplication.Services;


namespace NoteApplication.Forms
{
    public partial class UpdateTaskForm : Form
    {
        private TaskItem _task;
        private readonly TaskController _taskController;
        public event Action UpdateTask;  
        public UpdateTaskForm(TaskItem task, TaskController taskController)
        {
            InitializeComponent();
            _task = task;
            _taskController = taskController;
            PopulateFormFields();
        }

        private void PopulateFormFields()
        {
            if (_task != null)
            {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                txtTaskName.Text = _task.TaskName;
                rtxtDescription.Text = _task.TaskDescription;

                // Add more fields as needed
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            _task.TaskName = txtTaskName.Text;
            _task.TaskDescription = rtxtDescription.Text;
            //_taskController.UpdateTask(_task.TaskName, _task.TaskDescription);
            UpdateTask?.Invoke();
            this.Close();
        }

    }
}