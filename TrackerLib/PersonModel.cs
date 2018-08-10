using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class PersonModel
    {
        /// <summary>
        /// Prénom du participant
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nom du participant
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email du participant
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Numéro de téléphone du participant
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
