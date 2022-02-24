namespace SemihCelek.Champions_League.Controllers
{
    public class DrawController
    {
        private ITeamDraw _teamDraw;

        public DrawController(ITeamDraw teamDraw)
        {
            _teamDraw = teamDraw;
        }

        public void DrawTeamToTheirGroups()
        {
            _teamDraw.DistributeTeamsToGroups();
        }
    }
}