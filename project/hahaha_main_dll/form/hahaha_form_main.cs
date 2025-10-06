using Microsoft.Extensions.Logging;

namespace c_sharp_base_v2
{
    public partial class hahaha_form_main : hahahalib.ui.hahaha_form_base_titlebar
    {
        public hahaha_form_main()
        {
            InitializeComponent();
        }

        private void hahaha_form_main_Load(object sender, EventArgs e)
        {
            // 簡易寫
            new Thread(() =>
            {
                ha.Log_Form_Main!.LogDebug("載入主程式");
                Thread.Sleep(500);
                ha.Form_Main!.Invoke(new Action(() =>
                {
                    label_title.Text = app.Name_Title;
                }));
            }).Start();
        }

        private void hahaha_form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            // ------------------------------------------
            // 關閉
            // ------------------------------------------
            ha.Flow_Close!.Close_All();
            
        }
    }
}
