using Component.TheHunters.Models.Charts;
using Component.TheHunters.Models.UBoat;

namespace Component.TheHunters.Combat
{
    public interface ICombatRound
    {
        int RoundNumber { get; }

        bool Completed { get; }

        void CompleteRound();

        void AddGunAttack(Ship ship, int rounds);

        void ResolveGunAttack(Ship ship);

        void AddTorpedoAttack(Ship ship, Torpedo[] torpedos);

        void ResolveTorpedoAttack(Ship ship);
    }
}