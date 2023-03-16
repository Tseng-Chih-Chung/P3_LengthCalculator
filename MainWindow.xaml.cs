using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P3_Length_Calculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); 
            //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.#####}", douCM / 100);
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共5位的數字，轉型成文字型態，在txtM顯示結果
            txtKM.Text = string.Format("{0:0.#####}", douCM / 100000);
            //公分換公里(1公里=100000公分)
            txtIn.Text = string.Format("{0:0.#####}", douCM / 2.54);
            //公分換英吋(1英吋≈2.54公分)
            txtFt.Text = string.Format("{0:0.#####}", douCM / 30.48);
            //公分換英呎(1英呎≈30.44公分)
            txtYard.Text = string.Format("{0:0.#####}", douCM / 91.44);
            //公分換碼(1碼≈91.44公分)
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;
            douM = Convert.ToDouble(txtM.Text);
            txtCM.Text = string.Format("{0:0.#####}", douM * 100);
            txtKM.Text = string.Format("{0:0.#####}", douM / 1000);
            txtIn.Text = string.Format("{0:0.#####}", douM * 39.37);
            txtFt.Text = string.Format("{0:0.#####}", douM * 3.28);
            txtYard.Text = string.Format("{0:0.#####}", douM * 1.09);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;
            douKM = Convert.ToDouble(txtKM.Text);
            txtCM.Text = string.Format("{0:0.#####}", douKM * 100000);
            txtM.Text = string.Format("{0:0.#####}", douKM * 1000);
            txtIn.Text = string.Format("{0:0.#####}", douKM * 39370);
            txtFt.Text = string.Format("{0:0.#####}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.#####}", douKM * 1093.6);
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;
            douIn = Convert.ToDouble(txtIn.Text);
            txtCM.Text = string.Format("{0:0.#####}", douIn * 2.54);
            txtM.Text = string.Format("{0:0.#####}", douIn * 0.025);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.00003);
            txtFt.Text = string.Format("{0:0.#####}", douIn * 0.083);
            txtYard.Text = string.Format("{0:0.#####}", douIn * 0.027);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;
            douFt = Convert.ToDouble(txtFt.Text);
            txtCM.Text = string.Format("{0:0.#####}", douFt * 30.48);
            txtM.Text = string.Format("{0:0.#####}", douFt * 0.30);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.00031);
            txtIn.Text = string.Format("{0:0.#####}", douFt * 12);
            txtYard.Text = string.Format("{0:0.#####}", douFt * 0.33);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            douYard = Convert.ToDouble(txtYard.Text);
            txtCM.Text = string.Format("{0:0.#####}", douYard * 91.44);
            txtM.Text = string.Format("{0:0.#####}", douYard * 0.91);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.00091);
            txtIn.Text = string.Format("{0:0.#####}", douYard * 36);
            txtFt.Text = string.Format("{0:0.#####}", douYard * 3);
        }
    }
}
