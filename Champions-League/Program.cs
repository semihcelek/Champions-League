using System;
using SemihCelek.Champions_League.Models.DataAccess;
using SemihCelek.Champions_League.Models.GroupingPhase;
using SemihCelek.Champions_League.Utils;

namespace SemihCelek.Champions_League
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDataPathFinder dataPathFinder = new DataPathFinder();
            IDataAccess dataAccess = new GroupDataAccess(dataPathFinder);
            TeamDataExtractor teamDataExtractor = new TeamDataExtractor(dataAccess);
            IPotRandomizer potRandomizer = new PotRandomizer();

            TeamPotAdjuster teamPotAdjuster = new TeamPotAdjuster(teamDataExtractor, potRandomizer);
            teamPotAdjuster.TeamSeedSeparator();

        }
    }
}