namespace csharp_15
{
    partial class CheckUp
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
            this.dgvCheckups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbPasient = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.addCheckUp = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckups
            // 
            this.dgvCheckups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column10,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCheckups.Location = new System.Drawing.Point(579, 28);
            this.dgvCheckups.Name = "dgvCheckups";
            this.dgvCheckups.RowTemplate.Height = 33;
            this.dgvCheckups.Size = new System.Drawing.Size(1452, 808);
            this.dgvCheckups.TabIndex = 0;
            this.dgvCheckups.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCheckups_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasient *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note *";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(18, 353);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(367, 31);
            this.txtPrice.TabIndex = 6;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(18, 458);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(367, 212);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(18, 69);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(367, 33);
            this.cmbDoctor.TabIndex = 8;
            // 
            // cmbPasient
            // 
            this.cmbPasient.FormattingEnabled = true;
            this.cmbPasient.Location = new System.Drawing.Point(18, 167);
            this.cmbPasient.Name = "cmbPasient";
            this.cmbPasient.Size = new System.Drawing.Size(367, 33);
            this.cmbPasient.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(18, 272);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(367, 33);
            this.cmbType.TabIndex = 10;
            // 
            // addCheckUp
            // 
            this.addCheckUp.Location = new System.Drawing.Point(18, 718);
            this.addCheckUp.Name = "addCheckUp";
            this.addCheckUp.Size = new System.Drawing.Size(367, 45);
            this.addCheckUp.TabIndex = 11;
            this.addCheckUp.Text = "Add Check Up";
            this.addCheckUp.UseVisualStyleBackColor = true;
            this.addCheckUp.Click += new System.EventHandler(this.addCheckUp_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 678);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 718);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(367, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Check Up";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 778);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(367, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Check Up";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Doctor";
            this.Column2.Name = "Column2";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DoctorId";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pasinet";
            this.Column3.Name = "Column3";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "PasientId";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "TypeId";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Note";
            this.Column7.Name = "Column7";
            // 
            // CheckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2163, 861);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.addCheckUp);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbPasient);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCheckups);
            this.Name = "CheckUp";
            this.Text = "CheckUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPasient;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button addCheckUp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}