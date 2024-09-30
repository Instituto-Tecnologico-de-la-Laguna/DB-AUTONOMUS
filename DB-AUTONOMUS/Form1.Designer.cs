namespace DB_AUTONOMUS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            label2 = new Label();
            txtMaterno = new TextBox();
            label3 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(25, 117);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(227, 31);
            txtPaterno.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 89);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "A. Paterno";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(25, 199);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(227, 31);
            txtMaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 4;
            label3.Text = "A. Materno";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(25, 261);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(382, 31);
            txtMail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 233);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 6;
            label4.Text = "Mail";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(25, 332);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 304);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(224, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(342, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 384);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(txtMaterno);
            Controls.Add(label3);
            Controls.Add(txtPaterno);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private Label label2;
        private TextBox txtMaterno;
        private Label label3;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}
