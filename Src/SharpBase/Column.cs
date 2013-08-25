namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Column
    {
        private string name;
        private bool autonumeric;
        private int lastid = 0;

        public Column(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public bool IsAutonumeric { get { return this.autonumeric; } }

        public void Autonumeric()
        {
            this.autonumeric = true;
        }

        public int GetNextId()
        {
            if (!this.autonumeric)
                throw new InvalidOperationException();

            this.lastid++;
            return this.lastid;
        }
    }
}
