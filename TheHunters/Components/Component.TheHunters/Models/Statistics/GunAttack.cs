namespace Component.TheHunters.Models.Statistics
{
    internal class GunAttack
    {
        #region CONSTRUCTOR
        private GunAttack(int combatRound, bool hit, int damage)
        {
            this.CombatRound = combatRound;
            this.Hit = hit;
            this.Damage = damage;
        }
        #endregion

        #region PROPERTIES
        internal int CombatRound { get; }

        internal bool Hit { get; }

        internal int Damage { get; }
        #endregion

        #region METHODS
        internal static GunAttack SuccessfulAttack(int combatRound, int damage)
        {
            return new GunAttack(combatRound, true, damage);
        }
        internal static GunAttack UnsuccessfulAttack(int combatRound)
        {
            return new GunAttack(combatRound, false, 0);
        }
        #endregion
    }
}