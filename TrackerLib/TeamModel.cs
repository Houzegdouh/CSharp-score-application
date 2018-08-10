﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class TeamModel
    {
        /// <summary>
        /// Membre de l'équipe participante, la liste ne contiendra qu'une seule personne si la participation est individuelle
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        public string TeamName { get; set; }

    }
}
