namespace PocketDerby {
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
            this.components = new System.ComponentModel.Container();
            this.ListView = new System.Windows.Forms.ListView();
            this.HorseImageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorseNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpeedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuckColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OddsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FHorseImageList = new System.Windows.Forms.ImageList(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HorseImageColumn,
            this.HorseNumberColumn,
            this.HorseNameColumn,
            this.SpeedColumn,
            this.LuckColumn,
            this.OddsColumn});
            this.ListView.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListView.FullRowSelect = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(50, 86);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(690, 350);
            this.ListView.SmallImageList = this.FHorseImageList;
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // HorseImageColumn
            // 
            this.HorseImageColumn.Text = "馬体写真";
            this.HorseImageColumn.Width = 120;
            // 
            // HorseNumberColumn
            // 
            this.HorseNumberColumn.Text = "馬番";
            this.HorseNumberColumn.Width = 70;
            // 
            // HorseNameColumn
            // 
            this.HorseNameColumn.Text = "馬名";
            this.HorseNameColumn.Width = 180;
            // 
            // SpeedColumn
            // 
            this.SpeedColumn.Text = "スピード";
            this.SpeedColumn.Width = 100;
            // 
            // LuckColumn
            // 
            this.LuckColumn.Text = "運の良さ";
            this.LuckColumn.Width = 120;
            // 
            // OddsColumn
            // 
            this.OddsColumn.Text = "オッズ";
            this.OddsColumn.Width = 90;
            // 
            // FHorse1ImageList
            // 
            this.FHorseImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FHorseImageList.ImageSize = new System.Drawing.Size(80, 58);
            this.FHorseImageList.TransparentColor = System.Drawing.Color.Transparent;
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
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
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
            this.Controls.Add(this.ListView);
            this.Name = "HorseSelectForm";
            this.Text = "HorseSelectForm";
            this.Load += new System.EventHandler(this.HorseSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader HorseNumberColumn;
        private System.Windows.Forms.ColumnHeader SpeedColumn;
        private System.Windows.Forms.ColumnHeader LuckColumn;
        private System.Windows.Forms.ColumnHeader OddsColumn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CurrentMoneyLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ColumnHeader HorseNameColumn;
        private System.Windows.Forms.ColumnHeader HorseImageColumn;
        private System.Windows.Forms.ImageList FHorseImageList;
    }
}