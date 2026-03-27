namespace PocketDerby {
    partial class ResultForm {
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
            this.ResultListView = new System.Windows.Forms.ListView();
            this.OrderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorseNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OddsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NextRaceButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.PayoutLabel = new System.Windows.Forms.Label();
            this.YourBakenLabel = new System.Windows.Forms.Label();
            this.HitStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(25, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(265, 48);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "レース結果";
            // 
            // ResultListView
            // 
            this.ResultListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderColumn,
            this.HorseNumberColumn,
            this.HorseNameColumn,
            this.OddsColumn});
            this.ResultListView.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(148, 107);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(490, 203);
            this.ResultListView.TabIndex = 17;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderColumn
            // 
            this.OrderColumn.Text = "着順";
            this.OrderColumn.Width = 80;
            // 
            // HorseNumberColumn
            // 
            this.HorseNumberColumn.Text = "馬番";
            this.HorseNumberColumn.Width = 80;
            // 
            // HorseNameColumn
            // 
            this.HorseNameColumn.Text = "馬名";
            this.HorseNameColumn.Width = 230;
            // 
            // OddsColumn
            // 
            this.OddsColumn.Text = "オッズ";
            this.OddsColumn.Width = 100;
            // 
            // NextRaceButton
            // 
            this.NextRaceButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NextRaceButton.Location = new System.Drawing.Point(432, 452);
            this.NextRaceButton.Name = "NextRaceButton";
            this.NextRaceButton.Size = new System.Drawing.Size(240, 75);
            this.NextRaceButton.TabIndex = 19;
            this.NextRaceButton.Text = "次のレースへ";
            this.NextRaceButton.UseVisualStyleBackColor = true;
            this.NextRaceButton.Click += new System.EventHandler(this.NextRaceButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishButton.Location = new System.Drawing.Point(112, 452);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(171, 75);
            this.FinishButton.TabIndex = 18;
            this.FinishButton.Text = "終了";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CurrentMoneyLabel
            // 
            this.CurrentMoneyLabel.AutoSize = true;
            this.CurrentMoneyLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentMoneyLabel.Location = new System.Drawing.Point(404, 376);
            this.CurrentMoneyLabel.Name = "CurrentMoneyLabel";
            this.CurrentMoneyLabel.Size = new System.Drawing.Size(200, 24);
            this.CurrentMoneyLabel.TabIndex = 22;
            this.CurrentMoneyLabel.Text = "所持金：25000円";
            // 
            // PayoutLabel
            // 
            this.PayoutLabel.AutoSize = true;
            this.PayoutLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PayoutLabel.Location = new System.Drawing.Point(144, 376);
            this.PayoutLabel.Name = "PayoutLabel";
            this.PayoutLabel.Size = new System.Drawing.Size(200, 24);
            this.PayoutLabel.TabIndex = 21;
            this.PayoutLabel.Text = "払戻金：25000円";
            // 
            // YourBakenLabel
            // 
            this.YourBakenLabel.AutoSize = true;
            this.YourBakenLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.YourBakenLabel.Location = new System.Drawing.Point(144, 339);
            this.YourBakenLabel.Name = "YourBakenLabel";
            this.YourBakenLabel.Size = new System.Drawing.Size(185, 24);
            this.YourBakenLabel.TabIndex = 23;
            this.YourBakenLabel.Text = "あなたの馬券：";
            // 
            // HitStatusLabel
            // 
            this.HitStatusLabel.AutoSize = true;
            this.HitStatusLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HitStatusLabel.Location = new System.Drawing.Point(327, 339);
            this.HitStatusLabel.Name = "HitStatusLabel";
            this.HitStatusLabel.Size = new System.Drawing.Size(85, 24);
            this.HitStatusLabel.TabIndex = 20;
            this.HitStatusLabel.Text = "的中！";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.YourBakenLabel);
            this.Controls.Add(this.CurrentMoneyLabel);
            this.Controls.Add(this.PayoutLabel);
            this.Controls.Add(this.HitStatusLabel);
            this.Controls.Add(this.NextRaceButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ResultForm";
            this.Text = "ポケットダービー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader OrderColumn;
        private System.Windows.Forms.ColumnHeader HorseNumberColumn;
        private System.Windows.Forms.ColumnHeader HorseNameColumn;
        private System.Windows.Forms.ColumnHeader OddsColumn;
        private System.Windows.Forms.Button NextRaceButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label CurrentMoneyLabel;
        private System.Windows.Forms.Label PayoutLabel;
        private System.Windows.Forms.Label YourBakenLabel;
        private System.Windows.Forms.Label HitStatusLabel;
    }
}