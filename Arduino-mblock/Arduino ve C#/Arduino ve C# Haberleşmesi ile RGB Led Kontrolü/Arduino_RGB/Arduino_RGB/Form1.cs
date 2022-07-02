using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_RGB
{
    public partial class Form1 : Form
    {
        SerialPort SerialPort = new SerialPort();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SetColor(Color color)
        {
            try
            {
                panel1.BackColor = color;   //Panel rengini ayarla
                label1.Text = "R = " + color.R.ToString();  //Rengin R değerini yazdır
                label2.Text = "G = " + color.G.ToString();  //Rengin G değerini yazdır
                label3.Text = "B = " + color.B.ToString();  //Rengin B değerini yazdır
                R.Value = color.R;     //TrackBar 1 isimlere dikkat edin
                G.Value = color.G;     //TrackBar 2
                B.Value = color.B;     //TrackBar 3
                SerialPort.Write(new[] { color.R, color.G, color.B }, 0, 3);  //Rengin RGB değerlerini porta gönder
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata"); //Hata mesajı
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
                        foreach (string port in ports)
                            comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
        }

        private void button18_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();    //Renk paletini aç
            SetColor(colorDialog1.Color); //Rengi renk paletinde seçilen olarak ayarla
        }


        private void RED_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);         //Rengi Red olarak ayarla
        }

        private void LİME_Click(object sender, EventArgs e)
        {
            SetColor(Color.Lime);        //Rengi Lime olarak ayarla
        }

        private void BLUE_Click(object sender, EventArgs e)
        {
            SetColor(Color.Blue);      //Rengi Blue olarak ayarla
        }

        private void PURPLE_Click(object sender, EventArgs e)
        {
            SetColor(Color.Purple);      //Rengi Purple olarak ayarla
        }

        private void YELLOW_Click(object sender, EventArgs e)
        {
            SetColor(Color.Yellow);      //Rengi Yellow olarak ayarla
        }

        private void FUCHSİA_Click(object sender, EventArgs e)
        {
            SetColor(Color.Magenta);     //Rengi magenta olarak ayarla
        }

        private void CYAN_Click(object sender, EventArgs e)
        {
            SetColor(Color.Cyan);        //Rengi cyan olarak ayarla
        }

        private void WHİTE_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);       //Rengi White olarak ayarla
        }

        private void DARKORENGE_Click(object sender, EventArgs e)
        {
            SetColor(Color.Orange);      //Rengi Orange olarak ayarla
        }

        private void TAN_Click(object sender, EventArgs e)
        {
            SetColor(Color.Tan);      //Rengi Tan olarak ayarla
        }

        private void BLACK_Click(object sender, EventArgs e)
        {
            SetColor(Color.Black);      //Rengi Black olarak ayarla
        }

        private void VİOLET_Click(object sender, EventArgs e)
        {
            SetColor(Color.Violet);      //Rengi Violet olarak ayarla
        }


        private void R_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));   //RGB Renk ayarı
        }

        private void G_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value)); //RGB Renk ayarı
        }

        private void B_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value)); //RGB Renk ayarı
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SerialPort.IsOpen)
                {
                    SerialPort.PortName = comboBox1.Text; //Port ismini comboBox1'den al
                    SerialPort.BaudRate = 9600;           //BaudRate'i 9600 olarak ayarla
                    SerialPort.Open();                    //Seri portu aç
                    button.Text = "KES";                 //Buton2 yazısını değiştir
                }
                else
                {

                    SetColor(Color.Black);                //Rengi siyah olarak ayarla
                    button.Text = "BAĞLAN";              //Buton2 yazısını değiştir
                    SerialPort.Close();                   //Seri portu kapa

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");      //Hata mesajı
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SerialPort.IsOpen) SerialPort.Close();    //Seri port açıksa kapat
        }



                                 private void panel1_Paint(object sender, PaintEventArgs e)
                                                {

                                                }


    }
}
