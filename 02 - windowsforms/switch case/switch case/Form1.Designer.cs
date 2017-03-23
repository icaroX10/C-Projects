namespace switch_case
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.txtLab = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(169, 79);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 0;
            this.cbMes.Text = "Selecione o mes";
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // txtLab
            // 
            this.txtLab.AutoSize = true;
            this.txtLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab.Location = new System.Drawing.Point(12, 79);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(151, 24);
            this.txtLab.TabIndex = 1;
            this.txtLab.Text = "Escolha um Mês";
            this.txtLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmes
            // 
            this.txtmes.AutoSize = true;
            this.txtmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.Location = new System.Drawing.Point(32, 143);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(0, 22);
            this.txtmes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 262);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.cbMes);
            this.Name = "Form1";
            this.Text = "OLA MUNDO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label txtLab;
        private System.Windows.Forms.Label txtmes;
    }
}

