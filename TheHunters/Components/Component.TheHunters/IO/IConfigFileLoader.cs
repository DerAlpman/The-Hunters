using System.Collections.Generic;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.IO
{
    /// <summary>
    /// <para>Defines methods for reading configuration file data.</para>
    /// </summary>
    public interface IConfigFileLoader
    {
        /// <summary>
        /// <para>Reads the ships that are persisted in <paramref name="configFile"/>.</para>
        /// </summary>
        /// <param name="configFile">A configuration file.</param>
        IEnumerable<Ship> ReadShipData(string configFile);
    }
}
