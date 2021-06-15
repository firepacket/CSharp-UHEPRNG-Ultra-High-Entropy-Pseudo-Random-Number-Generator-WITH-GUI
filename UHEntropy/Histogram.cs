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
    public partial class Histogram : Form
    {
        public Histogram(string str)
        {
            InitializeComponent();
            for (int i = 0; i < 94; i++)
            {
                if (i == 4)
                    continue;
                char chr = ((char)(33 + i));
                int c = str.Where(s => s == chr).Count();
                Panel p = new Panel();
                p.Width = 3;
                p.Padding = new Padding(0,3,0,0);
                p.Margin = new Padding(4,3,4,0);
                p.BackColor = Color.Green;
                p.Height = (int)Math.Round((flowBars.Height * 50) * (c/(double)str.Length),0);
                flowBars.Controls.Add(p);


                Label l = new Label();
                l.Padding = new Padding(1, 0, 1, 0);
                l.Margin = new Padding(2, 0, 0, 0);
                l.Font = new Font(FontFamily.GenericMonospace, 7f);
                l.Text = chr.ToString();
                l.AutoSize = true;
                //flowPAN.Controls.Add(l);
                flowBars.Controls.Add(l);
            }
            //this.Width = flowPAN.Size.Width;
        }
    }
}
