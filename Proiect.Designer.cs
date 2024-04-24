    namespace WindowsFormsApp1
{
    partial class FrmProiect
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScor = new System.Windows.Forms.TextBox();
            this.lblAfisarea = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(136, 87);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(194, 29);
            this.txtNume.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(136, 122);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(194, 29);
            this.txtPrenume.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scor";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtScor
            // 
            this.txtScor.Location = new System.Drawing.Point(136, 157);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(194, 29);
            this.txtScor.TabIndex = 2;
            // 
            // lblAfisarea
            // 
            this.lblAfisarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAfisarea.Location = new System.Drawing.Point(45, 28);
            this.lblAfisarea.Name = "lblAfisarea";
            this.lblAfisarea.Size = new System.Drawing.Size(285, 56);
            this.lblAfisarea.TabIndex = 6;
            this.lblAfisarea.Visible = false;
            // 
            // btnSalvare
            // 
            this.btnSalvare.AutoSize = true;
            this.btnSalvare.Location = new System.Drawing.Point(412, 87);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(124, 32);
            this.btnSalvare.TabIndex = 3;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.AutoSize = true;
            this.btnAdaugare.Location = new System.Drawing.Point(412, 125);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(124, 32);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.AutoSize = true;
            this.btnIesire.Location = new System.Drawing.Point(43, 207);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(89, 32);
            this.btnIesire.TabIndex = 5;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Afiare tot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Scor mare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmProiect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.lblAfisarea);
            this.Controls.Add(this.txtScor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProiect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proiect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScor;
        private System.Windows.Forms.Label lblAfisarea;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

