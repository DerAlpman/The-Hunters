using System;

namespace Component.TheHunters.Models
{
    public class UBoatModel
    {
        #region PROPERTIES
        public string Type { get; }

        public int Length { get; }

        public int Displacement { get; }

        public double SurfaceSpeed { get; }

        public int Range { get; }

        public int Crew { get; }

        public int TotalProduced { get; }

        public int Mineload { get; }

        public int TorpedoLoad { get; }

        public Torpedo[] ForwardReloads { get; }

        public Torpedo[] AftReloads { get; }

        public DateTime Available { get; }

        public DeckGun DeckGun { get; }

        public Flak[] Flak { get; }

        public TorpedoTube[] ForwardTorpedoTubes { get; }

        public TorpedoTube[] AftTorpedoTubes { get; }

        public int StandardNumberSteamTorpedod { get; }

        public int StandardNumberElectricTorpedos { get; }

        public int MaxTorpedoAdjustments { get; }
        #endregion PROPERTIES
    }
}
