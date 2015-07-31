namespace EraNameConverter
{
    partial class Converter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Era = new System.Windows.Forms.ComboBox();
			this.result = new System.Windows.Forms.TextBox();
			this.arrow = new System.Windows.Forms.Label();
			this.label_era = new System.Windows.Forms.Label();
			this.label_year = new System.Windows.Forms.Label();
			this.label_ad = new System.Windows.Forms.Label();
			this.label_year_2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(135, 40);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(78, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Era
			// 
			this.Era.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Era.FormattingEnabled = true;
			this.Era.Items.AddRange(new object[] {
            "平成",
            "昭和",
            "大正",
            "明治",
            "西暦"});
			this.Era.Location = new System.Drawing.Point(12, 40);
			this.Era.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Era.Name = "Era";
			this.Era.Size = new System.Drawing.Size(98, 23);
			this.Era.TabIndex = 1;
			this.Era.SelectedIndexChanged += new System.EventHandler(this.Era_SelectedIndexChanged);
			// 
			// result
			// 
			this.result.Enabled = false;
			this.result.Font = new System.Drawing.Font("Meiryo UI", 23F);
			this.result.ForeColor = System.Drawing.SystemColors.InfoText;
			this.result.Location = new System.Drawing.Point(305, 29);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(181, 46);
			this.result.TabIndex = 2;
			this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// arrow
			// 
			this.arrow.AutoSize = true;
			this.arrow.Font = new System.Drawing.Font("Meiryo UI", 14F);
			this.arrow.Location = new System.Drawing.Point(253, 40);
			this.arrow.Name = "arrow";
			this.arrow.Size = new System.Drawing.Size(29, 24);
			this.arrow.TabIndex = 3;
			this.arrow.Text = "→";
			// 
			// label_era
			// 
			this.label_era.AutoSize = true;
			this.label_era.Location = new System.Drawing.Point(12, 21);
			this.label_era.Name = "label_era";
			this.label_era.Size = new System.Drawing.Size(61, 15);
			this.label_era.TabIndex = 4;
			this.label_era.Text = "元号・西暦";
			// 
			// label_year
			// 
			this.label_year.AutoSize = true;
			this.label_year.Location = new System.Drawing.Point(219, 43);
			this.label_year.Name = "label_year";
			this.label_year.Size = new System.Drawing.Size(19, 15);
			this.label_year.TabIndex = 5;
			this.label_year.Text = "年";
			// 
			// label_ad
			// 
			this.label_ad.AutoSize = true;
			this.label_ad.Location = new System.Drawing.Point(302, 9);
			this.label_ad.Name = "label_ad";
			this.label_ad.Size = new System.Drawing.Size(55, 15);
			this.label_ad.TabIndex = 6;
			this.label_ad.Text = "変換結果";
			// 
			// label_year_2
			// 
			this.label_year_2.AutoSize = true;
			this.label_year_2.Font = new System.Drawing.Font("Meiryo UI", 13F);
			this.label_year_2.Location = new System.Drawing.Point(487, 47);
			this.label_year_2.Name = "label_year_2";
			this.label_year_2.Size = new System.Drawing.Size(28, 23);
			this.label_year_2.TabIndex = 7;
			this.label_year_2.Text = "年";
			// 
			// Converter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 101);
			this.Controls.Add(this.label_year_2);
			this.Controls.Add(this.label_ad);
			this.Controls.Add(this.label_year);
			this.Controls.Add(this.label_era);
			this.Controls.Add(this.arrow);
			this.Controls.Add(this.result);
			this.Controls.Add(this.Era);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(543, 139);
			this.MinimumSize = new System.Drawing.Size(543, 139);
			this.Name = "Converter";
			this.Text = "元号変換";
			this.Load += new System.EventHandler(this.Converter_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Era;
	private System.Windows.Forms.TextBox result;
	private System.Windows.Forms.Label arrow;
	private System.Windows.Forms.Label label_era;
	private System.Windows.Forms.Label label_year;
	private System.Windows.Forms.Label label_ad;
	private System.Windows.Forms.Label label_year_2;
    }
}

