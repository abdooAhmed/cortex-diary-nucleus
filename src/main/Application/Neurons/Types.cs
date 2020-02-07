﻿using System;
using System.Collections.Generic;
using System.Text;

namespace works.ei8.Cortex.Diary.Nucleus.Application.Neurons
{
    public struct Messages
    {
        public struct Exception
        {
            public const string InvalidId = "Id must not be equal to '00000000-0000-0000-0000-000000000000'.";
            public const string InvalidExpectedVersion = "Expected Version must be equal to or greater than '1'.";
            public const string UnauthorizedUserAccess = "User not authorized to access Avatar.";
        }
    }
}
