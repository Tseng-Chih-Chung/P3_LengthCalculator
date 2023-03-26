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
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            //如果strInput轉換數字成功把其存在douOutput
            {
                txtM.Text = string.Format("{0:0.#####}", douOutput / 100);
                //string.Format("{0:0.#####}" 選小數點5位並印出來
                txtKM.Text = string.Format("{0:0.#####}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.#####}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.#####}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.#####}", douOutput / 91.44);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.#####}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.#####}", douOutput / 1000);
                txtIn.Text = string.Format("{0:0.#####}", douOutput * 39.37);
                txtFt.Text = string.Format("{0:0.#####}", douOutput * 3.28);
                txtYard.Text = string.Format("{0:0.#####}", douOutput * 1.09);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.#####}", douOutput * 100000);
                txtM.Text = string.Format("{0:0.#####}", douOutput * 1000);
                txtIn.Text = string.Format("{0:0.#####}", douOutput * 39370);
                txtFt.Text = string.Format("{0:0.#####}", douOutput * 3280.84);
                txtYard.Text = string.Format("{0:0.#####}", douOutput * 1093.6);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }
private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.#####}", douOutput * 30.48);
                txtM.Text = string.Format("{0:0.#####}", douOutput * 0.30);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00031);
                txtIn.Text = string.Format("{0:0.#####}", douOutput * 12);
                txtYard.Text = string.Format("{0:0.#####}", douOutput * 0.33);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }
        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.#####}", douOutput * 2.54);
                txtM.Text = string.Format("{0:0.#####}", douOutput * 0.025);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00003);
                txtFt.Text = string.Format("{0:0.#####}", douOutput * 0.083);
                txtYard.Text = string.Format("{0:0.#####}", douOutput * 0.027);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.#####}", douOutput * 91.44);
                txtM.Text = string.Format("{0:0.#####}", douOutput * 0.91);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00091);
                txtIn.Text = string.Format("{0:0.#####}", douOutput * 36);
                txtFt.Text = string.Format("{0:0.#####}", douOutput * 3);
                txtInfo.Text = "運算有誤差 勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
