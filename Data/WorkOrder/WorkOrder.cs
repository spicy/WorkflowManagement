using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<WorkOrderServices> Services { get; set; } = new List<WorkOrderServices>();
        public virtual List<WorkOrderPackages> Packages { get; set; } = new List<WorkOrderPackages>();
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}