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
            file = @"C:\Users\Geisson\Desktop\PUC\Arquitetura de Computadores II\Relatórios\Relatório 5\Relatório5b\CompiladorMinHex\CompiladorMinHex\CompiladorMinHex\DataMne\In.txt";

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
            var instrucoes = ltbMnemonico.Items;                // Instruções mnemônicas do ListBox Mnemônico.
            
            ltbHexadecimal.Items.Clear();                       // Limpar o ListBox Hexadecimal.
            file = @"C:\Users\Geisson\Desktop\PUC\Arquitetura de Computadores II\Relatórios\Relatório 5\Relatório5b\CompiladorMinHex\CompiladorMinHex\CompiladorMinHex\DataHex\Out.txt";
            
            // Objeto para escrever no arquivo.
            using (StreamWriter writer = new StreamWriter(file))
            {
                String linha;
                String instrucaoHex;

                // Percorrer as instruções menemônicas.
                foreach (var instrucao in instrucoes)
                {
                    linha = instrucao.ToString();
                    instrucaoHex = Decode.Compile(linha);           // Compila Ins. mnemônico em Ins. hexadecimal para a ULA.

                    if (Decode.FlagRecord)
                    {
                        ltbHexadecimal.Items.Add(instrucaoHex);     // Adicionar a instrução no ListBox Hexadecimal.
                        writer.WriteLine(instrucaoHex);             // Escreve a instrução hex no arquivo.
                    }
                }

                writer.Close();                                     // Fechar writer para escrita.
            }
            btnCompilar.Enabled = false;                        // Desabilitar botão 'Compilar'.
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
