using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Une équipe du matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Le score de la game en question
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// La game d'où provient cette équipe
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
