

using Orchard.ContentManagement.Records;

namespace Sample.Template.Models {
    public class MyTablePartRecord : ContentPartRecord {

	public virtual int YearReleased{ get; set; }
	public virtual string TagLine{ get; set; }
	public virtual string Keywords{ get; set; }
	public virtual string Name{ get; set; }
  
    }
}