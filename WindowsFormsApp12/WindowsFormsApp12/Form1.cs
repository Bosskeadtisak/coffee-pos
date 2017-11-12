using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        string POS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void B (string Menu,string Bath)
        {
            string[] B = { Menu, Bath };
            var K = new ListViewItem(B);
            listView1.Items.Add(K);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            B ("ESSPRESSO(HOT)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            B("ESSPRESSO(ICE)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            B("ESSPRESSO(FRAPPE)", "50");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            B("AMRICANO(HOT)", "35");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            B("AMRICANO(ICE)", "45");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            B("LATTE(HOT)", "35");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            B("LATE(ICE)", "45");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            B("LATTE(FRAPPE)", "50");

        }

        private void button42_Click(object sender, EventArgs e)
        {
            B("MOCHA(HOT)", "35");

        }

        private void button41_Click(object sender, EventArgs e)
        {
            B("MOCHA(ICE)", "45");

        }

        private void button40_Click(object sender, EventArgs e)
        {
            B("MOCHA(FRAPPE)", "50");

        }

        private void button39_Click(object sender, EventArgs e)
        {
            B("CAPPUCCINO(HOT)", "35");

        }

        private void button38_Click(object sender, EventArgs e)
        {
            B("CAPPPUCCINO(HICE)", "45");

        }

        private void button37_Click(object sender, EventArgs e)
        {
            B("CAPPUCCINO(HOT)", "50");

        }

        private void button36_Click(object sender, EventArgs e)
        {
            B("GREEN TEA(HOT)", "20");

        }

        private void button35_Click(object sender, EventArgs e)
        {
            B("GREEN TEA(ICE)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            B("GREEN TEA(FRAPPE)", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            B("THAI TEA(HOT)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            B("THAI TEA(HOT)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            B("THAI TEA(FRAPPE)", "30");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            B("CO COA(HOT)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            B("CO COA (HOT)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            B("CO COA(FRAPPE)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            B("MILK(HOT)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            B("MILK(ICE)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            B("MILK(FRAPPR)", "30");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            B("MILK TEA(ICE)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            B("MILK(ICE)", "30");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            B("MILK TEA(ICE)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            B("MILK TEA(FRAPPPE)", "30");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            B("MILO(HOT)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            B("MILO(ICE)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            B("MILO(FRAPPE)", "30");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            B("NESCAFE(HOT)", "20");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            B("NESCAFE(ICE)", "25");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            B("NESCAFE(FRAPPE)", "30");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            B("NESTEA TEA(HOT)", "20");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            B("NESTEA TEA(ICE)", "25");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            B("NESTEA TEA(FRAPPE)", "30");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B("CATALUPE", "25");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            B("STRAWBERRY", "25");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B("BULEHAWAI", "25");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B("REA LIME SODA", "25");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            B("HONEY LIME SODA", "25");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            B("APPLE", "25");
        }
        double P;
        public string[] K()
        {
            P = 0;
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                P += double.Parse(listView1.Items[i].SubItems[1].Text);
                G[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label1.Text = P.ToString();
            return G;


        }
        public string[] M()
        {
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                G[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return G;
        }
        bool oh = false;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (oh == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                oh = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;
            if (listView1.Items.Count > 0)
                HA();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }
        public void HA()
        {
            string[] J = K();
            string[] b = M();
            string mu = "Coffee Pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string LOL = "Coffee Pos";
            LOL += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            LOL += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                LOL += J[i] + new String(' ', 20) + b[i] + "Bath" + "\r\n";

            }
            LOL += "\r\n";
            LOL += "Totle Price :" + label1.Text;
            System.IO.File.WriteAllText(POS + @"\" + mu + ".txt", LOL);
            textBox1.Text += LOL + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + POS + @"\" + mu + ".txt";

        }

        private void button49_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            oh = false;
            tabControl1.Controls.Remove(Payment);
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
