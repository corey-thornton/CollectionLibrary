using System.Collections.Generic;

namespace Library.model
{
    class GameCollection
    {
        private ICollection<Game> games;

        public GameCollection()
        {
            this.games = new List<Game>();
        }

        public ICollection<Game> getGameCollection()
        {
            return this.games;
        }

        public void addGame(Game game)
        {
            this.games.Add(game);
        }
    }
}
