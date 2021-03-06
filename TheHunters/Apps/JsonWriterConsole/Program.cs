﻿using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Component.TheHunters.IO;
using Component.TheHunters.Models.Charts;
using JsonWriterConsole.Creators;

namespace JsonWriterConsole
{
    internal static class Program
    {
        private static void Main()
        {
            var configFileFolder = GetFoldersForConfigurationFiles();

            var creators = new List<IConfigurationFileCreator>()
            {
                { new ShipListCreator() },
                { new UBoatModelCreator() },
                { new UBoatPatrolAssignmentCreator() },
                { new EncounterChartCreator() },
                { new FlakAttackvsAircraftChartCreator() }
            };

            foreach (var creator in creators)
            {
                creator.WriteData(configFileFolder);
            }
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
