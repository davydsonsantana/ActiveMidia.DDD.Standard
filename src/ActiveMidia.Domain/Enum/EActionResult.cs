using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Enum {
    public enum EActionResult {
        PreFollowValidationFail = 1,
        AlreadyFollowingOrRequested = 2,
        FollowError = 3,
        AlreadyFollowing = 4,
        FollowRequested = 5,
        Followed = 6,
        ProfileAlreadyFollowUs = 7,
        Liked = 8,
        GenderValidationFail = 9
    }
}
