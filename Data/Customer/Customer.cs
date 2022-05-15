using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class Customer
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        #endregion

        #region Methods

        public static async Task<IEnumerable<string>> CustomerSearch(string value, Dictionary<int, string> CustomerList)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, don't return values (drop-down will not open)
            if (string.IsNullOrEmpty(value))
                return new string[0];
            return CustomerList.Values.ToList().Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion
    }
}
