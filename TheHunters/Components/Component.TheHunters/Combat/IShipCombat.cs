using System.Collections.Generic;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Combat
{
    public interface IShipCombat
    {
        bool Escorted { get; }

        IEnumerable<Ship> AllShips { get; }

        IEnumerable<Ship> NotSunkShips { get; }

        IEnumerable<Ship> DamagedShips { get; }

        IEnumerable<ICombatRound> Rounds { get; }

        ICombatRound StartCombatRound();

        void FinishCombatRound(ICombatRound combatRound);
    }
}
