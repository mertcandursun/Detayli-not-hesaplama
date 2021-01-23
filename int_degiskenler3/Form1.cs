using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_degiskenler3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = "Bilgilendirme : 1.Not(Vize) yüzdesi %40, 2.Not(Final) yüzdesi %60 // Büt Final yerine geçer";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ders1Not3.Visible = true;
            label7.Visible = true;
            ders1Not2.Visible = false;
            if (checkBox1.Checked == false)
            {
                ders1Not3.Visible = false;
                label7.Visible = false;
                ders1Not2.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ders2Not3.Visible = true;
            label11.Visible = true;
            ders2Not2.Visible = false;
            if (checkBox2.Checked == false)
            {
                ders2Not3.Visible = false;
                label11.Visible = false;
                ders2Not2.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ders3Not3.Visible = true;
            label12.Visible = true;
            ders3Not2.Visible = false;
            if (checkBox3.Checked == false)
            {
                ders3Not3.Visible = false;
                label12.Visible = false;
                ders3Not2.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ders4Not3.Visible = true;
            label13.Visible = true;
            ders4Not2.Visible = false;
            if (checkBox4.Checked == false)
            {
                ders4Not3.Visible = false;
                label13.Visible = false;
                ders4Not2.Visible = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ders5Not3.Visible = true;
            label14.Visible = true;
            ders5Not2.Visible = false;
            if (checkBox5.Checked == false)
            {
                ders5Not3.Visible = false;
                label14.Visible = false;
                ders5Not2.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 87-100 AA
             * 81-87 BA
             * 74-80 BB
             * 67-73 CB
             * 60-66 CC
             * 53-59 DC
             * 46-52 DD
             * 39-45 FD
             * 0-38  FF
             */
            

            string ders1Harf, ders2Harf, ders3Harf, ders4Harf, ders5Harf;

            double 
            ders1Ort, ders2Ort, ders3Ort, ders4Ort,ders5Ort,
            ders1Vize,ders1Final,ders2Vize,
            ders2Final,ders3Vize,ders3Final,
            ders4Vize,ders4Final,ders5Vize,ders5Final;


            ders1Vize = Convert.ToDouble(ders1Not1.Text);
                if (checkBox1.Checked == true)
                {
                    ders1Final = Convert.ToDouble(ders1Not3.Text);
                    ders1Ort = ders1Vize * 0.4 + Convert.ToDouble(ders1Not3.Text) * 0.6;
                    if (ders1Ort >= 87)
                    {
                        ders1Harf = "AA";
                    }
                    else if (ders1Ort >= 81 && ders1Ort <= 86)
                    {
                        ders1Harf = "BA";
                    }
                    else if (ders1Ort >= 74 && ders1Ort <= 80)
                    {
                        ders1Harf = "BB";
                    }
                    else if (ders1Ort >= 67 && ders1Ort <= 73)
                    {
                        ders1Harf = "CB";
                    }
                    else if (ders1Ort >= 60 && ders1Ort <= 66)
                    {
                        ders1Harf = "CC";
                    }
                    else if (ders1Ort >= 53 && ders1Ort <= 59)
                    {
                        ders1Harf = "DC";
                    }
                    else if (ders1Ort >= 46 && ders1Ort <= 52)
                    {
                        ders1Harf = "DD";
                    }
                    else if (ders1Ort >= 39 && ders1Ort <= 45)
                    {
                        ders1Harf = "FD";
                    }
                    else if (ders1Ort <= 38)
                    {
                        ders1Harf = "FF";
                    }
                    
                }
                else
                { 
                    ders1Final = Convert.ToDouble(ders1Not2.Text);
                    ders1Ort = ders1Vize * 0.4 + Convert.ToDouble(ders1Not2.Text) * 0.6;
                        if (ders1Ort >= 87)
                        {
                            ders1Harf = "AA";
                        }
                        else if (ders1Ort >= 81 && ders1Ort <= 86)
                        {
                            ders1Harf = "BA";
                        }
                        else if (ders1Ort >= 74 && ders1Ort <= 80)
                        {
                            ders1Harf = "BB";
                        }
                        else if (ders1Ort >= 67 && ders1Ort <= 73)
                        {
                            ders1Harf = "CB";
                        }
                        else if (ders1Ort >= 60 && ders1Ort <= 66)
                        {
                            ders1Harf = "CC";
                        }
                        else if (ders1Ort >= 53 && ders1Ort <= 59)
                        {
                            ders1Harf = "DC";
                        }
                        else if (ders1Ort >= 46 && ders1Ort <= 52)
                        {
                            ders1Harf = "DD";
                        }
                        else if (ders1Ort >= 39 && ders1Ort <= 45)
                        {
                            ders1Harf = "FD";
                        }
                        else if (ders1Ort <= 38)
                        {
                            ders1Harf = "FF";
                        }

                }
                listBox1.Items.Add($"1.Ders Ortalaması : {ders1Ort}");
                


            ders2Vize = Convert.ToDouble(ders2Not1.Text);
                if (checkBox2.Checked == true)
                {
                    ders2Final = Convert.ToDouble(ders2Not3.Text);
                    ders2Ort = ders2Vize * 0.4 + Convert.ToDouble(ders2Not3.Text) * 0.6;
                }
                else
                {
                    ders2Final = Convert.ToDouble(ders2Not2.Text);
                    ders2Ort = ders2Vize * 0.4 + Convert.ToDouble(ders2Not2.Text) * 0.6;
                }

            listBox1.Items.Add($"2.Ders Ortalaması {ders2Ort}");

            ders3Vize = Convert.ToDouble(ders3Not1.Text);
                if (checkBox3.Checked == true)
                {  
                    ders3Final = Convert.ToDouble(ders3Not3.Text);
                    ders3Ort = ders3Vize * 0.4 + ders3Final * 0.6;
                }
                else
                {
                    ders3Final = Convert.ToDouble(ders3Not2.Text);
                    ders3Ort = ders3Final * 0.4 + ders3Final * 0.6;
                }

                listBox1.Items.Add($"3.Ders Ortalaması : {ders3Ort}");

                ders4Vize = Convert.ToDouble(ders4Not1.Text);
                if (checkBox4.Checked == true)
                {
                    ders4Final = Convert.ToDouble(ders4Not3.Text);
                    ders4Ort = ders4Vize * 0.4 + ders4Final * 0.6;
                }
                else
                {
                    ders4Final = Convert.ToDouble(ders4Not2.Text);
                    ders4Ort = ders4Vize * 0.4 + ders4Final * 0.6;
                }

                listBox1.Items.Add($"4.Ders Ortalaması : {ders4Ort}");

                ders5Vize = Convert.ToDouble(ders5Not1.Text);
                if (checkBox5.Checked == true)
                {
                    ders5Final = Convert.ToDouble(ders5Not3.Text);
                    ders5Ort = ders5Vize * 0.4 + ders5Final * 0.6;
                }
                else
                {
                    ders5Final = Convert.ToDouble(ders5Not2.Text);
                    ders5Ort = ders5Vize * 0.4 + ders5Final * 0.6;
                }

                listBox1.Items.Add($"5.Ders Ortalaması : {ders5Ort}");
        }

        private void ders1Not1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
