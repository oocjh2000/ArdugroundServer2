using System;
using System.Collections.Generic;

namespace AdrugroundServer2._0.Models
{
    public class Playground
    {
        public Playground(int id, string PlayGroundName, int MaxPlayer,Player p)
        {
            this.playGroundName = PlayGroundName;
            this.maxPlayers = MaxPlayer;
            this.id = id;
            this.players = new List<Player>();
            this.players.Add(p);
        }
        public void AddPlayer(Player p) => this.players.Add(p);
        public void ExitPlayer(Player p) => players.Remove(p);
        int id;
        public string playGroundName;
        public int playerCount = 0;
        private List<Player> players;
        public int maxPlayers;


    }
}
