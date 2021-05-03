using CFBAcademia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFBAcademia.DAL
{
    public class DALUsuario
    {
        public void NovoUsuario(Usuario usuario)
        {
            if(VerificarSeExisteUsuario(usuario))
            {
                MessageBox.Show("Usuario ja existe");
                return;
            }
            
            try
            {
                var cmd = Banco.Conectar().CreateCommand();
                cmd.CommandText = "INSERT INTO Usuarios (nome, username, senha, status, nivel) values (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@username", usuario.Username);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@status", usuario.Status);
                cmd.Parameters.AddWithValue("@nivel", usuario.Nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario cadastrado com Sucesso");
                Banco.Conectar().Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar usuario" + e);
                Banco.Conectar().Close();
            }
        }

        public static DataTable ObterUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.Conectar().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, Banco.Conectar());
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterUsuariosById(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Banco.Conectar().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuarios where idusuario ="+id;
                    da = new SQLiteDataAdapter(cmd.CommandText, Banco.Conectar());
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerificarSeExisteUsuario(Usuario usuario)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = Banco.Conectar().CreateCommand();
            cmd.CommandText = "SELECT username FROM USUARIOS WHERE username = '"+usuario+"' ";
            da = new SQLiteDataAdapter(cmd.CommandText, Banco.Conectar());
            da.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                res = true;
            }
            else
            {
                return res = false;
            }
            return res;
        }
    }
}
