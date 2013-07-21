namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Table
    {
        private string name;

        public Table(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }
    }
}
