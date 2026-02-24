namespace アプリ画面作成 {
    partial class ClearForm {
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
            this.ClearStatusLabel = new System.Windows.Forms.Label();
            this.GoTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowDrop = true;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(25, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(755, 48);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "あなたはもう競馬マスターです！";
            // 
            // ClearStatusLabel
            // 
            this.ClearStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearStatusLabel.AutoSize = true;
            this.ClearStatusLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.ClearStatusLabel.Location = new System.Drawing.Point(235, 225);
            this.ClearStatusLabel.Name = "ClearStatusLabel";
            this.ClearStatusLabel.Size = new System.Drawing.Size(287, 64);
            this.ClearStatusLabel.TabIndex = 3;
            this.ClearStatusLabel.Text = "クリア！";
            // 
            // GoTitleButton
            // 
            this.GoTitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GoTitleButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoTitleButton.Location = new System.Drawing.Point(259, 407);
            this.GoTitleButton.Name = "GoTitleButton";
            this.GoTitleButton.Size = new System.Drawing.Size(240, 72);
            this.GoTitleButton.TabIndex = 4;
            this.GoTitleButton.Text = "タイトルへ";
            this.GoTitleButton.UseVisualStyleBackColor = true;
            // 
            // ClearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GoTitleButton);
            this.Controls.Add(this.ClearStatusLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ClearForm";
            this.Text = "ClearForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ClearStatusLabel;
        private System.Windows.Forms.Button GoTitleButton;
    }
}