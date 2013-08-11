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

        [TestMethod]
        public void InsertRow()
        {
            Engine engine = new Engine();
            Database db = engine.CreateDatabase("MyCompany");
            Table table = db.CreateTable("People");

            table.AddColumn("Name");
            table.AddColumn("Age");

            var row = table.Insert("Adam", 800);

            Assert.IsNotNull(row);
            Assert.AreEqual("Adam", row.GetCell(0));
            Assert.AreEqual(800, row.GetCell(1));
        }

        [TestMethod]
        public void InsertRowAndGetRows()
        {
            Engine engine = new Engine();
            Database db = engine.CreateDatabase("MyCompany");
            Table table = db.CreateTable("People");

            table.AddColumn("Name");
            table.AddColumn("Age");

            table.Insert("Adam", 800);

            var rows = table.GetRows();

            Assert.IsNotNull(rows);
            Assert.AreEqual(1, rows.Count());
            Assert.AreEqual("Adam", rows.First().GetCell(0));
            Assert.AreEqual(800, rows.First().GetCell(1));
        }
    }
}
