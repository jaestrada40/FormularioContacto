namespace Contacto
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
            label2 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 80);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 118);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(131, 115);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(360, 23);
            txtCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 153);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(131, 153);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(360, 113);
            txtMensaje.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Font = new Font("Montserrat", 14F, FontStyle.Bold);
            btnEnviar.ForeColor = SystemColors.ButtonFace;
            btnEnviar.Location = new Point(131, 282);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(133, 39);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEstado.Location = new Point(131, 351);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 32);
            lblEstado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private Label lblEstado;
    }
}
