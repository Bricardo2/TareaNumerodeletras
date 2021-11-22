
namespace TareaNumerodeletras
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcaracter = new System.Windows.Forms.TextBox();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los caracteres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Al revez";
            // 
            // txtcaracter
            // 
            this.txtcaracter.Location = new System.Drawing.Point(300, 79);
            this.txtcaracter.Name = "txtcaracter";
            this.txtcaracter.Size = new System.Drawing.Size(307, 20);
            this.txtcaracter.TabIndex = 2;
            // 
            // txtresul
            // 
            this.txtresul.Location = new System.Drawing.Point(300, 145);
            this.txtresul.Name = "txtresul";
            this.txtresul.Size = new System.Drawing.Size(307, 20);
            this.txtresul.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Realizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.txtcaracter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcaracter;
        private System.Windows.Forms.TextBox txtresul;
        private System.Windows.Forms.Button button1;
    }
}