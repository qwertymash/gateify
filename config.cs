using System.ComponentModel;

using Exiled.API.Interfaces;

namespace aegis.gateify
{
    public class Config : IConfig
    {
        [Description("Whether the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether debug messages should be shown in the console")]
        public bool Debug { get; set; } = false;

        [Description("Whether a CASSIE message should broadcast at round start")]
        public bool ShouldAnnounceLock { get; set; } = true;

        [Description("[REQUIRES ShouldAnnounceLock TO BE TRUE] Whether the CASSIE message should be glitchy")]
        public bool ShouldAnnounceLockGlitch { get; set; } = false;

        [Description("[REQUIRES ShouldAnnounceLock TO BE TRUE] How much CASSIE should wait before broadcasting at round start (in seconds)")]
        public float AnnounceLockDelay { get; set; } = 30f;

        [Description("[REQUIRES ShouldAnnounceLock TO BE TRUE] Message to broadcast at round start")]
        public string AnnounceLockBroadcast { get; set; } = "test";

        [Description("[REQUIRES ShouldAnnounceLockGlitch TO BE FALSE] Translation to use at round start (if glitchy, this will be ignored)")]
        public string AnnounceLockTranslation { get; set; } = "This is a cool translation!";

        [Description("Whether a CASSIE message should broadcast at team arrival/when opened")]
        public bool ShouldAnnounceOpen { get; set; } = true;

        [Description("[REQUIRES ShouldAnnounceOpen TO BE TRUE] Whether the CASSIE message should be glitchy")]
        public bool ShouldAnnounceOpenGlitch { get; set; } = false;

        [Description("[REQUIRES ShouldAnnounceOpen TO BE TRUE] How much CASSIE should wait before broadcasting at team arrival/when opened (in seconds) (if 0, then right after the MTF announcement)")]
        public float AnnounceOpenDelay { get; set; } = 0f;

        [Description("[REQUIRES ShouldAnnounceOpen TO BE TRUE] Message to broadcast at team arrival/when opened")]
        public string AnnounceOpenBroadcast { get; set; } = "test";

        [Description("[REQUIRES ShouldAnnounceOpenGlitch TO BE FALSE] Translation to use at team arrival/when opened (if glitchy, this will be ignored)")]
        public string AnnounceOpenTranslation { get; set; } = "This is a cool translation!";

        [Description("Whether or not the gates should close after a while")]
        public bool ShouldCloseGates { get; set; } = true;

        [Description("[REQUIRES ShouldCloseGates TO BE TRUE] How long the gates should remain open after a respawn (in seconds)")]
        public float CloseGatesAfter { get; set; } = 60f;
    }
}