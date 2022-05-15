using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Data
{
    public class PackageServices
    {
        [Key]
        public int Id { get; set; }
        public virtual Package Package { get; set; }
        public virtual Service Service { get; set; }
    }
}
