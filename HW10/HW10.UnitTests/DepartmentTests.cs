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
    public class DepartmentTests
    {
        private Department _source;

        [SetUp]
        public void SetUp()
        {

            var headOffice = new Department
            {
                Code = "00001",
                Title = "Head office"
            };

            _source = new Department()
            {
                HeadDepartment = headOffice,
                Code = "00002",
                Title = "It department",
                Memo = "Responsible for all it infrastructure"
            };
          
        }

        [Test]
        public void CloneCatalog_ReturnNewCopy()
        {
            var clone = _source.CloneCatalog();

            Console.WriteLine($"Source: {_source.Uid} - {_source} - {_source.HeadDepartment}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone} - {clone.HeadDepartment}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.Memo, clone.Memo);

        }

        [Test]
        public void Clone_ReturnNewCopy()
        {
            var clone = (Department)_source.Clone();

            Console.WriteLine($"Source: {_source.Uid} - {_source} - {_source.HeadDepartment}");
            Console.WriteLine($"Clone: {clone.Uid} - {clone} - {clone.HeadDepartment}");

            Assert.AreNotEqual(_source.Uid, clone.Uid);

            Assert.AreEqual(_source.Code, clone.Code);
            Assert.AreEqual(_source.Title, clone.Title);
            Assert.AreEqual(_source.Memo, clone.Memo);

        }
    }
}
