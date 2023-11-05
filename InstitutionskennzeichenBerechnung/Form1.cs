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
        private int CalculateChecksum8(string originalIKNumber)
        {

            int sum = 0;
            for (int i = 0; i < originalIKNumber.Length; i++)
            {
                if (i % 2 == 0)  // Jede ungerade Stelle von rechts nach links
                {
                    sum += int.Parse(originalIKNumber[i].ToString());
                }
                else
                {
                    int digit = int.Parse(originalIKNumber[i].ToString()) * 2;
                    sum += digit > 9 ? digit - 9 : digit;
                }
            }

            int checksum = (10 - (sum % 10)) % 10;
            return checksum;
        }
        private int CalculateChecksum9(string originalIKNumber3)
        {

            int sum = 0;
            for (int i = 0; i < originalIKNumber3.Length; i++)
            {
                if (i % 2 == 0)  // Jede ungerade Stelle von rechts nach links
                {
                    sum += int.Parse(originalIKNumber3[i].ToString());
                }
                else
                {
                    int digit = int.Parse(originalIKNumber3[i].ToString()) * 2;
                    sum += digit > 9 ? digit - 9 : digit;
                }
            }

            int checksum = (10 - (sum % 10)) % 10;
            return checksum;
        }
        private void btnCalculateChecksum_Click(object sender, EventArgs e)
        {
            string IKNumber = txtBoxNumber.Text.Replace('.', ',');
            txtBoxNumber.Text = IKNumber;
            int checksum = 0;

            if (IKNumber.Length < 8 || IKNumber.Length > 9)
            {
                lblResult.Text = MESSAGE_wrong;
                return;
            }
            if (IKNumber.Length == 8)
            {
                string originalIKNumber = IKNumber.Remove(0, 1);
                checksum = CalculateChecksum8(originalIKNumber);
                lblChecksum.Text = checksum.ToString();
                lblIKNumberComplete.Text = IKNumber + checksum.ToString();
                lblResult.Text = MESSAGE_correct;
            }
            else if (IKNumber.Length == 9)
            {
                string originalIKNumber2 = IKNumber.Remove(8);
                string originalIKNumber3 = originalIKNumber2.Remove(0, 1);
                checksum = CalculateChecksum9(originalIKNumber3);
                lblChecksum.Text = checksum.ToString();
                lblIKNumberComplete.Text = originalIKNumber2 + checksum.ToString();
                if (IKNumber[8] == checksum)
                {
                    lblResult.Text = MESSAGE_correct;
                }
                else
                {
                    lblResult.Text = MESSAGE_wrongIKNumber;
                }
            }

            
            
        }

        private void btnClose_Click(object sender, EventArgs e) 
        { 
            Application.Exit();
        }
    }
}
