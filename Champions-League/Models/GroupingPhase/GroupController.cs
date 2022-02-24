using System;
using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class GroupController
    {
        public List<GroupModel> CompetingGroups
        {
            get => _competingGroups;
            set => _competingGroups = value;
        }

        private List<GroupModel> _competingGroups;

        public GroupController()
        {
            CompetingGroups = new List<GroupModel>(8);
            SetGroups();
        }

        private void SetGroups()
        {
            for (int i = 0; i < 8; i++)
            {
                _competingGroups.Add(new GroupModel());
            }
        }
    }
}