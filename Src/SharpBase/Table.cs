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
        private IList<string> columnnames = new List<string>();
        private IList<Row> rows = new List<Row>();

        public Table(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public Column AddColumn(string name)
        {
            Column column = new Column(name);
            this.columnnames.Add(name);
            this.columns.Add(column);
            return column;
        }

        public IEnumerable<string> GetColumnNames()
        {
            return this.columnnames;
        }

        public IEnumerable<Column> GetColumns()
        {
            return this.columns;
        }

        public Row Insert(params object[] values)
        {
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
