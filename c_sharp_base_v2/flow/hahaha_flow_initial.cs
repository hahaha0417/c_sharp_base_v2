
using Microsoft.Extensions.Logging;

namespace c_sharp_base_v2
{
    public class hahaha_flow_initial : hahaha.hahaha_flow_initial
    {
        public hahaha_flow_initial()
        {
        }
        public override int Initial_All()
        {
            ha.Log_Form_Main!.LogDebug("初始化");
            hahaha_exe.Initial_All();

            return 0;
        }
        public override int Initial_UI_All()
        {
            ha.Log_Form_Main!.LogDebug("初始化UI");
            hahaha_exe.Initial_UI_All();

            return 0;
        }
    }
   
}