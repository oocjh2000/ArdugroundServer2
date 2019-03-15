using System;
namespace AdrugroundServer2._0.Models
{
    public class Player
    {
        public Player(Player p)
        {
            this.Exp = p.Exp;
            this.hp = p.hp;
            this.Name = p.Name;
        }
        public string Name;
        public int Exp;
        public int hp;
    }
}
