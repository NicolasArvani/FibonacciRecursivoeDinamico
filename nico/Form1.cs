using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace nico
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
            carregarLista();
        }

        List<BigInteger> ListaFibonacci; //lista com os fibonaccis guardados
        
        /*Carregar lista dinamica*/
        private void carregarLista()
        {
            
            FileStream fs = new FileStream("Fibonacci.bin", FileMode.OpenOrCreate); //objeto de arquivo binario
            BinaryFormatter bf = new BinaryFormatter();
            if(fs.Length == 0) //Se não houver itens na lista, insere os dois primeiros numeros
            {
                ListaFibonacci = new List<BigInteger>();
                ListaFibonacci.Add(1);
                ListaFibonacci.Add(1);
            }
            else //caso haja, apenas carrega o arquivo para a lista
                ListaFibonacci = (List<BigInteger>)bf.Deserialize(fs);
            fs.Close();
        }

        
        /*Fibonacci*/
        private BigInteger fibonacciDinamico(ref List<BigInteger> lista, int n)
        {
            int ultimo = lista.Count;
            if (n <= lista.Count) //se o numero ja foi calculado anteriormente, retorna imediatamente
                return lista[n - 1];
            else //recursao
            {
                ListaFibonacci.Add(fibonacciDinamico(ref ListaFibonacci, n - 1) + fibonacciDinamico(ref ListaFibonacci, n - 2));
                return ListaFibonacci[n - 1];
            }

        }

        public BigInteger FibonacciRecursivo(BigInteger x)
        {
            if (x == 1 || x == 2)
                return 1;
            else if (x == 0)
                return 0;
            else
                return FibonacciRecursivo(x - 1) + FibonacciRecursivo(x - 2);
        }

        /*Componentes*/

        private void btnRodar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInputFibonacci.Text) || txtInputFibonacci.Text.Any(Char.IsLetter)) //verifica se o input é valido
                return;
            this.Cursor = Cursors.WaitCursor;
            int x = int.Parse(txtInputFibonacci.Text);
            if(x > 40)
            {
                if(MessageBox.Show("Indice de Fibonacci muito grande, deseja continuar?","Atenção", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }

            Stopwatch stopwatch = new Stopwatch();
            if (chkRecursivo.Checked)
            {
                stopwatch.Start();
                BigInteger resultadoRec = FibonacciRecursivo((BigInteger)x);
                stopwatch.Stop();

                txtOutput.AppendText("[Recursivo] Fibonacci de " + x.ToString() + ": " + resultadoRec.ToString() + "\r\n");
                txtOutput.AppendText("Tempo de execução: " + stopwatch.ElapsedMilliseconds.ToString() + "ms\r\n");
                stopwatch.Reset();
            }

            if (chkDinamico.Checked)
            {
                stopwatch.Start();
                BigInteger resultadoDin = fibonacciDinamico(ref ListaFibonacci, x);
                stopwatch.Stop();

                txtOutput.AppendText("[Dinamica] Fibonacci de " + x.ToString() + ": " + resultadoDin.ToString() + "\r\n");
                txtOutput.AppendText("Tempo de execução: " + stopwatch.ElapsedMilliseconds.ToString() + "ms\r\n");
            }
            this.Cursor = Cursors.Default;
        }

        private void btnFibonacciRecursivo_Click(object sender, EventArgs e) //legacy
        {
            if (String.IsNullOrEmpty(txtInputFibonacci.Text))
                return;
            int x = int.Parse(txtInputFibonacci.Text);
            if(x > 40)
            {
                MessageBox.Show("Número muito grande, escolha um número menor que 40!");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BigInteger resultadoRec = FibonacciRecursivo((BigInteger)x);
            stopwatch.Stop();
            txtOutput.AppendText("[Recursivo] Fibonacci de " + x.ToString() + ": " + resultadoRec.ToString() + "\r\n");
            txtOutput.AppendText("Tempo de execução: " + stopwatch.ElapsedMilliseconds.ToString() + "ms\r\n");

        }

        private void btnFibonacciLista_Click(object sender, EventArgs e) //legacy
        {
            if (String.IsNullOrEmpty(txtInputFibonacci.Text))
                return;
            int n = int.Parse(txtInputFibonacci.Text);
           
            if (n - ListaFibonacci.Count > 200)
            {
                MessageBox.Show("Número muito grande, escolha um número menor que 40!");
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BigInteger resultado = fibonacciDinamico(ref ListaFibonacci, n);

            stopwatch.Stop();
            txtOutput.AppendText("[Dinamica] Fibonacci de " + n + ":" + " " + resultado.ToString() + "\r\n");
            txtOutput.AppendText("Tempo de execução: " + stopwatch.ElapsedMilliseconds.ToString() + "ms\r\n");

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("Listando itens no arquivo:\r\n");
            this.Cursor = Cursors.WaitCursor;
            txtOutput.Hide();
            int i = 1;
            foreach(BigInteger n in ListaFibonacci)
            {
                txtOutput.AppendText("N." + i + ": " + n + "\r\n");
                i++;
            };
            txtOutput.AppendText("Total de Itens: " + ListaFibonacci.Count.ToString() + "\r\n");
            txtOutput.Show();
            this.Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        /*ToolStripMenu*/

        private void zerarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que quer limpar o arquivo e a lista?\r\nEssa ação não poderá ser desfeita!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FileStream fs = new FileStream("Fibonacci.bin", FileMode.Create);
                ListaFibonacci.Clear();
                fs.Close();
                carregarLista();
            }
        }

        private void salvarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo Binário|*.bin";
            sfd.FileName = "Fibonacci";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ListaFibonacci);
                fs.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }


        /*Background*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Salvar a lista no arquivo antes de fechar o form
            FileStream fs = new FileStream("Fibonacci.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ListaFibonacci);
            fs.Close();
        }
    }


}
