namespace SharpBase.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ColumnTests
    {
        [TestMethod]
        public void CreateColumn()
        {
            Column column = new Column("Address");
            Assert.AreEqual("Address", column.Name);
        }

        [TestMethod]
        public void Autonumeric()
        {
            Column column = new Column("Address");
            
            column.Autonumeric();

            Assert.IsTrue(column.IsAutonumeric);

            Assert.AreEqual(1, column.GetNextId());
            Assert.AreEqual(2, column.GetNextId());
            Assert.AreEqual(3, column.GetNextId());
        }

        [TestMethod]
        public void NotAutonumeric()
        {
            Column column = new Column("Address");

            try
            {
                column.GetNextId();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
            }
        }
    }
}
