using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Data;
using Ystad.Orders.Models;
using Ystad.Orders.Services;
using Ystad.Orders.ViewModels;
using AutoMapper;


	//In Drivers folder

namespace Ystad.Orders.Drivers {
    public class  OrderPartDriver: ContentPartDriver<OrderPart> {
       

 private readonly IOrderService _orderservice;

            public OrderPartDriver(
                IOrderService orderservice 
            ) {
                _orderservice = orderservice;
            }


        protected override string Prefix {
            get { return "Order"; }
        }

        protected override DriverResult Display(OrderPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_Order",
			() => shapeHelper.Parts_Order(Part: part));
        }

        // GET
        protected override DriverResult Editor(OrderPart part, dynamic shapeHelper) {

            return ContentShape("Parts_Order_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/Order",           
			Model: new OrderPartsViewModel
			{
			Part = part,
																		MaintenanceGroups = _orderservice.GetMaintenanceGroups(),																								Priorities = _orderservice.GetPriorities(),						Protocols = _orderservice.GetProtocols(),			},

				
                    Prefix: Prefix));
        }

		// POST
        protected override DriverResult Editor(OrderPart part, IUpdateModel updater, dynamic shapeHelper) {
            var model = new OrderPartsViewModel
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
