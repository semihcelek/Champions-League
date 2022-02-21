using System.Collections.Generic;
using System.IO;
using SemihCelek.Champions_League.Utils;

namespace SemihCelek.Champions_League.Models.DataAccess
{
    public class GroupDataAccess: IDataAccess
    {
        private IDataPathFinder _dataPathFinder;

        private List<string> _teamData;

        public GroupDataAccess(IDataPathFinder dataPathFinder)
        {
            _dataPathFinder = dataPathFinder;
            _teamData = new List<string>();
        }
        
        public List<string> ReadLines()
        {
            string[] data = File.ReadAllLines(_dataPathFinder.GetDataPath("team-data.txt"));
            
            foreach (string line in data)
            {
                _teamData.Add(line);
            }

            return _teamData;
        }
    }
}