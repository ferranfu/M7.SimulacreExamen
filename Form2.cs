using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form2 : Form
    {
        private string paraula;
        private int probes = 1;
        char[] letras;
        private bool encertat = false;
        private int errors = 0;
        ArrayList arrayErrors = new ArrayList();

        public Form2(string paraula)
        {
            InitializeComponent();


            letras = paraula.ToCharArray();


            for (int i = 1; i <= 26; i++)
            {
                string buttonName = "button" + i.ToString();
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                button.Click += new EventHandler(afegir_text);
            }

        }

        public void afegir_text(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;
            textBox31.Text += text;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }








        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

       

        private void button26_Click_1(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        { 
                string textoActual = textBox31.Text;
                if (!string.IsNullOrEmpty(textoActual))
                {
                    StringBuilder sb = new StringBuilder(textoActual);
                    sb.Remove(sb.Length - 1, 1);
                    textBox31.Text = sb.ToString();
                }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if ((textBox31.Text != "") && (textBox31.Text.Length == 5))
            {
                char[] enviat = textBox31.Text.ToCharArray();

                if (textBox31.Text == paraula)
                {
                    MessageBox.Show("CORRECTE!", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {

                        string nomtextbox = "TextBox" + probes.ToString();
                        Control[] controls = this.Controls.Find(nomtextbox, true);

                        if (controls.Length > 0 && controls[0] is TextBox)
                        {
                            Color color = Color.Gray; // color de fuente predeterminado
                            TextBox textBox = (TextBox)controls[0];
                            textBox.Text = new string(enviat[i], 1);

                            for (int j = 0; j < 5; j++)
                            {
                                if (letras[i] == enviat[j])
                                {
                                    if (i == j)
                                    {
                                        color = Color.Green;
                                    }
                                    else
                                    {
                                        if (color == Color.Green)
                                        {

                                        }
                                        else
                                        {
                                            color = Color.Yellow;
                                        }
                                    }
                                }
                                else
                                {
                                }
                            }

                            textBox.ForeColor = color; // establecer el color de fuente del cuadro de texto correspondiente
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado el control " + nomtextbox, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        probes++;
                    }
                }
            }
            else
            {
                MessageBox.Show("No has introduit una paraula o aquesta no te 5 lletres", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
