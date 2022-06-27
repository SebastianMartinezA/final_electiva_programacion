﻿namespace UI
{
    partial class FormInfraccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonConf = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.listBoxIncidentes = new System.Windows.Forms.ListBox();
            this.labelIncidentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infraccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonto.Location = new System.Drawing.Point(36, 272);
            this.textBoxMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMonto.MaxLength = 50;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(333, 29);
            this.textBoxMonto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.AllowDrop = true;
            this.textBoxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(36, 199);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDesc.MaxLength = 50;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(333, 29);
            this.textBoxDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Leve",
            "Grave"});
            this.comboBoxTipo.Location = new System.Drawing.Point(36, 124);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(333, 29);
            this.comboBoxTipo.TabIndex = 1;
            // 
            // buttonConf
            // 
            this.buttonConf.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConf.Location = new System.Drawing.Point(268, 344);
            this.buttonConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size(101, 47);
            this.buttonConf.TabIndex = 4;
            this.buttonConf.Text = "Confirmar";
            this.buttonConf.UseVisualStyleBackColor = false;
            this.buttonConf.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(135, 344);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 47);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificar.Location = new System.Drawing.Point(268, 344);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(101, 47);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // listBoxIncidentes
            // 
            this.listBoxIncidentes.FormattingEnabled = true;
            this.listBoxIncidentes.ItemHeight = 15;
            this.listBoxIncidentes.Location = new System.Drawing.Point(434, 46);
            this.listBoxIncidentes.Name = "listBoxIncidentes";
            this.listBoxIncidentes.Size = new System.Drawing.Size(238, 364);
            this.listBoxIncidentes.TabIndex = 14;
            this.listBoxIncidentes.Visible = false;
            this.listBoxIncidentes.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxIncidentes_Format);
            // 
            // labelIncidentes
            // 
            this.labelIncidentes.AutoSize = true;
            this.labelIncidentes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIncidentes.Location = new System.Drawing.Point(434, 18);
            this.labelIncidentes.Name = "labelIncidentes";
            this.labelIncidentes.Size = new System.Drawing.Size(100, 25);
            this.labelIncidentes.TabIndex = 15;
            this.labelIncidentes.Text = "Incidentes";
            // 
            // FormInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 422);
            this.ControlBox = false;
            this.Controls.Add(this.labelIncidentes);
            this.Controls.Add(this.listBoxIncidentes);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonConf);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInfraccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infraccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox textBoxMonto;
        private Label label3;
        private TextBox textBoxDesc;
        private Label label2;
        private ComboBox comboBoxTipo;
        private Button buttonConf;
        private Button buttonCancel;
        private Button buttonModificar;
        private ListBox listBoxIncidentes;
        private Label labelIncidentes;
    }
}