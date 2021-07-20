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
        public decimal finalResult;
        #endregion
        #region taxLevel
        public int[][] taxLevel = new int[][]
        {
        new int[] { 0,800,1620,2160,4320,7120,11230},
        new int[] { 900,1080,1800,2700,3600,4500,5400,6300,7200,8100,9000,9900,10800,11700,12600,13500,14400,15300,16200},
        new int[] { 1080,1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 },
        new int[] { 1620,2160,4320,7120,11230,15210,28220,46170,69690,117000,151200},
        new int[] { 900,1260,2160,3060,6480,9900,16380,24300,33660,44460,56700}
        };
        #endregion 
        #region ComboBox's Item
        //string[] car_CBXArray = new string[] { "機車", "貨車", "大客車", "自用小客車", "營業用小客車" };
        //string[] scooterArray = new string[] { "150cc 以下", "151cc~ 250cc", "251cc~ 500cc", "501cc~ 600cc", "601cc~1200cc", "1201cc~1800cc", "1801cc 以上", };
        //string[] truckArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc~3600cc", "3601cc~4200cc", "4201cc~4800cc", "4801cc~5400cc", "5401cc~6000cc", "6001cc~6600cc", "6601cc~7200cc", "7201cc~7800cc", "7801cc~8400cc", "8401cc~9000cc", "9001cc~9600cc", "9601cc~10200cc", "10201cc 以上" };
        //string[] busArray = new string[] { "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc~3600cc", "3601cc~4200cc", "4201cc~4800cc", "4801cc~5400cc", "5401cc~6000cc", "6001cc~6600cc", "6601cc~7200cc", "7201cc~7800cc", "7801cc~8400cc", "8401cc~9000cc", "9001cc~9600cc", "9601cc~10200cc", "10201cc 以上" };
        //string[] carArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc - 4200cc", "4201cc - 5400cc", "5401cc - 6600cc", "6601cc - 7800cc", "7801cc 以上" };
        //string[] carForBusinessArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc - 4200cc", "4201cc - 5400cc", "5401cc - 6600cc", "6601cc - 7800cc", "7801cc 以上" };
        #endregion

        #region Event

        private void W3_HK_TaxCalculator_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            {
                this.tax_CBX.DataSource = MethodClass.scooterArray;
            }
            else if (this.car_CBX.SelectedItem as string == "貨車")
            {
                this.tax_CBX.DataSource = MethodClass.truckArray;
            }
            else if (this.car_CBX.SelectedItem as string == "大客車")
            {
                this.tax_CBX.DataSource = MethodClass.busArray;
            }
            else if (this.car_CBX.SelectedItem as string == "自用小客車")
            {
                this.tax_CBX.DataSource = MethodClass.carArray;
            }
            else if (this.car_CBX.SelectedItem as string == "營業用小客車")
            {
                this.tax_CBX.DataSource = MethodClass.carForBusinessArray;
            }
        }



        private void reset_Btn_Click(object sender, EventArgs e)
        {
            Init();
            MessageBox.Show(Convert.ToString(MethodClass.get__result(1,2)));
        }

        private void calculator_Btn_Click(object sender, EventArgs e)
        {
            this.lbl_Result.Text = string.Empty;
            if (this.year_rBtn.Checked)
            {
                this.lbl_Result.Text = $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy-1-1")} ~ {this.dateTimePicker2.Value.ToString("yyyy-12-31")}" + Environment.NewLine + $"計算天數 : {usedDate()}" + Environment.NewLine + $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine + $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine + $"計算公式 : {taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {usedDate()} / {isLeapYear(this.dateTimePicker1.Value.Year)} = {getResult().ToString("#,0")} 元" + Environment.NewLine + $"應納稅額 : {getResult().ToString("#,0")} 元";
            }
            else if (this.date_rBtn.Checked)
            {
                for (int i = this.dateTimePicker1.Value.Year; i <= this.dateTimePicker2.Value.Year; i++)
                {
                    this.lbl_Result.Text +=
                       $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy-MM-dd")} ~ {this.dateTimePicker2.Value.ToString("yyyy-MM-dd")}" + Environment.NewLine +
                       $"計算天數 : {isLeapYear(i)}" + Environment.NewLine +
                       $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                       $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine +
                       $"計算公式 : {taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {usedDate()} / {isLeapYear(i)} = {getResult().ToString("#,0")} 元" + Environment.NewLine +
                       $"應納稅額 : {getResult().ToString("#,0")} 元" + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        #endregion

        #region Method
        private void Init()
        {
            this.year_rBtn.Checked = true;
            this.lbl_Result.Text = string.Empty;
            this.car_CBX.DataSource = MethodClass.car_CBXArray;
        }

        private int usedDate()
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

        private int isLeapYear(int year)
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
            finalResult = (decimal)taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex] * usedDate() / isLeapYear(this.dateTimePicker1.Value.Year);
            return finalResult;
        }

        //private string 跨日期整年度用()
        //{
        //    int sYear = Convert.ToInt32(this.dateTimePicker1.Value);
        //    int eYear = Convert.ToInt32(this.dateTimePicker2.Value);
        //    this.dateTimePicker1.Value.

        //    if

        //    this.lbl_Result.Text = $"使用期間 : {this.dateTimePicker1.Value.ToString("1-1")} ~ {this.dateTimePicker2.Value.ToString("yyyy-12-31")}" + Environment.NewLine + $"計算天數 : {usedDate()}" + Environment.NewLine + $"排氣量 : {this.tax_CBX.SelectedItem.ToString()}" + Environment.NewLine + $"用途 : {this.car_CBX.SelectedItem.ToString()}" + Environment.NewLine + $"計算公式 : {taxLevel[this.car_CBX.SelectedIndex][this.tax_CBX.SelectedIndex]} * {usedDate()} / {isLeapYear(this.dateTimePicker1.Value.Year)} = {getResult().ToString("#,0")} 元" + Environment.NewLine + $"應納稅額 : {getResult().ToString("#,0")} 元";

        //    return "temp";
        //}

        #endregion



    }
}
