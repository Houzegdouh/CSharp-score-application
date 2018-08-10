using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    class TournamentModel
    {
        /// <summary>
        /// Nom du tournoi
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Frais d'entrée si existant
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Liste des équipes participantes
        /// </summary>
        public List<TeamModel> EntredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prix du tournoi
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Rounds du tournoi (globalement)
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
