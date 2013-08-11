namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Row
    {
        private object[] values;

        public Row(object[] values)
        {
            this.values = values;
        }

        public object GetCell(int offset)
        {
            return this.values[offset];
        }
    }
}
