using System.Collections.Generic;
using SemihCelek.Champions_League.Utils;

namespace SemihCelek.Champions_League.Models.GroupingPhase.PotGroups
{
    public class PotRandomizer : IPotRandomizer
    {
        private List<InitialTeamModel> ShufflePotGroups(List<InitialTeamModel> groupList)
        {
            return Shuffle.ShuffleList(groupList);
        }

        public List<List<InitialTeamModel>> RandomizePotGroups(List<List<InitialTeamModel>> potList)
        {
            for (int i = 0; i <= 3; i++)
            {
                potList[i] = ShufflePotGroups(potList[i]);
            }

            return potList;
        }
    }
}