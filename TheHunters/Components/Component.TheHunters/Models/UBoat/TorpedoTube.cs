namespace Component.TheHunters.Models.UBoat
{
    /// <summary>
    /// <para>This can contain a <see cref="Torpedo"/> and is part of a <see cref="TorpedoSection"/>.</para>
    /// </summary>
    public class TorpedoTube
    {
        #region PROPERTIES
        public Torpedo Torpedo { get; set; }
        #endregion PROPERTIES

        #region METHODS
        internal bool IsLoaded()
        {
            return Torpedo != null;
        }
        #endregion
    }
}
