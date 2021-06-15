namespace UHEntropy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gobtn = new System.Windows.Forms.Button();
            this.rangeNUD = new System.Windows.Forms.NumericUpDown();
            this.countNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateBTN = new System.Windows.Forms.Button();
            this.randLB = new System.Windows.Forms.ListBox();
            this.exportNumsCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exportTextCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charlbl = new System.Windows.Forms.Label();
            this.lengthNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.histBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rangeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
            this.exportNumsCMS.SuspendLayout();
            this.exportTextCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(171, 2);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(453, 354);
            this.textBox1.TabIndex = 0;
            // 
            // Gobtn
            // 
            this.Gobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gobtn.Location = new System.Drawing.Point(544, 362);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(75, 39);
            this.Gobtn.TabIndex = 1;
            this.Gobtn.Text = "Go";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Gobtn_Click);
            // 
            // rangeNUD
            // 
            this.rangeNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeNUD.Location = new System.Drawing.Point(53, 306);
            this.rangeNUD.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.rangeNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rangeNUD.Name = "rangeNUD";
            this.rangeNUD.Size = new System.Drawing.Size(112, 22);
            this.rangeNUD.TabIndex = 2;
            this.rangeNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rangeNUD.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // countNUD
            // 
            this.countNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countNUD.Location = new System.Drawing.Point(53, 334);
            this.countNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.countNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNUD.Name = "countNUD";
            this.countNUD.Size = new System.Drawing.Size(112, 22);
            this.countNUD.TabIndex = 3;
            this.countNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countNUD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Range:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count:";
            // 
            // generateBTN
            // 
            this.generateBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateBTN.Location = new System.Drawing.Point(7, 362);
            this.generateBTN.Name = "generateBTN";
            this.generateBTN.Size = new System.Drawing.Size(82, 39);
            this.generateBTN.TabIndex = 6;
            this.generateBTN.Text = "Generate";
            this.generateBTN.UseVisualStyleBackColor = true;
            this.generateBTN.Click += new System.EventHandler(this.generateBTN_Click);
            // 
            // randLB
            // 
            this.randLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randLB.ColumnWidth = 10;
            this.randLB.ContextMenuStrip = this.exportNumsCMS;
            this.randLB.FormattingEnabled = true;
            this.randLB.ItemHeight = 16;
            this.randLB.Location = new System.Drawing.Point(1, 2);
            this.randLB.Name = "randLB";
            this.randLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.randLB.Size = new System.Drawing.Size(164, 288);
            this.randLB.TabIndex = 7;
            // 
            // exportNumsCMS
            // 
            this.exportNumsCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.exportNumsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportNumbersToolStripMenuItem});
            this.exportNumsCMS.Name = "exportNumsCMS";
            this.exportNumsCMS.Size = new System.Drawing.Size(186, 28);
            // 
            // exportNumbersToolStripMenuItem
            // 
            this.exportNumbersToolStripMenuItem.Name = "exportNumbersToolStripMenuItem";
            this.exportNumbersToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.exportNumbersToolStripMenuItem.Text = "Export Numbers";
            this.exportNumbersToolStripMenuItem.Click += new System.EventHandler(this.exportNumbersToolStripMenuItem_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBTN.Location = new System.Drawing.Point(92, 362);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(55, 39);
            this.clearBTN.TabIndex = 8;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exportTextCMS
            // 
            this.exportTextCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.exportTextCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTextToolStripMenuItem});
            this.exportTextCMS.Name = "exportTextCMS";
            this.exportTextCMS.Size = new System.Drawing.Size(153, 28);
            // 
            // exportTextToolStripMenuItem
            // 
            this.exportTextToolStripMenuItem.Name = "exportTextToolStripMenuItem";
            this.exportTextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exportTextToolStripMenuItem.Text = "Export Text";
            // 
            // charlbl
            // 
            this.charlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charlbl.Location = new System.Drawing.Point(215, 371);
            this.charlbl.Name = "charlbl";
            this.charlbl.Size = new System.Drawing.Size(126, 23);
            this.charlbl.TabIndex = 9;
            this.charlbl.Text = "Chars: 0";
            this.charlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengthNUD
            // 
            this.lengthNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthNUD.Location = new System.Drawing.Point(395, 371);
            this.lengthNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lengthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNUD.Name = "lengthNUD";
            this.lengthNUD.Size = new System.Drawing.Size(84, 22);
            this.lengthNUD.TabIndex = 10;
            this.lengthNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthNUD.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Length:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Save Random Numbers";
            // 
            // histBTN
            // 
            this.histBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.histBTN.Image = global::UHEntropy.Properties.Resources.imageres_6125;
            this.histBTN.Location = new System.Drawing.Point(156, 364);
            this.histBTN.Name = "histBTN";
            this.histBTN.Size = new System.Drawing.Size(53, 37);
            this.histBTN.TabIndex = 12;
            this.histBTN.Text = "?";
            this.histBTN.UseVisualStyleBackColor = true;
            this.histBTN.Click += new System.EventHandler(this.histBTN_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(483, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.histBTN);
            this.Controls.Add(this.lengthNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.charlbl);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.countNUD);
            this.Controls.Add(this.rangeNUD);
            this.Controls.Add(this.randLB);
            this.Controls.Add(this.generateBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gobtn);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ultra High Entropy PRNG C# Demo";
            ((System.ComponentModel.ISupportInitialize)(this.rangeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
            this.exportNumsCMS.ResumeLayout(false);
            this.exportTextCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.NumericUpDown rangeNUD;
        private System.Windows.Forms.NumericUpDown countNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateBTN;
        private System.Windows.Forms.ListBox randLB;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.ContextMenuStrip exportNumsCMS;
        private System.Windows.Forms.ToolStripMenuItem exportNumbersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip exportTextCMS;
        private System.Windows.Forms.ToolStripMenuItem exportTextToolStripMenuItem;
        private System.Windows.Forms.Label charlbl;
        private System.Windows.Forms.NumericUpDown lengthNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button histBTN;
        private System.Windows.Forms.Button button1;
    }
}

