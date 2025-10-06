using Microsoft.Extensions.Logging;

namespace c_sharp_base_v2
{

    // ---------------------------------------------------------------
    //
    // ---------------------------------------------------------------

    public static partial class hahaha_exe
    {
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_form_main? Form_Main_ = null;


        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_setting_box? Setting_Box_ = null;
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static ILogger? Log_Form_Main_ = null;
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_flow_initial? Flow_Initial_ = null;
        public static hahaha_flow_close? Flow_Close_ = null;
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------


        // ---------------------------------------------------------------
        // 全部
        // ---------------------------------------------------------------
        public static int Initial_Environment_All()
        {
            Setting_Box_ = new hahaha_setting_box();

            if (Setting_Box_.Load_All() != 0)
            {
                Setting_Box_.Save_All();
            }

            ha.Setting = Setting_Box_;

            hahaha_sub_lib.Log_.Create($"{ha.Setting.System.Dir_Environment}/{ha.Setting.System.Name_Config}/nlog.config");

            Log_Form_Main_ = hahaha_sub_lib.Log_.Create_Log<hahaha_form_main>();
            ha.Log_Form_Main = Log_Form_Main_;
            // ---------------------------------------------------------------
            //
            // ---------------------------------------------------------------
            hahaha_sub_lib.Initial_Environment();
            hahaha_main_dll.Initial_Environment();
            hahaha_sub_dll.Initial_Environment();
            hahaha_exe.Initial_Environment();

            return 0;
        }
        public static int Initial_All()
        {
            hahaha_sub_lib.Initial();
            hahaha_main_dll.Initial();
            hahaha_sub_dll.Initial();
            hahaha_exe.Initial();

            return 0;
        }

        public static int Initial_UI_All()
        {
            hahaha_sub_lib.Initial_UI();
            hahaha_main_dll.Initial_UI();
            hahaha_sub_dll.Initial_UI();
            hahaha_exe.Initial_UI();

            return 0;
        }

        public static int Close_All()
        {
            hahaha_exe.Close();
            hahaha_sub_dll.Close();
            hahaha_main_dll.Close();
            hahaha_sub_lib.Close();

            return 0;
        }


        // ---------------------------------------------------------------
        // 主要
        // ---------------------------------------------------------------
        public static int Initial_Environment()
        {
            Flow_Initial_ = new hahaha_flow_initial();
            Flow_Close_ = new hahaha_flow_close();

            ha.Flow_Initial = Flow_Initial_;
            ha.Flow_Close = Flow_Close_;




            return 0;
        }

        public static int Initial()
        {
            return 0;
        }

        public static int Initial_UI()
        {
            return 0;
        }

        public static int Close()
        {
            return 0;
        }



    }

}