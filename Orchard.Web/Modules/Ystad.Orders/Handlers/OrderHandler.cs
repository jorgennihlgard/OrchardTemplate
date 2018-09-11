

using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Indexing;
using Ystad.Orders.Models;

namespace Ystad.Orders.Handlers {

    public class OrderHandler : ContentHandler {
      
        public OrderHandler(IRepository<OrderPartRecord> orderPartRepository){
            Filters.Add(StorageFilter.For(orderPartRepository));
		}
	}
}