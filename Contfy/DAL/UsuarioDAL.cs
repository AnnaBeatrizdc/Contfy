using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contfy.Models;

namespace Contfy.DAL
{
    internal class UsuarioDAL
    {
         public static UsuarioMdl Login(string email, string senha)
{
    SqlConnection conexao = ConexaoDAL.getConexao();

    conexao.Open();

    senha = BLL.Utils.Criptografia
        .criptografarSenha(senha);

    string sql = @"SELECT * FROM Usuarios
                   WHERE Email = @Email
                   AND Senha = @Senha";

    SqlCommand cmd = new SqlCommand(sql, conexao);

    cmd.Parameters.AddWithValue("@Email", email);
    cmd.Parameters.AddWithValue("@Senha", senha);

    SqlDataReader reader = cmd.ExecuteReader();

    UsuarioMdl usuario = null;

             if (reader.Read())
            {
                    usuario = new UsuarioMdl();

                    usuario.setId(
                    Convert.ToInt32(reader["Id"])
                    );

                    usuario.setNome(
                    reader["Nome"].ToString()
                    );

                    usuario.setEmail(
                    reader["Email"].ToString()
                    );

                    usuario.setUsuario(
                    reader["Usuario"].ToString()
                    );

                    usuario.setTipoUsuario(
                    reader["TipoUsuario"].ToString()
                    );
            }

            conexao.Close();

             return usuario;

}
            //VERIFICA SE EXISTE USUARIO
             public static bool ExisteUsuario(string usuario)
            {
                bool existe = false;

            try
            {
                using (SqlConnection conexao =
                ConexaoDAL.getConexao())
            {
                conexao.Open();

                string sql = @"SELECT COUNT(*)
                           FROM Usuarios
                           WHERE Usuario = @Usuario";

                using (SqlCommand cmd =
                new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                int quantidade =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                existe = quantidade > 0;
            }
        }
    }
                catch (Exception ex)
            {
                throw new Exception("Erro ao verificar usuário: "+ ex.Message);
            }

                return existe;
            }

            //VERIFICA SE EXISTE EMAIL
            public static bool ExisteEmail(string email)
{
            bool existe = false;

            try
    {
                        using (SqlConnection conexao =
                         ConexaoDAL.getConexao())
        {
                        conexao.Open();

                        string sql = @"SELECT COUNT(*)
                           FROM Usuarios
                           WHERE Email = @Email";

                        using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
            {
                        cmd.Parameters.AddWithValue(
                        "@Email", email);

                        int quantidade =
                        Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                existe = quantidade > 0;
            }
        }
    }
                catch (Exception ex)
            {
                throw new Exception("Erro ao verificar email: "+ ex.Message);
            }

                return existe;
}

                public static void CadastrarUsuario(UsuarioMdl usuario)
{
                try
    {
                 using (SqlConnection conexao =
                ConexaoDAL.getConexao())
        {
            conexao.Open();

            string sql = @"INSERT INTO Usuarios
                           (
                               Nome,
                               Usuario,
                               Email,
                               Senha,
                               TipoUsuario
                           )
                           VALUES
                           (
                               @Nome,
                               @Usuario,
                               @Email,
                               @Senha,
                               @TipoUsuario
                           )";

            using (SqlCommand cmd =
                new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue(
                    "@Nome",
                    usuario.getNome());

                cmd.Parameters.AddWithValue(
                    "@Usuario",
                    usuario.getUsuario());

                cmd.Parameters.AddWithValue(
                    "@Email",
                    usuario.getEmail());

                cmd.Parameters.AddWithValue(
                    "@Senha",
                    usuario.getSenha());

                cmd.Parameters.AddWithValue(
                    "@TipoUsuario",
                    usuario.getTipoUsuario());

                cmd.ExecuteNonQuery();
            }
        }
    }
    catch(Exception ex)
    {
        throw new Exception(
            "Erro ao cadastrar usuário: "
            + ex.Message
        );
    }

        }
    }
}

