namespace hahaha
{
    public class hahaha_setting_box
    {
        // -------------------------------------------------
        // system
        // -------------------------------------------------
        public hahaha_setting_system System = new hahaha_setting_system();
        // -------------------------------------------------
        // global
        // -------------------------------------------------
        public hahaha_setting_global Global = new hahaha_setting_global();
        // -------------------------------------------------
        //
        // -------------------------------------------------
        public hahaha_setting_box()
        {
        }

        public virtual int Load_All()
        {
            return 0;

        }

        public virtual int Save_All()
        {
            return 0;
        }

        public virtual int Load_System()
        {
            return 0;
        }

        public virtual int Save_System()
        {
            return 0;
        }

        public virtual int Load_Global()
        {
            return 0;
        }

        public virtual int Save_Global()
        {
            return 0;
        }
    }
}