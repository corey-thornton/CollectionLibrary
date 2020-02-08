using System;
using System.Collections.Generic;
using System.Text;

namespace Library.model
{
    public class Game
    {
       public string title { get;  set; }
       public string gameSystem { get;  set; } 
       public string developer { get;  set; }
       public string type { get;  set; }
       public int playerAmount { get;  set; }

        public Game(string title, string gameSystem, string developer, string type, int playerAmount)
        {
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.gameSystem = gameSystem ?? throw new ArgumentNullException(nameof(gameSystem));
            this.developer = developer ?? throw new ArgumentNullException(nameof(developer));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.playerAmount = playerAmount;
        }

        public Game()
        {

        }
    }
}
