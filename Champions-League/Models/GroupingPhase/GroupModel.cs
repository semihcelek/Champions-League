using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class GroupModel
    {
        public string GroupName { get; set; }

        public List<TeamModel> CompetingTeams
        {
            get => _competingTeams;
            set => _competingTeams = value;
        }

        private List<TeamModel> _competingTeams;

        public GroupModel()
        {
            _competingTeams = new List<TeamModel>(4);
        }
    }
}