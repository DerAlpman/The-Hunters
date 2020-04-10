using System;
using Component.TheHunters.Properties;

namespace Component.TheHunters.Models
{
    public class TorpedoTube
    {
        #region PROPERTIES
        public Torpedo Torpedo { get; set; }
        #endregion PROPERTIES

        public void Reload(Torpedo torpedo)
        {
            if (Torpedo != null)
                throw new InvalidOperationException(Resources.TorpedoTubeAlreadyLoaded);

            Torpedo = torpedo ?? throw new ArgumentNullException(nameof(torpedo));
        }
    }
}
