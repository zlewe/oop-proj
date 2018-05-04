using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonKnight
{

    class Monster
    {
        int health = 100;
        int damage = 8;
        int atkType = 0;
        int speed = 5;

        public Monster(int h, int d, int aT, int s)
        {
            health = h;
            damage = d;
            atkType = aT;
            speed = s;
        }

        public void HealthChange(int dmg)
        {
            health += dmg;
        }
    }
}
