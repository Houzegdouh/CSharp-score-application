namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBoxs = new System.Windows.Forms.CheckBox();
            this.MatchuoListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Green;
            this.HeaderLabel.Location = new System.Drawing.Point(16, 36);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(137, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournoi:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.Green;
            this.TournamentName.Location = new System.Drawing.Point(151, 36);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(92, 45);
            this.TournamentName.TabIndex = 2;
            this.TournamentName.Text = "none";
            this.TournamentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.RoundLabel.Location = new System.Drawing.Point(17, 101);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(95, 37);
            this.RoundLabel.TabIndex = 3;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(118, 101);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(290, 38);
            this.RoundDropDown.TabIndex = 4;
            // 
            // UnplayedOnlyCheckBoxs
            // 
            this.UnplayedOnlyCheckBoxs.AutoSize = true;
            this.UnplayedOnlyCheckBoxs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckBoxs.ForeColor = System.Drawing.Color.DarkGreen;
            this.UnplayedOnlyCheckBoxs.Location = new System.Drawing.Point(118, 145);
            this.UnplayedOnlyCheckBoxs.Name = "UnplayedOnlyCheckBoxs";
            this.UnplayedOnlyCheckBoxs.Size = new System.Drawing.Size(224, 29);
            this.UnplayedOnlyCheckBoxs.TabIndex = 5;
            this.UnplayedOnlyCheckBoxs.Text = "Non joués uniquement";
            this.UnplayedOnlyCheckBoxs.UseVisualStyleBackColor = true;
            // 
            // MatchuoListBox
            // 
            this.MatchuoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchuoListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MatchuoListBox.FormattingEnabled = true;
            this.MatchuoListBox.ItemHeight = 30;
            this.MatchuoListBox.Location = new System.Drawing.Point(118, 197);
            this.MatchuoListBox.Name = "MatchuoListBox";
            this.MatchuoListBox.Size = new System.Drawing.Size(290, 212);
            this.MatchuoListBox.TabIndex = 6;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.DarkGreen;
            this.TeamOneName.Location = new System.Drawing.Point(414, 187);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(121, 37);
            this.TeamOneName.TabIndex = 7;
            this.TeamOneName.Text = "Equipe 1";
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.TeamOneScore.Location = new System.Drawing.Point(477, 224);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(64, 30);
            this.TeamOneScore.TabIndex = 8;
            this.TeamOneScore.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(547, 219);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValue.TabIndex = 9;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(547, 347);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreValue.TabIndex = 12;
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.TeamTwoScore.Location = new System.Drawing.Point(477, 352);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(64, 30);
            this.TeamTwoScore.TabIndex = 11;
            this.TeamTwoScore.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.Color.DarkGreen;
            this.TeamTwoName.Location = new System.Drawing.Point(414, 307);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(121, 37);
            this.TeamTwoName.TabIndex = 10;
            this.TeamTwoName.Text = "Equipe 2";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.VersusLabel.Location = new System.Drawing.Point(559, 281);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(70, 37);
            this.VersusLabel.TabIndex = 13;
            this.VersusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ScoreButton.Location = new System.Drawing.Point(653, 278);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(95, 48);
            this.ScoreButton.TabIndex = 14;
            this.ScoreButton.Text = "Valider";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(781, 421);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchuoListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBoxs);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBoxs;
        private System.Windows.Forms.ListBox MatchuoListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScore;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScore;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

