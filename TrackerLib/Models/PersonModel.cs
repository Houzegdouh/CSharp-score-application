using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Id unique du prix
        /// </summary>
        public int Id { get; set; }
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
        public string FullName
        {
            get {
                return $"{ FirstName } { LastName }";
                }
        }
    }
}
