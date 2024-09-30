namespace Demo
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
            this.boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toler = new System.Windows.Forms.TextBox();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(283, 95);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Pesar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso referencial (kg)";
            // 
            // refer
            // 
            this.refer.Location = new System.Drawing.Point(147, 77);
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(107, 23);
            this.refer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tolerancia (+/- kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toler
            // 
            this.toler.Location = new System.Drawing.Point(147, 118);
            this.toler.Name = "toler";
            this.toler.Size = new System.Drawing.Size(107, 23);
            this.toler.TabIndex = 4;
            // 
            // tabla1
            // 
            this.tabla1.AllowUserToAddRows = false;
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3});
            this.tabla1.Location = new System.Drawing.Point(14, 148);
            this.tabla1.Name = "tabla1";
            this.tabla1.RowTemplate.Height = 25;
            this.tabla1.Size = new System.Drawing.Size(344, 237);
            this.tabla1.TabIndex = 5;
            // 
            // C1
            // 
            this.C1.HeaderText = "Peso";
            this.C1.Name = "C1";
            // 
            // C2
            // 
            this.C2.HeaderText = "Fecha";
            this.C2.Name = "C2";
            // 
            // C3
            // 
            this.C3.HeaderText = "Hora";
            this.C3.Name = "C3";
            // 
            // label3
            // 
            this.label3.Image = global::Demo.Properties.Resources.logolcsa;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 64);
            this.label3.TabIndex = 6;
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(115, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONTROL DE PESOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.toler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button boton;
        private Label label1;
        private TextBox refer;
        private Label label2;
        private TextBox toler;
        private DataGridView tabla1;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
        private DataGridViewTextBoxColumn C3;
        private Label label3;
        private Label label4;
    }
}