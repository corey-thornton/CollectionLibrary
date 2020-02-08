using System;
using System.Collections.Generic;
using System.Text;

namespace Library.model
{
    class Game
    {
       public string title { get; private set; }
       public string gameSystem { get; private set; } 
       public string developer { get; private set; }
       public string type { get; private set; }
       public int playerAmount { get; private set; }

        public Game(string title, string gameSystem, string developer, string type, int playerAmount)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.gameSystem = gameSystem ?? throw new ArgumentNullException(nameof(gameSystem));
            this.developer = developer ?? throw new ArgumentNullException(nameof(developer));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.playerAmount = playerAmount;
        }


    }
}
