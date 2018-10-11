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
        public List<TeamModel> selectedTeams = new List<TeamModel>();
        public List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        public void WireUpLists()
        {
            TeamSelectionDropDown.DataSource = null;
            TeamSelectionDropDown.DataSource = availableTeams;
            TeamSelectionDropDown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = selectedTeams; 
            TournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            TournamentTeamsListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {

            /*PersonModel p = (PersonModel)MemberSelectionDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
            }*/

            TeamModel t = (TeamModel)TeamSelectionDropDown.SelectedItem;

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();

            }
        }
    }
}
