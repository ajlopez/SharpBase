namespace SharpBase.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void AddColumnAndGetColumnNames()
        {
            Engine engine = new Engine();
            Database db = engine.CreateDatabase("Warehouse");
            Table table = db.CreateTable("Products");

            table.AddColumn("Name");

            var result = table.GetColumnNames();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Name", result.First());
        }

        [TestMethod]
        public void AddColumnsAndGetColumnNames()
        {
            Engine engine = new Engine();
            Database db = engine.CreateDatabase("Warehouse");
            Table table = db.CreateTable("Products");

            table.AddColumn("Name");
            table.AddColumn("Description");
            table.AddColumn("Price");

            var result = table.GetColumnNames().ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Name", result[0]);
            Assert.AreEqual("Description", result[1]);
            Assert.AreEqual("Price", result[2]);
        }
    }
}
