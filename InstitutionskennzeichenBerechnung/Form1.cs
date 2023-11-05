using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutionskennzeichenBerechnung
{
    public partial class Form1 : Form
    {
        //Vordefinition Messages für die Ausgabe
        const string MESSAGE_idle = "Eigabe erwartet...";
        const string MESSAGE_correct = "Die Eingabe ist korrekt!";
        const string MESSAGE_wrong = "Die Eingabe ist inkorrekt, Berechnung nicht möglich!";
        const string MESSAGE_wrongIKNumber = "Die Prüfsummme der gegebenen IK war falsch.";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtBoxNumber.Text = string.Empty;
            lblResult.Text = MESSAGE_idle;
        }
        private int CalculateChecksum(string IKNumber)
        {
            int[] weights = { 7, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(IKNumber.ToString());
                sum += digit * weights[i];
            }

            int checksum = (11 - (sum % 11)) % 11;
            return checksum;
        }
        private void btnCalculateChecksum_Click(object sender, EventArgs e)
        {
            string IKNumber = txtBoxNumber.Text.Replace('.', ',');
            txtBoxNumber.Text = IKNumber;
            //string originalIKNumber = IKNumber;
            int checksum = 0;

            if (IKNumber.Length < 8 || IKNumber.Length > 9)
            {
                lblResult.Text = MESSAGE_wrong;
                return;
            }
            if (IKNumber.Length == 8)
            {
                string originalIKNumber = IKNumber.Remove(0, 1);
                checksum = CalculateChecksum(IKNumber);
                lblChecksum.Text = checksum.ToString();
                lblIKNumberComplete.Text = IKNumber + checksum.ToString();
                lblResult.Text = MESSAGE_correct;
            }
            else if (IKNumber.Length == 9)
            {
                string originalIKNumber2 = IKNumber.Remove(8);
                string originalIKNumber3 = originalIKNumber2.Remove(0, 1);
                checksum = CalculateChecksum(IKNumber);
                lblChecksum.Text = checksum.ToString();
                lblIKNumberComplete.Text = originalIKNumber2 + checksum.ToString();
                if (checksum != IKNumber[7])
                {
                    lblResult.Text = MESSAGE_wrongIKNumber;
                }
                else
                {
                    lblResult.Text = MESSAGE_correct;
                }
            }

            
            
        }

        private void btnClose_Click(object sender, EventArgs e) 
        { 
            Application.Exit();
        }
    }
}
