using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IJobTaskRepository
    {
        IEnumerable GetJobTasks();
        JobTask GetJobTaskByID(int jobTaskId);
        void InsertJobTask(JobTask jobTask);
        void DeleteJobTask(int jobTaskId);
        void UpdateJobTask(JobTask jobTask);
        void Save();
    }
}
