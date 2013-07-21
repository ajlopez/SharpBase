using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpBase.Tests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void CreateDatabase()
        {
            Engine engine = new Engine();
            Database db = engine.CreateDatabase("Warehouse");

            Assert.IsNotNull(db);
            Assert.AreEqual("Warehouse", db.Name);
        }

        [TestMethod]
        public void GetDatabase()
        {
            Engine engine = new Engine();
            engine.CreateDatabase("Warehouse");

            Database db = engine.GetDatabase("Warehouse");

            Assert.IsNotNull(db);
            Assert.AreEqual("Warehouse", db.Name);
        }

        [TestMethod]
        public void GetNullIfUnknownDatabase()
        {
            Engine engine = new Engine();

            Database db = engine.GetDatabase("Warehouse");

            Assert.IsNull(db);
        }
    }
}
