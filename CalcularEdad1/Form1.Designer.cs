namespace CalcularEdad1
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
            btnValidar = new Button();
            txtNombre = new TextBox();
            txtFCNCA = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(133, 222);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "VALIDAR";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtFCNCA
            // 
            txtFCNCA.Location = new Point(33, 162);
            txtFCNCA.Name = "txtFCNCA";
            txtFCNCA.Size = new Size(175, 23);
            txtFCNCA.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(194, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(126, 23);
            txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 62);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 4;
            label1.Text = "Introduzca su nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 62);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 5;
            label2.Text = "introduzca su apellido:";
            label2.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(275, 30);
            label3.TabIndex = 6;
            label3.Text = "Introduzca correctamente su fecha de nacimiento: \r\n(dd/mm/yyyy)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 9);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 7;
            label4.Text = "Calcular tu edad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtFCNCA);
            Controls.Add(txtNombre);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtNombre;
        private TextBox txtFCNCA;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}