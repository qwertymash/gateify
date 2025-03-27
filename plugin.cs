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
            GateA = Door.Get(DoorType.GateA);
            GateB = Door.Get(DoorType.GateB);

            if (Config.ShouldSyncGates)
            {
                #region SYNCED SETTINGS
                Timing.CallDelayed(Config.SyncLockDelay, () =>
                {
                    #region ANNOUNCE LOCK
                    if (Config.SyncShouldAnnounceLock)
                    {

                    }
                    #endregion
                });
                #endregion
            }
            else
            {
                #region NON-SYNCED SETTINGS

                #endregion
            }

            /*Timing.CallDelayed(Config.SyncLockDelay, () =>
            {
                LockGate(GateA);
                LockGate(GateB);
                
                if (Config.SyncShouldCloseAfterDelay)
                {
                    CloseGate(GateA);
                    CloseGate(GateB);
                }

                if (Config.SyncShouldAnnounceLock)
                {
                    if (Config.SyncShouldAnnounceLockGlitch)
                    {
                        Cassie.GlitchyMessage(Config.SyncAnnounceLockBroadcast, Config.SyncAnnounceLockGlitchChance/100, Config.SyncAnnounceLockJamChance/100);
                    }
                    else
                    {
                        Cassie.MessageTranslated(Config.SyncAnnounceLockBroadcast, Config.SyncAnnounceTranslation);
                    }
                }
            });*/
        }

        private void Respawn(RespawnedTeamEventArgs team)
        {
            /*Log.Debug($"{team.Wave} arrived, unlocking their respective gate");
            if (team.Wave is NtfSpawnWave || team.Wave is NtfMiniWave)
            {
                if (!Config.SyncShouldOpenAfterDelay)
                {
                    OpenGate(GateB);
                }

                Timing.CallDelayed(Config.AnnounceOpenDelay, () =>
                {
                    if (Config.SyncShouldOpenAfterDelay)
                    {
                        OpenGate(GateB);
                    }

                    if (Config.ShouldAnnounceOpen)
                    {
                        if (Config.ShouldAnnounceOpenGlitch)
                        {
                            Cassie.GlitchyMessage(Config.AnnounceOpenBroadcastGateB, Config.AnnounceOpenGlitchChance/100, Config.AnnounceOpenJamChance/100);
                        }
                        else
                        {
                            Cassie.MessageTranslated(Config.AnnounceOpenBroadcastGateB, Config.AnnounceOpenTranslationGateB);
                        }
                    }
                });

                if (Config.ShouldCloseGates)
                {
                    Timing.CallDelayed(Config.CloseGatesAfter, () =>
                    {
                        CloseGate(GateB);
                    });
                }
            }
            else if (team.Wave is ChaosSpawnWave || team.Wave is ChaosMiniWave)
            {
                if (!Config.ShouldOpenAfterDelay)
                {
                    OpenGate(GateA);
                }

                Timing.CallDelayed(Config.AnnounceOpenDelay, () =>
                {
                    if (Config.ShouldOpenAfterDelay)
                    {
                        OpenGate(GateA);
                    }

                    if (Config.ShouldAnnounceOpenGlitch)
                    {
                        Cassie.GlitchyMessage(Config.AnnounceOpenBroadcastGateA, Config.AnnounceOpenGlitchChance/100, Config.AnnounceOpenJamChance/100);
                    }
                    else if (Config.ShouldAnnounceOpen)
                    {
                        Cassie.MessageTranslated(Config.AnnounceOpenBroadcastGateA, Config.AnnounceOpenTranslationGateA);
                    }
                });

                if (Config.ShouldCloseGates)
                {
                    Timing.CallDelayed(Config.CloseGatesAfter, () =>
                    {
                        CloseGate(GateA);
                    });
                }
            }*/
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