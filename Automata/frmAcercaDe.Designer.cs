namespace Automata
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.lblAutomataTitulo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutomataTitulo
            // 
            this.lblAutomataTitulo.AutoSize = true;
            this.lblAutomataTitulo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F);
            this.lblAutomataTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAutomataTitulo.Location = new System.Drawing.Point(342, 39);
            this.lblAutomataTitulo.Name = "lblAutomataTitulo";
            this.lblAutomataTitulo.Size = new System.Drawing.Size(139, 34);
            this.lblAutomataTitulo.TabIndex = 1;
            this.lblAutomataTitulo.Text = "Automata";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(354, 77);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "version 1.0";
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.lblCopyrights.ForeColor = System.Drawing.Color.DimGray;
            this.lblCopyrights.Location = new System.Drawing.Point(346, 320);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(274, 12);
            this.lblCopyrights.TabIndex = 3;
            this.lblCopyrights.Text = "© 2018 HomeSierra Corp. Todos los derechos reservados.";
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::Automata.Properties.Resources.AutomataLogoWithoutTitleOpacity;
            this.picboxLogo.Location = new System.Drawing.Point(12, 7);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(325, 325);
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAutomataTitulo);
            this.Controls.Add(this.picboxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Label lblAutomataTitulo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyrights;
    }
}