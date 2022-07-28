using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio_Motivacional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string DataAgora = DateTime.Now.ToString("HH:mm");
            var dateTime = DateTime.Parse(DataAgora);
            textBox1.Text = DataAgora;

            DateTime hour1 = new DateTime(0, 0);
            DateTime hour2 = new DateTime(12, 0);
            DateTime hour3 = new DateTime(18, 0);

            if (dateTime >= hour1)
            {
                richTextBox1.Text = "Bom dia! Eu quero estar apto a olhar para trás e dizer, ‘Eu fiz tudo o que podia, e fui bem sucedido.’ Eu não quero olhar para trás e dizer que deveria ter feito isso ou aquilo. Michael Phelps";
            }
            else
            if (dateTime >= hour2 && dateTime <= hour3)
            {
                richTextBox1.Text = "Boa Tarde! Não existem atalhos – tudo é repetição, repetição, repetição.";
            }
            else
            {
                richTextBox1.Text = "Boa Noite! Sejam fortes e corajosos, todos vocês que esperam no Senhor.Salmos 31:24";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
