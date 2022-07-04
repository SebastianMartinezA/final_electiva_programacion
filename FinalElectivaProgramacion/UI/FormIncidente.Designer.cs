namespace UI
{
    partial class FormIncidente
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
            this.buttonConf = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxInfraccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerIncidente = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConf
            // 
            this.buttonConf.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConf.Location = new System.Drawing.Point(230, 298);
            this.buttonConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size(87, 41);
            this.buttonConf.TabIndex = 18;
            this.buttonConf.Text = "Confirmar";
            this.buttonConf.UseVisualStyleBackColor = false;
            this.buttonConf.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(116, 298);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 41);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(31, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Patente";
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPatente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPatente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPatente.Location = new System.Drawing.Point(31, 236);
            this.textBoxPatente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatente.MaxLength = 50;
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(286, 29);
            this.textBoxPatente.TabIndex = 17;
            this.textBoxPatente.TextChanged += new System.EventHandler(this.textBoxPatente_TextChanged);
            this.textBoxPatente.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPatente_Validating);
            this.textBoxPatente.Validated += new System.EventHandler(this.textBoxPatente_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(31, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Infraccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha";
            // 
            // comboBoxInfraccion
            // 
            this.comboBoxInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxInfraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInfraccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxInfraccion.FormattingEnabled = true;
            this.comboBoxInfraccion.Items.AddRange(new object[] {
            "Leve",
            "Grave"});
            this.comboBoxInfraccion.Location = new System.Drawing.Point(31, 172);
            this.comboBoxInfraccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInfraccion.Name = "comboBoxInfraccion";
            this.comboBoxInfraccion.Size = new System.Drawing.Size(286, 29);
            this.comboBoxInfraccion.TabIndex = 14;
            this.comboBoxInfraccion.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxInfraccion_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Incidente";
            // 
            // dateTimePickerIncidente
            // 
            this.dateTimePickerIncidente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerIncidente.Location = new System.Drawing.Point(31, 108);
            this.dateTimePickerIncidente.MaxDate = new System.DateTime(2022, 6, 28, 0, 0, 0, 0);
            this.dateTimePickerIncidente.Name = "dateTimePickerIncidente";
            this.dateTimePickerIncidente.Size = new System.Drawing.Size(286, 29);
            this.dateTimePickerIncidente.TabIndex = 24;
            this.dateTimePickerIncidente.Value = new System.DateTime(2022, 6, 28, 0, 0, 0, 0);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 366);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePickerIncidente);
            this.Controls.Add(this.buttonConf);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInfraccion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxInfraccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncidente;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}