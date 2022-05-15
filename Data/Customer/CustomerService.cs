using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class CustomerService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public CustomerService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Customers
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _appDBContext.Customers.ToListAsync();
        }
        #endregion

        #region Insert Customer
        public async Task<bool> InsertCustomerAsync(Customer customer)
        {
            await _appDBContext.Customers.AddAsync(customer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Customer by Id
        public async Task<Customer> GetCustomerAsync(int Id)
        {
            Customer customer = await _appDBContext.Customers.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return customer;
        }
        #endregion

        #region Update Customer
        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            _appDBContext.Customers.Update(customer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteCustomer
        public async Task<bool> DeleteCustomerAsync(Customer customer)
        {
            _appDBContext.Remove(customer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
