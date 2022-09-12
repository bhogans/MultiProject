using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface ICTaskRepository
    {
        IEnumerable GetcTasks();
        CTask GetcTaskByID(int cTaskId);
        void InsertcTask(CTask cTask);
        void DeletecTask(int cTaskId);
        void UpdatecTask(CTask cTask);
        void Save();
    }
}
