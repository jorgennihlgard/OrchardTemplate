

using Orchard.ContentManagement.Records;

namespace Sample.Template.Models {
    public class KaffeKoppPartRecord : ContentPartRecord {

	public virtual int Deciliter{ get; set; }
	public virtual string Handtag{ get; set; }
	public virtual string Färg{ get; set; }
	public virtual string Namn{ get; set; }
  
    }
}