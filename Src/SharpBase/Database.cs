namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Database
    {
        private IDictionary<string, Table> tables = new Dictionary<string, Table>();
        private string name;

        public Database(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public Table CreateTable(string name)
        {
            var table = new Table(name);
            this.tables[name] = table;
            return table;
        }

        public Table GetTable(string name)
        {
            if (!this.tables.ContainsKey(name))
                return null;

            return this.tables[name];
        }
    }
}
