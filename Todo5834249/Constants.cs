using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo5834249
{
    public class Constants
    {
        public const string DatabaseFileName = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            //Abrir la base de datos en modo lectura/escritura
            SQLite.SQLiteOpenFlags.ReadWrite |
            //Crear la base de datos si no existe
            SQLite.SQLiteOpenFlags.Create |
            //Habilitación del acceso a la base de datos multiproceso
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);
    }
}
