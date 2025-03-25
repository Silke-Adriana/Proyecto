namespace FrontEnd
{
    partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            lbl_FP_TituloP = new Label();
            Btn_FP_Clientes = new Button();
            Btn_FP_Libros = new Button();
            SuspendLayout();
            // 
            // lbl_FP_TituloP
            // 
            lbl_FP_TituloP.AutoSize = true;
            lbl_FP_TituloP.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_FP_TituloP.Location = new Point(139, 34);
            lbl_FP_TituloP.Name = "lbl_FP_TituloP";
            lbl_FP_TituloP.Size = new Size(616, 134);
            lbl_FP_TituloP.TabIndex = 0;
            lbl_FP_TituloP.Text = "Bienvenido";
    
            // 
            // Btn_FP_Clientes
            // 
            Btn_FP_Clientes.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Btn_FP_Clientes.Location = new Point(230, 232);
            Btn_FP_Clientes.Name = "Btn_FP_Clientes";
            Btn_FP_Clientes.Size = new Size(200, 70);
            Btn_FP_Clientes.TabIndex = 1;
            Btn_FP_Clientes.Text = "Clientes";
            Btn_FP_Clientes.UseVisualStyleBackColor = true;
            Btn_FP_Clientes.Click += Btn_FP_Clientes_Click;
            // 
            // Btn_FP_Libros
            // 
            Btn_FP_Libros.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Btn_FP_Libros.Location = new Point(436, 232);
            Btn_FP_Libros.Name = "Btn_FP_Libros";
            Btn_FP_Libros.Size = new Size(200, 70);
            Btn_FP_Libros.TabIndex = 2;
            Btn_FP_Libros.Text = "Libros";
            Btn_FP_Libros.UseVisualStyleBackColor = true;
            Btn_FP_Libros.Click += Btn_FP_Libros_Click;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_4_1024x683;
            ClientSize = new Size(882, 453);
            Controls.Add(Btn_FP_Libros);
            Controls.Add(Btn_FP_Clientes);
            Controls.Add(lbl_FP_TituloP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Principal";
            Text = "Libreria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_FP_TituloP;
        private Button Btn_FP_Clientes;
        private Button Btn_FP_Libros;
    }
}