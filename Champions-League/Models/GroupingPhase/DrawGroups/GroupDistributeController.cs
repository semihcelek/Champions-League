using System;
using System.Collections.Generic;
using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public class GroupDistributeController : IGroupDistributeController
    {
        private int _groupingOrder;
        
        private ITeamModelConverter _teamModelConverter;
        
        private List<GroupModel> _competitionGroups;

        public GroupDistributeController(ITeamModelConverter teamModelConverter, List<GroupModel> competitionGroups)
        {
            _teamModelConverter = teamModelConverter;
            _competitionGroups = competitionGroups;
            _groupingOrder = 0;
        }

        public void DistributeTitleHolderGroups(InitialTeamModel teamModel)
        {
            TeamModel currentTeam = _teamModelConverter.ConvertInitialTeamModel(teamModel);
            _competitionGroups[_groupingOrder].CompetingTeams.Add(currentTeam);

            _groupingOrder++;
        }

        public void DistributeRemainingGroups(InitialTeamModel teamModel)
        {
            TeamModel currentTeam = _teamModelConverter.ConvertInitialTeamModel(teamModel);
            _competitionGroups[_groupingOrder % 8].CompetingTeams.Add(currentTeam);

            _groupingOrder++;
        }
    }
}