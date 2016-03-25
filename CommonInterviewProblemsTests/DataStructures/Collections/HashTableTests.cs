using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Collections;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures.Collections
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void Resizes_When_Load_Over_75()
        {
            RavenHashTable<string> hashTable = new RavenHashTable<string>();
            hashTable.Add("1")
                .Add("2")
                .Add("3")
                .Add("4")
                .Add("5")
                .Add("6")
                .Add("7")
                .Add("8")
                .Add("9");
            Assert.AreEqual(9, hashTable.Size);
            Assert.IsTrue(hashTable.Capacity > 10);
        }

        [TestMethod]
        public void Can_Add_Identical_Value_After_Resize()
        {
            RavenHashTable<string> hashTable = new RavenHashTable<string>();
            hashTable.Add("AAA")
                .Add("BBB")
                .Add("CCC")
                .Add("DDD")
                .Add("EEE")
                .Add("FFF")
                .Add("GGG")
                .Add("HHH")
                .Add("999");
            hashTable.Add("ZZZ");
            Assert.AreEqual(10, hashTable.Size);
            Assert.IsTrue(hashTable.Capacity > 10);
        }

        [TestMethod]
        public void Can_FindValue()
        {
            RavenHashTable<string> hashTable = new RavenHashTable<string>();
            hashTable.Add("AAA")
                .Add("BBB")
                .Add("CCC")
                .Add("DDD")
                .Add("EEE")
                .Add("FFF")
                .Add("GGG")
                .Add("HHH")
                .Add("999");
            hashTable.Add("ZZZ");
            Assert.AreEqual(true, hashTable.Exists("GGG"));
        }
    }
}
