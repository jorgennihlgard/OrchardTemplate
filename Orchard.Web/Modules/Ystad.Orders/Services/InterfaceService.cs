


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Orchard;

namespace Ystad.Orders.Services
{


   public interface IOrderService : IDependency
    {
														        IEnumerable<SelectListItem> GetMaintenanceGroups();
																							        IEnumerable<SelectListItem> GetPriorities();
					        IEnumerable<SelectListItem> GetProtocols();
		    }
}