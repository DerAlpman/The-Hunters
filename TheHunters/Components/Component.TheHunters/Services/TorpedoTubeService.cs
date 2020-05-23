using System;
using Component.TheHunters.Models.UBoat;
using Component.TheHunters.Properties;

namespace Component.TheHunters.Services
{
    /// <summary>
    /// <see cref="ITorpedoTubeService"/>
    /// </summary>
    internal class TorpedoTubeService : ITorpedoTubeService
    {
        /// <summary>
        /// <see cref="ITorpedoTubeService.TryReloadTorpedoTube(TorpedoTube, Torpedo)"/>
        /// </summary>
        /// <exception cref="System.ArgumentNullException">If <paramref name="torpedoTube"/> or <paramref name="torpedo"/> is null."/></exception>
        public bool TryReloadTorpedoTube(TorpedoTube torpedoTube, Torpedo torpedo, out string message)
        {
            message = String.Empty;
            if (torpedoTube is null)
            {
                throw new ArgumentNullException(nameof(torpedoTube));
            }

            if (torpedo is null)
            {
                throw new ArgumentNullException(nameof(torpedo));
            }

            if (torpedoTube.IsLoaded())
            {
                message = Resources.TorpedoTubeAlreadyLoaded;
                return false;
            }

            torpedoTube.Torpedo = torpedo;
            message = Resources.TorpedoTubeNowLoaded;
            return true;
        }
    }
}