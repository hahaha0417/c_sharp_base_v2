
using Microsoft.Extensions.Logging;

namespace c_sharp_base_v2
{
    public class hahaha_flow_close : hahaha.hahaha_flow_close
    {
        public hahaha_flow_close()
        {
        }

        public override int Close_All()
        {
            ha.Log_Form_Main!.LogDebug("Ãö³¬");
            hahaha_exe.Close_All();

            return 0;
        }
    }
}