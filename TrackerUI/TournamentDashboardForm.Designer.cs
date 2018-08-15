namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.TeamPrizeLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentLoadButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamPrizeLabel
            // 
            this.TeamPrizeLabel.AutoSize = true;
            this.TeamPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPrizeLabel.ForeColor = System.Drawing.Color.Green;
            this.TeamPrizeLabel.Location = new System.Drawing.Point(329, 41);
            this.TeamPrizeLabel.Name = "TeamPrizeLabel";
            this.TeamPrizeLabel.Size = new System.Drawing.Size(253, 45);
            this.TeamPrizeLabel.TabIndex = 14;
            this.TeamPrizeLabel.Text = "Tableau de bord";
            // 
            // LoadExistingTournamentDropDown
            // 
            this.LoadExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentDropDown.Location = new System.Drawing.Point(264, 160);
            this.LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            this.LoadExistingTournamentDropDown.Size = new System.Drawing.Size(375, 38);
            this.LoadExistingTournamentDropDown.TabIndex = 19;
            // 
            // SelectTournamentLabel
            // 
            this.SelectTournamentLabel.AutoSize = true;
            this.SelectTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTournamentLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SelectTournamentLabel.Location = new System.Drawing.Point(387, 112);
            this.SelectTournamentLabel.Name = "SelectTournamentLabel";
            this.SelectTournamentLabel.Size = new System.Drawing.Size(151, 25);
            this.SelectTournamentLabel.TabIndex = 18;
            this.SelectTournamentLabel.Text = "Charger Tournoi";
            // 
            // TournamentLoadButton
            // 
            this.TournamentLoadButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.TournamentLoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TournamentLoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TournamentLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentLoadButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLoadButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.TournamentLoadButton.Location = new System.Drawing.Point(376, 228);
            this.TournamentLoadButton.Name = "TournamentLoadButton";
            this.TournamentLoadButton.Size = new System.Drawing.Size(184, 63);
            this.TournamentLoadButton.TabIndex = 26;
            this.TournamentLoadButton.Text = "Charger";
            this.TournamentLoadButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.CreateTournamentButton.Location = new System.Drawing.Point(318, 322);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(303, 81);
            this.CreateTournamentButton.TabIndex = 27;
            this.CreateTournamentButton.Text = "Créer un tournoi";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(911, 462);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.TournamentLoadButton);
            this.Controls.Add(this.LoadExistingTournamentDropDown);
            this.Controls.Add(this.SelectTournamentLabel);
            this.Controls.Add(this.TeamPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tableau de bord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamPrizeLabel;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropDown;
        private System.Windows.Forms.Label SelectTournamentLabel;
        private System.Windows.Forms.Button TournamentLoadButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}