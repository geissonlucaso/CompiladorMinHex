using CompiladorMinHex.Tools;
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
                ReadFile(file);
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
            var instrucoes = ltbMnemonico.Items;        // Instruções mnemônicas do ListBox Mnemônico.
            ltbHexadecimal.Items.Clear();               // Limpar o ListBox Hexadecimal.

            // Percorrer as instruções menemônicas.
            foreach (var instrucao in instrucoes)
            {
                String linha = instrucao.ToString();

                String instrucaoHex = Decode.Compile(linha);
                if (Decode.FlagRecord)
                    ltbHexadecimal.Items.Add(instrucaoHex);     // Adicionar a instrução no ListBox Hexadecimal.
            }

            btnCompilar.Enabled = false;                // Desabilitar botão 'Compilar'.
        }

        // Método para ler arquivo.
        private void ReadFile(string file)
        {
            String[] linhas = File.ReadAllLines(file);
            ltbMnemonico.Items.Clear();

            // Percorre cada uma das linhas (item do vetor).
            foreach (String linha in linhas)
            {
                // Adiciona a linha no ListBox.
                ltbMnemonico.Items.Add(linha);
            }
        }
    }
}
