using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ystad.Workorder.Models;

namespace Ystad.Workorder.ViewModels
{
    public class WorkOrderPartsViewModel
    {
        public IEnumerable<SelectListItem> MaintenanceGroups { get; set; }
        public WorkOrderPart Part { get; set; }
    }
}