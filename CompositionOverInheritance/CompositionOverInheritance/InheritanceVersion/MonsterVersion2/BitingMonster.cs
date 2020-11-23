namespace InheritanceVersion.MonsterVersion2
{
    public class BitingMonster : MonsterVersion3
    {
        public int BiteDamage { get; set; }

        public BitingMonster(int hitPoints, int biteDamage)
            : base(hitPoints)
        {
            BiteDamage = biteDamage;
        }
    }
}
