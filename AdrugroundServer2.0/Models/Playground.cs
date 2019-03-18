using System;
namespace AdrugroundServer2._0.Models
{
    public class Playground
    {
        public Playground(string PlayGroundName, int MaxPlayer)
        {
            this.playGroundName = PlayGroundName;
            this.maxPlayers = MaxPlayer;
        }

        public string playGroundName;
        public int playerCount;
        public Player[] players;
        private int maxPlayers;


    }
}
