using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class ServiceService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public ServiceService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Services
        public async Task<List<Service>> GetAllServicesAsync()
        {
            return await _appDBContext.Services.Include(s => s.Process).ToListAsync();
        }
        #endregion

        #region Insert Service
        public async Task<bool> InsertSerivceAsync(Service service)
        {
            await _appDBContext.Services.AddAsync(service);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Service by Id
        public async Task<Service> GetServiceAsync(int Id)
        {
            return await _appDBContext.Services.FirstOrDefaultAsync(c => c.Id.Equals(Id));
        }
        #endregion

        #region Update Service
        public async Task<bool> UpdateServiceAsync(Service service)
        {
            _appDBContext.Services.Update(service);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Service
        public async Task<bool> DeleteServiceAsync(Service service)
        {
            _appDBContext.Remove(service);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
