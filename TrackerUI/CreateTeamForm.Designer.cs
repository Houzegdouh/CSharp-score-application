namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamCreateLabel = new System.Windows.Forms.Label();
            this.MemberSelectionDropDown = new System.Windows.Forms.ComboBox();
            this.SelectMemberLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AddMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CellPhoneValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(66, 104);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(235, 35);
            this.TeamNameValue.TabIndex = 14;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TeamNameLabel.Location = new System.Drawing.Point(63, 66);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(151, 25);
            this.TeamNameLabel.TabIndex = 13;
            this.TeamNameLabel.Text = "Nom de l\'équipe";
            // 
            // TeamCreateLabel
            // 
            this.TeamCreateLabel.AutoSize = true;
            this.TeamCreateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamCreateLabel.ForeColor = System.Drawing.Color.Green;
            this.TeamCreateLabel.Location = new System.Drawing.Point(12, 9);
            this.TeamCreateLabel.Name = "TeamCreateLabel";
            this.TeamCreateLabel.Size = new System.Drawing.Size(265, 45);
            this.TeamCreateLabel.TabIndex = 12;
            this.TeamCreateLabel.Text = "Créer une équipe";
            // 
            // MemberSelectionDropDown
            // 
            this.MemberSelectionDropDown.FormattingEnabled = true;
            this.MemberSelectionDropDown.Location = new System.Drawing.Point(68, 185);
            this.MemberSelectionDropDown.Name = "MemberSelectionDropDown";
            this.MemberSelectionDropDown.Size = new System.Drawing.Size(290, 38);
            this.MemberSelectionDropDown.TabIndex = 17;
            // 
            // SelectMemberLabel
            // 
            this.SelectMemberLabel.AutoSize = true;
            this.SelectMemberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMemberLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SelectMemberLabel.Location = new System.Drawing.Point(63, 157);
            this.SelectMemberLabel.Name = "SelectMemberLabel";
            this.SelectMemberLabel.Size = new System.Drawing.Size(153, 25);
            this.SelectMemberLabel.TabIndex = 16;
            this.SelectMemberLabel.Text = "Membre existant";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddMemberButton.Location = new System.Drawing.Point(117, 229);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(184, 40);
            this.AddMemberButton.TabIndex = 18;
            this.AddMemberButton.Text = "Ajouter membre";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // AddMemberGroupBox
            // 
            this.AddMemberGroupBox.Controls.Add(this.CellPhoneValue);
            this.AddMemberGroupBox.Controls.Add(this.CellphoneLabel);
            this.AddMemberGroupBox.Controls.Add(this.EmailValue);
            this.AddMemberGroupBox.Controls.Add(this.EmailLabel);
            this.AddMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddMemberGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddMemberGroupBox.Location = new System.Drawing.Point(68, 275);
            this.AddMemberGroupBox.MaximumSize = new System.Drawing.Size(700, 500);
            this.AddMemberGroupBox.MinimumSize = new System.Drawing.Size(100, 30);
            this.AddMemberGroupBox.Name = "AddMemberGroupBox";
            this.AddMemberGroupBox.Size = new System.Drawing.Size(398, 221);
            this.AddMemberGroupBox.TabIndex = 19;
            this.AddMemberGroupBox.TabStop = false;
            this.AddMemberGroupBox.Text = "Ajouter Nouveau Membre";
            this.AddMemberGroupBox.Enter += new System.EventHandler(this.AddMemberGroupBox_Enter);
            // 
            // CellPhoneValue
            // 
            this.CellPhoneValue.Location = new System.Drawing.Point(109, 157);
            this.CellPhoneValue.Name = "CellPhoneValue";
            this.CellPhoneValue.Size = new System.Drawing.Size(250, 35);
            this.CellPhoneValue.TabIndex = 17;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellphoneLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.CellphoneLabel.Location = new System.Drawing.Point(18, 160);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(40, 30);
            this.CellphoneLabel.TabIndex = 16;
            this.CellphoneLabel.Text = "Tél";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(109, 116);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(250, 35);
            this.EmailValue.TabIndex = 15;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmailLabel.Location = new System.Drawing.Point(18, 119);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 30);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(109, 75);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(250, 35);
            this.LastNameValue.TabIndex = 13;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.LastNameLabel.Location = new System.Drawing.Point(18, 80);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 30);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Nom";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(109, 34);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(250, 35);
            this.FirstNameValue.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.FirstNameLabel.Location = new System.Drawing.Point(18, 39);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(85, 30);
            this.FirstNameLabel.TabIndex = 10;
            this.FirstNameLabel.Text = "Prénom";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CreateMemberButton.Location = new System.Drawing.Point(165, 513);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(184, 40);
            this.CreateMemberButton.TabIndex = 20;
            this.CreateMemberButton.Text = "Créer membre";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMemberListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 30;
            this.TeamMemberListBox.Location = new System.Drawing.Point(509, 104);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(282, 392);
            this.TeamMemberListBox.TabIndex = 21;
            // 
            // DeleteSelectedPlayerButton
            // 
            this.DeleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeleteSelectedPlayerButton.Location = new System.Drawing.Point(797, 268);
            this.DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            this.DeleteSelectedPlayerButton.Size = new System.Drawing.Size(128, 78);
            this.DeleteSelectedPlayerButton.TabIndex = 22;
            this.DeleteSelectedPlayerButton.Text = "Supprimer sélection";
            this.DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedPlayerButton.Click += new System.EventHandler(this.DeleteSelectedPlayerButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CreateTeamButton.Location = new System.Drawing.Point(386, 573);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(183, 49);
            this.CreateTeamButton.TabIndex = 23;
            this.CreateTeamButton.Text = "Créer équipe";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(952, 636);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedPlayerButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.CreateMemberButton);
            this.Controls.Add(this.AddMemberGroupBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.MemberSelectionDropDown);
            this.Controls.Add(this.SelectMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.TeamCreateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Créer une équipe";
            this.AddMemberGroupBox.ResumeLayout(false);
            this.AddMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label TeamCreateLabel;
        private System.Windows.Forms.ComboBox MemberSelectionDropDown;
        private System.Windows.Forms.Label SelectMemberLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.GroupBox AddMemberGroupBox;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox CellPhoneValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button DeleteSelectedPlayerButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}