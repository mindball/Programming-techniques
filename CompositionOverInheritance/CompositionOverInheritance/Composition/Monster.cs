using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class Monster
    {       

        public Monster(int hitPoints)
        {
            this.HitPoints = hitPoints;
            this.AttackTypes = new Dictionary<AttackType, int>();
        }

        public int HitPoints { get; set; }

        public Dictionary<AttackType, int> AttackTypes { get; set; }

        // These replace the functionality of checking an object's "type",
        // to see if it "is" a certain datatype (KickingMonster, BitingMonster, etc.)
        public bool CanBite => this.AttackTypes.ContainsKey(AttackType.Biting);

        public bool CanKick => this.AttackTypes.ContainsKey(AttackType.Kicking);

        public bool CanPunch => this.AttackTypes.ContainsKey(AttackType.Punching);
        
        //add later
        public bool CanSpitting => this.AttackTypes.ContainsKey(AttackType.Spitting);

        public int BiteDamage
        {
            get
            {
                if (this.CanBite)
                {
                    return AttackTypes[AttackType.Biting];
                }

                throw new NotSupportedException("This monster cannot bite.");
            }
        }

        public int KickDamage
        {
            get
            {
                if (this.CanKick)
                {
                    return AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick.");
            }
        }

        public int PunchDamage
        {
            get
            {
                if (this.CanPunch)
                {
                    return AttackTypes[AttackType.Punching];
                }

                throw new NotSupportedException("This monster cannot punch.");
            }
        }

        //add later
        public int SpitDamage
        {
            get
            {
                if (this.CanSpitting)
                {
                    return AttackTypes[AttackType.Spitting];
                }

                throw new NotSupportedException("This monster cannot spitting.");
            }
        }

        public void AddAttackType(AttackType attackType, int amountOfDamage)
        {
            this.AttackTypes[attackType] = amountOfDamage;
        }

    }
}
