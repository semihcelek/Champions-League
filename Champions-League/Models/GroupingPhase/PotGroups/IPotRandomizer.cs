using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.GroupingPhase.PotGroups
{
    public interface IPotRandomizer
    {
        List<List<InitialTeamModel>> RandomizePotGroups(List<List<InitialTeamModel>> potList);
    }
}