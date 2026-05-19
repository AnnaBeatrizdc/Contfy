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
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"INSERT INTO Container
                           (
                               cd_codigo,
                               nm_nome,
                               nm_status,
                               ds_localizacao,
                               cd_usuario
                           )
                           VALUES
                           (
                               @Codigo,
                               @Nome,
                               @Status,
                               @Localizacao,
                               @Responsavel
                           )";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", container.getCodigo());

                        cmd.Parameters.AddWithValue("@Nome", container.getNome());

                        cmd.Parameters.AddWithValue("@Status", container.getStatus());

                        cmd.Parameters.AddWithValue("@Localizacao", container.getLocalizacao());

                        cmd.Parameters.AddWithValue("@Responsavel", container.getResponsavel());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar container: " + ex.Message);
            }
        }

        public static bool ExisteContainer(string codigo)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"SELECT COUNT(*)
                           FROM Container
                           WHERE cd_codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        int quantidade = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = quantidade > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar container: " + ex.Message);
            }
            return existe;
        }

        public static DataTable ListarContainers()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = ConexaoDAL.getConexao())
            {
                string sql = @"SELECT
                            c.cd_codigo AS CodigoContainer,
                            c.nm_nome AS NomeContainer,
                            c.nm_status AS StatusContainer,
                            c.ds_localizacao AS LocalizacaoContainer,
                            u.cd_codigo AS CodigoResponsavel,
                            u.nm_nome AS NomeResponsavel
                            FROM Container c
                            LEFT JOIN Usuario u
                                ON c.cd_usuario = u.cd_codigo";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabela);
                }
            }

            return tabela;
        }

        public static void AlterarContainer(ContainerMdl container)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"UPDATE Container
                               SET
                               nm_nome = @Nome,
                               nm_status = @Status,
                               ds_localizacao = @Localizacao,
                               cd_usuario = @Responsavel
                               WHERE cd_codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", container.getCodigo());

                        cmd.Parameters.AddWithValue("@Nome", container.getNome());

                        cmd.Parameters.AddWithValue("@Status", container.getStatus());

                        cmd.Parameters.AddWithValue("@Localizacao", container.getLocalizacao());

                        cmd.Parameters.AddWithValue("@Responsavel", container.getResponsavel());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar container: " + ex.Message);
            }
        }

        public static ContainerMdl BuscarPorCodigo(string codigo)
        {
            ContainerMdl container = null;

            using (SqlConnection conexao = ConexaoDAL.getConexao())
            {
                conexao.Open();

                string sql = @"SELECT
            c.cd_codigo,
            c.nm_nome,
            c.nm_status,
            c.ds_localizacao,
            u.cd_codigodeee AS CodigoResponsavel
        FROM Container c
        LEFT JOIN Usuario u
            ON c.cd_usuario = u.cd_codigo
        WHERE c.cd_codigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            container = new ContainerMdl();

                            container.setCodigo(
                                dr["cd_codigo"].ToString());

                            container.setNome(
                                dr["nm_nome"].ToString());

                            container.setStatus(
                                dr["nm_status"].ToString());

                            container.setLocalizacao(
                                dr["ds_localizacao"].ToString());

                            container.setResponsavel(
                                dr["CodigoResponsavel"].ToString());
                        }
                    }
                }
            }

            return container;
        }

        public static void DeletarContainer(string codigo)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql =
                        @"DELETE FROM Container
                        WHERE cd_codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar container: " + ex.Message);
            }
        }

        public static DataTable FiltrarContainers(string pesquisa, string status)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open();

                    string sql = @"
                        SELECT
                c.cd_codigo AS CodigoContainer,
                c.nm_nome AS NomeContainer,
                c.nm_status AS StatusContainer,
                c.ds_localizacao AS LocalizacaoContainer,
                u.cd_codigo AS CodigoResponsavel,
                u.nm_nome AS NomeResponsavel
            FROM Container c
            LEFT JOIN Usuario u
                ON c.cd_usuario = u.cd_codigo
            WHERE
            (
                c.cd_codigo LIKE @Pesquisa
                OR c.nm_nome LIKE @Pesquisa
                OR c.ds_localizacao LIKE @Pesquisa
                OR u.nm_nome LIKE @Pesquisa
            )";

                    if (status != "Todos")
                    {
                        sql += " AND c.nm_status = @Status";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Pesquisa", "%" + pesquisa + "%");

                        if (status != "Todos")
                        {
                            cmd.Parameters.AddWithValue("@Status", status);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tabela);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar container: " + ex.Message);
            }

            return tabela;
        }


    }
}
