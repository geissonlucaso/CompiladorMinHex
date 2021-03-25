using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorMinHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirMne_Click(object sender, EventArgs e)
        {
            String file = @"C:\Users\Geisson\Desktop\PUC\Arquitetura de Computadores II\Relatórios\Relatório 5\Relatório5b\CompiladorMinHex\CompiladorMinHex\CompiladorMinHex\DataMne\teste.txt";

            if (File.Exists(file))
            {
                String[] linhas = File.ReadAllLines(file);
                ltbMnemonico.Items.Clear();

                foreach (String linha in linhas)
                {
                    ltbMnemonico.Items.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não existe!");
            }
        }
    }
}
