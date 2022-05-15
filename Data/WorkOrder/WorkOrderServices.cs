using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    /// <summary>
    /// NOT WorkOrderService, This is an object that relates services to a WorkOrder
    /// </summary>
    public class WorkOrderServices
    {
        [Key]
        public int Id { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual Service Service { get; set; }
    }
}
