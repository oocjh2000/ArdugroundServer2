using System;
using System.Text.RegularExpressions;

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
        public bool CheckPlayer()
        {
            if (Regex.IsMatch(Email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"))
                return true;
            return false;
        }
        public string Name;
        public string Email;
        public int Exp;
        public int hp;
    }
}
