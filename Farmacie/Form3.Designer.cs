namespace Farmacie
{
    partial class Form3
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.buttonLogin1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(184, 64);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(116, 22);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(184, 132);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(116, 22);
            this.textBoxParola.TabIndex = 1;
            this.textBoxParola.UseSystemPasswordChar = true;
            this.textBoxParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(222, 31);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 17);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "user";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(222, 103);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(48, 17);
            this.labelParola.TabIndex = 3;
            this.labelParola.Text = "parola";
            // 
            // buttonLogin1
            // 
            this.buttonLogin1.Location = new System.Drawing.Point(205, 173);
            this.buttonLogin1.Name = "buttonLogin1";
            this.buttonLogin1.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin1.TabIndex = 4;
            this.buttonLogin1.Text = "login";
            this.buttonLogin1.UseVisualStyleBackColor = true;
            this.buttonLogin1.Click += new System.EventHandler(this.buttonLogin1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 278);
            this.Controls.Add(this.buttonLogin1);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUser);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonLogin1;
    }
}