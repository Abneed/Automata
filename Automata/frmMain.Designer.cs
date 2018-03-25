namespace Automata
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTablaDeTransicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTablaDeTransicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acecaDeAutomataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcontrolPestanas = new System.Windows.Forms.TabControl();
            this.tabPageCadenas = new System.Windows.Forms.TabPage();
            this.dgvCadenas = new System.Windows.Forms.DataGridView();
            this.columnCadena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProcedimiento = new System.Windows.Forms.TabPage();
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panelControlesEntrada = new System.Windows.Forms.Panel();
            this.panelControlesSalida = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.tabcontrolPestanas.SuspendLayout();
            this.tabPageCadenas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).BeginInit();
            this.panelControlesEntrada.SuspendLayout();
            this.panelControlesSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(599, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTablaDeTransicionesToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // nuevoTablaDeTransicionesToolStripMenuItem
            // 
            this.nuevoTablaDeTransicionesToolStripMenuItem.Name = "nuevoTablaDeTransicionesToolStripMenuItem";
            this.nuevoTablaDeTransicionesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Mayú s+N";
            this.nuevoTablaDeTransicionesToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.nuevoTablaDeTransicionesToolStripMenuItem.Text = "Tabla de Transiciones...";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirTablaDeTransicionesToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // abrirTablaDeTransicionesToolStripMenuItem
            // 
            this.abrirTablaDeTransicionesToolStripMenuItem.Name = "abrirTablaDeTransicionesToolStripMenuItem";
            this.abrirTablaDeTransicionesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Mayús+O";
            this.abrirTablaDeTransicionesToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.abrirTablaDeTransicionesToolStripMenuItem.Text = "Tabla de Transiciones...";
            this.abrirTablaDeTransicionesToolStripMenuItem.Click += new System.EventHandler(this.abrirTablaDeTransicionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acecaDeAutomataToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acecaDeAutomataToolStripMenuItem
            // 
            this.acecaDeAutomataToolStripMenuItem.Name = "acecaDeAutomataToolStripMenuItem";
            this.acecaDeAutomataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acecaDeAutomataToolStripMenuItem.Text = "Aceca de Automata";
            this.acecaDeAutomataToolStripMenuItem.Click += new System.EventHandler(this.acecaDeAutomataToolStripMenuItem_Click);
            // 
            // tabcontrolPestanas
            // 
            this.tabcontrolPestanas.Controls.Add(this.tabPageCadenas);
            this.tabcontrolPestanas.Controls.Add(this.tabPageProcedimiento);
            this.tabcontrolPestanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolPestanas.Location = new System.Drawing.Point(0, 0);
            this.tabcontrolPestanas.Name = "tabcontrolPestanas";
            this.tabcontrolPestanas.SelectedIndex = 0;
            this.tabcontrolPestanas.Size = new System.Drawing.Size(599, 291);
            this.tabcontrolPestanas.TabIndex = 1;
            // 
            // tabPageCadenas
            // 
            this.tabPageCadenas.Controls.Add(this.dgvCadenas);
            this.tabPageCadenas.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadenas.Name = "tabPageCadenas";
            this.tabPageCadenas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadenas.Size = new System.Drawing.Size(591, 265);
            this.tabPageCadenas.TabIndex = 0;
            this.tabPageCadenas.Text = "Cadenas";
            this.tabPageCadenas.UseVisualStyleBackColor = true;
            // 
            // dgvCadenas
            // 
            this.dgvCadenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadenas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCadena,
            this.columnFDC,
            this.columnCAT,
            this.columnEstado});
            this.dgvCadenas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadenas.Location = new System.Drawing.Point(3, 3);
            this.dgvCadenas.Name = "dgvCadenas";
            this.dgvCadenas.Size = new System.Drawing.Size(585, 259);
            this.dgvCadenas.TabIndex = 0;
            // 
            // columnCadena
            // 
            this.columnCadena.HeaderText = "Cadena";
            this.columnCadena.Name = "columnCadena";
            this.columnCadena.ReadOnly = true;
            // 
            // columnFDC
            // 
            this.columnFDC.HeaderText = "FDC";
            this.columnFDC.Name = "columnFDC";
            this.columnFDC.ReadOnly = true;
            // 
            // columnCAT
            // 
            this.columnCAT.HeaderText = "CAT";
            this.columnCAT.Name = "columnCAT";
            this.columnCAT.ReadOnly = true;
            // 
            // columnEstado
            // 
            this.columnEstado.HeaderText = "Estado";
            this.columnEstado.Name = "columnEstado";
            this.columnEstado.ReadOnly = true;
            // 
            // tabPageProcedimiento
            // 
            this.tabPageProcedimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcedimiento.Name = "tabPageProcedimiento";
            this.tabPageProcedimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcedimiento.Size = new System.Drawing.Size(591, 265);
            this.tabPageProcedimiento.TabIndex = 1;
            this.tabPageProcedimiento.Text = "Procedimiento";
            this.tabPageProcedimiento.UseVisualStyleBackColor = true;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(19, 24);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(47, 13);
            this.lblCadena.TabIndex = 0;
            this.lblCadena.Text = "Cadena:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(72, 21);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(125, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(203, 19);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // panelControlesEntrada
            // 
            this.panelControlesEntrada.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControlesEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControlesEntrada.Controls.Add(this.lblCadena);
            this.panelControlesEntrada.Controls.Add(this.btnIngresar);
            this.panelControlesEntrada.Controls.Add(this.txtCadena);
            this.panelControlesEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlesEntrada.Location = new System.Drawing.Point(0, 24);
            this.panelControlesEntrada.Name = "panelControlesEntrada";
            this.panelControlesEntrada.Size = new System.Drawing.Size(599, 61);
            this.panelControlesEntrada.TabIndex = 3;
            // 
            // panelControlesSalida
            // 
            this.panelControlesSalida.Controls.Add(this.tabcontrolPestanas);
            this.panelControlesSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlesSalida.Location = new System.Drawing.Point(0, 85);
            this.panelControlesSalida.Name = "panelControlesSalida";
            this.panelControlesSalida.Size = new System.Drawing.Size(599, 291);
            this.panelControlesSalida.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 376);
            this.Controls.Add(this.panelControlesSalida);
            this.Controls.Add(this.panelControlesEntrada);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "Automata";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabcontrolPestanas.ResumeLayout(false);
            this.tabPageCadenas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).EndInit();
            this.panelControlesEntrada.ResumeLayout(false);
            this.panelControlesEntrada.PerformLayout();
            this.panelControlesSalida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTablaDeTransicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acecaDeAutomataToolStripMenuItem;
        private System.Windows.Forms.TabControl tabcontrolPestanas;
        private System.Windows.Forms.TabPage tabPageCadenas;
        private System.Windows.Forms.TabPage tabPageProcedimiento;
        private System.Windows.Forms.DataGridView dgvCadenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCadena;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEstado;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTablaDeTransicionesToolStripMenuItem;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Panel panelControlesEntrada;
        private System.Windows.Forms.Panel panelControlesSalida;
    }
}

