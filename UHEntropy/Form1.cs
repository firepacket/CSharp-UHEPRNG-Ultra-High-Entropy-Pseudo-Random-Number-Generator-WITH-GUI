using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHEntropy
{
    public partial class Form1 : Form
    {
        double chars = 0;
        UltraHighEntropyPrng rng = new UltraHighEntropyPrng();
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            rng.InitState();
            rng.AddEntropy();
            rng.RandomString(2560*100); // Priming the engine?
        }

        private void Gobtn_Click(object sender, EventArgs e)
        {
            int n = (int)lengthNUD.Value;
            rng.AddEntropy();
            var prngState = rng.RandomString(n);    // obtain random printable characters
            chars += n;
            textBox1.AppendText(prngState);	          // display the updated result in the form
            charlbl.Text = "Chars: " + FormatNumber(chars);
           
        }

        string FormatNumber(double amount)
        {
            string samount = amount.ToString();
            StringBuilder sb = new StringBuilder(samount);
            if (amount.ToString().Length > 3)
                for (int i = samount.Length - 3; i > 0; i -= 3)
                    sb.Insert(i, ",");
            return sb.ToString();
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countNUD.Value; i++)
                randLB.Items.Add("      " + rng.Random((int)rangeNUD.Value));
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            randLB.Items.Clear();
        }

        private void exportNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
           
            foreach (var v in randLB.Items)
                l.Add(v.ToString());
            DelimitForm df = new DelimitForm(l.ToArray());

            df.ShowDialog();
        }

        private void histBTN_Click(object sender, EventArgs e)
        {
            Histogram h = new Histogram(textBox1.Text);
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            charlbl.Text = "Chars: 0";
            chars = 0;
        }
    }
}
