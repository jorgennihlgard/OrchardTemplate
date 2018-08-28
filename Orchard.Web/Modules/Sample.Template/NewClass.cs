

using Orchard.ContentManagement.Records;

namespace Pluralsight.Movies.Models {
    public class TableName : ContentPartRecord {

		public virtual int YearReleased{ get; set; }
	public virtual string TagLine{ get; set; }
	public virtual string Keywords{ get; set; }
       
      
       
    }
}