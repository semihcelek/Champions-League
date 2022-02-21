namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class InitialTeamModel
    {
        private string _teamName;
        
        public string TeamName
        {
            get => _teamName;
            set => _teamName = value;
        }

        private string _teamCountryCode;

        public string TeamCountryCode
        {
            get => _teamCountryCode;
            set => _teamCountryCode = value;
        }

        private int _teamSeedPoint;

        public int TeamSeedPoint
        {
            get => _teamSeedPoint;
            set => _teamSeedPoint = value;
        }
        
        public InitialTeamModel(string teamName, string teamCountryCode, int teamSeedPoint)
        {
            _teamName = teamName;
            _teamCountryCode = teamCountryCode;
            _teamSeedPoint = teamSeedPoint;
        }
    }
}