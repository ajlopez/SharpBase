namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Table
    {
        private string name;
        private IList<string> columnnames = new List<string>();

        public Table(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public void AddColumn(string name)
        {
            this.columnnames.Add(name);
        }

        public IEnumerable<string> GetColumnNames()
        {
            return this.columnnames;
        }
    }
}
