using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NoteApplication.Models;
using NoteApplication.Services;

namespace NoteApplication.Controllers
{
    public class TaskController
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public List<TaskItem> GetAllTasks()
        {
            return _taskService.GetAllTasks();
        }

        public TaskItem GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        public void UpdateTask(string taskName, string taskDescription)
        {
            var taskItem = new TaskItem
            {
                TaskName = taskName,
                TaskDescription = taskDescription,
                //Status = status
            };
            _taskService.AddTask(taskItem);
        }

        public void UpdateTask(int id, string taskName, string taskDescription)
        {
            var taskItem = _taskService.GetTaskById(id);
            if (taskItem != null)
            {
                taskItem.TaskName = taskName;
                taskItem.TaskDescription = taskDescription;
                //taskItem.Status = status;
                _taskService.UpdateTask(taskItem);
            }
        }

        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }

    }
}
