namespace crud_nomina
{
    partial class frmCrearCargo
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbestatus = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btcrear = new System.Windows.Forms.Button();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(146, 40);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(164, 20);
            this.tbnombre.TabIndex = 1;
            // 
            // tbestatus
            // 
            this.tbestatus.Location = new System.Drawing.Point(146, 70);
            this.tbestatus.Name = "tbestatus";
            this.tbestatus.Size = new System.Drawing.Size(164, 20);
            this.tbestatus.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Empleados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbcodigo);
            this.panel1.Controls.Add(this.tbnombre);
            this.panel1.Controls.Add(this.tbestatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 109);
            this.panel1.TabIndex = 9;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(274, 177);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(60, 28);
            this.bteliminar.TabIndex = 13;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(165, 177);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(60, 28);
            this.btactualizar.TabIndex = 11;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btcrear
            // 
            this.btcrear.Location = new System.Drawing.Point(53, 177);
            this.btcrear.Name = "btcrear";
            this.btcrear.Size = new System.Drawing.Size(60, 28);
            this.btcrear.TabIndex = 10;
            this.btcrear.Text = "Crear";
            this.btcrear.UseVisualStyleBackColor = true;
            this.btcrear.Click += new System.EventHandler(this.btcrear_Click);
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(146, 9);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(164, 20);
            this.tbcodigo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // frmCrearCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 340);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btcrear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Name = "frmCrearCargo";
            this.Text = "Cargos ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbestatus;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btcrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbcodigo;
    }
}