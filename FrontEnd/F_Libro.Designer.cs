namespace FrontEnd
{
    partial class F_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DG_F_Libro = new DataGridView();
            lbl_FL_TituloP = new Label();
            gbox_FL_Datos = new GroupBox();
            tbox_FL_Id = new TextBox();
            txt_FL_Stock = new Label();
            txt_FL_Precio = new Label();
            tbox_FL_Stock = new TextBox();
            tbox_FL_Precio = new TextBox();
            txt_FL_Genero = new Label();
            txt_FL_Autor = new Label();
            tbox_FL_Genero = new TextBox();
            tbox_FL_Autor = new TextBox();
            tbox_FL_Titulo = new TextBox();
            txt_FL_Nombre = new Label();
            btn_FL_Cargar = new Button();
            btn_FL_Modificar = new Button();
            btn_FL_Limpiar = new Button();
            btn_FL_Eliminar = new Button();
            Btn_FL_volver = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_F_Libro).BeginInit();
            gbox_FL_Datos.SuspendLayout();
            SuspendLayout();
            // 
            // DG_F_Libro
            // 
            DG_F_Libro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_F_Libro.Location = new Point(12, 295);
            DG_F_Libro.Name = "DG_F_Libro";
            DG_F_Libro.RowHeadersWidth = 51;
            DG_F_Libro.Size = new Size(858, 546);
            DG_F_Libro.TabIndex = 0;
            DG_F_Libro.CellClick += DG_F_Libro_CellClick;
            // 
            // lbl_FL_TituloP
            // 
            lbl_FL_TituloP.AutoSize = true;
            lbl_FL_TituloP.BackColor = SystemColors.ControlLightLight;
            lbl_FL_TituloP.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_FL_TituloP.ForeColor = SystemColors.ActiveCaptionText;
            lbl_FL_TituloP.Location = new Point(176, 9);
            lbl_FL_TituloP.Name = "lbl_FL_TituloP";
            lbl_FL_TituloP.Size = new Size(526, 53);
            lbl_FL_TituloP.TabIndex = 1;
            lbl_FL_TituloP.Text = "Administrador de Libros";
            lbl_FL_TituloP.Click += label1_Click;
            // 
            // gbox_FL_Datos
            // 
            gbox_FL_Datos.Controls.Add(tbox_FL_Id);
            gbox_FL_Datos.Controls.Add(txt_FL_Stock);
            gbox_FL_Datos.Controls.Add(txt_FL_Precio);
            gbox_FL_Datos.Controls.Add(tbox_FL_Stock);
            gbox_FL_Datos.Controls.Add(tbox_FL_Precio);
            gbox_FL_Datos.Controls.Add(txt_FL_Genero);
            gbox_FL_Datos.Controls.Add(txt_FL_Autor);
            gbox_FL_Datos.Controls.Add(tbox_FL_Genero);
            gbox_FL_Datos.Controls.Add(tbox_FL_Autor);
            gbox_FL_Datos.Controls.Add(tbox_FL_Titulo);
            gbox_FL_Datos.Controls.Add(txt_FL_Nombre);
            gbox_FL_Datos.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_FL_Datos.Location = new Point(12, 82);
            gbox_FL_Datos.Name = "gbox_FL_Datos";
            gbox_FL_Datos.Size = new Size(301, 207);
            gbox_FL_Datos.TabIndex = 2;
            gbox_FL_Datos.TabStop = false;
            gbox_FL_Datos.Text = "Libros:";
            // 
            // tbox_FL_Id
            // 
            tbox_FL_Id.Location = new Point(274, 11);
            tbox_FL_Id.Name = "tbox_FL_Id";
            tbox_FL_Id.Size = new Size(27, 28);
            tbox_FL_Id.TabIndex = 10;
            // 
            // txt_FL_Stock
            // 
            txt_FL_Stock.AutoSize = true;
            txt_FL_Stock.Location = new Point(11, 173);
            txt_FL_Stock.Name = "txt_FL_Stock";
            txt_FL_Stock.Size = new Size(53, 20);
            txt_FL_Stock.TabIndex = 9;
            txt_FL_Stock.Text = "Stock";
            // 
            // txt_FL_Precio
            // 
            txt_FL_Precio.AutoSize = true;
            txt_FL_Precio.Location = new Point(11, 140);
            txt_FL_Precio.Name = "txt_FL_Precio";
            txt_FL_Precio.Size = new Size(58, 20);
            txt_FL_Precio.TabIndex = 8;
            txt_FL_Precio.Text = "Precio";
            // 
            // tbox_FL_Stock
            // 
            tbox_FL_Stock.Location = new Point(74, 166);
            tbox_FL_Stock.Name = "tbox_FL_Stock";
            tbox_FL_Stock.Size = new Size(202, 28);
            tbox_FL_Stock.TabIndex = 7;
            // 
            // tbox_FL_Precio
            // 
            tbox_FL_Precio.Location = new Point(74, 133);
            tbox_FL_Precio.Name = "tbox_FL_Precio";
            tbox_FL_Precio.Size = new Size(202, 28);
            tbox_FL_Precio.TabIndex = 6;
            // 
            // txt_FL_Genero
            // 
            txt_FL_Genero.AutoSize = true;
            txt_FL_Genero.Location = new Point(11, 107);
            txt_FL_Genero.Name = "txt_FL_Genero";
            txt_FL_Genero.Size = new Size(66, 20);
            txt_FL_Genero.TabIndex = 5;
            txt_FL_Genero.Text = "Genero";
            // 
            // txt_FL_Autor
            // 
            txt_FL_Autor.AutoSize = true;
            txt_FL_Autor.Location = new Point(11, 70);
            txt_FL_Autor.Name = "txt_FL_Autor";
            txt_FL_Autor.Size = new Size(55, 20);
            txt_FL_Autor.TabIndex = 4;
            txt_FL_Autor.Text = "Autor";
            // 
            // tbox_FL_Genero
            // 
            tbox_FL_Genero.Location = new Point(74, 100);
            tbox_FL_Genero.Name = "tbox_FL_Genero";
            tbox_FL_Genero.Size = new Size(202, 28);
            tbox_FL_Genero.TabIndex = 3;
            // 
            // tbox_FL_Autor
            // 
            tbox_FL_Autor.Location = new Point(74, 67);
            tbox_FL_Autor.Name = "tbox_FL_Autor";
            tbox_FL_Autor.Size = new Size(202, 28);
            tbox_FL_Autor.TabIndex = 2;
            // 
            // tbox_FL_Titulo
            // 
            tbox_FL_Titulo.Location = new Point(74, 34);
            tbox_FL_Titulo.Name = "tbox_FL_Titulo";
            tbox_FL_Titulo.Size = new Size(202, 28);
            tbox_FL_Titulo.TabIndex = 1;
            // 
            // txt_FL_Nombre
            // 
            txt_FL_Nombre.AutoSize = true;
            txt_FL_Nombre.Location = new Point(11, 37);
            txt_FL_Nombre.Name = "txt_FL_Nombre";
            txt_FL_Nombre.Size = new Size(56, 20);
            txt_FL_Nombre.TabIndex = 0;
            txt_FL_Nombre.Text = "Titulo";
            // 
            // btn_FL_Cargar
            // 
            btn_FL_Cargar.Font = new Font("Times New Roman", 10.8F);
            btn_FL_Cargar.Location = new Point(331, 93);
            btn_FL_Cargar.Name = "btn_FL_Cargar";
            btn_FL_Cargar.Size = new Size(98, 30);
            btn_FL_Cargar.TabIndex = 3;
            btn_FL_Cargar.Text = "Cargar";
            btn_FL_Cargar.UseVisualStyleBackColor = true;
            btn_FL_Cargar.Click += Btn_FL_Cargar_Click;
            // 
            // btn_FL_Modificar
            // 
            btn_FL_Modificar.Font = new Font("Times New Roman", 10.8F);
            btn_FL_Modificar.Location = new Point(331, 129);
            btn_FL_Modificar.Name = "btn_FL_Modificar";
            btn_FL_Modificar.Size = new Size(98, 30);
            btn_FL_Modificar.TabIndex = 4;
            btn_FL_Modificar.Text = "Modificar";
            btn_FL_Modificar.UseVisualStyleBackColor = true;
            btn_FL_Modificar.Click += Btn_FL_Modificar_Click;
            // 
            // btn_FL_Limpiar
            // 
            btn_FL_Limpiar.Font = new Font("Times New Roman", 10.8F);
            btn_FL_Limpiar.Location = new Point(331, 165);
            btn_FL_Limpiar.Name = "btn_FL_Limpiar";
            btn_FL_Limpiar.Size = new Size(98, 30);
            btn_FL_Limpiar.TabIndex = 5;
            btn_FL_Limpiar.Text = "Limpiar";
            btn_FL_Limpiar.UseVisualStyleBackColor = true;
            btn_FL_Limpiar.Click += btn_FL_Limpiar_Click;
            // 
            // btn_FL_Eliminar
            // 
            btn_FL_Eliminar.Font = new Font("Times New Roman", 10.8F);
            btn_FL_Eliminar.Location = new Point(331, 201);
            btn_FL_Eliminar.Name = "btn_FL_Eliminar";
            btn_FL_Eliminar.Size = new Size(98, 30);
            btn_FL_Eliminar.TabIndex = 6;
            btn_FL_Eliminar.Text = "Eliminar";
            btn_FL_Eliminar.UseVisualStyleBackColor = true;
            btn_FL_Eliminar.Click += Btn_FL_Eliminar_Click;
            // 
            // Btn_FL_volver
            // 
            Btn_FL_volver.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_FL_volver.Location = new Point(772, 259);
            Btn_FL_volver.Name = "Btn_FL_volver";
            Btn_FL_volver.Size = new Size(98, 30);
            Btn_FL_volver.TabIndex = 7;
            Btn_FL_volver.Text = "Volver";
            Btn_FL_volver.UseVisualStyleBackColor = true;
            Btn_FL_volver.Click += Btn_FL_volver_Click;
            // 
            // F_Libro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(882, 853);
            Controls.Add(Btn_FL_volver);
            Controls.Add(btn_FL_Eliminar);
            Controls.Add(btn_FL_Limpiar);
            Controls.Add(btn_FL_Modificar);
            Controls.Add(btn_FL_Cargar);
            Controls.Add(gbox_FL_Datos);
            Controls.Add(lbl_FL_TituloP);
            Controls.Add(DG_F_Libro);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Libro";
            Text = "Admin Libros";
            Load += F_Libro_Load;
            ((System.ComponentModel.ISupportInitialize)DG_F_Libro).EndInit();
            gbox_FL_Datos.ResumeLayout(false);
            gbox_FL_Datos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_F_Libro;
        private Label lbl_FL_TituloP;
        private GroupBox gbox_FL_Datos;
        private TextBox tbox_FL_Titulo;
        private Label txt_FL_Nombre;
        private Label txt_FL_Autor;
        private TextBox tbox_FL_Genero;
        private TextBox tbox_FL_Autor;
        private Label txt_FL_Genero;
        private Label txt_FL_Stock;
        private Label txt_FL_Precio;
        private TextBox tbox_FL_Stock;
        private TextBox tbox_FL_Precio;
        private Button btn_FL_Cargar;
        private Button btn_FL_Modificar;
        private Button btn_FL_Limpiar;
        private Button btn_FL_Eliminar;
        private TextBox tbox_FL_Id;
        private Button Btn_FL_volver;
    }
}