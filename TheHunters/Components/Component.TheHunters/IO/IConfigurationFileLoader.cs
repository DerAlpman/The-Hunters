using System.Collections.Generic;
using System.IO;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.IO
{
    /// <summary>
    /// <para>Defines methods for reading configuration file data.</para>
    /// </summary>
    public interface IConfigurationFileLoader
    {
        /// <summary>
        /// <para>Reads ship data from a directory.</para>
        /// </summary>
        /// <param name="dataDirectory">The directory containing the ship data</param>
        /// <returns>A collection of <see cref="Ship"/>.</returns>
        IEnumerable<Ship> ReadShipDataFromDirectory(DirectoryInfo dataDirectory);
    }
}
