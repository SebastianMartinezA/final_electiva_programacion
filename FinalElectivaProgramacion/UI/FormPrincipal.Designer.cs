namespace UI
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCrearInfraccion = new System.Windows.Forms.Button();
            this.buttonModifInfraccion = new System.Windows.Forms.Button();
            this.buttonElimInfraccion = new System.Windows.Forms.Button();
            this.buttonMostrarInfraccion = new System.Windows.Forms.Button();
            this.buttonMostrarIncidente = new System.Windows.Forms.Button();
            this.buttonElimIncidente = new System.Windows.Forms.Button();
            this.buttonModifIncidente = new System.Windows.Forms.Button();
            this.buttonCrearIncidente = new System.Windows.Forms.Button();
            this.listBoxInfraccion = new System.Windows.Forms.ListBox();
            this.listBoxIncidente = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxInfraccion);
            this.tabPage1.Controls.Add(this.buttonMostrarInfraccion);
            this.tabPage1.Controls.Add(this.buttonElimInfraccion);
            this.tabPage1.Controls.Add(this.buttonModifInfraccion);
            this.tabPage1.Controls.Add(this.buttonCrearInfraccion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infracción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxIncidente);
            this.tabPage2.Controls.Add(this.buttonMostrarIncidente);
            this.tabPage2.Controls.Add(this.buttonElimIncidente);
            this.tabPage2.Controls.Add(this.buttonModifIncidente);
            this.tabPage2.Controls.Add(this.buttonCrearIncidente);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incidente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pago";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCrearInfraccion
            // 
            this.buttonCrearInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearInfraccion.Location = new System.Drawing.Point(34, 43);
            this.buttonCrearInfraccion.Name = "buttonCrearInfraccion";
            this.buttonCrearInfraccion.Size = new System.Drawing.Size(145, 25);
            this.buttonCrearInfraccion.TabIndex = 0;
            this.buttonCrearInfraccion.Text = "Crear";
            this.buttonCrearInfraccion.UseVisualStyleBackColor = true;
            this.buttonCrearInfraccion.Click += new System.EventHandler(this.buttonCrearInfraccion_Click);
            // 
            // buttonModifInfraccion
            // 
            this.buttonModifInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifInfraccion.Location = new System.Drawing.Point(34, 74);
            this.buttonModifInfraccion.Name = "buttonModifInfraccion";
            this.buttonModifInfraccion.Size = new System.Drawing.Size(145, 25);
            this.buttonModifInfraccion.TabIndex = 1;
            this.buttonModifInfraccion.Text = "Modificar";
            this.buttonModifInfraccion.UseVisualStyleBackColor = true;
            this.buttonModifInfraccion.Click += new System.EventHandler(this.buttonModifInfraccion_Click);
            // 
            // buttonElimInfraccion
            // 
            this.buttonElimInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimInfraccion.Location = new System.Drawing.Point(34, 105);
            this.buttonElimInfraccion.Name = "buttonElimInfraccion";
            this.buttonElimInfraccion.Size = new System.Drawing.Size(145, 25);
            this.buttonElimInfraccion.TabIndex = 2;
            this.buttonElimInfraccion.Text = "Eliminar";
            this.buttonElimInfraccion.UseVisualStyleBackColor = true;
            this.buttonElimInfraccion.Click += new System.EventHandler(this.buttonElimInfraccion_Click);
            // 
            // buttonMostrarInfraccion
            // 
            this.buttonMostrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarInfraccion.Location = new System.Drawing.Point(34, 136);
            this.buttonMostrarInfraccion.Name = "buttonMostrarInfraccion";
            this.buttonMostrarInfraccion.Size = new System.Drawing.Size(145, 25);
            this.buttonMostrarInfraccion.TabIndex = 3;
            this.buttonMostrarInfraccion.Text = "Mostrar";
            this.buttonMostrarInfraccion.UseVisualStyleBackColor = true;
            this.buttonMostrarInfraccion.Click += new System.EventHandler(this.buttonMostrarInfraccion_Click);
            // 
            // buttonMostrarIncidente
            // 
            this.buttonMostrarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarIncidente.Location = new System.Drawing.Point(34, 136);
            this.buttonMostrarIncidente.Name = "buttonMostrarIncidente";
            this.buttonMostrarIncidente.Size = new System.Drawing.Size(145, 25);
            this.buttonMostrarIncidente.TabIndex = 7;
            this.buttonMostrarIncidente.Text = "Mostrar";
            this.buttonMostrarIncidente.UseVisualStyleBackColor = true;
            // 
            // buttonElimIncidente
            // 
            this.buttonElimIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimIncidente.Location = new System.Drawing.Point(34, 105);
            this.buttonElimIncidente.Name = "buttonElimIncidente";
            this.buttonElimIncidente.Size = new System.Drawing.Size(145, 25);
            this.buttonElimIncidente.TabIndex = 6;
            this.buttonElimIncidente.Text = "Eliminar";
            this.buttonElimIncidente.UseVisualStyleBackColor = true;
            // 
            // buttonModifIncidente
            // 
            this.buttonModifIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifIncidente.Location = new System.Drawing.Point(34, 74);
            this.buttonModifIncidente.Name = "buttonModifIncidente";
            this.buttonModifIncidente.Size = new System.Drawing.Size(145, 25);
            this.buttonModifIncidente.TabIndex = 5;
            this.buttonModifIncidente.Text = "Modificar";
            this.buttonModifIncidente.UseVisualStyleBackColor = true;
            // 
            // buttonCrearIncidente
            // 
            this.buttonCrearIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearIncidente.Location = new System.Drawing.Point(34, 43);
            this.buttonCrearIncidente.Name = "buttonCrearIncidente";
            this.buttonCrearIncidente.Size = new System.Drawing.Size(145, 25);
            this.buttonCrearIncidente.TabIndex = 4;
            this.buttonCrearIncidente.Text = "Crear";
            this.buttonCrearIncidente.UseVisualStyleBackColor = true;
            // 
            // listBoxInfraccion
            // 
            this.listBoxInfraccion.FormattingEnabled = true;
            this.listBoxInfraccion.ItemHeight = 15;
            this.listBoxInfraccion.Location = new System.Drawing.Point(484, 3);
            this.listBoxInfraccion.Name = "listBoxInfraccion";
            this.listBoxInfraccion.Size = new System.Drawing.Size(308, 409);
            this.listBoxInfraccion.TabIndex = 4;
            // 
            // listBoxIncidente
            // 
            this.listBoxIncidente.FormattingEnabled = true;
            this.listBoxIncidente.ItemHeight = 15;
            this.listBoxIncidente.Location = new System.Drawing.Point(484, 3);
            this.listBoxIncidente.Name = "listBoxIncidente";
            this.listBoxIncidente.Size = new System.Drawing.Size(308, 409);
            this.listBoxIncidente.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "Dirección de Tránsito";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonMostrarInfraccion;
        private Button buttonElimInfraccion;
        private Button buttonModifInfraccion;
        private Button buttonCrearInfraccion;
        private TabPage tabPage2;
        private Button buttonMostrarIncidente;
        private Button buttonElimIncidente;
        private Button buttonModifIncidente;
        private Button buttonCrearIncidente;
        private TabPage tabPage3;
        private ListBox listBoxInfraccion;
        private ListBox listBoxIncidente;
    }
}