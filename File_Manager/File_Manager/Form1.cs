namespace File_Manager
{
    public partial class Form1 : Form
    {
        private TreeView lineTreeView;

        public Form1()
        {
            InitializeComponent();
            //InitializeLineTreeView();
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
        #endregion

        public void InitializeLineTreeView()
        {
            lineTreeView = new TreeView
            {
                Size = new Size(200, 200),

                LineColor = Color.Red
            };
        }
    }
}
