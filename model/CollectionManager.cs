using System;
using System.Collections.Generic;

namespace Library.model
{
    class CollectionManager
    {
        private GameCollection gameCollection;

        public CollectionManager(GameCollection gameCollection)
        {
            this.gameCollection = gameCollection ?? throw new ArgumentNullException(nameof(gameCollection));
        }

        public CollectionManager()
        {
            this.gameCollection = new GameCollection();
        }


        public void addToGameCollection(Game game)
        {
            this.gameCollection.addGame(game);

        }

        public ICollection<Game> getGames()
        {
            return this.gameCollection.getGameCollection();
        }
    }
}
