


using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;

namespace Sample.Template.Models {
    public class MyTablePart : ContentPart<MyTablePartRecord> {
        
		public int YearReleased {
		get { return Record.YearReleased; }
		set { Record.YearReleased = value; }
        }
			public string TagLine {
		get { return Record.TagLine; }
		set { Record.TagLine = value; }
        }
			public string Keywords {
		get { return Record.Keywords; }
		set { Record.Keywords = value; }
        }
			public string Name {
		get { return Record.Name; }
		set { Record.Name = value; }
        }
		    }
}