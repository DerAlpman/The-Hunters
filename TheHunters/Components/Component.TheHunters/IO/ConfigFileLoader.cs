using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.IO
{
    /// <summary>
    /// <para>Loads the necessary configuration files for the game.</para>
    /// </summary>
    internal class ConfigFileLoader : IConfigFileLoader
    {
        /// <summary>
        /// <para><see cref="IConfigFileLoader.ReadShipData(string)"/></para>
        /// </summary>
        public IEnumerable<Ship> ReadShipData(string configFile)
        {
            return JsonSerializer.Deserialize<IList<Ship>>(File.ReadAllText(Path.Combine(configFile)));
        }
    }
}
