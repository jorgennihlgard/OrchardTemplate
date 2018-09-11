

using Orchard.ContentManagement.Records;
using System;
namespace Ystad.Workorder.Models {
    public class WorkOrderPartRecord : ContentPartRecord {

	public virtual string Equipment{ get; set; }
	public virtual string Location{ get; set; }
	public virtual string Department{ get; set; }
	public virtual string MaintenanceGroup{ get; set; }
	public virtual string MaintenanceType{ get; set; }
	public virtual string Customer{ get; set; }
	public virtual string CustomerTelephone{ get; set; }
	public virtual string CustomerContactPerson{ get; set; }
	public virtual string RegisteredBy{ get; set; }
	public virtual string PerformedBy{ get; set; }
	public virtual string Priority{ get; set; }
	public virtual string Protocol{ get; set; }
	public virtual DateTime PickDate{ get; set; }
  
    }
}