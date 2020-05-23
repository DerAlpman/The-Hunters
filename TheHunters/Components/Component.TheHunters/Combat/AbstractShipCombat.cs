using System;
using System.Collections.Generic;
using System.Linq;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Combat
{
    public abstract class AbstractShipCombat : IShipCombat
    {
        #region FIELDS
        private readonly IList<Ship> _Ships;
        #endregion

        #region IShipCombat
        public abstract bool Escorted { get; }

        public IEnumerable<Ship> AllShips => _Ships;

        public IEnumerable<Ship> NotSunkShips => _Ships.Where(s => !s.Sunk);

        public IEnumerable<Ship> DamagedShips => _Ships.Where(s => s.Damage > 0);

        public IEnumerable<ICombatRound> Rounds { get; }

        public void FinishCombatRound(ICombatRound combatRound)
        {
            throw new NotImplementedException();
        }

        public ICombatRound StartCombatRound()
        {
            throw new NotImplementedException();
        }
        #endregion IShipCombat
    }
}
