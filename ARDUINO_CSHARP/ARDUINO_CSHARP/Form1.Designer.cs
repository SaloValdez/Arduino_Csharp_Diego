namespace ARDUINO_CSHARP
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
            this.btnOnFoco = new System.Windows.Forms.Button();
            this.btnOffFoco = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEncenderFocoALTERNA = new System.Windows.Forms.Button();
            this.btnApagarFocoALTERNA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnFoco
            // 
            this.btnOnFoco.Location = new System.Drawing.Point(9, 52);
            this.btnOnFoco.Name = "btnOnFoco";
            this.btnOnFoco.Size = new System.Drawing.Size(75, 23);
            this.btnOnFoco.TabIndex = 0;
            this.btnOnFoco.Text = "PRENDER FOCO";
            this.btnOnFoco.UseVisualStyleBackColor = true;
            this.btnOnFoco.Click += new System.EventHandler(this.btnOnFoco_Click);
            // 
            // btnOffFoco
            // 
            this.btnOffFoco.Location = new System.Drawing.Point(9, 91);
            this.btnOffFoco.Name = "btnOffFoco";
            this.btnOffFoco.Size = new System.Drawing.Size(75, 23);
            this.btnOffFoco.TabIndex = 1;
            this.btnOffFoco.Text = "APAGAR FOCO";
            this.btnOffFoco.UseVisualStyleBackColor = true;
            this.btnOffFoco.Click += new System.EventHandler(this.btnOffFoco_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(41, 184);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(334, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(123, 52);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(123, 91);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEncenderFocoALTERNA
            // 
            this.btnEncenderFocoALTERNA.Location = new System.Drawing.Point(285, 41);
            this.btnEncenderFocoALTERNA.Name = "btnEncenderFocoALTERNA";
            this.btnEncenderFocoALTERNA.Size = new System.Drawing.Size(164, 44);
            this.btnEncenderFocoALTERNA.TabIndex = 5;
            this.btnEncenderFocoALTERNA.Text = "ENCENCER FOCO";
            this.btnEncenderFocoALTERNA.UseVisualStyleBackColor = true;
            this.btnEncenderFocoALTERNA.Click += new System.EventHandler(this.btnEncenderFocoALTERNA_Click);
            // 
            // btnApagarFocoALTERNA
            // 
            this.btnApagarFocoALTERNA.Location = new System.Drawing.Point(285, 91);
            this.btnApagarFocoALTERNA.Name = "btnApagarFocoALTERNA";
            this.btnApagarFocoALTERNA.Size = new System.Drawing.Size(164, 44);
            this.btnApagarFocoALTERNA.TabIndex = 6;
            this.btnApagarFocoALTERNA.Text = "APAGAR FOCO";
            this.btnApagarFocoALTERNA.UseVisualStyleBackColor = true;
            this.btnApagarFocoALTERNA.Click += new System.EventHandler(this.btnApagarFocoALTERNA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 347);
            this.Controls.Add(this.btnApagarFocoALTERNA);
            this.Controls.Add(this.btnEncenderFocoALTERNA);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.btnOffFoco);
            this.Controls.Add(this.btnOnFoco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnFoco;
        private System.Windows.Forms.Button btnOffFoco;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEncenderFocoALTERNA;
        private System.Windows.Forms.Button btnApagarFocoALTERNA;
    }
}

