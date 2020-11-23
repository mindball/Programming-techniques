using Composition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEnfine
{
    [TestClass]
    public class TestMonsterFactoryCompositionVersion
    {
        [TestMethod]       
        public void Test_BitingMonster()
        {
            Monster crocodile = Composition.MonsterFactory.CreateMonster(Composition.MonsterFactory.MonsterType.Crocodile);

            Assert.IsTrue(crocodile.CanBite);
            Assert.IsFalse(crocodile.CanKick);
            Assert.IsFalse(crocodile.CanPunch);
        }

        [TestMethod]
        public void Test_BitingKickingMonster()
        {
            Monster horse = Composition.MonsterFactory.CreateMonster(Composition.MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse.CanBite);
            Assert.IsTrue(horse.CanKick);
            Assert.IsFalse(horse.CanPunch);
        }
    }
}
