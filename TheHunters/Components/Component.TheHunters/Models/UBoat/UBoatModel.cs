using System;
using System.Collections.Generic;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Models.UBoat
{
    /// <summary>
    /// <para>A model of a <see cref="UBoat"/>.</para>
    /// </summary>
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
            List<Patrol> patrols)
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

        public IEnumerable<Patrol> Patrols { get; set; }
        #endregion PROPERTIES
    }
}
