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
        public bool ShouldAnnounceLock { get; set; } = false;

        [Description("Whether the CASSIE message should be glitchy [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public bool ShouldAnnounceLockGlitch { get; set; } = false;

        [Description("Chance for CASSIE to glitch (values from 0% to 100%) [REQUIRES ShouldAnnounceLockGlitch TO BE TRUE]")]
        public float AnnounceLockGlitchChance { get; set; } = 0f;

        [Description("Chance for CASSIE to jam (values from 0% to 100%) [REQUIRES ShouldAnnounceLockGlitch TO BE TRUE]")]
        public float AnnounceLockJamChance { get; set; } = 0f;

        [Description("How much CASSIE should wait before broadcasting at round start (in seconds) (set to 0 to disable waiting) [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public float AnnounceLockDelay { get; set; } = 0f;

        [Description("Whether or not the gates should be locked after said delay (false = locked at round start)")]
        public bool ShouldLockAfterDelay { get; set; } = false;

        [Description("Message to broadcast at round start [REQUIRES ShouldAnnounceLock TO BE TRUE]")]
        public string AnnounceLockBroadcast { get; set; } = ".G7";

        [Description("Translation to use at round start (if glitchy, this will be ignored) [REQUIRES ShouldAnnounceLockGlitch TO BE FALSE]")]
        public string AnnounceLockTranslation { get; set; } = "Lazy bastard... forgot to configure me! Feel the wrath of the gates!";

        [Description("Whether a CASSIE message should broadcast at team arrival/when opened")]
        public bool ShouldAnnounceOpen { get; set; } = false;

        [Description("Whether the CASSIE message should be glitchy [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public bool ShouldAnnounceOpenGlitch { get; set; } = false;

        [Description("Chance for CASSIE to glitch (values from 0% to 100%) [REQUIRES ShouldAnnounceOpenGlitch TO BE TRUE] ")]
        public float AnnounceOpenGlitchChance { get; set; } = 0f;

        [Description("Chance for CASSIE to jam (values from 0% to 100%) [REQUIRES ShouldAnnounceOpenGlitch TO BE TRUE]")]
        public float AnnounceOpenJamChance { get; set; } = 0f;

        [Description("How much CASSIE should wait before broadcasting at team arrival/when opened (in seconds) (if 0, then right after the MTF announcement) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public float AnnounceOpenDelay { get; set; } = 0f;

        [Description("Whether or not the gates should be open after said delay (false = open on respawn)")]
        public bool ShouldOpenAfterDelay { get; set; } = false;

        [Description("Message to broadcast at team arrival/when opened (Gate A) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public string AnnounceOpenBroadcastGateA { get; set; } = ".G7 A";

        [Description("Message to broadcast at team arrival/when opened (Gate B) [REQUIRES ShouldAnnounceOpen TO BE TRUE]")]
        public string AnnounceOpenBroadcastGateB { get; set; } = ".G7 B";

        [Description("Translation to use at team arrival/when opened (Gate A) [REQUIRES ShouldAnnounceOpenGlitch TO BE FALSE]")]
        public string AnnounceOpenTranslationGateA { get; set; } = "Lazy bastard... forgot to configure me! Feel the wrath of the gate A!";

        [Description("Translation to use at team arrival/when opened (Gate B) [REQUIRES ShouldAnnounceOpenGlitch TO BE FALSE]")]
        public string AnnounceOpenTranslationGateB { get; set; } = "Lazy bastard... forgot to configure me! Feel the wrath of the gate B!";

        [Description("Whether or not the gates should close after a while")]
        public bool ShouldCloseGates { get; set; } = false;

        [Description("How long the gates should remain open after a respawn [REQUIRES ShouldCloseGates TO BE TRUE]")]
        public float CloseGatesAfter { get; set; } = 0f;
    }
}