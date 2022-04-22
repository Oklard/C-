using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int i = 0; i < 4; i++)
                MessageBox.Show(vetor[i].ToString(), "array");

        }

        private void btnVetorTexto_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Doomingo";
            semana[1] = "segunda"; 
            semana[2] = "terça"; 
            semana[3] = "quarta";
            semana[4] = "quinta";
            semana[5] = "sexta";
            semana[6] = "sabado";

            string valor = semana[1];
            for (int i = 0; i < 7; i++)
                MessageBox.Show(semana[i].ToString(), "array");
        }
    }
}
