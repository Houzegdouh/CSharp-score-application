namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.TournamentCreateLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.TeamSelectionDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.AddPrizeButton = new System.Windows.Forms.Button();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersList = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.TournamentCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentCreateLabel
            // 
            this.TournamentCreateLabel.AutoSize = true;
            this.TournamentCreateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentCreateLabel.ForeColor = System.Drawing.Color.Green;
            this.TournamentCreateLabel.Location = new System.Drawing.Point(11, 32);
            this.TournamentCreateLabel.Name = "TournamentCreateLabel";
            this.TournamentCreateLabel.Size = new System.Drawing.Size(215, 45);
            this.TournamentCreateLabel.TabIndex = 1;
            this.TournamentCreateLabel.Text = "Créer Tournoi";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(65, 127);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(235, 35);
            this.TournamentNameValue.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TournamentNameLabel.Location = new System.Drawing.Point(62, 89);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(147, 25);
            this.TournamentNameLabel.TabIndex = 10;
            this.TournamentNameLabel.Text = "Nom du tournoi";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(199, 191);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValue.TabIndex = 13;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.EntryFeeLabel.Location = new System.Drawing.Point(59, 198);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(125, 25);
            this.EntryFeeLabel.TabIndex = 12;
            this.EntryFeeLabel.Text = "Frais d\'entrée";
            // 
            // TeamSelectionDropDown
            // 
            this.TeamSelectionDropDown.FormattingEnabled = true;
            this.TeamSelectionDropDown.Location = new System.Drawing.Point(64, 392);
            this.TeamSelectionDropDown.Name = "TeamSelectionDropDown";
            this.TeamSelectionDropDown.Size = new System.Drawing.Size(290, 38);
            this.TeamSelectionDropDown.TabIndex = 15;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SelectTeamLabel.Location = new System.Drawing.Point(62, 364);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(150, 25);
            this.SelectTeamLabel.TabIndex = 14;
            this.SelectTeamLabel.Text = "Equipe Existante";
            // 
            // CreateTeamlinkLabel
            // 
            this.CreateTeamlinkLabel.AutoSize = true;
            this.CreateTeamlinkLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamlinkLabel.Location = new System.Drawing.Point(233, 364);
            this.CreateTeamlinkLabel.Name = "CreateTeamlinkLabel";
            this.CreateTeamlinkLabel.Size = new System.Drawing.Size(121, 25);
            this.CreateTeamlinkLabel.TabIndex = 16;
            this.CreateTeamlinkLabel.TabStop = true;
            this.CreateTeamlinkLabel.Text = "Créer équipe";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddTeamButton.Location = new System.Drawing.Point(116, 451);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(184, 40);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "Ajouter équipe";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // AddPrizeButton
            // 
            this.AddPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AddPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPrizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrizeButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddPrizeButton.Location = new System.Drawing.Point(115, 531);
            this.AddPrizeButton.Name = "AddPrizeButton";
            this.AddPrizeButton.Size = new System.Drawing.Size(184, 40);
            this.AddPrizeButton.TabIndex = 18;
            this.AddPrizeButton.Text = "Ajouter prix";
            this.AddPrizeButton.UseVisualStyleBackColor = true;
            this.AddPrizeButton.Click += new System.EventHandler(this.AddPrizeButton_Click);
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 30;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(405, 127);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(314, 212);
            this.TournamentTeamsListBox.TabIndex = 19;
            // 
            // TournamentPlayersList
            // 
            this.TournamentPlayersList.AutoSize = true;
            this.TournamentPlayersList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayersList.ForeColor = System.Drawing.Color.DarkGreen;
            this.TournamentPlayersList.Location = new System.Drawing.Point(400, 89);
            this.TournamentPlayersList.Name = "TournamentPlayersList";
            this.TournamentPlayersList.Size = new System.Drawing.Size(160, 25);
            this.TournamentPlayersList.TabIndex = 20;
            this.TournamentPlayersList.Text = "Equipes / Joueurs";
            // 
            // DeleteSelectedPlayerButton
            // 
            this.DeleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeleteSelectedPlayerButton.Location = new System.Drawing.Point(764, 191);
            this.DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            this.DeleteSelectedPlayerButton.Size = new System.Drawing.Size(128, 78);
            this.DeleteSelectedPlayerButton.TabIndex = 21;
            this.DeleteSelectedPlayerButton.Text = "Supprimer sélection";
            this.DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedPlayerButton.Click += new System.EventHandler(this.DeleteSelectedPlayerButton_Click);
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(764, 490);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(128, 81);
            this.DeleteSelectedPrizeButton.TabIndex = 24;
            this.DeleteSelectedPrizeButton.Text = "Supprimer prix";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.PrizesLabel.Location = new System.Drawing.Point(400, 392);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(44, 25);
            this.PrizesLabel.TabIndex = 23;
            this.PrizesLabel.Text = "Prix";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(405, 430);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(314, 212);
            this.PrizesListBox.TabIndex = 22;
            // 
            // TournamentCreateButton
            // 
            this.TournamentCreateButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.TournamentCreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TournamentCreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TournamentCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentCreateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentCreateButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.TournamentCreateButton.Location = new System.Drawing.Point(405, 684);
            this.TournamentCreateButton.Name = "TournamentCreateButton";
            this.TournamentCreateButton.Size = new System.Drawing.Size(184, 40);
            this.TournamentCreateButton.TabIndex = 25;
            this.TournamentCreateButton.Text = "Créer Tournoi";
            this.TournamentCreateButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(909, 750);
            this.Controls.Add(this.TournamentCreateButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayerButton);
            this.Controls.Add(this.TournamentPlayersList);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(this.AddPrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamlinkLabel);
            this.Controls.Add(this.TeamSelectionDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TournamentCreateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Créer nouveau tournoi";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentCreateLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox TeamSelectionDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateTeamlinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button AddPrizeButton;
        private System.Windows.Forms.ListBox TournamentTeamsListBox;
        private System.Windows.Forms.Label TournamentPlayersList;
        private System.Windows.Forms.Button DeleteSelectedPlayerButton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button TournamentCreateButton;
    }
}