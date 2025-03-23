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

        [Description("Whether the CASSIE message should be glitchy [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public bool ShouldAnnounceLockGlitch { get; set; } = false;

        [Description("Chance for CASSIE to glitch [REQUIRES ShouldAnnounceLockGlitch TO BE TRUE]")]
        public float AnnounceLockGlitchChance { get; set; } = 100f;

        [Description("Chance for CASSIE to jam [REQUIRES ShouldAnnounceLockGlitch TO BE TRUE]")]
        public float AnnounceLockJamChance { get; set; } = 100f;

        [Description("How much CASSIE should wait before broadcasting at round start (in seconds) [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public float AnnounceLockDelay { get; set; } = 30f;

        [Description("Message to broadcast at round start [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public string AnnounceLockBroadcast { get; set; } = "test test test";

        [Description("Translation to use at round start (if glitchy, this will be ignored) [REQUIRES ShouldAnnounceLockGlitch TO BE FALSE]")]
        public string AnnounceLockTranslation { get; set; } = "This is a cool translation!";

        [Description("Whether a CASSIE message should broadcast at team arrival/when opened")]
        public bool ShouldAnnounceOpen { get; set; } = true;

        [Description("Whether the CASSIE message should be glitchy [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public bool ShouldAnnounceOpenGlitch { get; set; } = false;

        [Description("Chance for CASSIE to glitch [REQUIRES ShouldAnnounceOpenGlitch TO BE TRUE] ")]
        public float AnnounceOpenGlitchChance { get; set; } = 25f;

        [Description("Chance for CASSIE to jam [REQUIRES ShouldAnnounceOpenGlitch TO BE TRUE]")]
        public float AnnounceOpenJamChance { get; set; } = 25f;

        [Description("How much CASSIE should wait before broadcasting at team arrival/when opened (in seconds) (if 0, then right after the MTF announcement) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public float AnnounceOpenDelay { get; set; } = 0f;

        [Description("Message to broadcast at team arrival/when opened (Gate A) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public string AnnounceOpenBroadcastGateA { get; set; } = "test test test";

        [Description("Message to broadcast at team arrival/when opened (Gate B) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public string AnnounceOpenBroadcastGateB { get; set; } = "test test test";

        [Description("Translation to use at team arrival/when opened (Gate A) [REQUIRES ShouldAnnounceOpenGlitch TO BE FALSE]")]
        public string AnnounceOpenTranslationGateA { get; set; } = "This is a cool translation!";

        [Description("Translation to use at team arrival/when opened (Gate B) [REQUIRES ShouldAnnounceOpenGlitch TO BE FALSE]")]
        public string AnnounceOpenTranslationGateB { get; set; } = "This is a cool translation!";

        [Description("Whether or not the gates should close after a while")]
        public bool ShouldCloseGates { get; set; } = true;

        [Description("How long the gates should remain open after a respawn (in seconds) [REQUIRES ShouldCloseGates TO BE TRUE]")]
        public float CloseGatesAfter { get; set; } = 60f;
    }
}