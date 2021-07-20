using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3_HK_TaxCalculator
{
    public partial class W3_HW_TaxCalculator : Form
    {

        public W3_HW_TaxCalculator()
        {
            InitializeComponent();
        }

        #region Variable Declaration                                  
        DateTime startDate, endDate;
        public decimal fullYearResult , result, resultSum;
        #endregion

        #region Event

        private void W3_HW_TaxCalculator_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void year_rBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
        }

        private void date_rBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.reset_Btn.Enabled = true;
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimePicker1.Value.Date;
            endDate = dateTimePicker2.Value.Date;
            if (endDate.Ticks < startDate.Ticks)
            {
                this.dateTipText.Visible = true;
                this.dateTipText.Text = "日期格式有誤,選單一日期應在選單二之前";
                this.car_CBX.Enabled = false;
            }
            else
            {
                this.dateTipText.Visible = false;
                this.car_CBX.Enabled = true;
            }
        }

        private void car_CBX_SelectedValueChanged(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
            this.tax_CBX.Enabled = true;
            this.reset_Btn.Enabled = true;
            if (this.car_CBX.SelectedItem as string == "機車")
                this.tax_CBX.DataSource = TaxClass.scooterArray;
            else if (this.car_CBX.SelectedItem as string == "貨車")
                this.tax_CBX.DataSource = TaxClass.truckArray;
            else if (this.car_CBX.SelectedItem as string == "大客車")
                this.tax_CBX.DataSource = TaxClass.busArray;
            else if (this.car_CBX.SelectedItem as string == "自用小客車")
                this.tax_CBX.DataSource = TaxClass.carArray;
            else if (this.car_CBX.SelectedItem as string == "營業用小客車")
                this.tax_CBX.DataSource = TaxClass.carForBusinessArray;
        }

        private void reset_Btn_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void calculator_Btn_Click(object sender, EventArgs e)
        {
            this.lbl_Result.Text = string.Empty;
            if (year_rBtn.Checked)
            {
                this.lbl_Result.Text =
                    $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy-1-1")} ~ {this.dateTimePicker2.Value.ToString("yyyy-12-31")}" + Environment.NewLine +
                    $"計算天數 : {usedDate()}" + Environment.NewLine +
                    $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                    $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                    $"計算公式 : {TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {usedDate()} / {isLeapYear(this.dateTimePicker1.Value.Year)} = {getResult().ToString("#,0")} 元" + Environment.NewLine +
                    $"應納稅額 : {getResult().ToString("#,0")} 元";
                MessageBox.Show(this.lbl_Result.Text);
            }
            else if (date_rBtn.Checked)
            {
                if (dateTimePicker1.Value.Year == dateTimePicker2.Value.Year)
                {
                    this.lbl_Result.Text =
                        $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy-MM-dd")} ~ {this.dateTimePicker2.Value.ToString("yyyy-MM-dd")}" + Environment.NewLine +
                        $"計算天數 : {usedDate()}" + Environment.NewLine +
                        $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                        $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                        $"計算公式 : {TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {usedDate()} / {isLeapYear(this.dateTimePicker1.Value.Year)} = {getResult().ToString("#,0")} 元" + Environment.NewLine +
                        $"應納稅額 : {getResult().ToString("#,0")} 元";
                    MessageBox.Show(this.lbl_Result.Text);
                }
                else
                {
                    resultSum = 0;
                    int i = this.dateTimePicker1.Value.Year;
                    if (i == dateTimePicker1.Value.Year)
                    {
                        result = TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex] * sYearUsedDate() / isLeapYear(i);
                        this.lbl_Result.Text +=
                            $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy-MM-dd")} ~ {this.dateTimePicker1.Value.ToString("yyyy-12-31")}" + Environment.NewLine +
                            $"計算天數 : {sYearUsedDate()}" + Environment.NewLine +
                            $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"計算公式 : {TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {sYearUsedDate()} / {isLeapYear(i)} = {result.ToString("#,0")} 元" + Environment.NewLine + Environment.NewLine;
                        resultSum += result;
                        i++;
                    }
                    while (i != this.dateTimePicker2.Value.Year)
                    {
                        result = TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex];
                        this.lbl_Result.Text +=
                            $"使用期間 : {i}-1-1 ~ {i}-12-31" + Environment.NewLine +
                            $"計算天數 : {isLeapYear(i)}" + Environment.NewLine +
                            $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"計算公式 : {TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {isLeapYear(i)} / {isLeapYear(i)} = {result.ToString("#,0")} 元" + Environment.NewLine + Environment.NewLine;
                        resultSum += result;
                        i++;
                    }
                    if (i == dateTimePicker2.Value.Year)
                    {
                        result = TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex] * eYearUsedDate() / isLeapYear(i);
                        this.lbl_Result.Text +=
                            $"使用期間 : {this.dateTimePicker2.Value.ToString("yyyy-1-1")} ~ {this.dateTimePicker2.Value.ToString("yyyy-MM-dd")}" + Environment.NewLine +
                            $"計算天數 : {eYearUsedDate()}" + Environment.NewLine +
                            $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                            $"計算公式 : {TaxClass.taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {eYearUsedDate()} / {isLeapYear(i)} = {result.ToString("#,0")} 元" + Environment.NewLine + Environment.NewLine;
                        resultSum += result;
                    }
                    this.lbl_Result.Text += $"應納稅額 : {resultSum.ToString("#,0")} 元";
                    MessageBox.Show(this.lbl_Result.Text);
                }

            }
        }
        #endregion

        #region Method
        private void Init() //初始化表單
        {
            this.year_rBtn.Checked = true;
            this.lbl_Result.Text = string.Empty;
            this.car_CBX.SelectedIndex = 0;
            this.tax_CBX.SelectedIndex += 0;
            this.dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker2.Value = DateTime.Today;
        }

        private int usedDate() //計算使用天數
        {
            if (this.year_rBtn.Checked)
                return isLeapYear(this.dateTimePicker1.Value.Year);
            else if (this.date_rBtn.Checked)
            {
                int usedDay = new TimeSpan(endDate.Ticks - startDate.Ticks).Days;
                return usedDay + 1;
            }
            return 0;
        }

        private int sYearUsedDate() //選取時間超過一年 計算第一年的使用天數
        {
            DateTime startYearLastDay = new DateTime(dateTimePicker1.Value.Year, 12, 31);
            int days = new TimeSpan(startYearLastDay.Ticks - startDate.Ticks).Days;
            return days + 1;
        }

        private int eYearUsedDate() //選取時間超過一年 計算最後一年的使用天數
        {
            DateTime endYearFirstDay = new DateTime(dateTimePicker2.Value.Year, 1, 1);
            int days = new TimeSpan(endDate.Ticks - endYearFirstDay.Ticks).Days;
            return days + 1;
        }

        private int isLeapYear(int year) //辨別閏年
        {
            if (this.year_rBtn.Checked)
            {
                if (DateTime.IsLeapYear(DateTime.Now.Year))
                    return 366;
                else
                    return 365;
            }
            else if (this.date_rBtn.Checked)
            {
                if (DateTime.IsLeapYear(year))
                    return 366;
                else
                    return 365;
            }
            return 0;
        }

        private decimal getResult()
        {
            fullYearResult = (decimal)TaxClass.taxLevel[this.car_CBX.SelectedIndex]
                [this.tax_CBX.SelectedIndex] * usedDate() / isLeapYear(this.dateTimePicker1.Value.Year);

            return Math.Floor(fullYearResult); // 試算結果採無條件捨去
        }
        #endregion
    }
}
