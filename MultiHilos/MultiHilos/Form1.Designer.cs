namespace MultiHilos
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
            btnProceso = new Button();
            pgrProceso = new ProgressBar();
            lblEnd = new Label();
            lblStart = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProceso
            // 
            btnProceso.Location = new Point(68, 22);
            btnProceso.Name = "btnProceso";
            btnProceso.Size = new Size(130, 23);
            btnProceso.TabIndex = 0;
            btnProceso.Text = "Ejecutar Proceso";
            btnProceso.UseVisualStyleBackColor = true;
            btnProceso.Click += btnProceso_Click;
            // 
            // pgrProceso
            // 
            pgrProceso.Location = new Point(31, 102);
            pgrProceso.Name = "pgrProceso";
            pgrProceso.Size = new Size(185, 23);
            pgrProceso.TabIndex = 1;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(160, 63);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(68, 15);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Sin proceso";
            lblEnd.Click += label1_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(41, 63);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(68, 15);
            lblStart.TabIndex = 3;
            lblStart.Text = "Sin proceso";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProceso);
            groupBox1.Controls.Add(pgrProceso);
            groupBox1.Controls.Add(lblEnd);
            groupBox1.Controls.Add(lblStart);
            groupBox1.Location = new Point(29, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ejemplo de Multi Hilo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Multi Hilos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProceso;
        private ProgressBar pgrProceso;
        private Label lblEnd;
        private Label lblStart;
        private GroupBox groupBox1;
    }
}
