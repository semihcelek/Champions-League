using System;
using SemihCelek.Champions_League.Controllers;
using SemihCelek.Champions_League.Models.DataAccess;
using SemihCelek.Champions_League.Models.GroupingPhase;
using SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;
using SemihCelek.Champions_League.Utils;
using SemihCelek.Champions_League.Views.DrawViews;

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
            
            GroupManager groupManager = new GroupManager();

            IGroupDistributeController groupDistributeController =
                new GroupDistributeController(teamModelConverter, groupManager.CompetingGroups);
            
            // Draw
            ITeamDraw titleHolderTeamsDraw =
                new TitleHolderTeamsDraw(teamPotAdjuster, groupDistributeController);
            
            ITeamDraw remainingTeamsDraw = 
                new RemainingTeamsDraw(teamPotAdjuster, groupDistributeController);

            DrawController titleHolderTeamsDrawController = new DrawController(titleHolderTeamsDraw);
            DrawController remainingTeamsDrawController = new DrawController(remainingTeamsDraw);

            DrawSelectionView drawSelectionView = new DrawSelectionView(titleHolderTeamsDrawController, remainingTeamsDrawController);

            drawSelectionView.CreateView();
        }
    }
}