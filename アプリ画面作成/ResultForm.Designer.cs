namespace アプリ画面作成 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderColumn,
            this.HorseNumberColumn,
            this.HorseNameColumn,
            this.OddsColumn});
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(79, 106);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(617, 191);
            this.ResultListView.TabIndex = 17;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderColumn
            // 
            this.OrderColumn.Text = "着順";
            // 
            // HorseNumberColumn
            // 
            this.HorseNumberColumn.Text = "馬番";
            // 
            // HorseNameColumn
            // 
            this.HorseNameColumn.Text = "馬名";
            // 
            // OddsColumn
            // 
            this.OddsColumn.Text = "オッズ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(432, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 75);
            this.button1.TabIndex = 19;
            this.button1.Text = "次のレースへ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(112, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 75);
            this.button2.TabIndex = 18;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(404, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "所持金：25000円";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(144, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "払戻金：25000円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(144, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "あなたの馬券：的中！";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ResultForm";
            this.Text = "ポケットダービー";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}