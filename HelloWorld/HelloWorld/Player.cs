using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Player
    {
        public string name = "aryan";
        private int health = 56;

        public void ChangeHealth(int newHealth)
        {
            health = newHealth;
        }

        public int getHealth()
        {
            return health;
        }
    }
}
