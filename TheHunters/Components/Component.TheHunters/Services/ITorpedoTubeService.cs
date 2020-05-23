using Component.TheHunters.Models.UBoat;

namespace Component.TheHunters.Services
{
    /// <summary>
    /// <para>Provides methods for handling of <see cref="TorpedoTube"/>.</para>
    /// </summary>
    public interface ITorpedoTubeService
    {
        /// <summary>
        /// <para>Reloads <paramref name="torpedoTube"/> with <paramref name="torpedo"/>.</para>
        /// </summary>
        /// <param name="torpedoTube">A <see cref="TorpedoTube"/>.</param>
        /// <param name="torpedo">A <see cref="Torpedo"/>.</param>
        bool TryReloadTorpedoTube(TorpedoTube torpedoTube, Torpedo torpedo, out string message);
    }
}