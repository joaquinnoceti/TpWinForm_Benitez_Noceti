
namespace TpWinForm_Benitez_Noceti
{
    partial class VistaPrevia
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescr = new System.Windows.Forms.RichTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboxCat = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblNomb = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(450, 96);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(213, 187);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 38;
            this.pbxArticulo.TabStop = false;
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.Location = new System.Drawing.Point(495, 26);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(107, 24);
            this.lblVistaPrevia.TabIndex = 37;
            this.lblVistaPrevia.Text = "Vista Previa";
            // 
            // txtImagen
            // 
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(166, 212);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.ReadOnly = true;
            this.txtImagen.Size = new System.Drawing.Size(196, 26);
            this.txtImagen.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(241, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 36);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(166, 312);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.ReadOnly = true;
            this.txtDescr.Size = new System.Drawing.Size(196, 100);
            this.txtDescr.TabIndex = 34;
            this.txtDescr.Text = "";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(166, 257);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(196, 26);
            this.txtPrecio.TabIndex = 32;
            // 
            // cboxCat
            // 
            this.cboxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCat.FormattingEnabled = true;
            this.cboxCat.Items.AddRange(new object[] {
            "Celulares",
            "Televisores",
            "Media",
            "Audio"});
            this.cboxCat.Location = new System.Drawing.Point(166, 165);
            this.cboxCat.Name = "cboxCat";
            this.cboxCat.Size = new System.Drawing.Size(196, 28);
            this.cboxCat.TabIndex = 31;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Sony",
            "Huawei",
            "Motorola"});
            this.cboxMarca.Location = new System.Drawing.Point(166, 117);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(196, 28);
            this.cboxMarca.TabIndex = 30;
            // 
            // txtNomb
            // 
            this.txtNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomb.Location = new System.Drawing.Point(166, 70);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.ReadOnly = true;
            this.txtNomb.Size = new System.Drawing.Size(196, 26);
            this.txtNomb.TabIndex = 29;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(166, 24);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(196, 26);
            this.txtCod.TabIndex = 28;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(28, 263);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(28, 212);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(104, 20);
            this.lblImagen.TabIndex = 26;
            this.lblImagen.Text = "URL Imagen:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(28, 173);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(82, 20);
            this.lblCat.TabIndex = 25;
            this.lblCat.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(28, 126);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(28, 351);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(96, 20);
            this.lblDes.TabIndex = 23;
            this.lblDes.Text = "Descripcion:";
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomb.Location = new System.Drawing.Point(28, 77);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(69, 20);
            this.lblNomb.TabIndex = 22;
            this.lblNomb.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(28, 24);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(120, 20);
            this.lblCod.TabIndex = 21;
            this.lblCod.Text = "Codigo Articulo:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(50, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 36);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // VistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 542);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboxCat);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.txtNomb);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.lblCod);
            this.Name = "VistaPrevia";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox txtDescr;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboxCat;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnModificar;
    }
}