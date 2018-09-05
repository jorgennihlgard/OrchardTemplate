
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Data;
using Ystad.Workorder.Models;
using Ystad.Workorder.Services;
using Ystad.Workorder.ViewModels;


	//In Drivers folder

namespace Ystad.Workorder.Drivers {
    public class WorkOrderPartDriver : ContentPartDriver<WorkOrderPart> {
       
		  private readonly IWorkOrderService _workorderservice;

            public WorkOrderPartDriver(
                IWorkOrderService workorderservice 
            ) {
                _workorderservice = workorderservice;
            }



        protected override string Prefix {
            get { return "WorkOrder"; }
        }

        protected override DriverResult Display(WorkOrderPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_WorkOrder",
			() => shapeHelper.Parts_WorkOrder(Part: part));
        }

      

		protected override DriverResult Editor(WorkOrderPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_WorkOrder_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/WorkOrder",
                    Model: new WorkOrderPartsViewModel
                    {
                        Part = part,
                        MaintenanceGroups = _workorderservice.GetMaintenanceGroups(),
                    },
                    Prefix: Prefix));
        }


		

		protected override DriverResult Editor(WorkOrderPart part, IUpdateModel updater, dynamic shapeHelper)
        {
			  var model = new WorkOrderPartsViewModel()
			  {
			      Part = part
			  };
			  if (updater.TryUpdateModel(model, Prefix, null, null))
			   {
			   }
			    return Editor(part, shapeHelper);
		    }
	}
}
