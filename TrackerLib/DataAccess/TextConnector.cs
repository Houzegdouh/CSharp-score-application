using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    class TextConnector : IDataConnection
    {
        // TODO - Cabler la création du prix au fichier text
        /// <summary>
        /// Enregistre un prix dans la base de données
        /// </summary>
        /// <param name="model"> information sur le prix</param>
        /// <returns>information sur le prix, Id inclus</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the textfile
            // Convert the file to a List<PrizeModel>
            // Find the ID
            // Add the new record with the new ID (max + 1)
            // Convert the Prizes to a list<string>
            // save the list<string> to a file
            model.Id = 1;
            return model;
        }
    }
}
