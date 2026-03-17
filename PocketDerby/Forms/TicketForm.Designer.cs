namespace PocketDerby {
    partial class TicketForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GoRaceButton = new System.Windows.Forms.Button();
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.ORALabel = new System.Windows.Forms.Label();
            this.HorseNameLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.HorseNumberLabel = new System.Windows.Forms.Label();
            this.BetTypeLabel = new System.Windows.Forms.Label();
            this.TicketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(25, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(314, 48);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "馬券購入！！";
            // 
            // GoRaceButton
            // 
            this.GoRaceButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoRaceButton.Location = new System.Drawing.Point(248, 432);
            this.GoRaceButton.Name = "GoRaceButton";
            this.GoRaceButton.Size = new System.Drawing.Size(254, 69);
            this.GoRaceButton.TabIndex = 13;
            this.GoRaceButton.Text = "いざレースへ！";
            this.GoRaceButton.UseVisualStyleBackColor = true;
            this.GoRaceButton.Click += new System.EventHandler(this.GoRaceButton_Click);
            // 
            // TicketPanel
            // 
            this.TicketPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TicketPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TicketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketPanel.Controls.Add(this.ORALabel);
            this.TicketPanel.Controls.Add(this.HorseNameLabel);
            this.TicketPanel.Controls.Add(this.BetLabel);
            this.TicketPanel.Controls.Add(this.HorseNumberLabel);
            this.TicketPanel.Controls.Add(this.BetTypeLabel);
            this.TicketPanel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TicketPanel.Location = new System.Drawing.Point(196, 158);
            this.TicketPanel.Name = "TicketPanel";
            this.TicketPanel.Size = new System.Drawing.Size(375, 212);
            this.TicketPanel.TabIndex = 14;
            // 
            // ORALabel
            // 
            this.ORALabel.AutoSize = true;
            this.ORALabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ORALabel.Location = new System.Drawing.Point(9, 180);
            this.ORALabel.Name = "ORALabel";
            this.ORALabel.Size = new System.Drawing.Size(26, 12);
            this.ORALabel.TabIndex = 5;
            this.ORALabel.Text = "ORA";
            // 
            // HouseNameLabel
            // 
            this.HorseNameLabel.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.HorseNameLabel.Font = new System.Drawing.Font("Meiryo UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HorseNameLabel.Location = new System.Drawing.Point(125, 84);
            this.HorseNameLabel.Name = "HouseNameLabel";
            this.HorseNameLabel.Size = new System.Drawing.Size(263, 47);
            this.HorseNameLabel.TabIndex = 4;
            this.HorseNameLabel.Text = "ガイアフォース";
            this.HorseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BetLabel.Location = new System.Drawing.Point(221, 159);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(133, 33);
            this.BetLabel.TabIndex = 3;
            this.BetLabel.Text = "10000円";
            // 
            // HorseNumberLabel
            // 
            this.HorseNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorseNumberLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HorseNumberLabel.Location = new System.Drawing.Point(78, 84);
            this.HorseNumberLabel.Name = "HorseNumberLabel";
            this.HorseNumberLabel.Size = new System.Drawing.Size(41, 48);
            this.HorseNumberLabel.TabIndex = 2;
            this.HorseNumberLabel.Text = "2";
            this.HorseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetTypeLabel
            // 
            this.BetTypeLabel.AutoSize = true;
            this.BetTypeLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BetTypeLabel.Location = new System.Drawing.Point(3, 56);
            this.BetTypeLabel.Name = "BetTypeLabel";
            this.BetTypeLabel.Size = new System.Drawing.Size(69, 96);
            this.BetTypeLabel.TabIndex = 0;
            this.BetTypeLabel.Text = "単\n勝";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TicketPanel);
            this.Controls.Add(this.GoRaceButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "TicketForm";
            this.Text = "ポケットダービー";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.TicketPanel.ResumeLayout(false);
            this.TicketPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button GoRaceButton;
        private System.Windows.Forms.Panel TicketPanel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label HorseNumberLabel;
        private System.Windows.Forms.Label BetTypeLabel;
        private System.Windows.Forms.Label HorseNameLabel;
        private System.Windows.Forms.Label ORALabel;
    }
}