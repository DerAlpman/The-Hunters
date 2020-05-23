using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.IO
{
    /// <summary>
    /// <para>Loads the necessary configuration files for the game.</para>
    /// </summary>
    internal class JsonConfigurationFileLoader : IConfigurationFileLoader
    {
        /// <summary>
        /// <see cref="IConfigurationFileLoader.ReadShipDataFromDirectory(string)"/>
        /// </summary>
        public IEnumerable<Ship> ReadShipDataFromDirectory(DirectoryInfo dataDirectory)
        {
            foreach (var file in dataDirectory.GetFiles("*.json", SearchOption.TopDirectoryOnly))
            {
                foreach (var ship in JsonSerializer.Deserialize<IList<Ship>>(File.ReadAllText(file.FullName)))
                {
                    yield return ship;
                }
            }
        }
    }
}
