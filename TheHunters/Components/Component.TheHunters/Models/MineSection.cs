namespace Component.TheHunters.Models
{
    public class MineSection
    {
        #region CONSTRUCTOR
        public MineSection(int maxMines)
        {
            MaxMines = maxMines;
            CurrentMines = maxMines;
        }
        #endregion

        #region PROPERTIES
        public int MaxMines { get; set; }

        public int CurrentMines { get; set; }
        #endregion
    }
}
