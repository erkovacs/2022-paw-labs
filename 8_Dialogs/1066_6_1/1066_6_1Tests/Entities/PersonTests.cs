using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1066_6_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066_6_1.Entities.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest()
        {
            var person = new Person();
            Assert.IsNotNull(person);
        }

        [TestMethod()]
        public void PersonTest1()
        {
            var person = new Person("Kovacs", "Erik", "1234", DateTime.Now, Gender.Male);
            Assert.IsNotNull(person);
        }

        [TestMethod()]
        public void PersonTest2()
        {
            var person = new Person();
            try
            {
                person.FirstName = null;
            }
            catch (Exception)
            { 
                Assert.IsTrue(true);
            }
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.Fail();
        }
    }
}