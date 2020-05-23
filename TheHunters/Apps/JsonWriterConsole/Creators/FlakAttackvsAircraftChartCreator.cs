using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters.Enumerations;
using Component.TheHunters.IO;
using Component.TheHunters.Models.Charts;

namespace JsonWriterConsole.Creators
{
    /// <summary>
    /// <see cref="IConfigFileCreator"/>
    /// <para>This class creates configuration files for the Flak Attack vs. Aircraft chart.</para>
    /// </summary>
    internal class FlakAttackvsAircraftChartCreator : IConfigFileCreator
    {
        #region IConfigFileCreator
        /// <summary>
        /// <see cref="IConfigFileCreator.WriteData(string)"/>
        /// </summary>
        public void WriteData(string configFileFolder)
        {
            var data = BuildData();
            WriteDataToJson(configFileFolder, data);
        }
        #endregion IConfigFileCreator

        #region METHODS
        private void WriteDataToJson(string configFileFolder, IEnumerable<FlakAttackvsAircraft> data)
        {
            using var fileStream = new FileStream(Path.Combine(configFileFolder, "FlakAttackvsAircraftChart.json"), FileMode.Create);
            using var utf8JsonWriter = new Utf8JsonWriter(fileStream);
            JsonSerializer.Serialize(utf8JsonWriter, data);
        }

        private IEnumerable<FlakAttackvsAircraft> BuildData()
        {
            yield return new FlakAttackvsAircraft(-1, 3, FlakAttackvsAircraftResult.SHOT_DOWN);
            yield return new FlakAttackvsAircraft(4, 5, FlakAttackvsAircraftResult.DAMAGED);
            yield return new FlakAttackvsAircraft(6, 13, FlakAttackvsAircraftResult.MISS);
        }
        #endregion METHODS
    }
}