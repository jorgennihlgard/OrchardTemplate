


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
		    }
}