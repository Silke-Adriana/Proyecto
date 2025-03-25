using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class F_Principal : Form
    {

        public F_Principal()
        {
            InitializeComponent();
        }

  

        private void Btn_FP_Clientes_Click(object sender, EventArgs e)
        {
            F_Cliente cliente = new F_Cliente();
            cliente.Show();
        }

        private void Btn_FP_Libros_Click(object sender, EventArgs e)
        {
            F_Libro libro = new F_Libro();
            libro.Show();
        }

    
    }
}
