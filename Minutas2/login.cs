using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minutas2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Parametrizar_minuta minuta = new Parametrizar_minuta(); 
            minuta.Show();
        }
    }
}
