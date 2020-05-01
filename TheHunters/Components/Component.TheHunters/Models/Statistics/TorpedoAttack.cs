namespace Component.TheHunters.Models.Statistics
{
    internal class TorpedoAttack
    {
        #region CONSTRUCTOR
        private TorpedoAttack(int combatRound, bool hit, bool dud, int damaage)
        {
            this.CombatRound = combatRound;
            this.Hit = hit;
            this.Dud = dud;
            this.Damage = damaage;
        }
        #endregion

        #region PROPERTIES
        internal int CombatRound { get; }

        internal bool Hit { get; }

        internal bool Dud { get; }

        internal int Damage { get; }
        #endregion

        #region METHODS
        internal static TorpedoAttack SuccessfulAttack(int combatRound, int damage)
        {
            return new TorpedoAttack(combatRound, true, false, damage);
        }
        internal static TorpedoAttack DudAttack(int combatRound)
        {
            return new TorpedoAttack(combatRound, true, true, 0);
        }

        internal static TorpedoAttack UnsuccessfulAttack(int combatRound)
        {
            return new TorpedoAttack(combatRound, false, false, 0);
        }
        #endregion
    }
}