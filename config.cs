using System.ComponentModel;

using Exiled.API.Interfaces;

namespace aegis.gateify
{
    public class Config : IConfig
    {
        // i wanna blow my brains out.

        [Description("Whether the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
        [Description("Whether debug messages should be shown in the console")]
        public bool Debug { get; set; } = false;



        [Description("Whether gate setting should sync between each other")]
        public bool ShouldSyncGates { get; set; } = true;
        #region SYNCED GATE SETTINGS
        [Description("SYNCED SETTINGS\nShould the gates lock after a specific time? (use 0 for round start)")]
        public float SyncLockDelay { get; set; } = 0f;
        [Description("Should the gates close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float SyncCloseAfterDelay { get; set; } = 0f;
        [Description("Whether a CASSIE message should broadcast the lock")]
        public bool SyncShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceLockGlitch { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float SyncAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float SyncAnnounceLockJamChance { get; set; } = 0f;
        [Description("The time (in seconds) needed to wait after the respawn wave before opening (set to -1 to disable)")]
        public float SyncOpenDelay { get; set; } = -1f;
        [Description("The time (in seconds) needed to wait after the respawn wave before closing (set to -1 to disable) (relative to the respawn wave)")]
        public float SyncCloseDelay { get; set; } = -1f;
        #endregion
        #region NON-SYNCED GATE SETTINGS
        #region GATE A
        [Description("NON-SYNCED SETTINGS\nGATE A\nShould the gate lock after a specific time? (use 0 for round start)")]
        public float GateALockDelay { get; set; } = 0f;
        [Description("Should the gate close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float GateACloseAfterDelay { get; set; } = 0f;
        [Description("Whether a CASSIE message should broadcast the lock")]
        public bool GateAShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceLockGlitch { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateAAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateAAnnounceLockJamChance { get; set; } = 0f;
        [Description("The time (in seconds) needed to wait after the respawn wave before opening (set to -1 to disable)")]
        public float GateAOpenDelay { get; set; } = -1f;
        [Description("The time (in seconds) needed to wait after the respawn wave before closing (set to -1 to disable) (relative to the respawn wave)")]
        public float GateACloseDelay { get; set; } = -1f;
        #endregion
        #region GATE B
        [Description("GATE B\nShould the gate lock after a specific time? (use 0 for round start)")]
        public float GateBLockDelay { get; set; } = 0f;
        [Description("Should the gate close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float GateBCloseAfterDelay { get; set; } = 0f;
        [Description("Whether a CASSIE message should broadcast the lock")]
        public bool GateBShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceLockGlitch { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateBAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateBAnnounceLockJamChance { get; set; } = 0f;
        [Description("The time (in seconds) needed to wait after the respawn wave before opening (set to -1 to disable)")]
        public float GateBOpenDelay { get; set; } = -1f;
        [Description("The time (in seconds) needed to wait after the respawn wave before closing (set to -1 to disable) (relative to the respawn wave)")]
        public float GateBCloseDelay { get; set; } = -1f;
        #endregion
        #endregion


        [Description("Whether the CASSIE messages are synced between each other (GATE A <-> GATE B")]
        public bool SyncCassieMessages { get; set; } = false;
        #region SYNCED CASSIE SETTINGS
        [Description("SYNCED CASSIE SETTINGS\nWhether CASSIE should broadcast the gate opening")]
        public bool SyncShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceOpenGlitch { get; set; } = false;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool SyncShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceCloseGlitch { get; set; } = false;
        #endregion

        #region NON-SYNCED CASSIE SETTINGS
        #region GATE A
        [Description("NON-SYNCED CASSIE SETTINGS\nGATE A\nWhether CASSIE should broadcast the gate opening")]
        public bool GateAShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceOpenGlitch { get; set; } = false;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool GateAShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceCloseGlitch { get; set; } = false;
        #endregion
        #region GATE B
        [Description("GATE B\nWhether CASSIE should broadcast the gate opening")]
        public bool GateBShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceOpenGlitch { get; set; } = false;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool GateBShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceCloseGlitch { get; set; } = false;
        #endregion
        #endregion
    }
}