namespace Farmacie
{
    partial class Form4
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
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.buttonCumpara = new System.Windows.Forms.Button();
            this.dataGridViewAfisare = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numarul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efecte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescriptie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisare)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(67, 51);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 0;
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(67, 125);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantitate.TabIndex = 1;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(67, 13);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 2;
            this.labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(64, 96);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(64, 17);
            this.labelCantitate.TabIndex = 3;
            this.labelCantitate.Text = "Cantitate";
            // 
            // buttonCumpara
            // 
            this.buttonCumpara.Location = new System.Drawing.Point(67, 194);
            this.buttonCumpara.Name = "buttonCumpara";
            this.buttonCumpara.Size = new System.Drawing.Size(75, 23);
            this.buttonCumpara.TabIndex = 4;
            this.buttonCumpara.Text = "Cumpara";
            this.buttonCumpara.UseVisualStyleBackColor = true;
            this.buttonCumpara.Click += new System.EventHandler(this.buttonCumpara_Click);
            // 
            // dataGridViewAfisare
            // 
            this.dataGridViewAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfisare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Pret,
            this.Numarul,
            this.Efecte,
            this.Prescriptie});
            this.dataGridViewAfisare.Location = new System.Drawing.Point(222, 13);
            this.dataGridViewAfisare.Name = "dataGridViewAfisare";
            this.dataGridViewAfisare.RowTemplate.Height = 24;
            this.dataGridViewAfisare.Size = new System.Drawing.Size(566, 306);
            this.dataGridViewAfisare.TabIndex = 15;
            this.dataGridViewAfisare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAfisare_MouseClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // Numarul
            // 
            this.Numarul.HeaderText = "Numarul";
            this.Numarul.Name = "Numarul";
            // 
            // Efecte
            // 
            this.Efecte.HeaderText = "Efecte";
            this.Efecte.Name = "Efecte";
            // 
            // Prescriptie
            // 
            this.Prescriptie.HeaderText = "Prescriptie";
            this.Prescriptie.Name = "Prescriptie";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAfisare);
            this.Controls.Add(this.buttonCumpara);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.textBoxNume);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button buttonCumpara;
        private System.Windows.Forms.DataGridView dataGridViewAfisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numarul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efecte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescriptie;
    }
}