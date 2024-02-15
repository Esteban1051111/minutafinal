using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Minutas2
{
    public partial class VentaContadoParticulares : Form
    {
        private Parametrizar_minuta form1Instance;
        public VentaContadoParticulares()
        { 
            InitializeComponent();
            MostrarForm1();
        }
        private void MostrarForm1()
        {
            form1Instance = new Parametrizar_minuta();
            form1Instance.TopLevel = false;
            form1Instance.FormBorderStyle = FormBorderStyle.None;
            form1Instance.Dock = DockStyle.Fill;
            panel1.Controls.Add(form1Instance);
            form1Instance.Show();
        }



        private void paneleditordetexto_Paint(Form formulario1)
        {
            
        }

        private void paneleditordetexto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VentaContadoParticulares_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
