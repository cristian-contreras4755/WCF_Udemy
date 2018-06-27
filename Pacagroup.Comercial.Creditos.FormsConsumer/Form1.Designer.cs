namespace Pacagroup.Comercial.Creditos.FormsConsumer
{
    partial class frmListadoCreditos
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
            this.gridCreditos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCreditos
            // 
            this.gridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCreditos.Location = new System.Drawing.Point(29, 117);
            this.gridCreditos.Name = "gridCreditos";
            this.gridCreditos.Size = new System.Drawing.Size(660, 190);
            this.gridCreditos.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(600, 66);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(89, 45);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Créditos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListadoCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 331);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridCreditos);
            this.Name = "frmListadoCreditos";
            this.Text = "Listado de Créditos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCreditos;
        private System.Windows.Forms.Button btnListar;
    }
}

