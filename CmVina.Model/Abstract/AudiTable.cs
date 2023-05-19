using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmVina.Model.Abstract
{
    public abstract class AudiTable : IAudiTable
    {
        public string UserID0 { get ; set ; }
        public DateTime? Date0 { get ; set ; }
        public DateTime? Time0 { get ; set ; }
        public string UserID2 { get ; set ; }
        public DateTime? Date2 { get ; set ; }
        public DateTime? Time2 { get ; set ; }
        public string MetaKeyword { get ; set ; }
        public string MetaDescription { get ; set ; }
        public bool Status { get ; set ; }
    }
}
