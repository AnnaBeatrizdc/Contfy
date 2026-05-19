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

            senha = BLL.Utils.Criptografia.criptografarSenha(senha);

            string sql = @"SELECT * FROM Usuario
                   WHERE ds_email = @Email
                   AND ds_senha = @Senha";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", senha);

            SqlDataReader reader = cmd.ExecuteReader();

            UsuarioMdl usuario = null;

            if (reader.Read())
            {
                usuario = new UsuarioMdl();

                usuario.setTipoUsuario(reader["nm_tipoUsuario"].ToString());
            }

            conexao.Close();

            return usuario;

        }
        //VERIFICA SE EXISTE EMAIL
        public static bool ExisteEmail(string email)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"SELECT COUNT(*)
                           FROM Usuario
                           WHERE ds_email = @Email";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        int quantidade =Convert.ToInt32(cmd.ExecuteScalar());
                        existe = quantidade > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar email: " + ex.Message);
            }

            return existe;
        }

        public static void CadastrarUsuario(UsuarioMdl usuario)
        {
            try
            {
                using (SqlConnection conexao =ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"INSERT INTO Usuario
                           (
                               nm_nome,
                               nm_tipoUsuario,
                               ds_email,
                               ds_senha,
                               cd_telefone,
                               cd_CEP,
                               nm_logradouro,
                               nm_bairro,
                               nm_localidade,
                               sg_uf
                           )
                           VALUES
                           (
                               @Nome,
                               @TipoUsuario,
                               @Email,
                               @Senha,
                               @Telefone,
                               @CEP,
                               @Logradouro,
                               @Bairro,
                               @Localidade,
                               @UF
                           )";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Nome",
                            usuario.getNome());

                        cmd.Parameters.AddWithValue(
                            "@TipoUsuario",
                            usuario.getTipoUsuario());

                        cmd.Parameters.AddWithValue(
                            "@Email",
                            usuario.getEmail());

                        cmd.Parameters.AddWithValue(
                            "@Senha",
                            usuario.getSenha());

                        cmd.Parameters.AddWithValue(
                            "@Telefone",
                            usuario.getTelefone());

                        cmd.Parameters.AddWithValue(
                            "@CEP",
                            usuario.getCep());

                        cmd.Parameters.AddWithValue(
                            "@Logradouro",
                            usuario.getLogradouro());

                        cmd.Parameters.AddWithValue(
                            "@Bairro",
                            usuario.getBairro());

                        cmd.Parameters.AddWithValue(
                            "@Localidade",
                            usuario.getLocalidade());

                        cmd.Parameters.AddWithValue(
                            "@UF",
                            usuario.getUf());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao cadastrar usuário: "
                    + ex.Message
                );
            }
        }
    }
}

