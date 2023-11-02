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
        const string MESSAGE_correct = "Die IK ist korrekt!";
        const string MESSAGE_wrong = "Die IK ist inkorrekt, Berechnung nicht möglich!";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtBoxNumber.Text = string.Empty;
            lblResult.Text = MESSAGE_idle;
        }

        private void btnCalculateChecksum_Click(object sender, EventArgs e)
        {
            string IKNumber = txtBoxNumber.Text.Replace('.', ',');
            txtBoxNumber.Text = IKNumber;

            
             if (IKNumber.Length == 8)
            {
                lblResult.Text = MESSAGE_correct;
            }
            else if (IKNumber.Length == 9)
            {
                lblResult.Text = MESSAGE_correct;
            }
            else
            {
                lblResult.Text = MESSAGE_wrong;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) 
        { 
            Application.Exit();
        }
    }
}
