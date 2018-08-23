using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                // TODO - à faire créer connection sql
                SqlConnector Sql = new SqlConnector();
                Connections.Add(Sql);

            }

            if (textFiles)
            {
                // TODO - à faire créer connection text
                TextConnection Text = new TextConnection();
                Connections.Add(Text);
            }
        }
    }
}
