namespace FACHASA
{
    partial class frmSeleccionServicios
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLavBasEn = new System.Windows.Forms.RadioButton();
            this.radLavCom = new System.Windows.Forms.RadioButton();
            this.radLavBasMot = new System.Windows.Forms.RadioButton();
            this.radLavBásico = new System.Windows.Forms.RadioButton();
            this.radLavExterno = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESCOGA LOS SERVICIOS QUE DESEE REALIZAR";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "GUARDAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(455, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MONTO TOTAL DEL SERVICIO";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(255, 230);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(240, 75);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "S/. 0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(397, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(135, 24);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(53, 17);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Motor";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 70);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Encerado";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Lavado Básico";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Lavado Exterior";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radLavBasEn);
            this.groupBox2.Controls.Add(this.radLavCom);
            this.groupBox2.Controls.Add(this.radLavBasMot);
            this.groupBox2.Controls.Add(this.radLavBásico);
            this.groupBox2.Controls.Add(this.radLavExterno);
            this.groupBox2.Location = new System.Drawing.Point(29, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquetes de Lavado";
            // 
            // radLavBasEn
            // 
            this.radLavBasEn.AutoSize = true;
            this.radLavBasEn.Location = new System.Drawing.Point(26, 96);
            this.radLavBasEn.Name = "radLavBasEn";
            this.radLavBasEn.Size = new System.Drawing.Size(154, 17);
            this.radLavBasEn.TabIndex = 4;
            this.radLavBasEn.TabStop = true;
            this.radLavBasEn.Text = "Lavado Básico + Encerado";
            this.radLavBasEn.UseVisualStyleBackColor = true;
            // 
            // radLavCom
            // 
            this.radLavCom.AutoSize = true;
            this.radLavCom.Location = new System.Drawing.Point(26, 119);
            this.radLavCom.Name = "radLavCom";
            this.radLavCom.Size = new System.Drawing.Size(108, 17);
            this.radLavCom.TabIndex = 3;
            this.radLavCom.TabStop = true;
            this.radLavCom.Text = "Lavado Completo";
            this.toolTip1.SetToolTip(this.radLavCom, "Lavado Básico + Motor + Encerado");
            this.radLavCom.UseVisualStyleBackColor = true;
            // 
            // radLavBasMot
            // 
            this.radLavBasMot.AutoSize = true;
            this.radLavBasMot.Location = new System.Drawing.Point(26, 73);
            this.radLavBasMot.Name = "radLavBasMot";
            this.radLavBasMot.Size = new System.Drawing.Size(135, 17);
            this.radLavBasMot.TabIndex = 2;
            this.radLavBasMot.TabStop = true;
            this.radLavBasMot.Text = "Lavado Básico + Motor";
            this.toolTip1.SetToolTip(this.radLavBasMot, "Lavado Básico + Encerado");
            this.radLavBasMot.UseVisualStyleBackColor = true;
            // 
            // radLavBásico
            // 
            this.radLavBásico.AutoSize = true;
            this.radLavBásico.Location = new System.Drawing.Point(26, 50);
            this.radLavBásico.Name = "radLavBásico";
            this.radLavBásico.Size = new System.Drawing.Size(96, 17);
            this.radLavBásico.TabIndex = 1;
            this.radLavBásico.TabStop = true;
            this.radLavBásico.Text = "Lavado Básico";
            this.toolTip1.SetToolTip(this.radLavBásico, "Lavado Carroceria, llantas, guardabarros, aspirado, limpieza interior.");
            this.radLavBásico.UseVisualStyleBackColor = true;
            this.radLavBásico.CheckedChanged += new System.EventHandler(this.radLavBásico_CheckedChanged);
            // 
            // radLavExterno
            // 
            this.radLavExterno.AutoSize = true;
            this.radLavExterno.Location = new System.Drawing.Point(26, 27);
            this.radLavExterno.Name = "radLavExterno";
            this.radLavExterno.Size = new System.Drawing.Size(100, 17);
            this.radLavExterno.TabIndex = 0;
            this.radLavExterno.TabStop = true;
            this.radLavExterno.Text = "Lavado Externo";
            this.toolTip1.SetToolTip(this.radLavExterno, "Lavado de carroceria, llantas, guardabarros.");
            this.radLavExterno.UseVisualStyleBackColor = true;
            this.radLavExterno.CheckedChanged += new System.EventHandler(this.radLavExterno_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(397, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Personaliza tu Servicio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "frmSeleccionServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Servicios a Vehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radLavBasMot;
        private System.Windows.Forms.RadioButton radLavBásico;
        private System.Windows.Forms.RadioButton radLavExterno;
        private System.Windows.Forms.RadioButton radLavCom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radLavBasEn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}