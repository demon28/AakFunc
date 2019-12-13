﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Models.Response
{
    public class ResponseBase
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public virtual bool Success { get; set; } = true;

        /// <summary>
        /// 返回码
        /// </summary>
        public virtual string Code { get; set; } = "0";

        /// <summary>
        /// 返回消息
        /// </summary>
        public virtual string Message { get; set; } = "成功";
    }

    public class ResponseBase<T> : ResponseBase
    {

        /// <summary>
        /// 数据
        /// </summary>
        public virtual T Data { get; set; }



    }
}
