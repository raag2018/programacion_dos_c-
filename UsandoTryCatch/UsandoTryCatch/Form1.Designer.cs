namespace UsandoTryCatch
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
            groupBox1 = new GroupBox();
            lblResultado = new Label();
            btnArea = new Button();
            txtLado = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblResultadoDiv = new Label();
            btnDividir = new Button();
            txtNumero = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            lblResultadoNum = new Label();
            btnConvertir = new Button();
            txtTextoNumero = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(btnArea);
            groupBox1.Controls.Add(txtLado);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(360, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calcular Area";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(13, 93);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(19, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "llll";
            // 
            // btnArea
            // 
            btnArea.Location = new Point(169, 57);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(147, 23);
            btnArea.TabIndex = 2;
            btnArea.Text = "Calcular Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(13, 58);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(150, 23);
            txtLado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Lado";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(lblResultadoDiv);
            groupBox2.Controls.Add(btnDividir);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(360, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 176);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dividir numero entre 100";
            // 
            // lblResultadoDiv
            // 
            lblResultadoDiv.AutoSize = true;
            lblResultadoDiv.Location = new Point(13, 93);
            lblResultadoDiv.Name = "lblResultadoDiv";
            lblResultadoDiv.Size = new Size(19, 15);
            lblResultadoDiv.TabIndex = 3;
            lblResultadoDiv.Text = "llll";
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(169, 57);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(147, 23);
            btnDividir.TabIndex = 2;
            btnDividir.Text = "Dividir Numero";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(13, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 23);
            txtNumero.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Ingresar numero";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 192);
            groupBox3.Controls.Add(lblResultadoNum);
            groupBox3.Controls.Add(btnConvertir);
            groupBox3.Controls.Add(txtTextoNumero);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 176);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Convertir texto a numero";
            // 
            // lblResultadoNum
            // 
            lblResultadoNum.AutoSize = true;
            lblResultadoNum.Location = new Point(13, 93);
            lblResultadoNum.Name = "lblResultadoNum";
            lblResultadoNum.Size = new Size(19, 15);
            lblResultadoNum.TabIndex = 3;
            lblResultadoNum.Text = "llll";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(169, 57);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(147, 23);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir a numero";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtTextoNumero
            // 
            txtTextoNumero.Location = new Point(13, 58);
            txtTextoNumero.Name = "txtTextoNumero";
            txtTextoNumero.Size = new Size(150, 23);
            txtTextoNumero.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 0;
            label4.Text = "Ingresar el texto del numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "TryCatch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblResultado;
        private Button btnArea;
        private TextBox txtLado;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblResultadoDiv;
        private Button btnDividir;
        private TextBox txtNumero;
        private Label label3;
        private GroupBox groupBox3;
        private Label lblResultadoNum;
        private Button btnConvertir;
        private TextBox txtTextoNumero;
        private Label label4;
    }
}
