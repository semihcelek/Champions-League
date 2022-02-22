using SemihCelek.Champions_League.Models.GroupingPhase.PotGroups;

namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class GroupDistributeController : IGroupDistributeController
    {
        private int groupingOrder;

        public GroupDistributeController()
        {
            groupingOrder = 0;
        }

        public void DistributeTitleHolderGroups(InitialTeamModel teamModel)
        {
            
            groupingOrder++;
        }

        public void DistributeRemainingGroups(InitialTeamModel teamModel)
        {
            throw new System.NotImplementedException();
        }
    }
}