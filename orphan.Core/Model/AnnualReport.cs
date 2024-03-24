using orphan.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class AnnualReport
    {
        public string Id { get; set; }  
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Year { get; set; }
        public string Ambitious { get; set; }

        public int NewOrphanId { get; set; }
        public NewOrphan NewOrphan { get; set; }
        

    }
}









