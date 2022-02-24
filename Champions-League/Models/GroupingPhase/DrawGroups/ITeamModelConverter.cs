using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public interface ITeamModelConverter
    {
        TeamModel ConvertInitialTeamModel(InitialTeamModel teamModel);
    }
}