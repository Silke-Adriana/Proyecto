using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd;
using Negocio;

namespace FrontEnd
{
    public partial class F_Libro : Form
    {
        Libro libro = new Libro();

        public F_Libro()
        {
            InitializeComponent();
            tbox_FL_Id.Enabled = false;
        }

        private void MostrarLibros()
        {
            //Le asigno al DataGrid del FrontEnd las personas a mostrar
            DG_F_Libro.DataSource = libro.MostrarLibro();
        }

        private void F_Libro_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void Btn_FL_Cargar_Click(object sender, EventArgs e)
        {
            libro.InsertarLibro(tbox_FL_Titulo.Text, tbox_FL_Autor.Text, tbox_FL_Genero.Text, tbox_FL_Precio.Text, tbox_FL_Stock.Text);
            MessageBox.Show("Libro cargado");
        }

        private void Btn_FL_Modificar_Click(object sender, EventArgs e)
        {
            libro.ModificarLibro(tbox_FL_Id.Text,
                                 tbox_FL_Titulo.Text,
                                 tbox_FL_Autor.Text,
                                 tbox_FL_Genero.Text,
                                 tbox_FL_Precio.Text,
                                 tbox_FL_Stock.Text);
            MessageBox.Show("Libro Modificado");

        }

        private void btn_FL_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_FL_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Estas Seguro que lo queres eliminar?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            libro.EliminarLibro(tbox_FL_Id.Text);
            MessageBox.Show("Cliente Eliminado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Creamos un método que nos permita tomar los datos de una celda.
        // El sender representa el control que activó el evento(DG_F_Cliente).
        // "e" contiene la información sobre la celda que se hizo clic, como su fila(e.RowIndex).
        private void DG_F_Libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Accedemos a la fila del DataGridView correspondiente al índice e.RowIndex.
                DataGridViewRow row = DG_F_Libro.Rows[e.RowIndex];
                // Le asignamos a los textBox el valor de de la celda y a este valor lo convertimos en string.
                tbox_FL_Id.Text = row.Cells["id_libro"].Value.ToString();
                tbox_FL_Titulo.Text = row.Cells["titulo"].Value.ToString();
                tbox_FL_Autor.Text = row.Cells["autor"].Value.ToString();
                tbox_FL_Genero.Text = row.Cells["genero"].Value.ToString();
                tbox_FL_Precio.Text = row.Cells["precio"].Value.ToString();
                tbox_FL_Stock.Text = row.Cells["stock"].Value.ToString();
            }
        }

        private void Btn_FL_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
