namespace Component.TheHunters.IO
{
    /// <summary>
    /// <para>Defines methods for writing configuration file data.</para>
    /// </summary>
    public interface IConfigurationFileCreator
    {
        /// <summary>
        /// <para>Writes the data <paramref name="configFileFolder"/>.</para>
        /// </summary>
        /// <param name="configFileFolder">A path to a folder.</param>
        void WriteData(string configFileFolder);
    }
}