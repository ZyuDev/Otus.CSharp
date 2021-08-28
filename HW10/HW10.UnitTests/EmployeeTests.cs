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
    public class EmployeeTests
    {
        private Employee _source;

        [SetUp]
        public void SetUp()
        {
            var itDepartment = new Department()
            {
                Code = "00002",
                Title = "It department"
            };

            _source = new Employee()
            {
                Code = "00001",
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                LastName = "Ivanov",
                DateOfBirth = new DateTime(1980, 1, 1),
                Position = "Developer",
                Department = itDepartment
            };
        }

        [Test]
        public void CloneCatalog_ReturnNewCopy()
        {
            var clone = _source.CloneCatalog();

            Console.WriteLine($"Source: {_source.Uid} - {_source} - {_source.Department}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone} - {clone.Department}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.Position, clone.Position);

        }

        [Test]
        public void Clone_ReturnNewCopy()
        {
            var clone = (Employee)_source.Clone();

            Console.WriteLine($"Source: {_source.Uid} - {_source} - {_source.Department}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone} - {clone.Department}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.Position, clone.Position);

        }
    }
}
