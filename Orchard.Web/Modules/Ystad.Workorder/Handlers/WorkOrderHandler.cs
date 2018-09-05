

using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Indexing;
using Ystad.Workorder.Models;

namespace Ystad.Workorder.Handlers {

    public class WorkOrderHandler : ContentHandler {
      
        public WorkOrderHandler(IRepository<WorkOrderPartRecord> workOrderPartRepository){
            Filters.Add(StorageFilter.For(workOrderPartRepository));
		}
	}
}