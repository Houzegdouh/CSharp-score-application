using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLib;
using TrackerLib.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        public List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();

        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
