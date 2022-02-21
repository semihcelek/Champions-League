using System;
using System.Collections.Generic;
using System.Linq;

namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class TeamPotAdjuster
    {
        private TeamDataExtractor _teamDataExtractor;

        private List<InitialTeamModel> _initialTeamList;

        private List<InitialTeamModel> _sortedTeamList;

        private Dictionary<char, InitialTeamModel> _RandomizedTeamPots;

        private IPotRandomizer _potRandomizer;

        public TeamPotAdjuster(TeamDataExtractor teamDataExtractor, IPotRandomizer potRandomizer)
        {
            _teamDataExtractor = teamDataExtractor;
            _potRandomizer = potRandomizer;
            _initialTeamList = teamDataExtractor.TeamList;

            _sortedTeamList = new List<InitialTeamModel>();
        }

        public void TeamSeedSeparator()
        {
            _sortedTeamList = _initialTeamList.OrderBy(teams => teams.TeamSeedPoint).ToList();
            foreach (InitialTeamModel teamModel in _sortedTeamList)
            {
                Console.WriteLine(teamModel.TeamName + teamModel.TeamCountryCode +teamModel.TeamSeedPoint);

            }
        }

        private void RandomizePots()
        {
            // _RandomizedTeamPots = _potRandomizer.RandomizePots(_sortedTeamList);
        }
    }
}