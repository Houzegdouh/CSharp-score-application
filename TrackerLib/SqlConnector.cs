using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    class SqlConnector : IDataConnection
    {
        // TODO - Faire réellement enregistrer le prix dans la base de données
        /// <summary>
        /// Enregistre un prix dans la base de données
        /// </summary>
        /// <param name="model"> information sur le prix</param>
        /// <returns>information sur le prix, Id inclus</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
