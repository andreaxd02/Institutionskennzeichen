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
        const string MESSAGE_checksum = "Die Prüfziffer ist...";
        const string MESSAGE_completeNumber = "Die komplette Nummer ist...";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtBoxNumber.Text = string.Empty;
            lblResult.Text = MESSAGE_idle;
        }
        private int calculateChecksum(string IKNumber)
        {
            
        }
        private void btnCalculateChecksum_Click(object sender, EventArgs e)
        {
            string IKNumber = txtBoxNumber.Text.Replace('.', ',');
            txtBoxNumber.Text = IKNumber;
            string originalIKNumber = IKNumber;
            int checksum = 0;

            if (IKNumber.Length < 8 || IKNumber.Length > 9)
            {
                lblResult.Text = MESSAGE_wrong;
                return;
            }
            IKNumber = IKNumber.Remove(1, 2);
            if(IKNumber.Length == 7)
            {
               IKNumber = IKNumber.Remove(7);
            }

            checksum = calculateChecksum(IKNumber);
            lblChecksum.Text = checksum.ToString();
            lblIKNumberComplete.Text = originalIKNumber + checksum.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e) 
        { 
            Application.Exit();
        }
    }
}
