using System;
using System.Collections.Generic;
using SemihCelek.Champions_League.Models.DataAccess;

namespace SemihCelek.Champions_League.Models.GroupingPhase.PotGroups
{
    public class TeamDataExtractor
    {
        private IDataAccess _teamDataAccess;

        private List<InitialTeamModel> _teamList;

        public TeamDataExtractor(IDataAccess teamDataAccess)
        {
            _teamDataAccess = teamDataAccess;
            _teamList = new List<InitialTeamModel>();
        }

        public List<InitialTeamModel> ExtractTeams()
        {
            List<string> teamData = _teamDataAccess.ReadLines();
            foreach (var line in teamData)
            {
                string[] spaceSeparatedTeamData = line.Split(" ");

                InitialTeamModel parsedTeam = new InitialTeamModel(spaceSeparatedTeamData[0], spaceSeparatedTeamData[1],
                    Int32.Parse(spaceSeparatedTeamData[2]));
                _teamList.Add(parsedTeam);
            }

            return _teamList;
        }
    }
}