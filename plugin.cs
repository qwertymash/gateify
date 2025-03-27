using System;

using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Doors;
using Exiled.Events.EventArgs.Server;
using Respawning.Waves;

using MEC;

namespace aegis.gateify
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Gateify";
        public override string Author => "aegis";
        public override Version Version => new Version(0, 2, 0);
        public override Version RequiredExiledVersion => new Version(9, 5, 0);
        private Door GateA = null;
        private Door GateB = null;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted += this.GetGates;
            Exiled.Events.Handlers.Server.RespawnedTeam += this.Respawn;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= this.GetGates;
            Exiled.Events.Handlers.Server.RespawnedTeam -= this.Respawn;
        }

        private void GetGates()
        {
            Log.Debug("Getting gates...");

            GateA = Door.Get(DoorType.GateA);
            GateB = Door.Get(DoorType.GateB);

            Log.Debug("Locking the gates... (might take a while depending on config)");

            if (Config.ShouldSyncGates)
            {
                #region SYNCED SETTINGS
                Timing.CallDelayed(Config.SyncLockDelay, () =>
                {
                    #region ANNOUNCE LOCK

                    if (Config.SyncShouldAnnounceLock)
                    {
                        if (Config.SyncShouldAnnounceLockGlitchy)
                        {
                            Cassie.GlitchyMessage(Config.SyncAnnounceLockBroadcast, Config.SyncAnnounceLockGlitchChance / 100, Config.SyncAnnounceLockJamChance / 100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.SyncAnnounceLockBroadcast, Config.SyncAnnounceLockTranslation);
                        }
                    }

                    #endregion

                    #region LOCK GATES

                    LockGate(GateA);
                    LockGate(GateB);

                    #endregion
                });

                Timing.CallDelayed(Config.SyncCloseDelay, () =>
                {
                    #region CLOSE GATES

                    CloseGate(GateA);
                    CloseGate(GateB);

                    #endregion
                });
                #endregion
            }
            else
            {
                #region NON-SYNCED SETTINGS
                #region GATE A

                Timing.CallDelayed(Config.GateALockDelay, () =>
                {
                    #region ANNOUNCE GATE LOCK

                    if (Config.GateAShouldAnnounceLock)
                    {
                        if (Config.GateAShouldAnnounceLockGlitchy)
                        {
                            Cassie.GlitchyMessage(Config.GateAAnnounceLockBroadcast, Config.GateAAnnounceLockGlitchChance / 100, Config.GateAAnnounceLockJamChance / 100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.GateAAnnounceLockBroadcast, Config.GateAAnnounceLockTranslation);
                        }
                    }

                    #endregion

                    #region LOCK GATE

                    LockGate(GateA);

                    #endregion
                });

                Timing.CallDelayed(Config.GateACloseDelay, () =>
                {
                    #region CLOSE GATE

                    CloseGate(GateA);

                    #endregion
                });

                #endregion

                #region GATE B

                Timing.CallDelayed(Config.GateBLockDelay, () =>
                {
                    #region ANNOUNCE GATE LOCK

                    if (Config.GateBShouldAnnounceLock)
                    {
                        if (Config.GateBShouldAnnounceLockGlitchy)
                        {
                            Cassie.GlitchyMessage(Config.GateBAnnounceLockBroadcast, Config.GateBAnnounceLockGlitchChance / 100, Config.GateBAnnounceLockJamChance / 100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.GateBAnnounceLockBroadcast, Config.GateBAnnounceLockTranslation);
                        }
                    }

                    #endregion

                    #region LOCK GATE

                    LockGate(GateB);

                    #endregion
                });

                Timing.CallDelayed(Config.GateBCloseDelay, () =>
                {
                    #region CLOSE GATE

                    CloseGate(GateB);

                    #endregion
                });

                #endregion
                #endregion
            }
        }

        private void Respawn(RespawnedTeamEventArgs team)
        {
            Log.Debug($"{team.Wave.ToString()} arrived, opening their gate... (might take a while depending on config)");

            if (Config.ShouldSyncGates)
            {
                #region SYNCED SETTINGS

                Timing.CallDelayed(Config.SyncRespawnOpenDelay, () =>
                {
                    #region ANNOUNCE OPEN

                    if (Config.SyncShouldAnnounceOpen)
                    {
                        if (Config.SyncShouldAnnounceOpenGlitchy)
                        {
                            Cassie.GlitchyMessage(Config.SyncAnnounceOpenBroadcast, Config.SyncAnnounceOpenGlitchChance / 100, Config.SyncAnnounceOpenJamChance / 100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.SyncAnnounceOpenBroadcast, Config.SyncAnnounceOpenTranslation);
                        }
                    }

                    #endregion

                    #region OPEN GATE

                    if (team.Wave is NtfSpawnWave || team.Wave is NtfMiniWave)
                    {
                        OpenGate(GateB);
                    }
                    else if (team.Wave is ChaosSpawnWave || team.Wave is ChaosMiniWave)
                    {
                        OpenGate(GateA);
                    }

                    #endregion
                });

                Timing.CallDelayed(Config.SyncRespawnCloseDelay, () =>
                {
                    #region ANNOUNCE CLOSE

                    if (Config.SyncShouldAnnounceClose)
                    {
                        if (Config.SyncShouldAnnounceCloseGlitchy)
                        {
                            Cassie.GlitchyMessage(Config.SyncAnnounceCloseBroadcast, Config.SyncAnnounceCloseGlitchChance / 100, Config.SyncAnnounceCloseJamChance / 100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.SyncAnnounceCloseBroadcast, Config.SyncAnnounceCloseTranslation);
                        }
                    }

                    #endregion

                    #region CLOSE GATE

                    if (team.Wave is NtfSpawnWave || team.Wave is NtfMiniWave)
                    {
                        CloseGate(GateB);
                    }
                    else if (team.Wave is ChaosSpawnWave || team.Wave is ChaosMiniWave)
                    {
                        CloseGate(GateA);
                    }

                    #endregion
                });

                #endregion
            }
            else
            {
                #region NON-SYNCED SETTINGS
                #region GATE A

                if (team.Wave is ChaosSpawnWave || team.Wave is ChaosMiniWave)
                {
                    Timing.CallDelayed(Config.GateARespawnOpenDelay, () =>
                    {
                        #region ANNOUNCE OPEN

                        if (Config.GateAShouldAnnounceOpen)
                        {
                            if (Config.GateAShouldAnnounceOpenGlitchy)
                            {
                                Cassie.GlitchyMessage(Config.GateAAnnounceOpenBroadcast, Config.GateAAnnounceOpenGlitchChance / 100, Config.GateAAnnounceOpenJamChance / 100);
                            }
                            else
                            {
                                Cassie.MessageTranslated(Config.GateAAnnounceOpenBroadcast, Config.GateAAnnounceOpenTranslation);
                            }
                        }

                        #endregion

                        #region OPEN GATE

                        OpenGate(GateA);

                        #endregion
                    });

                    Timing.CallDelayed(Config.GateARespawnCloseDelay, () =>
                    {
                        #region ANNOUNCE CLOSE

                        if (Config.GateAShouldAnnounceClose)
                        {
                            if (Config.GateAShouldAnnounceCloseGlitchy)
                            {
                                Cassie.GlitchyMessage(Config.GateAAnnounceCloseBroadcast, Config.GateAAnnounceCloseGlitchChance / 100, Config.GateAAnnounceCloseJamChance / 100);
                            }
                            else
                            {
                                Cassie.MessageTranslated(Config.GateAAnnounceCloseBroadcast, Config.GateAAnnounceCloseTranslation);
                            }
                        }

                        #endregion

                        #region CLOSE GATE

                        CloseGate(GateA);

                        #endregion
                    });
                }

                #endregion

                #region GATE B

                else if (team.Wave is NtfSpawnWave || team.Wave is NtfMiniWave)
                {
                    Timing.CallDelayed(Config.GateBRespawnOpenDelay, () =>
                    {
                        #region ANNOUNCE OPEN

                        if (Config.GateBShouldAnnounceOpen)
                        {
                            if (Config.GateBShouldAnnounceOpenGlitchy)
                            {
                                Cassie.GlitchyMessage(Config.GateBAnnounceOpenBroadcast, Config.GateBAnnounceOpenGlitchChance / 100, Config.GateBAnnounceOpenJamChance / 100);
                            }
                            else
                            {
                                Cassie.MessageTranslated(Config.GateBAnnounceOpenBroadcast, Config.GateBAnnounceOpenTranslation);
                            }
                        }

                        #endregion

                        #region OPEN GATE

                        OpenGate(GateB);

                        #endregion
                    });

                    Timing.CallDelayed(Config.GateBRespawnCloseDelay, () =>
                    {
                        #region ANNOUNCE CLOSE

                        if (Config.GateBShouldAnnounceClose)
                        {
                            if (Config.GateBShouldAnnounceCloseGlitchy)
                            {
                                Cassie.GlitchyMessage(Config.GateBAnnounceCloseBroadcast, Config.GateBAnnounceCloseGlitchChance / 100, Config.GateBAnnounceCloseJamChance / 100);
                            }
                            else
                            {
                                Cassie.MessageTranslated(Config.GateBAnnounceCloseBroadcast, Config.GateBAnnounceCloseTranslation);
                            }
                        }

                        #endregion

                        #region CLOSE GATE

                        CloseGate(GateB);

                        #endregion
                    });
                }

                #endregion
                #endregion
            }
        }

        private void LockGate(Door gate)
        {
            if (gate != null)
            {
                gate.Lock(long.MaxValue, DoorLockType.AdminCommand);
                Log.Debug($"Locked {gate.Name}");
            }
            else
            {
                Log.Error("Gate is null (????)");
            }
        }

        private void CloseGate(Door gate)
        {
            if (gate != null)
            {
                if (gate.IsOpen)
                {
                    gate.IsOpen = false;
                    Log.Debug($"Closed {gate.Name}");
                }
            }
            else
            {
                Log.Error("Gate is null (????)");
            }
        }

        private void OpenGate(Door gate)
        {
            if (gate != null)
            {
                if (!gate.IsOpen)
                {
                    gate.IsOpen = true;
                    Log.Debug($"Opened {gate.Name}");
                }
            }
            else
            {
                Log.Error("Gate is null (????)");
            }
        }
    }
}