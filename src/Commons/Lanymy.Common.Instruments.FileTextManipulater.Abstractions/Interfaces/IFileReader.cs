﻿namespace Lanymy.Common.Instruments.Interfaces
{
    /// <summary>
    /// 读文件 功能 接口
    /// </summary>
    public interface IFileReader
    {

        /// <summary>
        /// 读取全部消息
        /// </summary>
        /// <returns></returns>
        string ReadAll();



        /// <summary>
        /// 一行 一行 读取数据
        /// </summary>
        string ReadLine();



        /// <summary>
        /// 判断是否还有字符串
        /// </summary>
        /// <returns></returns>
        bool IfHaveString();

    }
}
