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
        public CreateTeamForm()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePerson(p);

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
    }
}
