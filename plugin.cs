using System;

using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Doors;
using Exiled.Events.EventArgs.Server;
using Respawning.Waves;

/*

using InventorySystem.Items.Thirdperson.LayerProcessors;
wtf was this doing here?

 */

namespace aegis.gateify
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Gateify";
        public override string Author => "aegis";
        public override Version Version => new Version(0, 1, 0);
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
            GateA = Door.Get("GATE_A");
            GateB = Door.Get("GATE_B");
            LockGate(GateA);
            LockGate(GateB);
        }

        private void Respawn(RespawnedTeamEventArgs team)
        {
            Log.Debug($"{team.Wave} arrived, unlocking their respective gate");
            if (team.Wave is NtfSpawnWave || team.Wave is NtfMiniWave)
            {
                OpenGate(GateB);
            }
            else if (team.Wave is ChaosSpawnWave || team.Wave is ChaosMiniWave)
            {
                OpenGate(GateA);
            }
        }

        private void LockGate(Door gate)
        {
            if (gate != null)
            {
                gate.Lock(long.MaxValue, DoorLockType.AdminCommand);
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
                }
            }
            else
            {
                Log.Error("Gate is null (????)");
            }
        }
    }
}