using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELITON___INVERSAO_DEPENDENCIA
{
    public class Switch
    {
        private readonly IDevice device;

        public Switch(IDevice device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.Operate();
        }
    }

}
