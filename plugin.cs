using System;

using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Doors;
using Exiled.Events.EventArgs.Server;
using Exiled.Events.Features;
using InventorySystem.Items.Thirdperson.LayerProcessors;

namespace aegis.gateify
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Gateify";
        public override string Author => "aegis";
        public override Version Version => new Version(0,1,0);
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
            Log.Debug($"{team.Wave} arrived, unlocking gate");
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

        private void UnlockGate(Door gate)
        {
            if (gate != null)
            {
                gate.Unlock(long.MaxValue, DoorLockType.AdminCommand);
            }
            else
            {
                Log.Error("Gate is null (????)");
            }
        }
    }
}