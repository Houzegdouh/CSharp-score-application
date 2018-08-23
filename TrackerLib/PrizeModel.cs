using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class PrizeModel
    {
        /// <summary>
        /// Id unique du prix
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Classement
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Titre
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Montant de la récompense
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Pourcentage de la somme initiale
        /// </summary>
        public double PrizePourcentage { get; set; }
    }
}