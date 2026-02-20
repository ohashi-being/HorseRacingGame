namespace アプリ画面作成 {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HorsePictureBox = new System.Windows.Forms.PictureBox();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HorseNameLabel = new System.Windows.Forms.Label();
            this.PayoutLabel = new System.Windows.Forms.Label();
            this.PayoutValueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorsePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMoneyLabel
            // 
            this.CurrentMoneyLabel.AutoSize = true;
            this.CurrentMoneyLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentMoneyLabel.Location = new System.Drawing.Point(53, 446);
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
            this.BetLabel.Text = "掛け金";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(419, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 111);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(25, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(608, 48);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "掛け金を入力してください";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HorsePictureBox);
            this.panel1.Location = new System.Drawing.Point(72, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 100);
            this.panel1.TabIndex = 12;
            // 
            // HorsePictureBox
            // 
            this.HorsePictureBox.Location = new System.Drawing.Point(3, 3);
            this.HorsePictureBox.Name = "HorsePictureBox";
            this.HorsePictureBox.Size = new System.Drawing.Size(111, 94);
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
            this.PayoutLabel.Size = new System.Drawing.Size(134, 37);
            this.PayoutLabel.TabIndex = 14;
            this.PayoutLabel.Text = "払戻金";
            // 
            // PayoutValueLabel
            // 
            this.PayoutValueLabel.AutoSize = true;
            this.PayoutValueLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PayoutValueLabel.Location = new System.Drawing.Point(412, 379);
            this.PayoutValueLabel.Name = "PayoutValueLabel";
            this.PayoutValueLabel.Size = new System.Drawing.Size(156, 37);
            this.PayoutValueLabel.TabIndex = 15;
            this.PayoutValueLabel.Text = "10000円";
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PayoutValueLabel);
            this.Controls.Add(this.PayoutLabel);
            this.Controls.Add(this.HorseNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HorseNumberLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.BetNumericUpDown);
            this.Controls.Add(this.CurrentMoneyLabel);
            this.Name = "BetForm";
            this.Text = "あ";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HorsePictureBox;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.Label HorseNameLabel;
        private System.Windows.Forms.Label PayoutLabel;
        private System.Windows.Forms.Label PayoutValueLabel;
    }
}