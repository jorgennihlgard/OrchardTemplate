
using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Data;
using Sample.Template.Models;
//using Sample.Template.Services;
//using Sample.Template.ViewModels;

	//In Drivers folder

namespace Sample.Template.Drivers {
    public class KaffeKoppPartDriver : ContentPartDriver<KaffeKoppPart> {
       

        protected override string Prefix {
            get { return "TemplateView"; }
        }

        protected override DriverResult Display(KaffeKoppPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_ShapeView",
			() => shapeHelper.Parts_ShapeView(Part: part));
        }

        // GET
        protected override DriverResult Editor(KaffeKoppPart part, dynamic shapeHelper) {
            return ContentShape("Parts_MyContent_Edit", () =>
                shapeHelper.EditorTemplate(TemplateName: "Parts/TemplateView", Model:part, Prefix: Prefix));
        }

		// POST
        protected override DriverResult Editor(KaffeKoppPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
	}
}
