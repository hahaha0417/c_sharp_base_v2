namespace c_sharp_base
{

    // ---------------------------------------------------------------
    //
    // ---------------------------------------------------------------

    public static partial class hahaha
    {
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        public static hahaha_form_main? Form_Main_ = null;


        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------
        // ---------------------------------------------------------------
        //
        // ---------------------------------------------------------------


        // ---------------------------------------------------------------
        // 全部
        // ---------------------------------------------------------------
        public static int Initial_Environment_All()
        {
            hahaha_sub_lib.Initial_Environment();
            hahaha_main_dll.Initial_Environment();
            hahaha_sub_dll.Initial_Environment();
            hahaha.Initial_Environment();

            return 0;
        }
        public static int Initial_All()
        {
            hahaha_sub_lib.Initial();
            hahaha_main_dll.Initial();
            hahaha_sub_dll.Initial();
            hahaha.Initial();

            return 0;
        }

        public static int Initial_UI_All()
        {
            hahaha_sub_lib.Initial_UI();
            hahaha_main_dll.Initial_UI();
            hahaha_sub_dll.Initial_UI();
            hahaha.Initial_UI();

            return 0;
        }

        public static int Close_All()
        {
            hahaha.Close();
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