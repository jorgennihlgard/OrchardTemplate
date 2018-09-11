using PD.Kendo.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Orchard.Localization;
using JetBrains.Annotations;

namespace PD.Kendo.Handlers
{
    /// <summary>
    /// Add into the site options the ability to pick a global theme
    /// </summary>
    [OrchardFeature("PD.Kendo")]
    public class KendoSiteSettingsPartHandler : ContentHandler
    {
        public KendoSiteSettingsPartHandler()
        {
            Filters.Add(new ActivatingFilter<KendoSiteSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<KendoSiteSettingsPart>("KendoSiteSettings", "Parts/KendoSiteSettings", "Kendo"));

            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Kendo")));
        }
    }
}
