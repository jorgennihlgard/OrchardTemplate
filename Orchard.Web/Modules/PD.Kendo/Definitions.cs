using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PD.Kendo
{
    public static class Definitions
    {
        public static string[] Themes = { 
            "Default",
            "Blue Opal", 
            "Bootstrap",
            "Silver",
            "Uniform",
            "Metro",
            "Black",
            "Metro Black",
            "High Contrast",
            "Moonlight",
            "Custom"
        };
    }

    public static class DefinitionContentType 
    {
        public static string KendoSchedulerTaskType = "KendoTask";
    }

    public static class DefinitionsAdminMenu 
    {
        public static string AdminMenuGroup = "Kendo UI";
    }

    internal static class DefinitionsGridUrlParameters 
    {
        internal static string Page = "page";
        internal static string PageSize = "pageSize";
        internal static string Sort = "sort";
        internal static string Mode = "mode";
        internal static string Group = "group";
        internal static string Filter = "filter";
        internal static string Aggregates = "aggregate";
    }
}