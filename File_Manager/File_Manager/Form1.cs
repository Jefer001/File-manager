namespace File_Manager
{
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        //private TreeView lineTreeView;
        #region Constants
        private const int WM_DEVICECHANGE = 537;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        #endregion

        public Form1()
        {
            InitializeComponent();
            //InitializeLineTreeView();
            RefreshUsb();
        }

        #region Private methods
        private void OscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(51, 51, 51);
            menu.Renderer = new ToolStripProfessionalRenderer(new MenuColor());
            discUnid.Renderer = new ToolStripProfessionalRenderer(new MenuColor());
            menu.ForeColor = Color.WhiteSmoke;
            
            discUnid.ForeColor = Color.WhiteSmoke;
            tvFile = new TreeView
            {
                ForeColor = Color.WhiteSmoke
            };
        }

        private void ClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            menu.ForeColor = Color.Black;
            discUnid.ForeColor = Color.Black;
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
        #endregion

        //public void InitializeLineTreeView()
        //{
        //    lineTreeView = new TreeView
        //    {
        //        Size = new Size(200, 200),

        //        LineColor = Color.Red
        //    };
        //}

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
