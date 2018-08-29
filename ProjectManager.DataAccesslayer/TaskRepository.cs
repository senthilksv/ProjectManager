using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectManager.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.DataAccesslayer
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ProjectManagerDbContext projectManagerDbContext;
        private readonly ILogger<TaskRepository> logger;
        public TaskRepository(ProjectManagerDbContext projectManagerDbContext, ILogger<TaskRepository> logger)
        {
            this.projectManagerDbContext = projectManagerDbContext;
            this.logger = logger;
        }
        public async Task<int> DeleteAsync(TaskDetail entity)
        {
            projectManagerDbContext.Tasks.Remove(entity);

            return await projectManagerDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskDetail>> GetAllAsync()
        {
            return await projectManagerDbContext.Tasks.AsNoTracking<TaskDetail>().ToListAsync();
        }

        public async Task<TaskDetail> GetAsync(int id)
        {
            return await projectManagerDbContext.Tasks.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<int> InsertAsync(TaskDetail entity)
        {
            projectManagerDbContext.Tasks.Add(entity);
            return await projectManagerDbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(int id, TaskDetail entity)
        {
            projectManagerDbContext.Tasks.Update(entity);
            return await projectManagerDbContext.SaveChangesAsync();
        }
    }
}
