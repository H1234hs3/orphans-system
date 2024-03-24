using Microsoft.Identity.Client;
using orphan.Data.SqlServer;
using orphan.Data.SqlServer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphans.Code
{
    public static class DependnecyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigrationonObjectManager.Register("NewOrphan", new NewOrphansEntity());
        }
    }
}
