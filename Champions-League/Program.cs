using System;
using SemihCelek.Champions_League.Models.DataAccess;
using SemihCelek.Champions_League.Models.GroupingPhase;
using SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;
using SemihCelek.Champions_League.Utils;

namespace SemihCelek.Champions_League
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IDataPathFinder dataPathFinder = new DataPathFinder();
            IDataAccess groupDataAccess = new GroupDataAccess(dataPathFinder);
            TeamDataExtractor teamDataExtractor = new TeamDataExtractor(groupDataAccess);
            IPotRandomizer potRandomizer = new PotRandomizer();

            TeamPotAdjuster teamPotAdjuster = new TeamPotAdjuster(teamDataExtractor, potRandomizer);

            TeamModelConverter teamModelConverter = new TeamModelConverter();
            GroupController groupController = new GroupController();

            IGroupDistributeController groupDistributeController =
                new GroupDistributeController(teamModelConverter, groupController.CompetingGroups);
            // Draw
            TitleHolderTeamsDraw titleHolderTeamsDraw =
                new TitleHolderTeamsDraw(teamPotAdjuster, groupDistributeController);

            RemainingTeamsDraw remainingTeamsDraw = new RemainingTeamsDraw(teamPotAdjuster, groupDistributeController);

            // teamPotAdjuster.ShowPots();

            titleHolderTeamsDraw.DistributeTeamsToGroups();
            remainingTeamsDraw.DistributeTeamsToGroups();
        }
    }
}