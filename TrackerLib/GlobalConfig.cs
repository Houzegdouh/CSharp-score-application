using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                // à faire créer connection sql
            }

            if (textFiles)
            {
                // à faire créer connection text
            }
        }
    }
}
