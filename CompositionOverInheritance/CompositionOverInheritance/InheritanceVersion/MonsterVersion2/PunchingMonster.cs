namespace InheritanceVersion.MonsterVersion2
{
    public class PunchingMonster : MonsterVersion3
    {
        public int PunchDamage { get; set; }

        public PunchingMonster(int hitPoints, int punchDamage)
            : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
    }
}
