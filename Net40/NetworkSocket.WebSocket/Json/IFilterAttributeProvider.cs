﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkSocket.WebSocket.Json
{
    /// <summary>
    /// 特性过滤器提供者
    /// </summary>
    public interface IFilterAttributeProvider
    {
        /// <summary>
        /// 获取服务行为的过滤器
        /// 不包括全局过滤器
        /// </summary>
        /// <param name="jsonAction">服务行为</param>
        /// <returns></returns>
        IEnumerable<IFilter> GetActionFilters(JsonAction jsonAction);
    }
}