namespace c_sharp_base_v2
{
    public class hahaha_setting_box : hahaha.hahaha_setting_box
    {

        // -------------------------------------------------
        //
        // -------------------------------------------------
        public hahaha_setting_box()
        {
        }

        public override int Load_All()
        {
            bool result = true;
            // -------------------------------------------------
            // system
            // -------------------------------------------------
            result &= Load_System() == 0;
            // -------------------------------------------------
            // global
            // -------------------------------------------------
            result &= Load_Global() == 0;
            // -------------------------------------------------
            // 
            // -------------------------------------------------

            return result ? 0 : -1;

        }

        public override int Save_All()
        {
            // -------------------------------------------------
            // system
            // -------------------------------------------------
            Save_System();
            // -------------------------------------------------
            // global
            // -------------------------------------------------
            Save_Global();
            // -------------------------------------------------
            // 
            // -------------------------------------------------

            return 0;

        }

        public override int Load_System()
        {
            int result = hahaha_sub_lib.Json_.Load($"{System.Dir_Environment}/{System.Name_Setting}/{System.Name_Class}/{System.Name_File}", ref System);

            return result;

        }

        public override int Save_System()
        {
            hahaha_sub_lib.Json_.Save($"{System.Dir_Environment}/{System.Name_Setting}/{System.Name_Class}/{System.Name_File}", System);

            return 0;

        }

        public override int Load_Global()
        {
            int result = hahaha_sub_lib.Json_.Load($"{System.Dir_Environment}/{System.Name_Setting}/{Global.Name_Class}/{Global.Name_File}", ref Global);

            return result;

        }

        public override int Save_Global()
        {
            hahaha_sub_lib.Json_.Save($"{System.Dir_Environment}/{System.Name_Setting}/{Global.Name_Class}/{Global.Name_File}", Global);

            return 0;

        }
    }
}