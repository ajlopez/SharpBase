namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Column
    {
        private string name;

        public Column(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }
    }
}
