using System.Collections.Generic;
using System.Linq;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Models.Statistics
{
    internal class ShipStatistic
    {
        #region FIELDS
        private readonly IList<GunAttack> _GunAttacks;
        private readonly IList<TorpedoAttack> _TorpedoAttacks;
        #endregion

        #region CONSTRUCTOR
        public ShipStatistic(Ship ship)
        {
            this.Ship = ship;
            _GunAttacks = new List<GunAttack>();
            _TorpedoAttacks = new List<TorpedoAttack>();
        }
        #endregion

        #region Properties
        internal Ship Ship { get; }

        internal int NumberGunAttacks => _GunAttacks.Count;

        internal double GunHitsPerAttack => (double)GunTotalHits / NumberGunAttacks;

        internal double GunDamagePerHit => (double)GunTotalDamage / GunTotalHits;

        internal double GunDamagePerAttack => (double)GunTotalDamage / NumberGunAttacks;

        internal int GunTotalDamage => _GunAttacks.Sum(ga => ga.Damage);

        internal int GunTotalHits => _GunAttacks.Count(ga => ga.Hit);

        internal int NumberTorpedoAttacks => _TorpedoAttacks.Count;

        internal double TorpedoHitsPerAttack => (double)TorpedoTotalHits / NumberTorpedoAttacks;

        internal double TorpedoDamagePerHit => (double)TorpedoTotalDamage / TorpedoTotalHitsWithoutDuds;

        internal double TorpedoDamagePerAttack => (double)TorpedoTotalDamage / NumberTorpedoAttacks;

        internal int TorpedoTotalDamage => _TorpedoAttacks.Sum(ta => ta.Damage);

        internal int TorpedoTotalHits => _TorpedoAttacks.Count(ta => ta.Hit);

        internal int TorpedoTotalHitsWithoutDuds => TorpedoTotalHits - TorpedoTotalDuds;

        internal int TorpedoTotalDuds => _TorpedoAttacks.Count(ta => ta.Dud);

        internal double TorpedoDudsPerHit => (double)TorpedoTotalDuds / TorpedoTotalHits;

        internal double TorpedoDudsPerAttack => (double)TorpedoTotalDuds / NumberTorpedoAttacks;
        #endregion Properties

        #region METHODS
        public void AddGunAttack(GunAttack attack)
        {
            _GunAttacks.Add(attack);
        }

        public void AddTorpedoAttack(TorpedoAttack attack)
        {
            _TorpedoAttacks.Add(attack);
        }
        #endregion METHODS
    }
}
