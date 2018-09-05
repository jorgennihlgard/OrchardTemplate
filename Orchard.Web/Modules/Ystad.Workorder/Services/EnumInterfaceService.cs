



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Orchard;

namespace Ystad.Workorder.Services
{

   public interface IWorkOrderService : IDependency
    {
        IEnumerable<SelectListItem> GetMaintenanceGroups();
    }
}