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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName= "Hassan", LastName= "Ouzegdouh" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Ness", LastName = "Kour" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Tarik", LastName = "Ouzegdouh" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Luffy", LastName = "Monkey" });
        }

        private void WireUpLists()
        {
            MemberSelectionDropDown.DataSource = null;

            MemberSelectionDropDown.DataSource = availableTeamMembers;
            MemberSelectionDropDown.DisplayMember = "FullName";

            TeamMemberListBox.DataSource = null;

            TeamMemberListBox.DataSource = selectedTeamMembers;
            TeamMemberListBox.DisplayMember = "FullName";
        }
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAdress = EmailValue.Text;
                p.CellphoneNumber = CellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                CellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Vous devez remplir tout les champs avant de valider");
            }

        }

        private bool ValidateForm()
        {
            if(FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if(LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if(EmailValue.Text.Length == 0)
            {
                return false;
            }
            if(CellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void AddMemberGroupBox_Enter(object sender, EventArgs e)
        {
        
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)MemberSelectionDropDown.SelectedItem;

            if(p != null) { 
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);
            WireUpLists();
            }
        }

        private void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMemberListBox.SelectedItem;

            if(p != null) { 
            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);
            WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
        }
    }
}
