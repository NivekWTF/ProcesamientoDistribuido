
namespace ProcesamientoDistribuido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnInsertarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.EnableHeadersVisualStyles = false;
            this.dtgClientes.Location = new System.Drawing.Point(8, 8);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.dtgClientes.RowTemplate.Height = 40;
            this.dtgClientes.RowTemplate.ReadOnly = true;
            this.dtgClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(833, 622);
            this.dtgClientes.TabIndex = 5;
            // 
            // btnInsertarClientes
            // 
            this.btnInsertarClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarClientes.Location = new System.Drawing.Point(943, 318);
            this.btnInsertarClientes.Name = "btnInsertarClientes";
            this.btnInsertarClientes.Size = new System.Drawing.Size(98, 58);
            this.btnInsertarClientes.TabIndex = 6;
            this.btnInsertarClientes.Text = "Insertar Clientes";
            this.btnInsertarClientes.UseVisualStyleBackColor = false;
            this.btnInsertarClientes.Click += new System.EventHandler(this.btnInsertarClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.btnInsertarClientes);
            this.Controls.Add(this.dtgClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnInsertarClientes;
    }
}

