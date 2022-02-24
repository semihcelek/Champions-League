using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public class TeamModelConverter: ITeamModelConverter
    {
        public TeamModel ConvertInitialTeamModel(InitialTeamModel initialTeamModel)
        {
            return new TeamModel(initialTeamModel.TeamName, initialTeamModel.TeamCountryCode);
        }
    }
}