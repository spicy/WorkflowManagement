using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    /// <summary>
    /// This is an object that relates services to a Package
    /// </summary>
    public class WorkOrderPackages
    {
        [Key]
        public int Id { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual Package Package { get; set; }
    }
}
