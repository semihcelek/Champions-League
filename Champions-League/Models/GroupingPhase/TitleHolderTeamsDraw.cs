using System.Collections.Generic;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class TitleHolderTeamsDraw
    {
        private TeamPotAdjuster _teamPotAdjuster;

        private List<InitialTeamModel> _titleHolderTeamPots;

        private IGroupDistributeController _groupDistributeController;

        public TitleHolderTeamsDraw(TeamPotAdjuster teamPotAdjuster)
        {
            _teamPotAdjuster = teamPotAdjuster;
            _titleHolderTeamPots = _teamPotAdjuster.AdjustTeamPots()[0];
        }

        private void DistributeTeamsToGroups()
        {
            int groupIndex = 0;
            foreach (InitialTeamModel teamModel in _titleHolderTeamPots)
            {
                _groupDistributeController.DistributeTitleHolderGroups(teamModel);
                groupIndex++;
            }
        }
    }
}