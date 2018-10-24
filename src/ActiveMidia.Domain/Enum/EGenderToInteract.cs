using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Enum {
    public enum EGenderToInteract {
        [Description("Male")]
        M = 'M',
        [Description("Female")]
        F = 'F',
        [Description("Both")]
        B = 'B'
    }
}
