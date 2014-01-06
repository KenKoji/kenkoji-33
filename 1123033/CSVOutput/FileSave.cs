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
