namespace Farmacie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxNumarul = new System.Windows.Forms.TextBox();
            this.radioButtonCu = new System.Windows.Forms.RadioButton();
            this.radioButtonFara = new System.Windows.Forms.RadioButton();
            this.checkBoxEfecteSecundare = new System.Windows.Forms.CheckedListBox();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.dataGridViewAfisare = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numarul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efecte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescriptie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFiltru = new System.Windows.Forms.ComboBox();
            this.buttonAfisare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prescpriptie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numarul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Efecte secundare";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(104, 43);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 5;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(104, 90);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 6;
            this.textBoxPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPret_KeyPress);
            // 
            // textBoxNumarul
            // 
            this.textBoxNumarul.Location = new System.Drawing.Point(104, 133);
            this.textBoxNumarul.Name = "textBoxNumarul";
            this.textBoxNumarul.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumarul.TabIndex = 7;
            this.textBoxNumarul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumarul_KeyPress);
            // 
            // radioButtonCu
            // 
            this.radioButtonCu.AutoSize = true;
            this.radioButtonCu.Location = new System.Drawing.Point(117, 186);
            this.radioButtonCu.Name = "radioButtonCu";
            this.radioButtonCu.Size = new System.Drawing.Size(46, 21);
            this.radioButtonCu.TabIndex = 8;
            this.radioButtonCu.TabStop = true;
            this.radioButtonCu.Text = "Cu";
            this.radioButtonCu.UseVisualStyleBackColor = true;
            // 
            // radioButtonFara
            // 
            this.radioButtonFara.AutoSize = true;
            this.radioButtonFara.Location = new System.Drawing.Point(181, 186);
            this.radioButtonFara.Name = "radioButtonFara";
            this.radioButtonFara.Size = new System.Drawing.Size(58, 21);
            this.radioButtonFara.TabIndex = 9;
            this.radioButtonFara.TabStop = true;
            this.radioButtonFara.Text = "Fara";
            this.radioButtonFara.UseVisualStyleBackColor = true;
            // 
            // checkBoxEfecteSecundare
            // 
            this.checkBoxEfecteSecundare.CheckOnClick = true;
            this.checkBoxEfecteSecundare.FormattingEnabled = true;
            this.checkBoxEfecteSecundare.Items.AddRange(new object[] {
            "Nimic",
            "Mancarimi",
            "Varsaturi",
            "Eruptii"});
            this.checkBoxEfecteSecundare.Location = new System.Drawing.Point(155, 240);
            this.checkBoxEfecteSecundare.Name = "checkBoxEfecteSecundare";
            this.checkBoxEfecteSecundare.Size = new System.Drawing.Size(128, 89);
            this.checkBoxEfecteSecundare.TabIndex = 10;
            this.checkBoxEfecteSecundare.Click += new System.EventHandler(this.checkBoxEfecteSecundare_Click);
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.Location = new System.Drawing.Point(12, 411);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(107, 41);
            this.buttonAdaugare.TabIndex = 11;
            this.buttonAdaugare.Text = "Adaugare";
            this.buttonAdaugare.UseVisualStyleBackColor = true;
            this.buttonAdaugare.Click += new System.EventHandler(this.adaugare_click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(155, 411);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(93, 41);
            this.buttonEditare.TabIndex = 12;
            this.buttonEditare.Text = "Editare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.editare_click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Location = new System.Drawing.Point(288, 411);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(93, 41);
            this.buttonStergere.TabIndex = 13;
            this.buttonStergere.Text = "Stergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.stergere_click);
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
            this.dataGridViewAfisare.Location = new System.Drawing.Point(344, 23);
            this.dataGridViewAfisare.Name = "dataGridViewAfisare";
            this.dataGridViewAfisare.RowTemplate.Height = 24;
            this.dataGridViewAfisare.Size = new System.Drawing.Size(566, 306);
            this.dataGridViewAfisare.TabIndex = 14;
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
            // comboBoxFiltru
            // 
            this.comboBoxFiltru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltru.FormattingEnabled = true;
            this.comboBoxFiltru.Location = new System.Drawing.Point(419, 345);
            this.comboBoxFiltru.Name = "comboBoxFiltru";
            this.comboBoxFiltru.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFiltru.TabIndex = 15;
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(649, 345);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(81, 24);
            this.buttonAfisare.TabIndex = 16;
            this.buttonAfisare.Text = "Afisare";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 464);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.comboBoxFiltru);
            this.Controls.Add(this.dataGridViewAfisare);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonAdaugare);
            this.Controls.Add(this.checkBoxEfecteSecundare);
            this.Controls.Add(this.radioButtonFara);
            this.Controls.Add(this.radioButtonCu);
            this.Controls.Add(this.textBoxNumarul);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxNumarul;
        private System.Windows.Forms.RadioButton radioButtonCu;
        private System.Windows.Forms.RadioButton radioButtonFara;
        private System.Windows.Forms.CheckedListBox checkBoxEfecteSecundare;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.Button buttonEditare;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.DataGridView dataGridViewAfisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numarul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efecte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescriptie;
        private System.Windows.Forms.ComboBox comboBoxFiltru;
        private System.Windows.Forms.Button buttonAfisare;
    }
}

