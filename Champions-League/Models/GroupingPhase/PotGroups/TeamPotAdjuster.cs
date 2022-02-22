using System;
using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.GroupingPhase.PotGroups
{
    public class TeamPotAdjuster
    {
        private List<InitialTeamModel> _initialTeamList;

        private List<List<InitialTeamModel>> _potList;

        private List<List<InitialTeamModel>> _randomizedPotList;
        
        private IPotRandomizer _potRandomizer;

        public TeamPotAdjuster(TeamDataExtractor teamDataExtractor, IPotRandomizer potRandomizer)
        {
            _potRandomizer = potRandomizer;
            _initialTeamList = teamDataExtractor.ExtractTeams();

            _potList = new List<List<InitialTeamModel>>();
            _randomizedPotList = new List<List<InitialTeamModel>>();
        }

        private void CategorizeTeamsWithTheirSeedPoints()
        {
            List<InitialTeamModel> pot1 = _initialTeamList.FindAll(team => team.TeamSeedPoint == 1);
            List<InitialTeamModel> pot2 = _initialTeamList.FindAll(team => team.TeamSeedPoint == 2);
            List<InitialTeamModel> pot3 = _initialTeamList.FindAll(team => team.TeamSeedPoint == 3);
            List<InitialTeamModel> pot4 = _initialTeamList.FindAll(team => team.TeamSeedPoint == 4);

            _potList.Add(pot1);
            _potList.Add(pot2);
            _potList.Add(pot3);
            _potList.Add(pot4);
        }

        public List<List<InitialTeamModel>> AdjustTeamPots()
        {
            CategorizeTeamsWithTheirSeedPoints();
            _randomizedPotList = _potRandomizer.RandomizePotGroups(_potList);
            return _randomizedPotList;
        }

        private void ShowPots()
        {
            foreach (List<InitialTeamModel> teamPotList in _randomizedPotList)
            {
                foreach (InitialTeamModel teamModel in teamPotList)
                {
                    Console.WriteLine(teamModel.TeamName + "  " + teamModel.TeamSeedPoint + "  " +
                                      teamModel.TeamCountryCode);
                }
            }
        }
    }
}