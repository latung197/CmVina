using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CmVina.Model.Abstract
{
    public abstract class AudiTable : IAudiTable
    {
        [MaxLength(256)]
        public string UserID0 { get ; set ; }
        public DateTime? Date0 { get ; set ; }
        public DateTime? Time0 { get ; set ; }
        [MaxLength(256)]
        public string UserID2 { get ; set ; }
        public DateTime? Date2 { get ; set ; }
        public DateTime? Time2 { get ; set ; }
        [MaxLength(256)]
        public string MetaKeyword { get ; set ; }
        [MaxLength(256)]
        public string MetaDescription { get ; set ; }
        public bool Status { get ; set ; }
    }
}
