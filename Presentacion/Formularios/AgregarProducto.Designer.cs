namespace Presentacion.Formularios
{
    partial class AgregarProducto
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
            this.groupProd = new System.Windows.Forms.GroupBox();
            this.btntest = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProd
            // 
            this.groupProd.Controls.Add(this.btntest);
            this.groupProd.Controls.Add(this.txtprecio);
            this.groupProd.Controls.Add(this.txtdescription);
            this.groupProd.Controls.Add(this.txtcodigo);
            this.groupProd.Controls.Add(this.txtid);
            this.groupProd.Controls.Add(this.label4);
            this.groupProd.Controls.Add(this.dtpfecha);
            this.groupProd.Controls.Add(this.label3);
            this.groupProd.Controls.Add(this.label2);
            this.groupProd.Controls.Add(this.label1);
            this.groupProd.Controls.Add(this.lblid);
            this.groupProd.Location = new System.Drawing.Point(81, 85);
            this.groupProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupProd.Name = "groupProd";
            this.groupProd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupProd.Size = new System.Drawing.Size(1082, 375);
            this.groupProd.TabIndex = 0;
            this.groupProd.TabStop = false;
            this.groupProd.Text = "Agregar Producto";
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(470, 41);
            this.btntest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(225, 29);
            this.btntest.TabIndex = 2;
            this.btntest.Text = "Test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(173, 242);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(224, 26);
            this.txtprecio.TabIndex = 9;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(173, 151);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(224, 62);
            this.txtdescription.TabIndex = 8;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(173, 98);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(224, 26);
            this.txtcodigo.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(173, 49);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(224, 26);
            this.txtid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(173, 302);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(224, 26);
            this.dtpfecha.TabIndex = 4;
            this.dtpfecha.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(32, 49);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(81, 486);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(199, 485);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 29);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 485);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 576);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupProd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarProducto_FormClosing);
            this.groupProd.ResumeLayout(false);
            this.groupProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupProd;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}