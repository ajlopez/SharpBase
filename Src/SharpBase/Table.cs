namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Table
    {
        private string name;
        private IList<Column> columns = new List<Column>();
        private IList<Row> rows = new List<Row>();

        public Table(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public Column AddColumn(string name)
        {
            Column column = new Column(name);
            this.columns.Add(column);
            return column;
        }

        public IEnumerable<string> GetColumnNames()
        {
            return this.columns.Select(c => c.Name);
        }

        public IEnumerable<Column> GetColumns()
        {
            return this.columns;
        }

        public Row Insert(params object[] values)
        {
            for (int k = 0; k < values.Length; k++)
                if (this.columns[k].IsAutonumeric)
                    values[k] = this.columns[k].GetNextId();

            var row = new Row(values);
            this.rows.Add(row);
            return row;
        }

        public IEnumerable<Row> GetRows()
        {
            return this.rows;
        }
    }
}
