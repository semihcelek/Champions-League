using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase.DrawGroups
{
    public interface IGroupDistributeController
    {
        void DistributeTitleHolderGroups(InitialTeamModel teamModel);
        void DistributeRemainingGroups(InitialTeamModel teamModel);
    }
}