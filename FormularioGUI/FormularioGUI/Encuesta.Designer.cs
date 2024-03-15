namespace FormularioGUI
{
    partial class Encuesta
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
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbVirtual = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Location = new System.Drawing.Point(88, 66);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(91, 17);
            this.chkJs.TabIndex = 0;
            this.chkJs.Text = "JAVASCRIPT";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Location = new System.Drawing.Point(88, 108);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(56, 17);
            this.chkHtml.TabIndex = 1;
            this.chkHtml.Text = "HTML";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Location = new System.Drawing.Point(88, 151);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(47, 17);
            this.chkCss.TabIndex = 2;
            this.chkCss.Text = "CSS";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURSOS DISPONIBLES";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(356, 283);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(246, 143);
            this.txtResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CURSOS SELECCIONADOS";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(88, 185);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(315, 66);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(74, 17);
            this.rdbPresencial.TabIndex = 7;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Que modalidad prefiere?";
            // 
            // rdbVirtual
            // 
            this.rdbVirtual.AutoSize = true;
            this.rdbVirtual.Location = new System.Drawing.Point(315, 107);
            this.rdbVirtual.Name = "rdbVirtual";
            this.rdbVirtual.Size = new System.Drawing.Size(54, 17);
            this.rdbVirtual.TabIndex = 9;
            this.rdbVirtual.TabStop = true;
            this.rdbVirtual.Text = "Virtual";
            this.rdbVirtual.UseVisualStyleBackColor = true;
            // 
            // Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.rdbVirtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbPresencial);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCss);
            this.Controls.Add(this.chkHtml);
            this.Controls.Add(this.chkJs);
            this.Name = "Encuesta";
            this.Text = "Encuesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbVirtual;
    }
}