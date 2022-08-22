
namespace Capa_Presentacion
{
    partial class FormPrcUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrcUsuario));
            this.BtnRegUser = new System.Windows.Forms.Button();
            this.BtnRegVisita = new System.Windows.Forms.Button();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegUser
            // 
            this.BtnRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegUser.Location = new System.Drawing.Point(31, 93);
            this.BtnRegUser.Name = "BtnRegUser";
            this.BtnRegUser.Size = new System.Drawing.Size(191, 71);
            this.BtnRegUser.TabIndex = 0;
            this.BtnRegUser.Text = "Registrar Usuario";
            this.BtnRegUser.UseVisualStyleBackColor = true;
            this.BtnRegUser.Click += new System.EventHandler(this.BtnRegUser_Click);
            // 
            // BtnRegVisita
            // 
            this.BtnRegVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegVisita.Location = new System.Drawing.Point(285, 93);
            this.BtnRegVisita.Name = "BtnRegVisita";
            this.BtnRegVisita.Size = new System.Drawing.Size(191, 71);
            this.BtnRegVisita.TabIndex = 1;
            this.BtnRegVisita.Text = "Registrar Visita";
            this.BtnRegVisita.UseVisualStyleBackColor = true;
            this.BtnRegVisita.Click += new System.EventHandler(this.BtnRegVisita_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.Location = new System.Drawing.Point(532, 93);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(191, 71);
            this.BtnRegistro.TabIndex = 221;
            this.BtnRegistro.Text = "Ver Registros";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(601, 289);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(154, 71);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "Cerrar Sesion";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // FormPrcUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 372);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnRegVisita);
            this.Controls.Add(this.BtnRegUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrcUsuario";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormPrcUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegUser;
        private System.Windows.Forms.Button BtnRegVisita;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Button BtnLogOut;
    }
}