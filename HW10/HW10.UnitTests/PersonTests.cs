using HW10.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.UnitTests
{
    [TestFixture]
    public class PersonTests
    {
        private Person _source;

        [SetUp]
        public void SetUp()
        {
            _source = new Person()
            {
                Code = "00001",
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                LastName = "Ivanov",
                DateOfBirth = new DateTime(1980,1,1)
            };
        }

        [Test]
        public void CloneCatalog_ReturnNewCopy()
        {
            var clone = _source.CloneCatalog();

            Console.WriteLine($"Source: {_source.Uid} - {_source}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.DateOfBirth, clone.DateOfBirth);

        }

        [Test]
        public void Clone_ReturnNewCopy()
        {
            var clone = (Person)_source.Clone();

            Console.WriteLine($"Source: {_source.Uid} - {_source}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.DateOfBirth, clone.DateOfBirth);

        }
    }
}
