

using Orchard.ContentManagement.Records;

namespace Sample.Template.Models {
    public class KaffeKoppPartRecord : ContentPartRecord {

	public virtual int Deciliter{ get; set; }
	public virtual string Handtag{ get; set; }
	public virtual string Färg{ get; set; }
	public virtual string Namn{ get; set; }
	public virtual string NewProp1{ get; set; }
	public virtual string NewProp2{ get; set; }
	public virtual string NewProp3{ get; set; }
	public virtual string NewProp4{ get; set; }
  
    }
}