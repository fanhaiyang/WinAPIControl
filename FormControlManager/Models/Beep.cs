using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormControlManager.Models
{
    public enum BeepType
    {
        SimpleBeep = -1,
        IconAsterisk = 0x00000040,
        IconExclamation = 0x00000030,
        IconQuestion = 0x00000020,
        Ok = 0x00000000,
    }
}
