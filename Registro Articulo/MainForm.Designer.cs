namespace Registro_Articulo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::Registro_Articulo.Properties.Resources.icons8_Folder_48;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salirToolStripMenuItem.Image = global::Registro_Articulo.Properties.Resources.icons8_Exit_48;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem});
            this.registroToolStripMenuItem.Image = global::Registro_Articulo.Properties.Resources.icons8_Check_Book_48;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.articuloToolStripMenuItem.Image = global::Registro_Articulo.Properties.Resources.icons8_Form_48;
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem1});
            this.consultarToolStripMenuItem.Image = global::Registro_Articulo.Properties.Resources.icons8_List_48;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // articuloToolStripMenuItem1
            // 
            this.articuloToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.articuloToolStripMenuItem1.Image = global::Registro_Articulo.Properties.Resources.icons8_View_321;
            this.articuloToolStripMenuItem1.Name = "articuloToolStripMenuItem1";
            this.articuloToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.articuloToolStripMenuItem1.Text = "Articulo";
            this.articuloToolStripMenuItem1.Click += new System.EventHandler(this.articuloToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 294);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem1;
    }
}

