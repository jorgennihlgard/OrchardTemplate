

using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Indexing;
using Sample.Template.Models;

namespace Pluralsight.Movies.Handlers {

    public class MyContentPartHandler : ContentHandler {
      
        public MyContentPartHandler(IRepository<MyTablePartRecord> myTablePartRepository){
            Filters.Add(StorageFilter.For(myTablePartRepository));
		}
	}
}