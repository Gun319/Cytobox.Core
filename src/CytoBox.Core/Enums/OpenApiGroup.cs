﻿using System.ComponentModel;

namespace CytoBox.Core.Enums
{
    public enum OpenApiGroup
    {
        [Description("用户接口")]
        User = 1,

        [Description("系统接口")]
        System = 2
    }
}
