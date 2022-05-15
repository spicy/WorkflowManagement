using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class WorkOrderService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public WorkOrderService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of WorkOrders
        public async Task<List<WorkOrder>> GetAllWorkOrdersAsync()
        {
            return await _appDBContext.WorkOrders.Include(wo => wo.Customer).ToListAsync();
        }
        #endregion

        #region Insert WorkOrder
        public async Task<bool> InsertWorkOrderAsync(WorkOrder WorkOrder)
        {
            await _appDBContext.WorkOrders.AddAsync(WorkOrder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertWorkOrderServiceAsync(WorkOrderServices workOrderServices)
        {
            await _appDBContext.WorkOrderServices.AddAsync(workOrderServices);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> InsertWorkOrderPackageAsync(WorkOrderPackages workOrderPackages)
        {
            await _appDBContext.WorkOrderPackages.AddAsync(workOrderPackages);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        #endregion

        #region Get WorkOrder by Id
        public async Task<WorkOrder> GetWorkOrderAsync(int Id)
        {
            return await _appDBContext.WorkOrders.FirstOrDefaultAsync(c => c.Id.Equals(Id));
        }
        #endregion

        #region Update WorkOrder
        public async Task<bool> UpdateWorkOrderAsync(WorkOrder WorkOrder)
        {
            _appDBContext.WorkOrders.Update(WorkOrder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteWorkOrder
        public async Task<bool> DeleteWorkOrderAsync(WorkOrder WorkOrder)
        {
            _appDBContext.Remove(WorkOrder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
