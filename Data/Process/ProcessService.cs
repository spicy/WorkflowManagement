using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class ProcessService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public ProcessService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Processes
        public async Task<List<Process>> GetAllProcessesAsync()
        {
            return await _appDBContext.Processes.ToListAsync();
        }
        #endregion

        #region Insert Process
        public async Task<bool> InsertProcessAsync(Process process)
        {
            await _appDBContext.Processes.AddAsync(process);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Process by Id
        public async Task<Process> GetProcessAsync(int Id)
        {
            Process process = await _appDBContext.Processes.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return process;
        }
        #endregion

        #region Update Process
        public async Task<bool> UpdateProcessAsync(Process process)
        {
            _appDBContext.Processes.Update(process);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Process
        public async Task<bool> DeleteProcessAsync(Process process)
        {
            _appDBContext.Remove(process);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
