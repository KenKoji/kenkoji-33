//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ColorBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    namespace Microsoft.Samples.Kinect.ColorBasics
    {
        /// <summary>
        /// ファイル保存クラス
        /// </summary>
        public class FileSave
        {
            public static void PNGSave()
            {
                label1.Content = "Team:やまだす\n1123060 常盤駿太 1123074.\n  上石悠樹 \n1123098  片山昂久 1123101 貝塚大晃.\n";
                // 画像保存をするためには、引数に何を割り当てればよいか考えて実装してみる
            }

            public static void CSVSave(bool[] flag)
            {
                // 既存のCSVファイルに情報を追記する設定
                using (StreamWriter sw = new StreamWriter("hoge.csv", true))
                {
                    for (int i = 0; i < flag.Length; i++)
                    {
                        sw.Write(flag[i].ToString() + ",");
                    }
                    sw.Write("\n");
                    sw.Close();
                }
            }
        }
    }
}