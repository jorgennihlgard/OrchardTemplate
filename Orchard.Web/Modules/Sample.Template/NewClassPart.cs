

using Orchard.ContentManagement.Records;

namespace Pluralsight.Movies.Models {
    public class MyTableRecord : ContentPartRecord {

	public virtual int YearReleased{ get; set; }
	public virtual string TagLine{ get; set; }
	public virtual string Keywords{ get; set; }
	public virtual string Name{ get; set; }
  
    }
}