using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmVina.Model.Abstract;

namespace CmVina.Model.Models
{
    public class Error:AudiTable
    {
        [MaxLength(25)]
        [Key]
        public string errorID { get; set; }
        [Required]
        public string errorName { get; set; }
        public string procesID { get; set; }
        
    }
}
