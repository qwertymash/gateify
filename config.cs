using System.ComponentModel;

using Exiled.API.Interfaces;

namespace aegis.gateify
{
    public class Config : IConfig
    {
        [Description("Whether the plugin is enabled")]
        public bool IsEnabled { get; set; }
        [Description("Whether debug messages should be shown in the console")]
        public bool Debug { get; set; }
    }
}