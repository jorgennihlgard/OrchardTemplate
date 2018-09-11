using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace PD.Kendo.Models
{
    public class KendoSiteSettingsPartRecord : ContentPartRecord
    {
        public virtual string DefaultTheme { get; set; }
    }
}