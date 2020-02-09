using Library.IO;
using Library.model;
using System.Collections.Generic;

namespace Library.controllers
{
    class Controller
    {


        private CollectionManager manager;
        private FileWriter fileWriter;
        private FileLoader fileLoader;


        public Controller()
        {
            // var game = new Game("The Legened of Zelda Breath of the Wild", "Nintendo Switch", "Nintendo", "Open World Adventure", 1);


            this.manager = new CollectionManager();
            this.fileWriter = new FileWriter();
            this.fileLoader = new FileLoader();
            this.loadGames();

            //this.manager.addToGameCollection(game);
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

        public void saveToFile()
        {
            this.fileWriter.writeGamesToXmlFile(this.manager.getGames());
        }

        private void loadGames()
        {
            var games = this.fileLoader.getGamesFromFile();
            foreach (Game game in games)
            {
                addNewGame(game);
            }
        }
    }
}
