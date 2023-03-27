using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HW_Tamagochi
{
    internal class GetWinForm
    {
        public static System.Windows.Forms.DialogResult Show(string text) 
        {
        return DialogResult.OK;
        }
        private void DisplayMessageBoxText()
        {
            MessageBox.Show("Hello, world.");
        }
        private static void button1_Click()
        {
            MessageBox.Show(
                "Выберите один из вариантов",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
        //Show(IWin32Window, String, String, MessageBoxButtons, MessageBoxIcon)
    }
}


