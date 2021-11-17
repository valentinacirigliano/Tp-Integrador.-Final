
namespace TpIntegradorLibros.Windows
{
    partial class FrmLibroAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreLibroTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.EditorialCB = new System.Windows.Forms.ComboBox();
            this.TemaCB = new System.Windows.Forms.ComboBox();
            this.PaginasNum = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.ISBNtb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PaginasNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editorial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Páginas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Autor:";
            // 
            // NombreLibroTB
            // 
            this.NombreLibroTB.Location = new System.Drawing.Point(140, 22);
            this.NombreLibroTB.Name = "NombreLibroTB";
            this.NombreLibroTB.Size = new System.Drawing.Size(237, 20);
            this.NombreLibroTB.TabIndex = 0;
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(140, 221);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(237, 20);
            this.AutorTB.TabIndex = 5;
            // 
            // EditorialCB
            // 
            this.EditorialCB.FormattingEnabled = true;
            this.EditorialCB.Location = new System.Drawing.Point(140, 60);
            this.EditorialCB.Name = "EditorialCB";
            this.EditorialCB.Size = new System.Drawing.Size(237, 21);
            this.EditorialCB.TabIndex = 1;
            // 
            // TemaCB
            // 
            this.TemaCB.FormattingEnabled = true;
            this.TemaCB.Location = new System.Drawing.Point(140, 99);
            this.TemaCB.Name = "TemaCB";
            this.TemaCB.Size = new System.Drawing.Size(237, 21);
            this.TemaCB.TabIndex = 2;
            // 
            // PaginasNum
            // 
            this.PaginasNum.Location = new System.Drawing.Point(140, 139);
            this.PaginasNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PaginasNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaginasNum.Name = "PaginasNum";
            this.PaginasNum.Size = new System.Drawing.Size(54, 20);
            this.PaginasNum.TabIndex = 3;
            this.PaginasNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::TpIntegradorLibros.Windows.Properties.Resources.delete_24px;
            this.CancelButton.Location = new System.Drawing.Point(229, 266);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 61);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Image = global::TpIntegradorLibros.Windows.Properties.Resources.save_24px;
            this.OKbutton.Location = new System.Drawing.Point(112, 266);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(83, 61);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ISBNtb
            // 
            this.ISBNtb.Location = new System.Drawing.Point(140, 181);
            this.ISBNtb.MaxLength = 13;
            this.ISBNtb.Name = "ISBNtb";
            this.ISBNtb.Size = new System.Drawing.Size(237, 20);
            this.ISBNtb.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLibroAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 349);
            this.Controls.Add(this.ISBNtb);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.PaginasNum);
            this.Controls.Add(this.TemaCB);
            this.Controls.Add(this.EditorialCB);
            this.Controls.Add(this.AutorTB);
            this.Controls.Add(this.NombreLibroTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLibroAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Agregar libro";
            ((System.ComponentModel.ISupportInitialize)(this.PaginasNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreLibroTB;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.ComboBox EditorialCB;
        private System.Windows.Forms.ComboBox TemaCB;
        private System.Windows.Forms.NumericUpDown PaginasNum;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ISBNtb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}