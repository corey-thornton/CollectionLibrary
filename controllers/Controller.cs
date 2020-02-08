using Library.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.controllers
{
    class Controller
    {
        

        private CollectionManager manager;

        public Controller()
        {
            var game = new Game("The Legened of Zelda Breath of the Wild", "Nintendo Switch", "Nintendo", "Open World Adventure", 1);


            this.manager = new CollectionManager();
            this.manager.addToGameCollection(game);
        }

        public ICollection<Game> getGames()
        {
            return this.manager.getGames();
        }

        public void addNewGame(Game game)
        {
            this.manager.addToGameCollection(game);

            //Game gameToAdd = new Game;
           // this.games.addGame(gameToAdd);

        }
    }
}
