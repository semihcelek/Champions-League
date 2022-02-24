using System;
using SemihCelek.Champions_League.Controllers;

namespace SemihCelek.Champions_League.Views.DrawViews
{
    public class DrawSelectionView
    {
        private DrawController _titleHolderTeamsDrawController;
        private DrawController _remainingTeamsDrawController;

        public DrawSelectionView(DrawController titleHolderTeamsDrawController, DrawController remainingTeamsDrawController)
        {
            _titleHolderTeamsDrawController = titleHolderTeamsDrawController;
            _remainingTeamsDrawController = remainingTeamsDrawController;
        }

        public void CreateView()
        {
            Console.WriteLine("Draw options are listed as:\n");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine(
                "Press (T) for drawing title holders groups.\n" +
                "Press (R) for drawing remaining team groups.\n"
            );

           ConsoleKeyInfo keyArgument =  Console.ReadKey();

           switch (keyArgument.Key)
           {
               case ConsoleKey.T:
                   // Change view to draw view.
                   _titleHolderTeamsDrawController.DrawTeamToTheirGroups();
                   break;
               case ConsoleKey.R:
                   _remainingTeamsDrawController.DrawTeamToTheirGroups();
                   break;
           }
        }
    }
}