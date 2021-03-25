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
        // Variáveis globais.
        String file;        // Arquivo que será lido.

        public Form1()
        {
            InitializeComponent();
            btnCompilar.Enabled = false;
        }

        // Abrir arquivo mnemônico.
        private void btnAbrirMne_Click(object sender, EventArgs e)
        {
            file = @"C:\Users\Geisson\Desktop\PUC\Arquitetura de Computadores II\Relatórios\Relatório 5\Relatório5b\CompiladorMinHex\CompiladorMinHex\CompiladorMinHex\DataMne\teste.txt";

            if (File.Exists(file))
            {
                String[] linhas = File.ReadAllLines(file);
                ltbMnemonico.Items.Clear();

                // Percorre cada uma das linhas (item do vetor).
                foreach (String linha in linhas)
                {
                    // Adiciona a linha no ListBox.
                    ltbMnemonico.Items.Add(linha);
                }

                btnCompilar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Arquivo não existe!");
            }
        }

        // Compilar arquivo mnemônico para hexadecimal.
        private void btnCompilar_Click(object sender, EventArgs e)
        {
            var instrucoes = ltbMnemonico.Items;
            ltbHexadecimal.Items.Clear();

            foreach (var instrucao in instrucoes)
            {
                ltbHexadecimal.Items.Add(instrucao);
            }

            btnCompilar.Enabled = false;
        }
    }
}
