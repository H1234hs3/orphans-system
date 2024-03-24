using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orphan.Core.Model
{
    public class OrphanAttachment
    {
        public int Id{ get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
        public string DocumentName { get; set; }
        public int NewOrphanId { get; set; }
        public  NewOrphan newOrphan  { get; set; }



    }
}





