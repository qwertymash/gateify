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
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nSYNCED SETTINGS\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nShould the gates lock after a specific time? (use 0 for round start)")]
        public float SyncLockDelay { get; set; } = 0f;
        [Description("Should the gates close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float SyncCloseDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before opening (set to 0 to disable)")]
        public float SyncRespawnOpenDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before closing (set to 0 to disable) (relative to the respawn wave)")]
        public float SyncRespawnCloseDelay { get; set; } = 0f;
        #endregion

        #region NON-SYNCED GATE SETTINGS
        #region GATE A
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nNON-SYNCED SETTINGS\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGATE A\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nShould the gate lock after a specific time? (use 0 for round start)")]
        public float GateALockDelay { get; set; } = 0f;
        [Description("Should the gate close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float GateACloseDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before opening (set to 0 to disable)")]
        public float GateARespawnOpenDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before closing (set to 0 to disable) (relative to the respawn wave)")]
        public float GateARespawnCloseDelay { get; set; } = 0f;
        #endregion
        #region GATE B
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGATE B\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nShould the gate lock after a specific time? (use 0 for round start)")]
        public float GateBLockDelay { get; set; } = 0f;
        [Description("Should the gate close after said delay? (use 0 for round start) (useful if the gate is already open yet you still want people to be locked in)")]
        public float GateBCloseDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before opening (set to 0 to disable)")]
        public float GateBRespawnOpenDelay { get; set; } = 0f;
        [Description("(CASSIE IS SYNCED WITH THIS) The time (in seconds) needed to wait after the respawn wave before closing (set to 0 to disable) (relative to the respawn wave)")]
        public float GateBRespawnCloseDelay { get; set; } = 0f;
        #endregion
        #endregion



        #region SYNCED CASSIE SETTINGS
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nSYNCED CASSIE SETTINGS\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nWhether CASSIE should broadcast the gates locking")]
        public bool SyncShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceLockTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceLockGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float SyncAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float SyncAnnounceLockJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gates opening")]
        public bool SyncShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceOpenGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float SyncAnnounceOpenGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float SyncAnnounceOpenJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool SyncShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string SyncAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string SyncAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool SyncShouldAnnounceCloseGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float SyncAnnounceCloseGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float SyncAnnounceCloseJamChance { get; set; } = 0f;
        #endregion

        #region NON-SYNCED CASSIE SETTINGS
        #region GATE A
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nNON-SYNCED CASSIE SETTINGS\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGATE A\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nWhether CASSIE should broadcast the gate locking")]
        public bool GateAShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceLockTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceLockGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateAAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateAAnnounceLockJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gate opening")]
        public bool GateAShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceOpenGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateAAnnounceOpenGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateAAnnounceOpenJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool GateAShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateAAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateAAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateAShouldAnnounceCloseGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateAAnnounceCloseGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateAAnnounceCloseJamChance { get; set; } = 0f;
        #endregion
        #region GATE B
        [Description("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGATE B\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nWhether a CASSIE message should broadcast the lock")]
        public bool GateBShouldAnnounceLock { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceLockBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceLockTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceLockGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateBAnnounceLockGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateBAnnounceLockJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gate opening")]
        public bool GateBShouldAnnounceOpen { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceOpenBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceOpenTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceOpenGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateBAnnounceOpenGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateBAnnounceOpenJamChance { get; set; } = 0f;
        [Description("Whether CASSIE should broadcast the gate closing")]
        public bool GateBShouldAnnounceClose { get; set; } = false;
        [Description("CASSIE broadcast message")]
        public string GateBAnnounceCloseBroadcast { get; set; } = ".G7";
        [Description("CASSIE broadcast translation")]
        public string GateBAnnounceCloseTranslation { get; set; } = "silly goober go look at your config";
        [Description("Whether the CASSIE message will be glitchy (i.e.: random static/jams)")]
        public bool GateBShouldAnnounceCloseGlitchy { get; set; } = false;
        [Description("Chance for CASSIE to glitch (values from 0% to 100%)")]
        public float GateBAnnounceCloseGlitchChance { get; set; } = 0f;
        [Description("Chance for CASSIE to jam (values from 0% to 100%)")]
        public float GateBAnnounceCloseJamChance { get; set; } = 0f;
        #endregion
        #endregion
    }
}