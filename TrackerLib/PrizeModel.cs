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
        public double PrizePercentage { get; set; }
        public PrizeModel()
        {

        }
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePourcentage)
        {
            this.PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            this.PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePourcentage, out prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;


        }
    }
}