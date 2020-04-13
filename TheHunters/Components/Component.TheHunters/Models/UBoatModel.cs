using System;
using System.Collections.Generic;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class UBoatModel
    {
        #region CONSTRUCTOR
        public UBoatModel(
            UBoatModels model, int length, int displacement,
            double speed, int range, int crew,
            int totalProduced, DeckGun deckGun, Flak[] flaks,
            int mineLoad, int torpedoLoad, DateTime available,
            int standardNumberSteamTorpedos, int standardNumberElectricTorpedos, int maxTorpedoAdjustments,
            MineSection mineSection, TorpedoSection frontTorpedoSection, TorpedoSection aftTorpedoSection,
            List<PatrolRegion> patrols)
        {
            Model = model;
            Length = length;
            Displacement = displacement;
            SurfaceSpeed = speed;
            Range = range;
            Crew = crew;
            TotalProduced = totalProduced;
            DeckGun = deckGun;
            Flak = flaks;
            Mineload = mineLoad;
            TorpedoLoad = torpedoLoad;
            Available = available;
            StandardNumberSteamTorpedos = standardNumberSteamTorpedos;
            StandardNumberElectricTorpedos = standardNumberElectricTorpedos;
            MaxTorpedoAdjustments = maxTorpedoAdjustments;
            MineSection = mineSection;
            FrontTorpedoSection = frontTorpedoSection;
            AftTorpedoSection = aftTorpedoSection;
            Patrols = patrols;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public UBoatModels Model { get; }

        public int Length { get; }

        public int Displacement { get; }

        public double SurfaceSpeed { get; }

        public int Range { get; }

        public int Crew { get; }

        public int TotalProduced { get; }

        public int Mineload { get; }

        public int TorpedoLoad { get; }

        public DateTime Available { get; }

        public DeckGun DeckGun { get; }

        public Flak[] Flak { get; }

        public int StandardNumberSteamTorpedos { get; }

        public int StandardNumberElectricTorpedos { get; }

        public int MaxTorpedoAdjustments { get; }

        public MineSection MineSection { get; set; }

        public TorpedoSection FrontTorpedoSection { get; set; }

        public TorpedoSection AftTorpedoSection { get; set; }

        public IEnumerable<PatrolRegion> Patrols { get; set; }
        #endregion PROPERTIES
    }
}
