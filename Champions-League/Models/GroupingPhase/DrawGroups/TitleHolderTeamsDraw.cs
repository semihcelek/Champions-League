using System.Collections.Generic;
using SemihCelek.Champions_League.Controllers;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public class TitleHolderTeamsDraw : ITeamDraw
    {
        // use struct for storing both group name on char and InitialTeamModel

        private TeamPotAdjuster _teamPotAdjuster;

        private List<InitialTeamModel> _titleHolderTeamPots;

        private IGroupDistributeController _groupDistributeController;

        public TitleHolderTeamsDraw(TeamPotAdjuster teamPotAdjuster,
            IGroupDistributeController groupDistributeController)
        {
            _teamPotAdjuster = teamPotAdjuster;
            _groupDistributeController = groupDistributeController;
            _titleHolderTeamPots = _teamPotAdjuster.RandomizedPotList[0];
        }

        public void DistributeTeamsToGroups()
        {
            foreach (InitialTeamModel teamModel in _titleHolderTeamPots)
            {
                _groupDistributeController.DistributeTitleHolderGroups(teamModel);
            }
        }
    }
}