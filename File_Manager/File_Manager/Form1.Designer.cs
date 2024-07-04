﻿namespace File_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            seleccionarToolStripMenuItem = new ToolStripMenuItem();
            comandoToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            temaToolStripMenuItem = new ToolStripMenuItem();
            oscuroToolStripMenuItem = new ToolStripMenuItem();
            claroToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            discUnid = new ToolStrip();
            tvFile = new TreeView();
            availableUnits = new ToolStripDropDownButton();
            menu.SuspendLayout();
            discUnid.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, seleccionarToolStripMenuItem, comandoToolStripMenuItem, redToolStripMenuItem, verToolStripMenuItem, configuraciónToolStripMenuItem, inicioToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(909, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // seleccionarToolStripMenuItem
            // 
            seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            seleccionarToolStripMenuItem.Size = new Size(79, 20);
            seleccionarToolStripMenuItem.Text = "Seleccionar";
            // 
            // comandoToolStripMenuItem
            // 
            comandoToolStripMenuItem.Name = "comandoToolStripMenuItem";
            comandoToolStripMenuItem.Size = new Size(72, 20);
            comandoToolStripMenuItem.Text = "Comando";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(39, 20);
            redToolStripMenuItem.Text = "Red";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temaToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // temaToolStripMenuItem
            // 
            temaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oscuroToolStripMenuItem, claroToolStripMenuItem });
            temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            temaToolStripMenuItem.Size = new Size(102, 22);
            temaToolStripMenuItem.Text = "Tema";
            // 
            // oscuroToolStripMenuItem
            // 
            oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            oscuroToolStripMenuItem.Size = new Size(112, 22);
            oscuroToolStripMenuItem.Text = "Oscuro";
            oscuroToolStripMenuItem.Click += OscuroToolStripMenuItem_Click;
            // 
            // claroToolStripMenuItem
            // 
            claroToolStripMenuItem.Name = "claroToolStripMenuItem";
            claroToolStripMenuItem.Size = new Size(112, 22);
            claroToolStripMenuItem.Text = "Claro";
            claroToolStripMenuItem.Click += ClaroToolStripMenuItem_Click;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // discUnid
            // 
            discUnid.Items.AddRange(new ToolStripItem[] { availableUnits });
            discUnid.Location = new Point(0, 24);
            discUnid.Name = "discUnid";
            discUnid.Size = new Size(909, 25);
            discUnid.TabIndex = 1;
            discUnid.Text = "toolStrip1";
            // 
            // tvFile
            // 
            tvFile.Dock = DockStyle.Left;
            tvFile.Location = new Point(0, 49);
            tvFile.Name = "tvFile";
            tvFile.Size = new Size(241, 538);
            tvFile.TabIndex = 2;
            // 
            // availableUnits
            // 
            availableUnits.DisplayStyle = ToolStripItemDisplayStyle.Text;
            availableUnits.Image = (Image)resources.GetObject("availableUnits.Image");
            availableUnits.ImageTransparentColor = Color.Magenta;
            availableUnits.Name = "availableUnits";
            availableUnits.Size = new Size(69, 22);
            availableUnits.Text = "Unidades";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 587);
            Controls.Add(tvFile);
            Controls.Add(discUnid);
            Controls.Add(menu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            discUnid.ResumeLayout(false);
            discUnid.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem seleccionarToolStripMenuItem;
        private ToolStripMenuItem comandoToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem temaToolStripMenuItem;
        private ToolStripMenuItem oscuroToolStripMenuItem;
        private ToolStripMenuItem claroToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStrip discUnid;
        private TreeView tvFile;
        private ToolStripDropDownButton availableUnits;
    }
}
