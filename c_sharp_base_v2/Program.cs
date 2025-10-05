namespace c_sharp_base
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // ------------------------------------------
            // 初始化環境
            // ------------------------------------------
            hahaha.Initial_Environment_All();
            hahaha_form_main form_main_ = new hahaha_form_main();
            hahaha.Form_Main_ = form_main_;
            ha.Form_Main = form_main_;



            // ------------------------------------------
            // 初始化
            // ------------------------------------------
            hahaha.Initial_All();
            // ------------------------------------------
            // 初始化 UI
            // ------------------------------------------
            hahaha.Initial_UI_All();

            // ------------------------------------------
            // 
            // ------------------------------------------
            // ------------------------------------------
            // 
            // ------------------------------------------


            Application.Run(form_main_);


        }
    }
}