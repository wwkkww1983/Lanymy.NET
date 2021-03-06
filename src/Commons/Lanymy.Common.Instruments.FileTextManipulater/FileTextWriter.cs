﻿using System;
using System.IO;
using System.Text;
using Lanymy.Common.ExtensionFunctions;
using Lanymy.Common.Instruments.Interfaces;

namespace Lanymy.Common.Instruments
{
    /// <summary>
    /// 文本文件写入器
    /// </summary>
    public class FileTextWriter : BaseFileTextReadOrWrite, IFileWriter
    {

        /// <summary>
        /// 写数据流对象
        /// </summary>
        public StreamWriter StreamWriter { get; protected set; }


        /// <summary>
        /// 文本文件写入器
        /// </summary>
        /// <param name="textFileFullPath">文本文件全路径</param>
        /// <param name="ifOverWriteFile">True 覆盖旧文件 创建新文件 ; False 在旧文件上 追加 内容; 默认值 False 旧文件追加内容</param>
        /// <param name="encoding">编码 null 则使用默认编码</param>
        public FileTextWriter(string textFileFullPath, bool ifOverWriteFile = false, Encoding encoding = null) : base(textFileFullPath, ifOverWriteFile, encoding)
        {
            StreamWriter = new StreamWriter(TextFileFullPath, true, CurrentEncoding);
        }


        /// <summary>
        /// 资源释放
        /// </summary>
        public override void Dispose()
        {
            if (!StreamWriter.IfIsNullOrEmpty())
            {
                StreamWriter.Dispose();
                StreamWriter = null;
            }
        }


        /// <summary>
        /// 写消息
        /// </summary>
        /// <param name="message"></param>
        public virtual void Write(string message)
        {
            StreamWriter.Write(message);
            StreamWriter.Flush();
        }


        /// <summary>
        /// 写一行消息
        /// </summary>
        /// <param name="message"></param>
        public virtual void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }



    }
}
