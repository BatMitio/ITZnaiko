using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string command = UserText.Text.Trim();
            string commandToReturn = "";
            string language = "";

            language = InputLanguage.CurrentInputLanguage.Culture.IetfLanguageTag.ToString();

            if (language == "en-US")
            {
                if (command.ToLower() == "hello" || command.ToLower() == "hello!")
                {
                    commandToReturn = "Hello, I am Petq";
                }
                else if (command.ToLower() == "")
                {
                    commandToReturn = "Please enter any message!";
                }
            }
            else if (language == "bg-BG")
            {
                if (command.ToLower() == "здрасти" || command.ToLower() == "здрасти!" || command.ToLower() == "здр")
                {
                    commandToReturn = "Здрасти, аз съм Петя!";
                }
                else if (command.ToLower() == "")
                {
                    commandToReturn = "Моля въведете някакво съобщение!";
                }
            }


            BotText.AppendText(commandToReturn + Environment.NewLine);
        }
    }
}
