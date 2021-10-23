using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDInWebAPIs.DataModels
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string DName { get; set; }
        public string Description { get; set; }
    }
}
