


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ystad.Orders.Models;

namespace Ystad.Orders.ViewModels
{


    public class OrderPartsViewModel
    { 
		 
		 
		 
			public IEnumerable<SelectListItem> MaintenanceGroups { get; set; }
		 
		 
		 
		 
		 
		 
		 
			public IEnumerable<SelectListItem> Priorities { get; set; }
		 
			public IEnumerable<SelectListItem> Protocols { get; set; }
			public OrderPart Part { get; set; }
    }
}