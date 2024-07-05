namespace File_Manager
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
            discUnid = new ToolStrip();
            availableUnits = new ToolStripDropDownButton();
            tvFile = new TreeView();
            menu = new MenuStrip();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            seleccionarToolStripMenuItem1 = new ToolStripMenuItem();
            comandoToolStripMenuItem1 = new ToolStripMenuItem();
            redToolStripMenuItem1 = new ToolStripMenuItem();
            verToolStripMenuItem1 = new ToolStripMenuItem();
            configuraciónToolStripMenuItem3 = new ToolStripMenuItem();
            appearance = new ToolStripMenuItem();
            darkAppearance = new ToolStripMenuItem();
            whiteAppearance = new ToolStripMenuItem();
            inicioToolStripMenuItem1 = new ToolStripMenuItem();
            discUnid.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
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
            // availableUnits
            // 
            availableUnits.DisplayStyle = ToolStripItemDisplayStyle.Text;
            availableUnits.Image = (Image)resources.GetObject("availableUnits.Image");
            availableUnits.ImageTransparentColor = Color.Magenta;
            availableUnits.Name = "availableUnits";
            availableUnits.Size = new Size(69, 22);
            availableUnits.Text = "Unidades";
            // 
            // tvFile
            // 
            tvFile.Dock = DockStyle.Left;
            tvFile.Location = new Point(0, 49);
            tvFile.Name = "tvFile";
            tvFile.Size = new Size(241, 538);
            tvFile.TabIndex = 2;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem1, seleccionarToolStripMenuItem1, comandoToolStripMenuItem1, redToolStripMenuItem1, verToolStripMenuItem1, configuraciónToolStripMenuItem3, inicioToolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(909, 24);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(60, 20);
            archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // seleccionarToolStripMenuItem1
            // 
            seleccionarToolStripMenuItem1.Name = "seleccionarToolStripMenuItem1";
            seleccionarToolStripMenuItem1.Size = new Size(79, 20);
            seleccionarToolStripMenuItem1.Text = "Seleccionar";
            // 
            // comandoToolStripMenuItem1
            // 
            comandoToolStripMenuItem1.Name = "comandoToolStripMenuItem1";
            comandoToolStripMenuItem1.Size = new Size(72, 20);
            comandoToolStripMenuItem1.Text = "Comando";
            // 
            // redToolStripMenuItem1
            // 
            redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            redToolStripMenuItem1.Size = new Size(39, 20);
            redToolStripMenuItem1.Text = "Red";
            // 
            // verToolStripMenuItem1
            // 
            verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            verToolStripMenuItem1.Size = new Size(35, 20);
            verToolStripMenuItem1.Text = "Ver";
            // 
            // configuraciónToolStripMenuItem3
            // 
            configuraciónToolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { appearance });
            configuraciónToolStripMenuItem3.Name = "configuraciónToolStripMenuItem3";
            configuraciónToolStripMenuItem3.Size = new Size(95, 20);
            configuraciónToolStripMenuItem3.Text = "Configuración";
            // 
            // appearance
            // 
            appearance.DropDownItems.AddRange(new ToolStripItem[] { darkAppearance, whiteAppearance });
            appearance.Name = "appearance";
            appearance.Size = new Size(102, 22);
            appearance.Text = "Tema";
            // 
            // darkAppearance
            // 
            darkAppearance.Name = "darkAppearance";
            darkAppearance.Size = new Size(112, 22);
            darkAppearance.Text = "Oscuro";
            darkAppearance.Click += OscuroToolStripMenuItem1_Click;
            // 
            // whiteAppearance
            // 
            whiteAppearance.Name = "whiteAppearance";
            whiteAppearance.Size = new Size(112, 22);
            whiteAppearance.Text = "Claro";
            whiteAppearance.Click += ClaroToolStripMenuItem1_Click;
            // 
            // inicioToolStripMenuItem1
            // 
            inicioToolStripMenuItem1.Name = "inicioToolStripMenuItem1";
            inicioToolStripMenuItem1.Size = new Size(48, 20);
            inicioToolStripMenuItem1.Text = "Inicio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 587);
            Controls.Add(tvFile);
            Controls.Add(discUnid);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            discUnid.ResumeLayout(false);
            discUnid.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip discUnid;
        private TreeView tvFile;
        private ToolStripDropDownButton availableUnits;
        private MenuStrip menu;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private ToolStripMenuItem seleccionarToolStripMenuItem1;
        private ToolStripMenuItem comandoToolStripMenuItem1;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem verToolStripMenuItem1;
        private ToolStripMenuItem configuraciónToolStripMenuItem3;
        private ToolStripMenuItem appearance;
        private ToolStripMenuItem darkAppearance;
        private ToolStripMenuItem whiteAppearance;
        private ToolStripMenuItem inicioToolStripMenuItem1;
    }
}
