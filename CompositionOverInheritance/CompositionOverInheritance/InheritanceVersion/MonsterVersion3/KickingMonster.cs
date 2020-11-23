namespace InheritanceVersion.MonsterVersion3
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
