using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBAcademia
{
    public class Banco
    {
        private static SQLiteConnection conexao;

        public static SQLiteConnection Conectar()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\matrsantos\\Documents\\Visual Studio 2017\\Projects\\CFBAcademia\\CFBAcademia\\db\\dbAcademia.db");
            conexao.Open();
            return conexao;
        }

        

        public static DataTable Consultar(string sql)
        {
           
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conectar().CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                    
                    da.Fill(dt);
                    
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
