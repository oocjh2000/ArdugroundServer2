using System;
using System.Text.RegularExpressions;

namespace AdrugroundServer2._0.Models
{
    public class Player
    {
        public Player(int hp,int Exp,string Name)
        {
            this.Exp = Exp;
            this.hp = hp;
            this.Name = Name;
        }
        public bool CheckPlayer()
        {
            if (Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return true;
            return false;
        }
        public string Name;
        public string Email;
        public int Exp;
        public int hp;
    }
}
