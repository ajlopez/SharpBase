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
    }
}
