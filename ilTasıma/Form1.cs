using System;
using System.Windows.Forms;

namespace IlAdiTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIlAdi.Text))
            {
                listBox1.Items.Add(txtIlAdi.Text); 
                txtIlAdi.Clear();                  
            }
        }

        private void btnSagaTasi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem); 
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnSolaTasi_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem); 
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
