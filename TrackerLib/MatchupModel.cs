using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class MatchupModel
    {
        /// <summary>
        /// Les équipes qui s'affrontent
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Le gagnant du matchUp
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Numéro du round lors du matchUp
        /// </summary>
        public int MatchupRound { get; set; }
    }
}