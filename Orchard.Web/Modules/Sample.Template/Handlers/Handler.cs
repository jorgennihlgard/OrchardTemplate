

using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Indexing;
using Sample.Template.Models;

namespace Sample.Template.Handlers {

    public class KaffeKoppHandler : ContentHandler {
      
        public KaffeKoppHandler(IRepository<KaffeKoppPartRecord> kaffeKoppPartRepository){
            Filters.Add(StorageFilter.For(kaffeKoppPartRepository));
		}
	}
}