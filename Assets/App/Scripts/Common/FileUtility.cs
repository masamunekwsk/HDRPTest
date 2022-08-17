using System.IO;
using UnityEngine;


    /// <summary>
    /// ファイル操作汎用処理
    /// </summary>
    public class FileUtility
    {
        /// <summary>
        /// StreamingのJsonファイルを読み込み
        /// </summary>
        /// <param name="name">Jsonファイル名</param>
        /// <returns>Json内容</returns>
        public static string LoadJson(string name)
        {
            var path = $"{Application.streamingAssetsPath}/{name}.json";
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"ファイルが存在しない：{path}");
            }
            return File.ReadAllText(path);
        }
    }
