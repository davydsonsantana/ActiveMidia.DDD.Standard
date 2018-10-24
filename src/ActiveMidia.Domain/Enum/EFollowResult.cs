using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Enum {
    public enum EFollowResult {
        Followed = 1,
        AlreadyFollowing = 2,
        Error = 3,
        Requested = 4,
        FollowValidationFail = 5
    }
}
