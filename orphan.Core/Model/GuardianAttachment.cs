using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orphan.Core.Model
{
    public class GuardianAttachment
    {
        public int Id { get; set; }
        public string Document_Name { get; set; }
        public string Document_Type { get; set; }
        public string Description { get; set; }

        public int NewOrphanId { get; set; }
        public NewOrphan NewOrphan { get; set; }

    }
}





