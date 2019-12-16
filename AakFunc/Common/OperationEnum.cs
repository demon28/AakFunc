﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Common
{

    public enum OperationEnum
    {

        获取登陆二维码 = 1,
        检查是否登录 = 2,
        获取62数据 = 3,
        使用62数据登录 = 4,

    }
    public enum LoginStatus
    {
        未登录=0,
        在线=1,
        离线=2,
        未知=3

    }
}
