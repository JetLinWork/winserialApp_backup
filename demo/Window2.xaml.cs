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
using System.Windows.Shapes;
using System.Collections;

namespace demo
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>

    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ButtonI_Click(object sender, RoutedEventArgs e)
        {
            int TempNum;
            if (IAutoKeyDown.Text.ToString() == "" || IAutoKeyUp.Text.ToString() == "") return;
            int.TryParse(IAutoKeyDown.Text.ToString(), out TempNum);
            if (TempNum < 0 || TempNum > 255)
            {
                MessageBox.Show("自动按键键值有效值0~255");
                return;
            }
            int.TryParse(IAutoKeyUp.Text.ToString(), out TempNum);
            if (TempNum < 0 || TempNum > 255)
            {
                MessageBox.Show("自动按键键值有效值0~255");
                return;
            }
            Hide();
        }

        private void Window2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;  // cancels the window close    
            Hide();      // Programmatically hides the window
        }

        private void TBox_KeyPress(object sender, KeyEventArgs e)   //Keyboard input limit
        {
            TextBox txt = sender as TextBox;

            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //int TXT1 = txt.Text.Length;
            //MessageBox.Show(txt.Text.ToString()+"+"+TXT1.ToString());
        }

        private void IAutoKeyUp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
