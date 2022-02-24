namespace SemihCelek.Champions_League.Models.GroupingPhase
{
    public class TeamModel
    {
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string CountryCode
        {
            get => _countryCode;
            set => _countryCode = value;
        }

        // this could be a group type.
        public char CompetingGroup
        {
            get => _competingGroup;
            set => _competingGroup = value;
        }

        private string _name;
        private string _countryCode;
        private char _competingGroup;

        public TeamModel(string name, string countryCode)
        {
            Name = name;
            CountryCode = countryCode;
        }
    }
}