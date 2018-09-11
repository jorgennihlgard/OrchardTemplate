
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ystad.Workorder.Models;

namespace Ystad.Workorder.Services
{


    public class WorkOrderService : IWorkOrderService
    {
															        public IEnumerable<SelectListItem> GetMaintenanceGroups()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var value in Enum.GetValues(typeof(PartsEnum)))
            {
                list.Add(new SelectListItem() { Selected = false, Text = value.ToString(), Value = ((int)value).ToString() });
            }
            return new SelectList(list, "Value", "Text");
        }
																						        public IEnumerable<SelectListItem> GetPriorities()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var value in Enum.GetValues(typeof(PriorityEnum)))
            {
                list.Add(new SelectListItem() { Selected = false, Text = value.ToString(), Value = ((int)value).ToString() });
            }
            return new SelectList(list, "Value", "Text");
        }
				        public IEnumerable<SelectListItem> GetProtocols()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var value in Enum.GetValues(typeof(ProtocolEnum)))
            {
                list.Add(new SelectListItem() { Selected = false, Text = value.ToString(), Value = ((int)value).ToString() });
            }
            return new SelectList(list, "Value", "Text");
        }
				    }
}