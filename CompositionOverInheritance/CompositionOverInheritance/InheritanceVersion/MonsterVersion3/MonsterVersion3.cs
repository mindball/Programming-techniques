namespace InheritanceVersion.MonsterVersion3
{
    public class MonsterVersion3
    {

        //After you finish creating all these classes, your boss sends you an email. 
        //Now, you need to have monsters that can also attack by spitting.
        //Cobras will bite and spit, camels will kick and spit, etc.
        //Instead of creating more sub-classes, you decide to try using composition.
        public MonsterVersion3(int hitPoints)
        {
            HitPoints = hitPoints;
        }

        public int HitPoints { get; set; }
        
    }
}
