
namespace W3_HK_TaxCalculator
{
    partial class W3_HW_TaxCalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year_rBtn = new System.Windows.Forms.RadioButton();
            this.date_rBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.car_CBX = new System.Windows.Forms.ComboBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.calculator_Btn = new System.Windows.Forms.Button();
            this.reset_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTipText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tax_CBX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // year_rBtn
            // 
            this.year_rBtn.AutoSize = true;
            this.year_rBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year_rBtn.Location = new System.Drawing.Point(308, 52);
            this.year_rBtn.Name = "year_rBtn";
            this.year_rBtn.Size = new System.Drawing.Size(110, 28);
            this.year_rBtn.TabIndex = 4;
            this.year_rBtn.TabStop = true;
            this.year_rBtn.Text = "今年度";
            this.year_rBtn.UseVisualStyleBackColor = true;
            this.year_rBtn.CheckedChanged += new System.EventHandler(this.year_rBtn_CheckedChanged);
            // 
            // date_rBtn
            // 
            this.date_rBtn.AutoSize = true;
            this.date_rBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date_rBtn.Location = new System.Drawing.Point(548, 53);
            this.date_rBtn.Name = "date_rBtn";
            this.date_rBtn.Size = new System.Drawing.Size(110, 28);
            this.date_rBtn.TabIndex = 5;
            this.date_rBtn.TabStop = true;
            this.date_rBtn.Text = "依期間";
            this.date_rBtn.UseVisualStyleBackColor = true;
            this.date_rBtn.CheckedChanged += new System.EventHandler(this.date_rBtn_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(279, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(4, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "從";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(244, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "至";
            // 
            // car_CBX
            // 
            this.car_CBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_CBX.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.car_CBX.FormattingEnabled = true;
            this.car_CBX.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.car_CBX.Location = new System.Drawing.Point(208, 13);
            this.car_CBX.Name = "car_CBX";
            this.car_CBX.Size = new System.Drawing.Size(396, 36);
            this.car_CBX.TabIndex = 10;
            this.car_CBX.SelectedValueChanged += new System.EventHandler(this.car_CBX_SelectedValueChanged);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Result.Location = new System.Drawing.Point(371, 383);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(15, 20);
            this.lbl_Result.TabIndex = 12;
            this.lbl_Result.Text = "-";
            this.lbl_Result.Visible = false;
            // 
            // calculator_Btn
            // 
            this.calculator_Btn.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculator_Btn.Location = new System.Drawing.Point(182, 468);
            this.calculator_Btn.Name = "calculator_Btn";
            this.calculator_Btn.Size = new System.Drawing.Size(127, 52);
            this.calculator_Btn.TabIndex = 13;
            this.calculator_Btn.Text = "試算";
            this.calculator_Btn.UseVisualStyleBackColor = true;
            this.calculator_Btn.Click += new System.EventHandler(this.calculator_Btn_Click);
            // 
            // reset_Btn
            // 
            this.reset_Btn.Enabled = false;
            this.reset_Btn.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reset_Btn.Location = new System.Drawing.Point(469, 468);
            this.reset_Btn.Name = "reset_Btn";
            this.reset_Btn.Size = new System.Drawing.Size(127, 52);
            this.reset_Btn.TabIndex = 14;
            this.reset_Btn.Text = "重設";
            this.reset_Btn.UseVisualStyleBackColor = true;
            this.reset_Btn.Click += new System.EventHandler(this.reset_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTipText);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(165, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 93);
            this.panel1.TabIndex = 15;
            // 
            // dateTipText
            // 
            this.dateTipText.AutoSize = true;
            this.dateTipText.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTipText.Location = new System.Drawing.Point(11, 52);
            this.dateTipText.Name = "dateTipText";
            this.dateTipText.Size = new System.Drawing.Size(16, 20);
            this.dateTipText.TabIndex = 10;
            this.dateTipText.Text = "-";
            this.dateTipText.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.car_CBX);
            this.panel2.Location = new System.Drawing.Point(41, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 65);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(88, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "試算結果僅供參考，實際金額，稅務相關問題請洽各縣市財稅局";
            // 
            // tax_CBX
            // 
            this.tax_CBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tax_CBX.Enabled = false;
            this.tax_CBX.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tax_CBX.FormattingEnabled = true;
            this.tax_CBX.Location = new System.Drawing.Point(208, 10);
            this.tax_CBX.Name = "tax_CBX";
            this.tax_CBX.Size = new System.Drawing.Size(396, 36);
            this.tax_CBX.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(46, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "排氣量";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tax_CBX);
            this.panel3.Location = new System.Drawing.Point(41, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 61);
            this.panel3.TabIndex = 17;
            // 
            // W3_HW_TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 659);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset_Btn);
            this.Controls.Add(this.calculator_Btn);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.date_rBtn);
            this.Controls.Add(this.year_rBtn);
            this.Controls.Add(this.label1);
            this.Name = "W3_HW_TaxCalculator";
            this.Text = "TaxCalculator";
            this.Load += new System.EventHandler(this.W3_HW_TaxCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton year_rBtn;
        private System.Windows.Forms.RadioButton date_rBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox car_CBX;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button calculator_Btn;
        private System.Windows.Forms.Button reset_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateTipText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tax_CBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}

