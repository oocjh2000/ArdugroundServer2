using System;
using System.Text.RegularExpressions;

namespace AdrugroundServer2._0.Models
{
    public class Player
    {
        public Player(int hp, string Name)
        {
            //this.Exp = Exp;
            this.hp = hp;
            this.Name = Name;
        }
        //fifebase 사용전까지 지우지말고
        public bool CheckPlayer()
        {
            if (Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return true;
            return false;
        }
        public string Name;
        public string Email;
       // public int Exp;
        public int hp;
    }
}
