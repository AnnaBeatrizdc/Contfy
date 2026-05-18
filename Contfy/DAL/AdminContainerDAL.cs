using Contfy.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Contfy.DAL
{
    internal class AdminContainerDAL
    {
        public static void AdicionarContainer(ContainerMdl container)
        {
            try
            {
                using (SqlConnection conexao =
                    ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"INSERT INTO Containers
                           (
                               Codigo,
                               Nome,
                               Status,
                               Localizacao
                           )
                           VALUES
                           (
                               @Codigo,
                               @Nome,
                               @Status,
                               @Localizacao
                           )";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Codigo",
                            container.getCodigo());

                        cmd.Parameters.AddWithValue(
                            "@Nome",
                            container.getNome());

                        cmd.Parameters.AddWithValue(
                            "@Status",
                            container.getStatus());

                        cmd.Parameters.AddWithValue(
                            "@Localizacao",
                            container.getLocalizacao());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao adicionar container: "
                    + ex.Message
                );
            }
        }

        public static bool ExisteContainer(string codigo)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexao =
                    ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"SELECT COUNT(*)
                           FROM Containers
                           WHERE Codigo = @Codigo";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Codigo",
                            codigo);

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
                throw new Exception(
                    "Erro ao verificar container: "
                    + ex.Message
                );
            }

            return existe;
        }

        public static DataTable ListarContainers()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection conexao =
                    ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql =
                        @"SELECT * FROM Containers";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
                    {
                        SqlDataAdapter da =
                            new SqlDataAdapter(cmd);

                        da.Fill(tabela);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao listar containers: "
                    + ex.Message
                );
            }

            return tabela;
        }

        public static void AlterarContainer(ContainerMdl container)
        {
            try
            {
                using (SqlConnection conexao =
                    ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"UPDATE Containers
                               SET
                               Nome = @Nome,
                               Status = @Status,
                               Localizacao = @Localizacao
                               WHERE Codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Codigo",
                            container.getCodigo());

                        cmd.Parameters.AddWithValue(
                            "@Nome",
                            container.getNome());

                        cmd.Parameters.AddWithValue(
                            "@Status",
                            container.getStatus());

                        cmd.Parameters.AddWithValue(
                            "@Localizacao",
                            container.getLocalizacao());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao alterar container: "
                    + ex.Message
                );
            }
        }

        public static void DeletarContainer(string codigo)
        {
            try
            {
                using (SqlConnection conexao =
                    ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql =
                        @"DELETE FROM Containers
                  WHERE Codigo = @Codigo";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Codigo",
                            codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao deletar container: "
                    + ex.Message
                );
            }
        }

        public static DataTable FiltrarContainers(string pesquisa,string status)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql =
                    @"SELECT * FROM Containers
                    WHERE
                    (
                    Codigo LIKE @Pesquisa
                    OR Nome LIKE @Pesquisa
                    OR Localizacao LIKE @Pesquisa
                    )";

                    if (status != "TODOS")
                    {
                        sql +=
                        " AND Status = @Status";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Pesquisa",
                            "%" + pesquisa + "%");

                        if (status != "TODOS")
                        {
                            cmd.Parameters.AddWithValue(
                                "@Status",
                                status);
                        }

                        SqlDataAdapter da =
                            new SqlDataAdapter(cmd);

                        da.Fill(tabela);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Erro ao filtrar containers: "
                    + ex.Message
                );
            }

            return tabela;
        }




    }

}
