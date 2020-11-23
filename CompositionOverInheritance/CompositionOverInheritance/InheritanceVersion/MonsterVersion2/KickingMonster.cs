using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVersion.MonsterVersion2
{
    public class KickingMonster : MonsterVersion3
    {       
            public int KickDamage { get; set; }

            public KickingMonster(int hitPoints, int kickDamage)
                : base(hitPoints)
            {
                KickDamage = kickDamage;
            }        
    }
}
