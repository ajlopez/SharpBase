namespace SharpBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        private IDictionary<string, Database> databases = new Dictionary<string, Database>();

        public Database CreateDatabase(string name)
        {
            var db = new Database(name);
            this.databases[name] = db;
            return db;
        }

        public Database GetDatabase(string name)
        {
            if (!this.databases.ContainsKey(name))
                return null;

            return this.databases[name];
        }
    }
}
