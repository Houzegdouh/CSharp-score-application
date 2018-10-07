﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;
using TrackerLib.DataAccess.TextHelpers;

namespace TrackerLib.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeFile.csv";
        private const string PeopleFile = "PersonFile.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().loadFile().convertToPersonModels();
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)

            people.Add(model);
            // Convert the Prizes to a list<string>
            // save the list<string> to a file
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

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
            List<PrizeModel> prizes = PrizeFile.FullFilePath().loadFile().convertPrizeToModels();
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)

            prizes.Add(model);
            // Convert the Prizes to a list<string>
            // save the list<string> to a file
            prizes.SaveToPrizeFile(PrizeFile);
            return model;
        }
    }
}
