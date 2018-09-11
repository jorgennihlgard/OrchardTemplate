//using PD.Kendo.Models;
//using Orchard.ContentManagement;
//using Orchard.ContentManagement.Drivers;
//using Orchard.ContentManagement.Handlers;
//using Orchard.Environment.Extensions;
//using System;
//using System.Linq;

//namespace PD.Kendo.Drivers
//{
//    [OrchardFeature("Kendo.Web")]
//    public class KendoSiteSettingsPartDriver : ContentPartDriver<KendoSiteSettingsPart>
//    {
//        protected override string Prefix
//        {
//            get { return "KendoSiteSettingsPart"; }
//        }

//        protected override DriverResult Display(KendoSiteSettingsPart part, string displayType, dynamic shapeHelper)
//        {
//            return ContentShape("Parts_KendoSiteSettings",
//                () => shapeHelper.Parts_KendoSiteSettings());
//        }

//        protected override DriverResult Editor(KendoSiteSettingsPart part, dynamic shapeHelper)
//        {
//            return ContentShape("Parts_KendoSiteSettings_Edit",
//                () => shapeHelper.EditorTemplate(
//                    TemplateName: "Parts.KendoSiteSettings",
//                    Model: part,
//                    Prefix: Prefix)).OnGroup(DefinitionsAdminMenu.AdminMenuGroup);
//        }

//        protected override DriverResult Editor(KendoSiteSettingsPart part, IUpdateModel updater, dynamic shapeHelper)
//        {
//            updater.TryUpdateModel(part, Prefix, null, null);
//            return Editor(part, shapeHelper);
//        }

//        protected override void Exporting(KendoSiteSettingsPart part, ExportContentContext context)
//        {
//            var element = context.Element(part.PartDefinition.Name);

//            element.SetAttributeValue("DefaultTheme", part.DefaultTheme);
//        }

//        protected override void Importing(KendoSiteSettingsPart part, ImportContentContext context)
//        {
//            var partName = part.PartDefinition.Name;

//            context.ImportAttribute(partName, "DefaultTheme", value => part.DefaultTheme = value);
//        }
//    }
//}