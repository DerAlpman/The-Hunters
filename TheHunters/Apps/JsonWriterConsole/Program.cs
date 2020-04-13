using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Component.TheHunters.Models;
using JsonWriterConsole.Creator;
using JsonWriterConsole.Creators;

namespace JsonWriterConsole
{
    internal static class Program
    {
        private static void Main()
        {
            var configFileFolder = GetFoldersForConfigurationFiles();

            ShipListCreator.WriteShips(configFileFolder);
            UBoatModelCreator.WriteUBoatModels(configFileFolder);
            UBoatPatrolAssignmentCreator.WritePatrolAssignments(configFileFolder);
        }

        private static string GetFoldersForConfigurationFiles()
        {
            Assembly currentAssem = Assembly.GetAssembly(typeof(Ship));
            var directory = Path.GetDirectoryName(currentAssem.CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(directory).Value;
            return Path.Combine(appRoot, @"..\..\Components", currentAssem.GetName().Name, "ConfigurationFiles");
        }

    }
}
