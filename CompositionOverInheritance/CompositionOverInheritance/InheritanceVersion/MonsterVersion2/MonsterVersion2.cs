using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVersion.MonsterVersion2
{

    //The next day, your boss tells you they need new types of monsters in the game – ones that 
    //can do different combinations of biting, kicking, and punching.Because this is getting complex, 
    //you also build a Factory class, to create the different types of monster objects.
    //create monster version 3
    public class MonsterVersion3
    {
        public MonsterVersion3(int hitPoints)
        {
            HitPoints = hitPoints;
        }

        public int HitPoints { get; set; }
        
    }
}
