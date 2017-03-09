namespace windowsForms
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
            this.titulo = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.btncalcidade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(112, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(323, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Curso Tecnico de Informatica";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(202, 35);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(112, 25);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "Aprenda...";
            this.subtitle.Click += new System.EventHandler(this.subtitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite Sua idade:";
            // 
            // txtidade
            // 
            this.txtidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtidade.Location = new System.Drawing.Point(155, 148);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(387, 20);
            this.txtidade.TabIndex = 3;
            this.txtidade.TextChanged += new System.EventHandler(this.txtidade_TextChanged);
            // 
            // btncalcidade
            // 
            this.btncalcidade.BackColor = System.Drawing.SystemColors.Menu;
            this.btncalcidade.Location = new System.Drawing.Point(426, 400);
            this.btncalcidade.Name = "btncalcidade";
            this.btncalcidade.Size = new System.Drawing.Size(116, 47);
            this.btncalcidade.TabIndex = 4;
            this.btncalcidade.Text = "Envia";
            this.btncalcidade.UseVisualStyleBackColor = false;
            this.btncalcidade.Click += new System.EventHandler(this.btncalcidade_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncalcidade);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Button btncalcidade;
        private System.Windows.Forms.Label label2;
    }
}

