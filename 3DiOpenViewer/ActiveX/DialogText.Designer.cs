﻿/*
 * Copyright (c) 2008-2009, 3Di, Inc. (http://3di.jp/) and contributors.
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of 3Di, Inc., nor the name of the 3Di Viewer
 *       "Rei" project, nor the names of its contributors may be used to
 *       endorse or promote products derived from this software without
 *       specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY 3Di, Inc. AND CONTRIBUTORS ``AS IS'' AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
 * PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL 3Di, Inc. OR THE
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
 * EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.4927
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenViewerAX
{
using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class DialogText
    {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DialogText()
        {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenViewerAX.DialogText", typeof(DialogText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Could not start the viewer. There is insufficient space left on the hard disk. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string InsufficientDiskSpaceError
        {
            get
            {
                return ResourceManager.GetString("InsufficientDiskSpaceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   At least 3G free space is recommended for this viewer.\nThe remaining disk space might be insufficient\nWould you like to start the viewer anyway? に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string InsufficientDiskSpaceWarning
        {
            get
            {
                return ResourceManager.GetString("InsufficientDiskSpaceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   An error occured while trying to identify the latest version. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string LatestVersionCheckError
        {
            get
            {
                return ResourceManager.GetString("LatestVersionCheckError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   To get more information about the latest version, see the web page below. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string LatestVersionInfo
        {
            get
            {
                return ResourceManager.GetString("LatestVersionInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   There is another instance of 3Di Viewer &quot;Rei&quot; already running. Please close all other instances and reload this page. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MultipleStartupError
        {
            get
            {
                return ResourceManager.GetString("MultipleStartupError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Startup Error に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string StartupError
        {
            get
            {
                return ResourceManager.GetString("StartupError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Warning に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string StartupWarning
        {
            get
            {
                return ResourceManager.GetString("StartupWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   To use this service, please upgrade 3Di Viewer &quot;Rei&quot; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UpdateRequired
        {
            get
            {
                return ResourceManager.GetString("UpdateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   An error occured during version checking. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string VersionCheckError
        {
            get
            {
                return ResourceManager.GetString("VersionCheckError", resourceCulture);
            }
        }
    }
}
