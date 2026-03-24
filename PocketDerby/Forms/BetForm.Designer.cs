namespace PocketDerby {
    partial class BetForm {
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
            this.CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HorseNumberLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OddsValueLabel = new System.Windows.Forms.Label();
            this.LuckValueLabel = new System.Windows.Forms.Label();
            this.SpeedValueLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.LuckLabel = new System.Windows.Forms.Label();
            this.OddsLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HorsePictureBox = new System.Windows.Forms.PictureBox();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HorseNameLabel = new System.Windows.Forms.Label();
            this.PayoutLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorsePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMoneyLabel
            // 
            this.CurrentMoneyLabel.AutoSize = true;
            this.CurrentMoneyLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentMoneyLabel.Location = new System.Drawing.Point(49, 459);
            this.CurrentMoneyLabel.Name = "CurrentMoneyLabel";
            this.CurrentMoneyLabel.Size = new System.Drawing.Size(312, 37);
            this.CurrentMoneyLabel.TabIndex = 3;
            this.CurrentMoneyLabel.Text = "所持金：10000円";
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BetLabel.Location = new System.Drawing.Point(132, 312);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(134, 37);
            this.BetLabel.TabIndex = 5;
            this.BetLabel.Text = "賭け金";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmButton.Location = new System.Drawing.Point(633, 459);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(107, 69);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "確定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(467, 459);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 69);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HorseNumberLabel
            // 
            this.HorseNumberLabel.AutoSize = true;
            this.HorseNumberLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HorseNumberLabel.Location = new System.Drawing.Point(245, 146);
            this.HorseNumberLabel.Name = "HorseNumberLabel";
            this.HorseNumberLabel.Size = new System.Drawing.Size(76, 37);
            this.HorseNumberLabel.TabIndex = 9;
            this.HorseNumberLabel.Text = "② ";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.OddsValueLabel, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LuckValueLabel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.SpeedValueLabel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.SpeedLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LuckLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.OddsLabel, 0, 2);
            this.TableLayoutPanel.Location = new System.Drawing.Point(419, 146);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.Size = new System.Drawing.Size(236, 111);
            this.TableLayoutPanel.TabIndex = 10;
            // 
            // OddsValueLabel
            // 
            this.OddsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OddsValueLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OddsValueLabel.Location = new System.Drawing.Point(133, 72);
            this.OddsValueLabel.Name = "OddsValueLabel";
            this.OddsValueLabel.Size = new System.Drawing.Size(100, 39);
            this.OddsValueLabel.TabIndex = 5;
            this.OddsValueLabel.Text = "5.2";
            this.OddsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LuckValueLabel
            // 
            this.LuckValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuckValueLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LuckValueLabel.Location = new System.Drawing.Point(133, 36);
            this.LuckValueLabel.Name = "LuckValueLabel";
            this.LuckValueLabel.Size = new System.Drawing.Size(100, 36);
            this.LuckValueLabel.TabIndex = 4;
            this.LuckValueLabel.Text = "90";
            this.LuckValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeedValueLabel
            // 
            this.SpeedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedValueLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SpeedValueLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SpeedValueLabel.Location = new System.Drawing.Point(133, 0);
            this.SpeedValueLabel.Name = "SpeedValueLabel";
            this.SpeedValueLabel.Size = new System.Drawing.Size(100, 36);
            this.SpeedValueLabel.TabIndex = 3;
            this.SpeedValueLabel.Text = "65";
            this.SpeedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SpeedLabel.Location = new System.Drawing.Point(3, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(124, 36);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "スピード";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LuckLabel
            // 
            this.LuckLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuckLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LuckLabel.Location = new System.Drawing.Point(3, 36);
            this.LuckLabel.Name = "LuckLabel";
            this.LuckLabel.Size = new System.Drawing.Size(124, 36);
            this.LuckLabel.TabIndex = 1;
            this.LuckLabel.Text = "運の良さ";
            this.LuckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OddsLabel
            // 
            this.OddsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OddsLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OddsLabel.Location = new System.Drawing.Point(3, 72);
            this.OddsLabel.Name = "OddsLabel";
            this.OddsLabel.Size = new System.Drawing.Size(124, 39);
            this.OddsLabel.TabIndex = 2;
            this.OddsLabel.Text = "オッズ";
            this.OddsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(25, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(608, 48);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "賭け金を入力してください";
            // 
            // HorsePictureBox
            // 
            this.HorsePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HorsePictureBox.Image = global::PocketDerby.Properties.Resources.ChatGPT_Image_2026年2月9日_10_38_31;
            this.HorsePictureBox.Location = new System.Drawing.Point(75, 110);
            this.HorsePictureBox.Name = "HorsePictureBox";
            this.HorsePictureBox.Size = new System.Drawing.Size(100, 100);
            this.HorsePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HorsePictureBox.TabIndex = 0;
            this.HorsePictureBox.TabStop = false;
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BetNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BetNumericUpDown.Location = new System.Drawing.Point(419, 312);
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(143, 28);
            this.BetNumericUpDown.TabIndex = 4;
            this.BetNumericUpDown.ValueChanged += new System.EventHandler(this.BetNumericUpDown_ValueChanged);
            // 
            // HorseNameLabel
            // 
            this.HorseNameLabel.AutoSize = true;
            this.HorseNameLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HorseNameLabel.Location = new System.Drawing.Point(69, 234);
            this.HorseNameLabel.Name = "HorseNameLabel";
            this.HorseNameLabel.Size = new System.Drawing.Size(239, 33);
            this.HorseNameLabel.TabIndex = 13;
            this.HorseNameLabel.Text = "ガイアフォース";
            // 
            // PayoutLabel
            // 
            this.PayoutLabel.AutoSize = true;
            this.PayoutLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PayoutLabel.Location = new System.Drawing.Point(132, 379);
            this.PayoutLabel.Name = "PayoutLabel";
            this.PayoutLabel.Size = new System.Drawing.Size(333, 37);
            this.PayoutLabel.TabIndex = 14;
            this.PayoutLabel.Text = "払戻金        円";
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.HorsePictureBox);
            this.Controls.Add(this.PayoutLabel);
            this.Controls.Add(this.HorseNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.HorseNumberLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.BetNumericUpDown);
            this.Controls.Add(this.CurrentMoneyLabel);
            this.Name = "BetForm";
            this.Text = "ポケットダービー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BetForm_FormClosed);
            this.Load += new System.EventHandler(this.BetForm_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorsePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentMoneyLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label HorseNumberLabel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox HorsePictureBox;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.Label HorseNameLabel;
        private System.Windows.Forms.Label PayoutLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label LuckLabel;
        private System.Windows.Forms.Label OddsLabel;
        private System.Windows.Forms.Label OddsValueLabel;
        private System.Windows.Forms.Label LuckValueLabel;
        private System.Windows.Forms.Label SpeedValueLabel;
    }
}