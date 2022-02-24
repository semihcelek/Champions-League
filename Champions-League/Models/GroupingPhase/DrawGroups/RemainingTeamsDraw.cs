using System.Collections.Generic;
using SemihCelek.Champions_League.Controllers;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public class RemainingTeamsDraw : ITeamDraw
    {
        private TeamPotAdjuster _teamPotAdjuster;
        
        private List<List<InitialTeamModel>> _remainingTeams;

        private IGroupDistributeController _groupDistributeController;

        public RemainingTeamsDraw(TeamPotAdjuster teamPotAdjuster, IGroupDistributeController groupDistributeController)
        {
            _teamPotAdjuster = teamPotAdjuster;
            _groupDistributeController = groupDistributeController;
            
            _remainingTeams = new List<List<InitialTeamModel>>();
            
            _remainingTeams.Add(teamPotAdjuster.RandomizedPotList[1]);
            _remainingTeams.Add(teamPotAdjuster.RandomizedPotList[2]);
            _remainingTeams.Add(teamPotAdjuster.RandomizedPotList[3]);
        }
        
        public void DistributeTeamsToGroups()
        {
            for (int i = 0; i < _remainingTeams.Count; i++)
            {
                List<InitialTeamModel> remainingTeamPots = _remainingTeams[i];
                
                for (var j = 0; j < remainingTeamPots.Count; j++)
                {
                    InitialTeamModel teamModel = remainingTeamPots[j];
                    _groupDistributeController.DistributeRemainingGroups(teamModel);
                }
            }
        }
        
    }
}