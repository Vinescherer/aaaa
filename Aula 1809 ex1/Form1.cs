using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aula_1809_ex1
{
    public partial class Form1 : Form
    {
        double alt, bas, raio, resu;
        Random randNum = new Random();
        int menor, maior = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    TextBox1Base.Enabled = true;
                    TextBox2Altura.Enabled = true;


                }
                if (comboBox1.SelectedIndex == 0)
                {
                    bas = double.Parse(TextBox1Base.Text);
                    alt = double.Parse(TextBox2Altura.Text);

                    resu = bas * alt;

                    MessageBox.Show(" A área do retângulo  é de " + resu);


                }
                if (comboBox1.SelectedIndex == 1)
                {


                    TextBox3Raio.Enabled = true;

                    TextBox1Base.Enabled = false;
                    TextBox1Base.Clear();
                    TextBox2Altura.Enabled = false;
                    TextBox2Altura.Clear();

                }

                if (comboBox1.SelectedIndex == 1)
                {
                    raio = double.Parse(TextBox3Raio.Text);

                    resu = raio * raio * 3.14 /2;

                    MessageBox.Show(" A área do círculo  é de " + resu);
                }


            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int [] valor1 = new int[10];
            int menor, maior = 0;
            Random randNum = new Random();

            try
            {
                for (i = 0; i < 10 ; i++)
                {
                    valor1[i] = randNum.Next(0, 50);
                    listBox1.Items.Add(valor1[i]);
                }
                for (i = 0; i < 10; i++)
                {
                    if (valor1[i] > maior)
                    {
                        maior = valor1[i];
                    }
                }

                menor = maior; 

                for (i = 0; i < 10; i++)
                {
                    if (valor1[i] < menor)
                    {
                        menor = valor1[i];
                    }
                }

                listBox2.Items.Add(menor);
                listBox2.Items.Add(maior);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int[] mod1 = new int[15];
            int[] mod2 = new int[15];
          
            try
            {
                maior = 0;
                menor = 0;
                for (int i = 0; i < 10; i++) 
                {
                    mod1[i] = randNum.Next(1, 19);
                    listBox3VetA.Items.Add(mod1[i]);
                    mod2[i] = randNum.Next(1, 19);
                    listBox4VetB.Items.Add(mod2[i]);
                }
              
                for (int i = 0; i < 10; i++)
                {
                    if (mod1[i] > maior)
                    {
                        maior = mod1[i];
                    }
                }

                menor = maior;

                for (int i = 0; i < 10; i++)
                {
                    if (mod2[i] < menor)
                    {
                        menor = mod2[i];
                    }
                }
                listBox5Resu.Items.Add(menor * maior);
                
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] num = new int[44];

            try
            {
                for (int i = 4; i < 8 ;i++) 
                { 
                    for (int j = 0;j < 11; j++)
                    {
                        num[j] = i * j;

                        if (num[j] %2 == 0)
                        {
                            listBox3.Items.Add(num[j]);
                        }  
                        if (num[j] %3 == 0)
                        {
                            listBox4.Items.Add(num[j]);
                        }

                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
