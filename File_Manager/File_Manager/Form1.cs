namespace File_Manager
{

    public partial class Form1 : Form
    {
        #region Constants
        private const int WM_DEVICECHANGE = 537;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUsb();
            string rootBase = @"D:\User\Descargas\";

            try
            {
                tvFile.Nodes.Clear();
                DirectoryInfo directoryInfo = new(rootBase);

                tvFile.Nodes.Add(CreateTree(directoryInfo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
        }

        #region Private methods
        private void OscuroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(51, 51, 51);
            menu.Renderer = new ToolStripProfessionalRenderer(new MenuColor());
            discUnid.Renderer = new ToolStripProfessionalRenderer(new MenuColor());
            menu.ForeColor = Color.WhiteSmoke;
            discUnid.ForeColor = Color.WhiteSmoke;
            appearance.ForeColor = Color.WhiteSmoke;
            darkAppearance.ForeColor = Color.WhiteSmoke;
            whiteAppearance.ForeColor = Color.WhiteSmoke;
            tvFile = new TreeView
            {
                ForeColor = Color.Aquamarine
            };
        }

        private void ClaroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            menu.ForeColor = Color.Black;
            discUnid.ForeColor = Color.Black;
            appearance.ForeColor = Color.Black;
            darkAppearance.ForeColor = Color.Black;
            whiteAppearance.ForeColor = Color.Black;
            menu.Renderer = new ToolStripProfessionalRenderer();
            discUnid.Renderer = new ToolStripProfessionalRenderer();
        }

        private void FillCombo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Fixed).ToArray();
            foreach (DriveInfo drive in drives)
            {
                availableUnits.DropDownItems.Add((drive.Name).ToString());
            }
        }

        private void RefreshUsb()
        {
            var usbs = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Removable).ToArray();
            availableUnits.DropDownItems.Clear();
            FillCombo();
            foreach (var usb in usbs)
            {
                availableUnits.DropDownItems.Add((usb.Name).ToString());
            }
        }

        private static TreeNode CreateTree(DirectoryInfo dir)
        {
            TreeNode treeNode = new(dir.Name);

            foreach (var directory in dir.GetDirectories())
            {
                treeNode.Nodes.Add(CreateTree(directory));
            }

            foreach (var file in dir.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(file.Name));
            }

            return treeNode;
        }
        #endregion

        #region Protected methods
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE && ((int)m.WParam == DBT_DEVICEARRIVAL || (int)m.WParam == DBT_DEVICEREMOVECOMPLETE))
                RefreshUsb();

            base.WndProc(ref m);
        }
        #endregion
    }
}
