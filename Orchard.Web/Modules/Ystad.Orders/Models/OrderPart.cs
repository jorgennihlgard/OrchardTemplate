

using System;
using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;

namespace Ystad.Orders.Models {
    public class OrderPart : ContentPart<OrderPartRecord> {
        
		public string Equipment {
		get { return Record.Equipment; }
		set { Record.Equipment = value; }
        }
			public string Location {
		get { return Record.Location; }
		set { Record.Location = value; }
        }
			public string Department {
		get { return Record.Department; }
		set { Record.Department = value; }
        }
			public string MaintenanceGroup {
		get { return Record.MaintenanceGroup; }
		set { Record.MaintenanceGroup = value; }
        }
			public string MaintenanceType {
		get { return Record.MaintenanceType; }
		set { Record.MaintenanceType = value; }
        }
			public string Customer {
		get { return Record.Customer; }
		set { Record.Customer = value; }
        }
			public string CustomerTelephone {
		get { return Record.CustomerTelephone; }
		set { Record.CustomerTelephone = value; }
        }
			public string CustomerContactPerson {
		get { return Record.CustomerContactPerson; }
		set { Record.CustomerContactPerson = value; }
        }
			public string RegisteredBy {
		get { return Record.RegisteredBy; }
		set { Record.RegisteredBy = value; }
        }
			public string PerformedBy {
		get { return Record.PerformedBy; }
		set { Record.PerformedBy = value; }
        }
			public string Priority {
		get { return Record.Priority; }
		set { Record.Priority = value; }
        }
			public string Protocol {
		get { return Record.Protocol; }
		set { Record.Protocol = value; }
        }
		    }
}