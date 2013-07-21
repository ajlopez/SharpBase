using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpBase.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        private Database db;

        [TestInitialize]
        public void Setup()
        {
            Engine engine = new Engine();
            this.db = engine.CreateDatabase("Warehouse");
        }

        [TestMethod]
        public void CreateTable()
        {
            Table table = this.db.CreateTable("Products");

            Assert.IsNotNull(table);
            Assert.AreEqual("Products", table.Name);
        }

        [TestMethod]
        public void GetTable()
        {
            this.db.CreateTable("Products");

            Table table = this.db.GetTable("Products");

            Assert.IsNotNull(table);
            Assert.AreEqual("Products", table.Name);
        }

        [TestMethod]
        public void GetNullIfUnknownTable()
        {
            Table table = this.db.GetTable("Products");

            Assert.IsNull(table);
        }
    }
}
