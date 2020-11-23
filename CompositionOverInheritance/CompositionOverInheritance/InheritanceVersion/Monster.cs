using System;

namespace InheritanceVersion
{
    //At the beginning case: create a Monster class, with two properties 
    public class Monster
    {        
        public Monster(int hitPoints, int attackDamage)
        {
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
        }

        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }
    }

    //After that:  then  boss tells you the game needs to have different types of monsters.
    //One type will attack by biting, the second by kicking, and the third by punching.
    //Create monster version 2
   
}
