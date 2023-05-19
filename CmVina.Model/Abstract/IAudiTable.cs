using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmVina.Model.Abstract
{
    public interface IAudiTable
    {
        string UserID0 { get; set; }
        DateTime? Date0 { get; set; }
        DateTime? Time0 { get; set; }
        string UserID2 { get; set; }
        DateTime? Date2 { get; set; }
        DateTime? Time2 { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }


    }
}
