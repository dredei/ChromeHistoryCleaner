#region Using

using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Numerics;

#endregion

namespace ChromeHistoryCleaner
{
    internal class HistoryCleaner
    {
        /// <summary>
        /// Проверяет запущенность хрома
        /// </summary>
        /// <returns></returns>
        public static bool IsChromeRunning()
        {
            return Process.GetProcessesByName( "chrome" ).Length > 0;
        }

        /// <summary>
        /// Проверяет путь на "файл"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsFile( string path )
        {
            if ( !File.Exists( path ) )
            {
                return false;
            }
            FileAttributes attr = File.GetAttributes( path );
            return ( attr & FileAttributes.Directory ) != FileAttributes.Directory;
        }

        /// <summary>
        /// Делает копию файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Возвращает значение, указывающее на успешность выполнения операции</returns>
        public static bool MakeBackup( string path )
        {
            if ( !IsFile( path ) )
            {
                return false;
            }
            try
            {
                File.Copy( path, path + ".bak", true );
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Удаляет с истории ненужные записи
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="visitCount">Минимальное количество посещений</param>
        /// <param name="dayDef">За сколько дней защищать данные</param>
        /// <param name="makeBackup">Создавать ли резервную копию</param>
        /// <returns>Возвращает к-во удаленных записей</returns>
        public static BigInteger ClearHistory( string path, int visitCount, int dayDef, bool makeBackup = true )
        {
            if ( IsChromeRunning() )
            {
                throw new Exception( "Закройте Chrome!" );
            }
            if ( makeBackup && !MakeBackup( path ) )
            {
                throw new Exception( "Не удалось сделать резервную копию!" );
            }
            SQLiteConnection conn = new SQLiteConnection( "Data Source=" + path );
            conn.Open();
            using ( SQLiteCommand command = new SQLiteCommand( conn ) )
            {
                var dtDef = DateTime.Now.AddDays( -dayDef );
                string dtDefStr = dtDef.ToString( "yyyy-MM-dd hh:mm:ss" );
                const string lt = "datetime(last_visit_time/1000000-11644473600,'unixepoch','localtime')";
                string query = "SELECT " + lt + " AS last_visit_time, url, visit_count" +
                               " FROM urls" +
                               " WHERE visit_count < " + visitCount + " AND " + lt + " <= '" + dtDefStr + "'" +
                               " ORDER BY last_visit_time DESC";
                command.CommandText = query;
                var res = command.ExecuteReader();
                BigInteger count = 0;
                while ( res.Read() )
                {
                    count++;
                }
                query = "DELETE FROM urls" +
                        " WHERE visit_count < " + visitCount + " AND " + lt + " <= '" + dtDefStr + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                return count;
            }
        }

        /// <summary>
        /// Возвращает путь к файлу History
        /// </summary>
        /// <returns></returns>
        public static string GetPathToHistory()
        {
            return Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData ) +
                   @"\Google\Chrome\User Data\Default\History";
        }
    }
}