
namespace MiCalculadora
{
    partial class FormCalculadora
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnOperar_Click = new System.Windows.Forms.Button();
            this.btnLimpiar_Click = new System.Windows.Forms.Button();
            this.btnCerrar_Click = new System.Windows.Forms.Button();
            this.btnConvertirABinario_Click = new System.Windows.Forms.Button();
            this.btnConvertirADecimal_Click = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(23, 59);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(127, 23);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(355, 59);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(129, 23);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbOperador
            // 
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(186, 59);
            this.cmbOperador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(129, 23);
            this.cmbOperador.TabIndex = 1;
            // 
            // btnOperar_Click
            // 
            this.btnOperar_Click.Location = new System.Drawing.Point(39, 125);
            this.btnOperar_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOperar_Click.Name = "btnOperar_Click";
            this.btnOperar_Click.Size = new System.Drawing.Size(96, 32);
            this.btnOperar_Click.TabIndex = 3;
            this.btnOperar_Click.Text = "Operar";
            this.btnOperar_Click.UseVisualStyleBackColor = true;
            this.btnOperar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar_Click
            // 
            this.btnLimpiar_Click.Location = new System.Drawing.Point(205, 125);
            this.btnLimpiar_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar_Click.Name = "btnLimpiar_Click";
            this.btnLimpiar_Click.Size = new System.Drawing.Size(96, 32);
            this.btnLimpiar_Click.TabIndex = 4;
            this.btnLimpiar_Click.Text = "Limpiar";
            this.btnLimpiar_Click.UseVisualStyleBackColor = true;
            this.btnLimpiar_Click.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnCerrar_Click
            // 
            this.btnCerrar_Click.Location = new System.Drawing.Point(369, 125);
            this.btnCerrar_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar_Click.Name = "btnCerrar_Click";
            this.btnCerrar_Click.Size = new System.Drawing.Size(96, 32);
            this.btnCerrar_Click.TabIndex = 5;
            this.btnCerrar_Click.Text = "Cerrar";
            this.btnCerrar_Click.UseVisualStyleBackColor = true;
            this.btnCerrar_Click.Click += new System.EventHandler(this.btnCerrar_Click_Click);
            // 
            // btnConvertirABinario_Click
            // 
            this.btnConvertirABinario_Click.Location = new System.Drawing.Point(100, 192);
            this.btnConvertirABinario_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertirABinario_Click.Name = "btnConvertirABinario_Click";
            this.btnConvertirABinario_Click.Size = new System.Drawing.Size(133, 32);
            this.btnConvertirABinario_Click.TabIndex = 6;
            this.btnConvertirABinario_Click.Text = "Convertir a binario";
            this.btnConvertirABinario_Click.UseVisualStyleBackColor = true;
            this.btnConvertirABinario_Click.Click += new System.EventHandler(this.btnConvertirABinario_Click_Click);
            // 
            // btnConvertirADecimal_Click
            // 
            this.btnConvertirADecimal_Click.Location = new System.Drawing.Point(287, 192);
            this.btnConvertirADecimal_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertirADecimal_Click.Name = "btnConvertirADecimal_Click";
            this.btnConvertirADecimal_Click.Size = new System.Drawing.Size(133, 32);
            this.btnConvertirADecimal_Click.TabIndex = 7;
            this.btnConvertirADecimal_Click.Text = "Convertir a decimal";
            this.btnConvertirADecimal_Click.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal_Click.Click += new System.EventHandler(this.btnConvertirADecimal_Click_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLabel.Location = new System.Drawing.Point(355, 9);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(0, 23);
            this.lblLabel.TabIndex = 0;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 244);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnConvertirADecimal_Click);
            this.Controls.Add(this.btnConvertirABinario_Click);
            this.Controls.Add(this.btnCerrar_Click);
            this.Controls.Add(this.btnLimpiar_Click);
            this.Controls.Add(this.btnOperar_Click);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Marco Broggi del curso 2ºA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnOperar_Click;
        private System.Windows.Forms.Button btnLimpiar_Click;
        private System.Windows.Forms.Button btnCerrar_Click;
        private System.Windows.Forms.Button btnConvertirABinario_Click;
        private System.Windows.Forms.Button btnConvertirADecimal_Click;
        private System.Windows.Forms.Label lblLabel;
    }
}

