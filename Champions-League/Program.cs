using System;
using SemihCelek.Champions_League.Models.DataAccess;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;
using SemihCelek.Champions_League.Utils;

namespace SemihCelek.Champions_League
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDataPathFinder dataPathFinder = new DataPathFinder();
            IDataAccess groupDataAccess = new GroupDataAccess(dataPathFinder);
            TeamDataExtractor teamDataExtractor = new TeamDataExtractor(groupDataAccess);
            IPotRandomizer potRandomizer = new PotRandomizer();

            TeamPotAdjuster teamPotAdjuster = new TeamPotAdjuster(teamDataExtractor, potRandomizer);
            teamPotAdjuster.AdjustTeamPots();

        }
    }
}