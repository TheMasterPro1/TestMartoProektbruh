using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartoZadachkusBruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                label1.Visible = false;
                textBox1.Visible = false;
                BackColor = Color.YellowGreen;
                var box = MessageBox.Show($"Намислих си число (1-{num}). Готов ли си да го познаеш?", "Компа пита", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                CreateLBL();
                button1.Visible = false;
                TextBox textBox = new TextBox();
                this.Controls.Add(textBox);
                textBox.Top = distanceU * 87;
                textBox.Left = distanceU * 415;
                distanceU++;
                textBox.Size = new Size(54, 20);
                textBox.Location = new Point(423, 76);
                textBox.Text = null;
                button2.Visible = true;
                textBox.Visible = false;
                textBox2.Visible = true;
                label2.Text = rnd.Next(num).ToString();
            }
            catch (Exception)
            {

            }

        }
        int distanceU = 1;
        public void CreateLBL()
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.Top = distanceU * 87;
            lbl.Left = distanceU * 415;
            distanceU++;
            lbl.ForeColor = Color.Coral;
            lbl.BackColor = Color.SteelBlue;
            lbl.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
            lbl.Text = "Познай числото:";
            lbl.Size = new Size(250, 50);
            lbl.Location = new Point(113, 72);
        }
        int n = 10;
        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                var box = MessageBox.Show($"Ne pozna", "Компа kazva", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            if (textBox2.Text == label2.Text)
            {
                label1.Text = "Позна";
                label1.Visible = true;
                
            }
            else if (int.Parse(textBox2.Text) > int.Parse(label2.Text))
            {
                n--;
                label1.Text = $"надолу, оставащи опити {n}";
                label1.Visible = true;                              
            }
            else
            {
                n--;
                label1.Text = $"нагоре, оставащи опити {n}";
                label1.Visible = true;                
            }
        }
    }
}

