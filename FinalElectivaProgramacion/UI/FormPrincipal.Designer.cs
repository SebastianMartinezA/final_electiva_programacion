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
            this.listBoxInfraccion = new System.Windows.Forms.ListBox();
            this.buttonMostrarInfraccion = new System.Windows.Forms.Button();
            this.buttonElimInfraccion = new System.Windows.Forms.Button();
            this.buttonModifInfraccion = new System.Windows.Forms.Button();
            this.buttonCrearInfraccion = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxIncidente = new System.Windows.Forms.ListBox();
            this.buttonMostrarIncidente = new System.Windows.Forms.Button();
            this.buttonElimIncidente = new System.Windows.Forms.Button();
            this.buttonModifIncidente = new System.Windows.Forms.Button();
            this.buttonCrearIncidente = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // listBoxInfraccion
            // 
            this.listBoxInfraccion.FormattingEnabled = true;
            this.listBoxInfraccion.ItemHeight = 15;
            this.listBoxInfraccion.Location = new System.Drawing.Point(431, 7);
            this.listBoxInfraccion.Name = "listBoxInfraccion";
            this.listBoxInfraccion.Size = new System.Drawing.Size(355, 409);
            this.listBoxInfraccion.TabIndex = 4;
            this.listBoxInfraccion.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxInfraccion_Format);
            // 
            // buttonMostrarInfraccion
            // 
            this.buttonMostrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarInfraccion.Location = new System.Drawing.Point(56, 193);
            this.buttonMostrarInfraccion.Name = "buttonMostrarInfraccion";
            this.buttonMostrarInfraccion.Size = new System.Drawing.Size(185, 58);
            this.buttonMostrarInfraccion.TabIndex = 3;
            this.buttonMostrarInfraccion.Text = "Mostrar infraccion";
            this.buttonMostrarInfraccion.UseVisualStyleBackColor = true;
            this.buttonMostrarInfraccion.Click += new System.EventHandler(this.buttonMostrarInfraccion_Click);
            // 
            // buttonElimInfraccion
            // 
            this.buttonElimInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElimInfraccion.Location = new System.Drawing.Point(56, 266);
            this.buttonElimInfraccion.Name = "buttonElimInfraccion";
            this.buttonElimInfraccion.Size = new System.Drawing.Size(185, 58);
            this.buttonElimInfraccion.TabIndex = 2;
            this.buttonElimInfraccion.Text = "Eliminar infraccion";
            this.buttonElimInfraccion.UseVisualStyleBackColor = true;
            this.buttonElimInfraccion.Click += new System.EventHandler(this.buttonElimInfraccion_Click);
            // 
            // buttonModifInfraccion
            // 
            this.buttonModifInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifInfraccion.Location = new System.Drawing.Point(56, 120);
            this.buttonModifInfraccion.Name = "buttonModifInfraccion";
            this.buttonModifInfraccion.Size = new System.Drawing.Size(185, 58);
            this.buttonModifInfraccion.TabIndex = 1;
            this.buttonModifInfraccion.Text = "Modificar infraccion";
            this.buttonModifInfraccion.UseVisualStyleBackColor = true;
            this.buttonModifInfraccion.Click += new System.EventHandler(this.buttonModifInfraccion_Click);
            // 
            // buttonCrearInfraccion
            // 
            this.buttonCrearInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearInfraccion.Location = new System.Drawing.Point(56, 46);
            this.buttonCrearInfraccion.Name = "buttonCrearInfraccion";
            this.buttonCrearInfraccion.Size = new System.Drawing.Size(185, 58);
            this.buttonCrearInfraccion.TabIndex = 0;
            this.buttonCrearInfraccion.Text = "Crear infraccion";
            this.buttonCrearInfraccion.UseVisualStyleBackColor = true;
            this.buttonCrearInfraccion.Click += new System.EventHandler(this.buttonCrearInfraccion_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(56, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar pago";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxIncidente
            // 
            this.listBoxIncidente.FormattingEnabled = true;
            this.listBoxIncidente.ItemHeight = 15;
            this.listBoxIncidente.Location = new System.Drawing.Point(431, 7);
            this.listBoxIncidente.Name = "listBoxIncidente";
            this.listBoxIncidente.Size = new System.Drawing.Size(355, 409);
            this.listBoxIncidente.TabIndex = 8;
            this.listBoxIncidente.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxIncidente_Format);
            // 
            // buttonMostrarIncidente
            // 
            this.buttonMostrarIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarIncidente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarIncidente.Location = new System.Drawing.Point(56, 180);
            this.buttonMostrarIncidente.Name = "buttonMostrarIncidente";
            this.buttonMostrarIncidente.Size = new System.Drawing.Size(185, 58);
            this.buttonMostrarIncidente.TabIndex = 7;
            this.buttonMostrarIncidente.Text = "Mostrar incidente";
            this.buttonMostrarIncidente.UseVisualStyleBackColor = true;
            this.buttonMostrarIncidente.Click += new System.EventHandler(this.buttonMostrarIncidente_Click);
            // 
            // buttonElimIncidente
            // 
            this.buttonElimIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimIncidente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElimIncidente.Location = new System.Drawing.Point(56, 253);
            this.buttonElimIncidente.Name = "buttonElimIncidente";
            this.buttonElimIncidente.Size = new System.Drawing.Size(185, 58);
            this.buttonElimIncidente.TabIndex = 6;
            this.buttonElimIncidente.Text = "Eliminar incidente";
            this.buttonElimIncidente.UseVisualStyleBackColor = true;
            this.buttonElimIncidente.Click += new System.EventHandler(this.buttonElimIncidente_Click);
            // 
            // buttonModifIncidente
            // 
            this.buttonModifIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifIncidente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifIncidente.Location = new System.Drawing.Point(56, 107);
            this.buttonModifIncidente.Name = "buttonModifIncidente";
            this.buttonModifIncidente.Size = new System.Drawing.Size(185, 58);
            this.buttonModifIncidente.TabIndex = 5;
            this.buttonModifIncidente.Text = "Modificar incidente";
            this.buttonModifIncidente.UseVisualStyleBackColor = true;
            // 
            // buttonCrearIncidente
            // 
            this.buttonCrearIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearIncidente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearIncidente.Location = new System.Drawing.Point(56, 33);
            this.buttonCrearIncidente.Name = "buttonCrearIncidente";
            this.buttonCrearIncidente.Size = new System.Drawing.Size(185, 58);
            this.buttonCrearIncidente.TabIndex = 4;
            this.buttonCrearIncidente.Text = "Crear incidente";
            this.buttonCrearIncidente.UseVisualStyleBackColor = true;
            this.buttonCrearIncidente.Click += new System.EventHandler(this.buttonCrearIncidente_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pago";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 401);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "Dirección de Tránsito";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private ListView listView1;
        private Button button1;
    }
}