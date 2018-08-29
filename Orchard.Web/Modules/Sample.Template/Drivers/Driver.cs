
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Data;
using Sample.Template.Models;
//using Sample.Template.Services;
//using Sample.Template.ViewModels;

	//In Drivers folder

namespace Sample.Template.Drivers {
    public class MyTablePartDriver : ContentPartDriver<MyTablePart> {
       

        protected override string Prefix {
            get { return "MyView"; }
        }

        protected override DriverResult Display(MyTablePart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_Movie",
			() => shapeHelper.Parts_Movie(MoviePart: part));
        }

        // GET
        protected override DriverResult Editor(MyTablePart part, dynamic shapeHelper) {
            return ContentShape("Parts_Parts_MyContent_Edit_Edit", () =>
                shapeHelper.EditorTemplate(TemplateName: "Parts/MyView", Model:part, Prefix: Prefix));
        }

		// POST
        protected override DriverResult Editor(MyTablePart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
	}
}
