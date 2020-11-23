using System;
using InheritanceVersion.MonsterVersion3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEnfine
{
    [TestClass]
    public class TestMonsterFactoryInheritanceVersion
    {
        [TestMethod]
        public void Test_BitingMonster()
        {
            MonsterVersion3 crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Assert.IsTrue(crocodile is BitingMonster);
        }

        [TestMethod]
        public void Test_BitingKickingMonster()
        {
            MonsterVersion3 horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse is BitingMonster);

            // This test will fail, because we cannot inherit from multiple base classes.
            Assert.IsTrue(horse is KickingMonster);
        }

    }
}
