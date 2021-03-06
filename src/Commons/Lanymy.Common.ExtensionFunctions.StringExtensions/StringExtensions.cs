﻿using System;
using System.Text;

namespace Lanymy.Common.ExtensionFunctions
{
    /// <summary>
    /// String静态扩展类库
    /// </summary>
    public static class StringExtensions
    {


        #region 字符串截取

        /// <summary>
        /// 从字符串左边获取指定长度的字符串  如果长度不在原字符串长度范围内 则返回原字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string LeftSubString(this string s, int length)
        {

            if (length < 0 || length > s.Length)
            {
                return s;
            }

            return s.Substring(0, length);

        }



        /// <summary>
        /// 从字符串右边获取指定长度的字符串  如果长度不在原字符串长度范围内 则返回原字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RightSubString(this string s, int length)
        {

            if (length < 0 || length > s.Length)
            {
                return s;
            }

            return s.Substring(s.Length - length);

        }


        /// <summary>
        /// 关键字索引从最后开始 截取 字符串 如果没有找到关键字 则返回 空字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="keyWord">关键字</param>
        /// <param name="ifCutKeyWord">是否保留关键字 默认值 True 不保留关键字</param>
        /// <param name="repeatCount">重复执行此方法的次数,默认值 0,只执行一次不重复执行</param>
        /// <returns></returns>
        public static string RightSubString(this string s, string keyWord, bool ifCutKeyWord = true, ushort repeatCount = 0)
        {

            if (repeatCount == 0)
            {

                if (s.LastIndexOf(keyWord, StringComparison.Ordinal) < 0)
                {
                    return "";
                }

                return ifCutKeyWord ? s.Substring(s.LastIndexOf(keyWord, StringComparison.Ordinal)).Remove(0, keyWord.Length) : s.Substring(s.LastIndexOf(keyWord, StringComparison.Ordinal));

            }

            for (int i = 0; i <= repeatCount; i++)
            {
                s = s.RightSubString(keyWord, ifCutKeyWord);
            }

            return s;


        }



        /// <summary>
        /// 从字符串左边删除指定长度的字符串 如果长度 小于0 则一个都不删 返回原字符串 如果长度大于原字符串最大长度 则全部删除
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string LeftRemoveString(this string s, int length)
        {

            if (length < 0)
            {
                return s;
            }

            if (length >= s.Length)
            {
                return "";
            }

            return s.Remove(0, length);

        }



        /// <summary>
        /// 从字符串右边删除指定长度的字符串 如果长度 小于0 则一个都不删 返回原字符串 如果长度大于原字符串最大长度 则全部删除
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RightRemoveString(this string s, int length)
        {

            if (length < 0)
            {
                return s;
            }

            if (length >= s.Length)
            {
                return "";
            }


            return s.Remove(s.Length - length);

        }


        /// <summary>
        /// 从字符串左侧 根据关键字 截取字符串 如果没有找到关键字 则返回 空字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="keyWord">关键字</param>
        /// <param name="ifCutKeyWord">截取后的字符串是否去掉关键字</param>
        /// <param name="repeatCount">重复执行此方法的次数,默认值 0,只执行一次不重复执行</param>
        /// <returns></returns>
        public static string LeftSubString(this string s, string keyWord, bool ifCutKeyWord = true, ushort repeatCount = 0)
        {

            if (repeatCount == 0)
            {

                if (s.IndexOf(keyWord, StringComparison.Ordinal) < 0)
                {
                    return "";
                }

                return ifCutKeyWord ? s.Substring(0, s.IndexOf(keyWord, StringComparison.Ordinal)) : s.Substring(0, s.IndexOf(keyWord, StringComparison.Ordinal)) + keyWord;

            }

            for (int i = 0; i <= repeatCount; i++)
            {
                s = s.LeftSubString(keyWord, ifCutKeyWord);
            }

            return s;

        }



        /// <summary>
        /// 从字符串左侧 根据关键字 删除字符串 如果没有匹配到关键字 则返回原字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="keyWord">关键字</param>
        /// <param name="ifCutKeyWord">删除后的字符串 是否 去掉 关键字</param>
        /// <param name="repeatCount">重复执行此方法的次数,默认值 0,只执行一次不重复执行</param>
        /// <returns></returns>
        public static string LeftRemoveString(this string s, string keyWord, bool ifCutKeyWord = true, ushort repeatCount = 0)
        {

            if (repeatCount == 0)
            {

                if (s.IndexOf(keyWord, StringComparison.Ordinal) < 0)
                {
                    return s;
                }

                return ifCutKeyWord ? s.Remove(0, s.IndexOf(keyWord, StringComparison.Ordinal) + keyWord.Length) : s.Remove(0, s.IndexOf(keyWord, StringComparison.Ordinal));

            }

            for (int i = 0; i <= repeatCount; i++)
            {
                s = s.LeftRemoveString(keyWord, ifCutKeyWord);
            }

            return s;

        }


        /// <summary>
        /// 从字符串右侧 根据关键字 在关键字第一个字符的索引位置起 删除字符 到结尾 如果没有匹配到关键字 则返回原字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="keyWord">关键字</param>
        /// <param name="ifCutKeyWord">删除后的字符串 是否 去掉 关键字 默认值 True 去掉关键字 </param>
        /// <param name="repeatCount">重复执行此方法的次数,默认值 0,只执行一次不重复执行</param>
        /// <returns></returns>
        public static string RightRemoveString(this string s, string keyWord, bool ifCutKeyWord = true, ushort repeatCount = 0)
        {

            if (repeatCount == 0)
            {

                if (s.IndexOf(keyWord, StringComparison.Ordinal) < 0)
                {
                    return s;
                }

                return ifCutKeyWord ? s.Remove(s.LastIndexOf(keyWord, StringComparison.Ordinal)) : s.Remove(s.LastIndexOf(keyWord, StringComparison.Ordinal) + keyWord.Length);

            }

            for (int i = 0; i <= repeatCount; i++)
            {
                s = s.RightRemoveString(keyWord, ifCutKeyWord);
            }

            return s;

        }


        /// <summary>
        /// 是否按字节(一个汉字占位双字节)截取字符串,如果遇到双字节处截取，则包含该双字节,并把指定的结尾字符串(如...)拼接到结尾
        /// </summary>
        /// <param name="s">字符串数据源</param>
        /// <param name="ifByByte">是否按字节(一个汉字占位双字节)截取字符串,如果遇到双字节处截取，则包含该双字节</param>
        /// <param name="length">截取的长度</param>
        /// <param name="outstr">结尾拼接字符串（如：...）</param>
        /// <returns></returns>
        public static string LeftSubString(this string s, bool ifByByte, int length, string outstr = "...")
        {

            if (ifByByte)
            {

                if (length < 0 || length >= s.GetStringTrueLength())
                {
                    return s + outstr;
                }

                int flagLength = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    flagLength += Encoding.Default.GetBytes(s.Substring(i, 1)).Length;
                    if (flagLength >= length)
                    {
                        return s.LeftSubString(i + 1) + outstr;
                    }
                }

                return "";

            }

            return s.LeftSubString(length) + outstr;

        }



        #endregion //字符串截取


        /// <summary>
        /// 获得字符串的真实长度(文字为两个占位符)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static int GetStringTrueLength(this string s, Encoding encoding = null)
        {

            if (encoding.IfIsNullOrEmpty())
            {
                encoding = Encoding.Default;
            }

            return s.IfIsNullOrEmpty() ? 0 : encoding.GetBytes(s).Length;

        }



    }
}
