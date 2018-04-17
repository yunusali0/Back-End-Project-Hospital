namespace csharp_15
{
    partial class Form1
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
            this.btnCheckUp = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnPasient = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckUp
            // 
            this.btnCheckUp.Location = new System.Drawing.Point(44, 100);
            this.btnCheckUp.Name = "btnCheckUp";
            this.btnCheckUp.Size = new System.Drawing.Size(187, 139);
            this.btnCheckUp.TabIndex = 0;
            this.btnCheckUp.Text = "Check Up";
            this.btnCheckUp.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(309, 100);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(187, 139);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            // 
            // btnPasient
            // 
            this.btnPasient.Location = new System.Drawing.Point(597, 100);
            this.btnPasient.Name = "btnPasient";
            this.btnPasient.Size = new System.Drawing.Size(187, 139);
            this.btnPasient.TabIndex = 2;
            this.btnPasient.Text = "Pasient";
            this.btnPasient.UseVisualStyleBackColor = true;
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(863, 100);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(187, 139);
            this.btnType.TabIndex = 3;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 674);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnPasient);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnCheckUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckUp;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPasient;
        private System.Windows.Forms.Button btnType;
    }
}

