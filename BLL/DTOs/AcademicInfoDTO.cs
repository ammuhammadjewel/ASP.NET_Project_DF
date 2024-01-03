using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AcademicInfoDTO
    {
        public int RId { get; set; }
        public string JSC { get; set; }
        public string JSC_reg { get; set; }
        public string SSC { get; set; }
        public string SSC_reg { get; set; }
        public string HSC { get; set; }
        public string HSC_reg { get; set; }
        public Nullable<int> FK_NID { get; set; }
    }
}
