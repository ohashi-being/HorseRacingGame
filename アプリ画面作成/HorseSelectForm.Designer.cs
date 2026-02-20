namespace アプリ画面作成 {
    partial class HorseSelectForm {
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.HorseNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpeedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuckColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OddsColumnH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.HorseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorseImageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HorseImageColumn,
            this.HorseNumberColumn,
            this.HorseNameColumn,
            this.SpeedColumn,
            this.LuckColumn,
            this.OddsColumnH});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(151, 86);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HorseNumberColumn
            // 
            this.HorseNumberColumn.DisplayIndex = 0;
            this.HorseNumberColumn.Text = "馬番";
            // 
            // SpeedColumn
            // 
            this.SpeedColumn.DisplayIndex = 1;
            this.SpeedColumn.Text = "スピード";
            // 
            // LuckColumn
            // 
            this.LuckColumn.DisplayIndex = 2;
            this.LuckColumn.Text = "運の良さ";
            // 
            // OddsColumnH
            // 
            this.OddsColumnH.DisplayIndex = 3;
            this.OddsColumnH.Text = "オッズ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TitleLabel.Location = new System.Drawing.Point(28, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(510, 48);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "馬を選択してください";
            // 
            // CurrentMoneyLabel
            // 
            this.CurrentMoneyLabel.AutoSize = true;
            this.CurrentMoneyLabel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentMoneyLabel.Location = new System.Drawing.Point(49, 459);
            this.CurrentMoneyLabel.Name = "CurrentMoneyLabel";
            this.CurrentMoneyLabel.Size = new System.Drawing.Size(312, 37);
            this.CurrentMoneyLabel.TabIndex = 2;
            this.CurrentMoneyLabel.Text = "所持金：10000円";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmButton.Location = new System.Drawing.Point(573, 454);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(157, 42);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "決定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // HorseNameColumn
            // 
            this.HorseNameColumn.Text = "馬名";
            // 
            // HorseImageColumn
            // 
            this.HorseImageColumn.Text = "馬体写真";
            // 
            // HorseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CurrentMoneyLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.listView1);
            this.Name = "HorseSelectForm";
            this.Text = "HorseSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader HorseNumberColumn;
        private System.Windows.Forms.ColumnHeader SpeedColumn;
        private System.Windows.Forms.ColumnHeader LuckColumn;
        private System.Windows.Forms.ColumnHeader OddsColumnH;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CurrentMoneyLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ColumnHeader HorseNameColumn;
        private System.Windows.Forms.ColumnHeader HorseImageColumn;
    }
}