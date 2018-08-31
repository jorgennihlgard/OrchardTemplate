


using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;

namespace Sample.Template.Models {
    public class KaffeKoppPart : ContentPart<KaffeKoppPartRecord> {
        
		public int Deciliter {
		get { return Record.Deciliter; }
		set { Record.Deciliter = value; }
        }
			public string Handtag {
		get { return Record.Handtag; }
		set { Record.Handtag = value; }
        }
			public string Färg {
		get { return Record.Färg; }
		set { Record.Färg = value; }
        }
			public string Namn {
		get { return Record.Namn; }
		set { Record.Namn = value; }
        }
			public string NewProp1 {
		get { return Record.NewProp1; }
		set { Record.NewProp1 = value; }
        }
			public string NewProp2 {
		get { return Record.NewProp2; }
		set { Record.NewProp2 = value; }
        }
			public string NewProp3 {
		get { return Record.NewProp3; }
		set { Record.NewProp3 = value; }
        }
			public string NewProp4 {
		get { return Record.NewProp4; }
		set { Record.NewProp4 = value; }
        }
		    }
}