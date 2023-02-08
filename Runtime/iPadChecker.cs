// ReSharper disable RedundantUsingDirective

using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// iPad かどうかを確認できるクラス
    /// </summary>
    public static class iPadChecker
    {
        //================================================================================
        // 変数(static)
        //================================================================================
        private static bool? m_isIPad;

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// iPad なら true を返します
        /// </summary>
        public static bool IsIPad =>
#if UNITY_IOS
            m_isIPad ??= SystemInfo.deviceModel.Contains( "iPad" );
#else
            false;
#endif
    }
}