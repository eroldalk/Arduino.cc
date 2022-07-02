namespace Arduino_RGB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.VİOLET = new System.Windows.Forms.Button();
            this.BLACK = new System.Windows.Forms.Button();
            this.TAN = new System.Windows.Forms.Button();
            this.DARKORENGE = new System.Windows.Forms.Button();
            this.WHİTE = new System.Windows.Forms.Button();
            this.CYAN = new System.Windows.Forms.Button();
            this.FUCHSİA = new System.Windows.Forms.Button();
            this.YELLOW = new System.Windows.Forms.Button();
            this.PURPLE = new System.Windows.Forms.Button();
            this.BLUE = new System.Windows.Forms.Button();
            this.LİME = new System.Windows.Forms.Button();
            this.RED = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.R = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.TrackBar();
            this.B = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(365, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 265);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.VİOLET);
            this.panel2.Controls.Add(this.BLACK);
            this.panel2.Controls.Add(this.TAN);
            this.panel2.Controls.Add(this.DARKORENGE);
            this.panel2.Controls.Add(this.WHİTE);
            this.panel2.Controls.Add(this.CYAN);
            this.panel2.Controls.Add(this.FUCHSİA);
            this.panel2.Controls.Add(this.YELLOW);
            this.panel2.Controls.Add(this.PURPLE);
            this.panel2.Controls.Add(this.BLUE);
            this.panel2.Controls.Add(this.LİME);
            this.panel2.Controls.Add(this.RED);
            this.panel2.Location = new System.Drawing.Point(37, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 265);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(68, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Renk Paleti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button18_Click);
            // 
            // VİOLET
            // 
            this.VİOLET.BackColor = System.Drawing.Color.Violet;
            this.VİOLET.Location = new System.Drawing.Point(247, 125);
            this.VİOLET.Name = "VİOLET";
            this.VİOLET.Size = new System.Drawing.Size(53, 43);
            this.VİOLET.TabIndex = 24;
            this.VİOLET.UseVisualStyleBackColor = false;
            this.VİOLET.Click += new System.EventHandler(this.VİOLET_Click);
            // 
            // BLACK
            // 
            this.BLACK.BackColor = System.Drawing.Color.Black;
            this.BLACK.Location = new System.Drawing.Point(176, 125);
            this.BLACK.Name = "BLACK";
            this.BLACK.Size = new System.Drawing.Size(53, 43);
            this.BLACK.TabIndex = 23;
            this.BLACK.UseVisualStyleBackColor = false;
            this.BLACK.Click += new System.EventHandler(this.BLACK_Click);
            // 
            // TAN
            // 
            this.TAN.BackColor = System.Drawing.Color.Tan;
            this.TAN.Location = new System.Drawing.Point(108, 125);
            this.TAN.Name = "TAN";
            this.TAN.Size = new System.Drawing.Size(53, 43);
            this.TAN.TabIndex = 22;
            this.TAN.UseVisualStyleBackColor = false;
            this.TAN.Click += new System.EventHandler(this.TAN_Click);
            // 
            // DARKORENGE
            // 
            this.DARKORENGE.BackColor = System.Drawing.Color.DarkOrange;
            this.DARKORENGE.Location = new System.Drawing.Point(40, 125);
            this.DARKORENGE.Name = "DARKORENGE";
            this.DARKORENGE.Size = new System.Drawing.Size(53, 43);
            this.DARKORENGE.TabIndex = 21;
            this.DARKORENGE.UseVisualStyleBackColor = false;
            this.DARKORENGE.Click += new System.EventHandler(this.DARKORENGE_Click);
            // 
            // WHİTE
            // 
            this.WHİTE.BackColor = System.Drawing.Color.White;
            this.WHİTE.Location = new System.Drawing.Point(247, 76);
            this.WHİTE.Name = "WHİTE";
            this.WHİTE.Size = new System.Drawing.Size(53, 43);
            this.WHİTE.TabIndex = 20;
            this.WHİTE.UseVisualStyleBackColor = false;
            this.WHİTE.Click += new System.EventHandler(this.WHİTE_Click);
            // 
            // CYAN
            // 
            this.CYAN.BackColor = System.Drawing.Color.Cyan;
            this.CYAN.Location = new System.Drawing.Point(176, 76);
            this.CYAN.Name = "CYAN";
            this.CYAN.Size = new System.Drawing.Size(53, 43);
            this.CYAN.TabIndex = 19;
            this.CYAN.UseVisualStyleBackColor = false;
            this.CYAN.Click += new System.EventHandler(this.CYAN_Click);
            // 
            // FUCHSİA
            // 
            this.FUCHSİA.BackColor = System.Drawing.Color.Fuchsia;
            this.FUCHSİA.Location = new System.Drawing.Point(108, 76);
            this.FUCHSİA.Name = "FUCHSİA";
            this.FUCHSİA.Size = new System.Drawing.Size(53, 43);
            this.FUCHSİA.TabIndex = 18;
            this.FUCHSİA.UseVisualStyleBackColor = false;
            this.FUCHSİA.Click += new System.EventHandler(this.FUCHSİA_Click);
            // 
            // YELLOW
            // 
            this.YELLOW.BackColor = System.Drawing.Color.Yellow;
            this.YELLOW.Location = new System.Drawing.Point(40, 76);
            this.YELLOW.Name = "YELLOW";
            this.YELLOW.Size = new System.Drawing.Size(53, 43);
            this.YELLOW.TabIndex = 17;
            this.YELLOW.UseVisualStyleBackColor = false;
            this.YELLOW.Click += new System.EventHandler(this.YELLOW_Click);
            // 
            // PURPLE
            // 
            this.PURPLE.BackColor = System.Drawing.Color.Purple;
            this.PURPLE.Location = new System.Drawing.Point(247, 27);
            this.PURPLE.Name = "PURPLE";
            this.PURPLE.Size = new System.Drawing.Size(53, 43);
            this.PURPLE.TabIndex = 16;
            this.PURPLE.UseVisualStyleBackColor = false;
            this.PURPLE.Click += new System.EventHandler(this.PURPLE_Click);
            // 
            // BLUE
            // 
            this.BLUE.BackColor = System.Drawing.Color.Blue;
            this.BLUE.Location = new System.Drawing.Point(176, 27);
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(53, 43);
            this.BLUE.TabIndex = 15;
            this.BLUE.UseVisualStyleBackColor = false;
            this.BLUE.Click += new System.EventHandler(this.BLUE_Click);
            // 
            // LİME
            // 
            this.LİME.BackColor = System.Drawing.Color.Lime;
            this.LİME.Location = new System.Drawing.Point(108, 27);
            this.LİME.Name = "LİME";
            this.LİME.Size = new System.Drawing.Size(53, 43);
            this.LİME.TabIndex = 14;
            this.LİME.UseVisualStyleBackColor = false;
            this.LİME.Click += new System.EventHandler(this.LİME_Click);
            // 
            // RED
            // 
            this.RED.BackColor = System.Drawing.Color.Red;
            this.RED.Location = new System.Drawing.Point(40, 27);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(53, 43);
            this.RED.TabIndex = 13;
            this.RED.UseVisualStyleBackColor = false;
            this.RED.Click += new System.EventHandler(this.RED_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Lime;
            this.button.Location = new System.Drawing.Point(64, 61);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(97, 24);
            this.button.TabIndex = 2;
            this.button.Text = "Bağlan";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(37, 408);
            this.R.Maximum = 255;
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(173, 56);
            this.R.TabIndex = 4;
            this.R.Scroll += new System.EventHandler(this.R_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(125, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(435, 46);
            this.label.TabIndex = 7;
            this.label.Text = "RGB RENKLENDİRME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(269, 408);
            this.G.Maximum = 255;
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(173, 56);
            this.G.TabIndex = 11;
            this.G.Scroll += new System.EventHandler(this.G_Scroll);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(501, 408);
            this.B.Maximum = 255;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(173, 56);
            this.B.TabIndex = 12;
            this.B.Scroll += new System.EventHandler(this.B_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(304, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(546, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(719, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.R);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RGB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RED;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar R;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar G;
        private System.Windows.Forms.TrackBar B;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VİOLET;
        private System.Windows.Forms.Button BLACK;
        private System.Windows.Forms.Button TAN;
        private System.Windows.Forms.Button DARKORENGE;
        private System.Windows.Forms.Button WHİTE;
        private System.Windows.Forms.Button CYAN;
        private System.Windows.Forms.Button FUCHSİA;
        private System.Windows.Forms.Button YELLOW;
        private System.Windows.Forms.Button PURPLE;
        private System.Windows.Forms.Button BLUE;
        private System.Windows.Forms.Button LİME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

