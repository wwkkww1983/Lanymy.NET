﻿using System;
using System.Collections.Generic;
using System.Text;
using Lanymy.Common.ExtensionFunctions;

namespace Lanymy.Common.Models.ResultModels
{

    public class LanymyCmdResultModel
    {

        /// <summary>
        /// 标识当前执行命令的ID
        /// </summary>
        public Guid CmdID { get; set; }

        /// <summary>
        /// 命令是否执行成功
        /// </summary>
        public bool IsSuccess => ErrorDataString.IfIsNullOrEmpty();

        public string ExecuteCommandString { get; set; }

        /// <summary>
        /// 命令行返回的正常输出数据字符串
        /// </summary>
        public string OutputDataString { get; set; }


        /// <summary>
        /// 命令行返回的异常输出数据字符串
        /// </summary>
        public string ErrorDataString { get; set; }

        /// <summary>
        /// 开始执行命令时间戳
        /// </summary>
        public DateTime CmdStartDateTime { get; set; }

        /// <summary>
        /// 命令执行完毕时间戳
        /// </summary>
        public DateTime CmdEndDateTime { get; set; }

    }

}
