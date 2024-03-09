using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugaslatihan
{
    public partial class Form1 : Form
    {
        Module obj = new Module();
        string[] nama = new string[3];
        double[] test = new double[3];
        double[] assigment = new double[3];
        double[] credit = new double[3];
        double[] grade_value = new double[3];
        double gpa;
        int i;

        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply_1(object sender, EventArgs e)
        {

        }

        private void e(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                obj.module_name = txtModule.Text;
                obj.module_test = Convert.ToDouble(nutest.Value);
                obj.assigment = Convert.ToDouble(nuassigment.Value);
                obj.credit_value = Convert.ToDouble(nucv.Value);


                if (obj.module_name == "")
                {
                    MessageBox.Show("Nama Module Test Tidak Boleh Kosong");
                }
                else
                {
               if(i < 3)
                {
                    nama[i] = obj.module_name;
                    test[i] = obj.module_test;
                    assigment[i] = obj.assigment;
                    credit[i] = obj.credit_value;

                    lbhasil.Text = obj.Calculate().ToString();
                    if (obj.result >= 80)
                    {
                        lbgrade.Text = "A";
                        obj.grade = "A";
                        grade_value[i] = 4;
                    }
                    else if (obj.result >= 70)
                    {
                        lbgrade.Text = "B";
                        obj.grade = "B";
                        grade_value[i] = 3;
                    }
                    else if (obj.result >= 60)
                    {
                        lbgrade.Text = "C";
                        obj.grade = "C";
                        grade_value[i] = 2;
                    }
                    else if (obj.result >= 50)
                    {
                        lbgrade.Text = "D";
                        obj.grade = "D";
                        grade_value[i] = 1;
                    }
                    else
                    {
                        lbgrade.Text = "E";
                        obj.grade = "E";
                        grade_value[i] = 0;
                    }

                    switch (obj.grade)
                    {
                        case "A":
                            MessageBox.Show("Mantap Bang");
                            break;
                        case "B":
                            MessageBox.Show("Boleh Juga");
                            break;
                        case "C":
                            MessageBox.Show("Lumayan Lahh");
                            break;
                        case "D":
                            MessageBox.Show("Duhhh");
                            break;
                        case "E":
                            MessageBox.Show("Belajar Lagi bang");
                            break;
                    }
                    i++;
                }
                else
                {
                    MessageBox.Show("Data Tidak Boleh Lebih Dari 3");
                }
            }   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gpa = getTotalGV() / getTotalCredit();
            MessageBox.Show("GPA : " + Math.Round(gpa, 2));
        }

        private double getTotalCredit()
        {
            double total =0;
            foreach (double C in credit)
            {
                total = total + C;
            }
            return total;
        }

        private double getTotalGV()
        {
            double total = 0;
            for(int j = 0; j < credit.Length; j ++)
            {
                total = total + (credit[j] * grade_value[j]);
            }
            return total;
        }

        private void nucv_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
