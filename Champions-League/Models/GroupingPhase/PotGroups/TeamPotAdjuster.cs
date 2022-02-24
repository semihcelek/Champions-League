using System;
using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.GroupingPhase.PotGroups
{
    public class TeamPotAdjuster
    {
        public List<List<InitialTeamModel>> RandomizedPotList
        {
            get => _randomizedPotList;
            set => _randomizedPotList = value;
        }
        
        private List<InitialTeamModel> _initialTeamList;

        private List<List<InitialTeamModel>> _potList;

        private List<List<InitialTeamModel>> _randomizedPotList;
        
        private IPotRandomizer _potRandomizer;

        public TeamPotAdjuster(TeamDataExtractor teamDataExtractor, IPotRandomizer potRandomizer)
        {
            _potRandomizer = potRandomizer;
            _initialTeamList = teamDataExtractor.ExtractTeams();

            _potList = new List<List<InitialTeamModel>>();
            RandomizedPotList = new List<List<InitialTeamModel>>();

            AdjustTeamPots();
        }



        private void CategorizeTeamsWithTheirSeedPoints()
        {
            List<InitialTeamModel> pot1 = _initialTeamList.FindAll(team => team.TeamSeedPoint.Equals(1));
            List<InitialTeamModel> pot2 = _initialTeamList.FindAll(team => team.TeamSeedPoint.Equals(2));
            List<InitialTeamModel> pot3 = _initialTeamList.FindAll(team => team.TeamSeedPoint.Equals(3));
            List<InitialTeamModel> pot4 = _initialTeamList.FindAll(team => team.TeamSeedPoint.Equals(4));

            _potList.Add(pot1);
            _potList.Add(pot2);
            _potList.Add(pot3);
            _potList.Add(pot4);
        }

        private List<List<InitialTeamModel>> AdjustTeamPots()
        {
            CategorizeTeamsWithTheirSeedPoints();
            RandomizedPotList = _potRandomizer.RandomizePotGroups(_potList);
            return RandomizedPotList;
        }

        // Remove this method, or move to view.
        public void ShowPots()
        {
            foreach (List<InitialTeamModel> teamPotList in RandomizedPotList)
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