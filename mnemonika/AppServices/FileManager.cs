using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.IO;
using mnemonika.AppConstants;

namespace mnemonika.AppServices
{
    internal class FileManager
    {
        /// <summary>
        /// PKGH
        /// Получение пути изображения
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <returns></returns>
        public static string GetImgPath(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return Path.Combine(Application.StartupPath, "img", FilePath.defaultPicture);
            }

            return Path.Combine(Application.StartupPath, "img", fileName);
        }

        /// <summary>
        /// PKGH
        /// Удаление файла
        /// </summary>
        /// <param name="photo">Название файла</param>
        internal static void DeleteFile(string photo)
        {
            if (string.IsNullOrWhiteSpace(photo))
            {
                return;
            }

            try
            {
                File.Delete(GetImgPath(photo));
            }
            catch (Exception e)
            {
                Debug.Print($"Не удалось удалить файл {photo}."); // PKGH Отладочная печать.                
            }
        }
    }
}