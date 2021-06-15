using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace UHEntropy
{
    public partial class DelimitForm : Form
    {
        string[] Nums;
        public DelimitForm(string[] nums)
        {
            Nums = nums;
            InitializeComponent();
        }
        string Delimit<T>(T[] array, string delimiter)
        {
            //if (array is string[])
            //    return String.Join(delimiter, array as string[]);
            List<string> strings = new List<string>();
            foreach (T item in array)
                strings.Add(item.ToString().Trim());
            return String.Join(delimiter, strings.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        File.Delete(sfd.FileName);
                    File.AppendAllText(sfd.FileName, Delimit<string>(Nums, textBox1.Text));
                }
                
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        File.Delete(sfd.FileName);
                    File.AppendAllText(sfd.FileName, Delimit<string>(Nums, Environment.NewLine));
                }

            }
            this.Close();
        }
    }
}
