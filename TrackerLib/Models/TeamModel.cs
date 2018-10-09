using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Identifiant de l'équipe
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Membre de l'équipe participante, la liste ne contiendra qu'une seule personne si la participation est individuelle
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
