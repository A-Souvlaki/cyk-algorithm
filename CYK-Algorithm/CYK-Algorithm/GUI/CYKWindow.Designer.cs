
namespace CYK_Algorithm.GUI
{
    partial class CYKWindow
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
            this.dGVMatriz = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.butAplicar = new MetroFramework.Controls.MetroButton();
            this.txtCadena = new MetroFramework.Controls.MetroTextBox();
            this.txtGramatica = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMatriz
            // 
            this.dGVMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVMatriz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGVMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMatriz.Location = new System.Drawing.Point(352, 107);
            this.dGVMatriz.Name = "dGVMatriz";
            this.dGVMatriz.Size = new System.Drawing.Size(472, 127);
            this.dGVMatriz.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Gramatica:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 302);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Cadena";
            // 
            // butAplicar
            // 
            this.butAplicar.Location = new System.Drawing.Point(58, 363);
            this.butAplicar.Name = "butAplicar";
            this.butAplicar.Size = new System.Drawing.Size(84, 28);
            this.butAplicar.TabIndex = 8;
            this.butAplicar.Text = "Aplicar";
            this.butAplicar.UseSelectable = true;
            this.butAplicar.Click += new System.EventHandler(this.butAplicar_Click_1);
            // 
            // txtCadena
            // 
            this.txtCadena.AllowDrop = true;
            // 
            // 
            // 
            this.txtCadena.CustomButton.Image = null;
            this.txtCadena.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtCadena.CustomButton.Name = "";
            this.txtCadena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCadena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCadena.CustomButton.TabIndex = 1;
            this.txtCadena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCadena.CustomButton.UseSelectable = true;
            this.txtCadena.CustomButton.Visible = false;
            this.txtCadena.Lines = new string[0];
            this.txtCadena.Location = new System.Drawing.Point(58, 324);
            this.txtCadena.MaxLength = 32767;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.PasswordChar = '\0';
            this.txtCadena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCadena.SelectedText = "";
            this.txtCadena.SelectionLength = 0;
            this.txtCadena.SelectionStart = 0;
            this.txtCadena.ShortcutsEnabled = true;
            this.txtCadena.Size = new System.Drawing.Size(269, 23);
            this.txtCadena.TabIndex = 9;
            this.txtCadena.UseSelectable = true;
            this.txtCadena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCadena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGramatica
            // 
            // 
            // 
            // 
            this.txtGramatica.CustomButton.Image = null;
            this.txtGramatica.CustomButton.Location = new System.Drawing.Point(97, 2);
            this.txtGramatica.CustomButton.Name = "";
            this.txtGramatica.CustomButton.Size = new System.Drawing.Size(169, 169);
            this.txtGramatica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGramatica.CustomButton.TabIndex = 1;
            this.txtGramatica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGramatica.CustomButton.UseSelectable = true;
            this.txtGramatica.CustomButton.Visible = false;
            this.txtGramatica.Lines = new string[0];
            this.txtGramatica.Location = new System.Drawing.Point(58, 107);
            this.txtGramatica.MaxLength = 32767;
            this.txtGramatica.Multiline = true;
            this.txtGramatica.Name = "txtGramatica";
            this.txtGramatica.PasswordChar = '\0';
            this.txtGramatica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGramatica.SelectedText = "";
            this.txtGramatica.SelectionLength = 0;
            this.txtGramatica.SelectionStart = 0;
            this.txtGramatica.ShortcutsEnabled = true;
            this.txtGramatica.Size = new System.Drawing.Size(269, 174);
            this.txtGramatica.TabIndex = 10;
            this.txtGramatica.UseSelectable = true;
            this.txtGramatica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGramatica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(352, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Matriz:";
            // 
            // CYKWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtGramatica);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.butAplicar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dGVMatriz);
            this.MaximizeBox = false;
            this.Name = "CYKWindow";
            this.Text = "CYK-Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMatriz;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton butAplicar;
        private MetroFramework.Controls.MetroTextBox txtCadena;
        private MetroFramework.Controls.MetroTextBox txtGramatica;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}