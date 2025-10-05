namespace c_sharp_base
{
    public partial class hahaha_form_main : hahahalib.ui.hahaha_form_base_titlebar
    {
        public hahaha_form_main()
        {
            InitializeComponent();
        }

        private void hahaha_form_main_Load(object sender, EventArgs e)
        {

        }

        private void hahaha_form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            hahaha.Close_All();
        }
    }
}
