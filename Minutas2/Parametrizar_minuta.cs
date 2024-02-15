using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Minutas2;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.Packaging;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;



namespace Minutas2
{
    public partial class Parametrizar_minuta : Form
    {
    

        StringReader leitura = null;
        bool salvoComSucesso = false;
        public string minuta;

        public Parametrizar_minuta()
        {
            InitializeComponent();
           
        }
       
        public void SetTextoEnRichTextBox(string texto)
        {
            // Asigna el texto al RichTextBox en el formulario Parametrizar_minuta
            richTextBox1.Text = texto;
        }

        private char DesejaSalvar()
        {
            F_Salvar f_Salvar = new F_Salvar();
            f_Salvar.ShowDialog();

            char ret = f_Salvar.d;
            return ret;
        }
        private void Novo()
        {
            if (richTextBox1.Text != "")
            {
                char ret = DesejaSalvar();

                if (ret == 'N')
                {
                    richTextBox1.Clear();
                    richTextBox1.Focus();
                }
                else if (ret == 'S')
                {
                    Salvar();
                    if (salvoComSucesso == true)
                    {
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                }
                else
                {

                }
            }

        }

        private void Salvar()
        {
           
            GuardarComoWord(richTextBox1.Text);
        }

        private void Abrir()
        {
            salvoComSucesso = true;
            if (richTextBox1.Text != "")
            {
                char ret = DesejaSalvar();
                if (ret == 'S')
                {
                    Salvar();
                }

            }
            if (salvoComSucesso == true)
            {
                 try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Abrir archivo";
                
                openFileDialog.Filter = "Documento de Word (*.docx)|*.docx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(openFileDialog.FileName, false))
                    {
                        var body = wordDocument.MainDocumentPart.Document.Body;

                        // Limpiar el contenido actual
                        this.richTextBox1.Clear();

                        // Recorrer los párrafos del documento de Word
                        foreach (var paragraph in body.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>())
                        {
                            // Agregar un salto de línea para separar los párrafos
                            this.richTextBox1.AppendText(Environment.NewLine);

                            // Recorrer los elementos de formato en el párrafo
                            foreach (var run in paragraph.Elements<DocumentFormat.OpenXml.Wordprocessing.Run>())
                            {
                                // Obtener el texto y aplicar formato al RichTextBox
                                var text = run.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
                                if (text != null)
                                {
                                    this.richTextBox1.AppendText(text.Text);
                                    // Aplicar formato adicional según sea necesario
                                    // Por ejemplo, puedes manejar el formato de fuente, negrita, cursiva, etc.
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir el archivo de Word: " + e.Message, "Error al abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
        public void GuardarComoWord(string contenido)
        {
            // Inicializa una aplicación Word
            Word.Application wordApp = new Word.Application();

            // Crea un nuevo documento de Word
            Word.Document doc = wordApp.Documents.Add();

            // Obtiene el formato actual del RichTextBox
            object oFalse = false; // Valor opcional para algunos parámetros
            object oTrue = true;
            object oUnit = Word.WdUnits.wdCharacter;
            object oCount = 1;
            object oExtend = Word.WdMovementType.wdExtend;

            // Copia el contenido del RichTextBox al documento de Word
            richTextBox1.SelectAll();
            richTextBox1.Copy();
            doc.ActiveWindow.Selection.Paste();

            // Guarda el documento en un archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de Word|.docx|Todos los archivos|.*";
            saveFileDialog1.Title = "Guardar como archivo de Word";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                doc.SaveAs2(filePath);
            }

            // Cierra la aplicación Word
            wordApp.Quit();

        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (n == false)
            {
                if (i == true & s == true) //italico e sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true) //sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false) //italico
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false) //nenhum
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
            else if (n == true)
            {
                if (i == true & s == true) //italico e sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true) //sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false) //italico
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true) //negrito e sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true) //sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false) //negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (n == false & s == false) //nenhum
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
            else if (i == true)
            {
                if (n == true & s == true) //negrito e sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true) //sublinhado
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false) //negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (i == true & n == true) //italico e negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & n == true) //negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold);
                }
                else if (i == true & n == false) //italico
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (i == false & n == false) //nenhum
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
            }
            else if (s == true)
            {
                if (i == true & n == true) //italico e negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true) //negrito
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                else if (i == true & n == false) //italico
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }
        private void justificar()
        {
            
        }
        private void alinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void Centralizar()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void alinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string txt = this.richTextBox1.Text;
            leitura = new StringReader(txt);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                char ret = DesejaSalvar();
                if (ret == 'S')
                {
                    Salvar();
                    if (salvoComSucesso == false)
                    {
                        e.Cancel = true;
                    }
                }
                else if (ret == 'C')
                {
                    e.Cancel = true;
                }
                else
                {

                }
            }
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void italiicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

      

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float PosY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPag = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while (cont < linhasPag)
            {
                PosY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY, new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }
            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Parametrizar_minuta_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_justificar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
