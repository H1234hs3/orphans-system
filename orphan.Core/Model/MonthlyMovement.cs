using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class MonthlyMovement
    {
        public int Id { get; set; }
        public DateTime ReceivedDate { get; set; }    
        public double Amount { get; set; }    
        public string Status { get; set; }   
        public int MonthNumber { get; set; }
        public string Description { get; set; }
        public int NewOrphanId { get; set; }
        public NewOrphan NewOrphan { get; set; }

        

    }
}






