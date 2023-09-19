using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1
{
    public partial class Form1 : Form, IView
    {

        public string imya
        {
            get { return textBox1.Text.Trim(); }
            set { textBox1.Text = value; }
        }
        public string vozrast
        {
            get { return textBox2.Text.Trim(); }
            set { textBox2.Text = value; }
        }
        public string poisk
        {
            get { return textBox3.Text.Trim(); }
            set { textBox3.Text = value; }
        }
        public string rezon
        {
            set 
            {
                listBox1.Items.Clear();
                List<string> list = new List<string>(value.Split('\n'));
                foreach (string l in list)
                {
                    listBox1.Items.Add(l);
                }
            }
        }

        public event EventHandler<EventArgs> EventLoad;
        public event EventHandler<EventArgs> EventSave;
        public event EventHandler<EventArgs> EventSearch;

  
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length > 0 && textBox2.Text.Length > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EventSave?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EventLoad?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = textBox3.Text.Length > 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EventSearch?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
