using Contfy.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contfy.DAL
{
    internal class AdminContainerDAL
    {
        // MÉTODO DE ADICIONAR CONTAINER
        public static void AdicionarContainer(ContainerMdl container)
        {
            try // Tenta executar o codigo no try, se der erro, cai no catch e mostra a mensagem de erro
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
                {
                    conexao.Open(); // Abre a conexao com o banco de dados

                    // Comando SQL para inserir um novo container na tabela Container, usando parametros para evitar SQL Injection
                    string sql = @"INSERT INTO Container(cd_codigo, nm_nome, nm_status, ds_localizacao, cd_usuario)
                                VALUES
                                (@Codigo, @Nome, @Status, @Localizacao, @Responsavel)";

                    // Cria um comando SQL usando a conexao e o comando SQL definido acima, e adiciona os parametros com os valores do container
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        // Adiciona os parametros com os valores do container, usando os metodos get para pegar os valores dos atributos do container
                        cmd.Parameters.AddWithValue("@Codigo", container.getCodigo());

                        cmd.Parameters.AddWithValue("@Nome", container.getNome());

                        cmd.Parameters.AddWithValue("@Status", container.getStatus());

                        cmd.Parameters.AddWithValue("@Localizacao", container.getLocalizacao());

                        cmd.Parameters.AddWithValue("@Responsavel", container.getResponsavel());

                        cmd.ExecuteNonQuery(); // Executa o comando SQL, nesse caso um INSERT, entao usamos ExecuteNonQuery que nao retorna nenhum resultado, apenas executa o comando
                    }
                }
            }
            catch (Exception ex) // Se ocorrer um erro, mostra a mensagem de erro com o conteudo da excecao
            {
                throw new Exception("Erro ao adicionar container: " + ex.Message);
            }
        }

        

        // MÉTODO PARA ALTERAR OS DADOS DE UM CONTAINER
        public static void AlterarContainer(ContainerMdl container)
        {
            try // Tenta executar o codigo no try, se der erro, cai no catch e mostra a mensagem de erro
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
                {
                    conexao.Open(); // Abre a conexao com o banco de dados

                    // Comando SQL para atualizar os dados de um container na tabela Container, usando parametros para evitar SQL Injection, o comando SQL atualiza o nome, status, localizacao e responsavel do container com o codigo fornecido
                    string sql = @"UPDATE Container
                               SET
                               nm_nome = @Nome,
                               nm_status = @Status,
                               ds_localizacao = @Localizacao,
                               cd_usuario = @Responsavel
                               WHERE cd_codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        // Adiciona os parametros com os valores do container, usando os metodos get para pegar os valores dos atributos do container
                        cmd.Parameters.AddWithValue("@Codigo", container.getCodigo());

                        cmd.Parameters.AddWithValue("@Nome", container.getNome());

                        cmd.Parameters.AddWithValue("@Status", container.getStatus());

                        cmd.Parameters.AddWithValue("@Localizacao", container.getLocalizacao());

                        cmd.Parameters.AddWithValue("@Responsavel", container.getResponsavel());

                        cmd.ExecuteNonQuery(); // Executa o comando SQL, nesse caso um UPDATE, entao usamos ExecuteNonQuery que nao retorna nenhum resultado, apenas executa o comando
                    }
                }
            }
            catch (Exception ex) // Se ocorrer um erro, mostra a mensagem de erro com o conteudo da excecao
            {
                throw new Exception("Erro ao alterar container: " + ex.Message);
            }
        }

        // MÉTODO PARA DELETAR UM CONTAINER
        public static void DeletarContainer(string codigo)
        {
            try // Tenta executar o codigo no try, se der erro, cai no catch e mostra a mensagem de erro
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
                {
                    conexao.Open(); // Abre a conexao com o banco de dados

                    // Comando SQL para deletar um container da tabela Container com o codigo fornecido, usando parametros para evitar SQL Injection
                    string sql = @"DELETE 
                                FROM Container
                                WHERE cd_codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao)) // Cria um comando SQL usando a conexao e o comando SQL definido acima, e adiciona o parametro com o valor do codigo
                    {
                        // Adiciona o parametro com o valor do codigo fornecido
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        cmd.ExecuteNonQuery(); // Executa o comando SQL, nesse caso um DELETE, entao usamos ExecuteNonQuery que nao retorna nenhum resultado, apenas executa o comando
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar container: " + ex.Message);
            }
        }

        // MÉTODO PARA VER SE O CONTAINER EXISTE
        public static bool ExisteContainer(string codigo)
        {
            bool existe = false; // Variavel para armazenar se o container existe ou nao, inicialmente falsa
            try // Tenta executar o codigo no try, se der erro, cai no catch e mostra a mensagem de erro
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
                {
                    conexao.Open(); // Abre a conexao com o banco de dados

                    // Comando SQL para contar quantos containers existem com o codigo fornecido
                    string sql = @"SELECT COUNT(*)
                                FROM Container
                                WHERE cd_codigo = @Codigo";

                    // Cria um comando SQL usando a conexao e o comando SQL definido acima, e adiciona o parametro com o valor do codigo
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo); // Adiciona o parametro com o valor do codigo fornecido

                        int quantidade = Convert.ToInt32(cmd.ExecuteScalar()); // Executa o comando SQL, nesse caso um SELECT COUNT(*), entao usamos ExecuteScalar que retorna o valor da primeira coluna da primeira linha do resultado, que nesse caso sera a quantidade de containers com o codigo fornecido
                        existe = quantidade > 0; // Se a quantidade for maior que 0, entao o container existe, entao atribuimos true para a variavel existe, caso contrario, permanece false
                    }
                }
            }
            catch (Exception ex) // Se ocorrer um erro, mostra a mensagem de erro com o conteudo da excecao
            {
                throw new Exception("Erro ao verificar container: " + ex.Message);
            }
            return existe;
        }

        // MÉTODO PARA LISTAR TODOS OS CONTAINERS
        public static DataTable ListarContainers()
        {
            DataTable tabela = new DataTable(); // Cria uma tabela de dados para armazenar os resultados da consulta SQL

            using (SqlConnection conexao = ConexaoDAL.getConexao())
            {
                // Seleciona os dados dos containers, incluindo o codigo, nome, status, localizacao e o codigo e nome do responsavel, usando um LEFT JOIN para pegar os dados do responsavel mesmo que o container nao tenha um responsavel associado
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

                using (SqlCommand cmd = new SqlCommand(sql, conexao)) // Cria um comando SQL usando a conexao e o comando SQL definido acima
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Cria um adaptador de dados usando o comando SQL, o adaptador de dados é usado para preencher a tabela de dados com os resultados da consulta SQL
                    da.Fill(tabela); // Preenche a tabela de dados com os resultados da consulta SQL, o adaptador de dados executa o comando SQL e preenche a tabela de dados com os resultados, nesse caso, os dados dos containers e seus responsaveis
                }
            }

            return tabela; // Retorna a tabela de dados preenchida com os resultados da consulta SQL, que pode ser usada para exibir os dados dos containers em um DataGridView ou outro controle de exibição de dados
        }

        public static ContainerMdl BuscarPorCodigo(string codigo)
        {
            ContainerMdl container = null; // Variavel para armazenar o container encontrado, inicialmente nula

            using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
            {
                conexao.Open(); // Abre a conexao com o banco de dados

                // Comando SQL para selecionar os dados de um container com o codigo fornecido, incluindo o codigo, nome, status, localizacao e o codigo do responsavel, usando um LEFT JOIN para pegar os dados do responsavel mesmo que o container nao tenha um responsavel associado
                string sql = @"SELECT
                            c.cd_codigo,
                            c.nm_nome,
                            c.nm_status,
                            c.ds_localizacao,
                            u.cd_codigo AS CodigoResponsavel
                            FROM Container c
                            LEFT JOIN Usuario u
                                ON c.cd_usuario = u.cd_codigo
                            WHERE c.cd_codigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(sql, conexao)) // Cria um comando SQL usando a conexao e o comando SQL definido acima, e adiciona o parametro com o valor do codigo
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo); // Adiciona o parametro com o valor do codigo fornecido

                    // Executa o comando SQL, nesse caso um SELECT, entao usamos ExecuteReader que retorna um SqlDataReader para ler os resultados da consulta SQL, nesse caso, os dados do container com o codigo fornecido
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Se o SqlDataReader tiver resultados, ou seja, se o container com o codigo fornecido existir, entao le os dados do container e armazena em um objeto ContainerMdl, usando os metodos set para atribuir os valores dos atributos do container
                        if (dr.Read())
                        {
                            // Cria um novo objeto ContainerMdl para armazenar os dados do container encontrado
                            container = new ContainerMdl();

                            container.setCodigo(dr["cd_codigo"].ToString());

                            container.setNome(dr["nm_nome"].ToString());

                            container.setStatus(dr["nm_status"].ToString());

                            container.setLocalizacao(dr["ds_localizacao"].ToString());

                            container.setResponsavel(dr["CodigoResponsavel"].ToString());
                        }
                    }
                }
            }

            return container; // Retorna o container encontrado, ou nulo se nenhum container com o codigo fornecido existir, esse metodo pode ser usado para preencher os campos de um formulario de edicao de container com os dados do container selecionado em um DataGridView ou outro controle de exibição de dados
        }


        // MÉTODO PARA FILTRAR OS CONTAINERS COM BASE EM UMA PESQUISA E UM STATUS, O METODO RETORNA UMA TABELA DE DADOS COM OS RESULTADOS DA CONSULTA SQL, que pode ser usada para exibir os dados dos containers filtrados em um DataGridView ou outro controle de exibição de dados
        public static DataTable FiltrarContainers(string pesquisa, string status)
        {
            DataTable tabela = new DataTable(); // Cria uma tabela de dados para armazenar os resultados da consulta SQL

            try // Tenta executar o codigo no try, se der erro, cai no catch e mostra a mensagem de erro
            {
                using (SqlConnection conexao = ConexaoDAL.getConexao()) // Usando a conexao do banco de dados, o using garante que a conexao seja fechada mesmo que ocorra um erro
                {
                    conexao.Open(); // Abre a conexao com o banco de dados

                    // Comando SQL para selecionar os dados dos containers que correspondem a pesquisa e ao status fornecidos, usando um LEFT JOIN para pegar os dados do responsavel mesmo que o container nao tenha um responsavel associado, a consulta SQL filtra os containers usando o operador LIKE para comparar os campos do container e do responsavel com a pesquisa fornecida, e se o status for diferente de "Todos", entao adiciona uma condicao para filtrar os containers pelo status fornecido
                    string sql = @"SELECT
                                c.cd_codigo AS CodigoContainer,
                                c.nm_nome AS NomeContainer,
                                c.nm_status AS StatusContainer,
                                c.ds_localizacao AS LocalizacaoContainer,
                                u.cd_codigo AS CodigoResponsavel,
                                u.nm_nome AS NomeResponsavel
                                FROM Container c
                                LEFT JOIN Usuario u
                                    ON c.cd_usuario = u.cd_codigo
                                WHERE (
                                    c.cd_codigo LIKE @Pesquisa
                                    OR c.nm_nome LIKE @Pesquisa
                                    OR c.ds_localizacao LIKE @Pesquisa
                                    OR u.cd_codigo LIKE @Pesquisa
                                    OR u.nm_nome LIKE @Pesquisa
                                    )";

                    // Se o status for diferente de "Todos", entao adiciona uma condicao para filtrar os containers pelo status fornecido, usando um parametro para evitar SQL Injection
                    if (status != "Todos")
                    {
                        sql += " AND c.nm_status = @Status"; // Adiciona a condicao para filtrar os containers pelo status fornecido, usando um parametro para evitar SQL Injection
                    }

                    // Cria um comando SQL usando a conexao e o comando SQL definido acima, e adiciona os parametros com os valores da pesquisa e do status
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        // Adiciona o parametro com o valor da pesquisa fornecida, usando o operador LIKE para comparar os campos do container e do responsavel com a pesquisa fornecida, entao adicionamos os caracteres curinga % antes e depois da pesquisa para permitir que a consulta SQL encontre os containers que contenham a pesquisa em qualquer parte dos campos comparados
                        cmd.Parameters.AddWithValue("@Pesquisa", "%" + pesquisa + "%");

                        if (status != "Todos") // Se o status for diferente de "Todos", entao adiciona o parametro com o valor do status fornecido para filtrar os containers pelo status fornecido, usando um parametro para evitar SQL Injection
                        {
                            cmd.Parameters.AddWithValue("@Status", status);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd); // Cria um adaptador de dados usando o comando SQL, o adaptador de dados é usado para preencher a tabela de dados com os resultados da consulta SQL

                        da.Fill(tabela); // Preenche a tabela de dados com os resultados da consulta SQL, o adaptador de dados executa o comando SQL e preenche a tabela de dados com os resultados, nesse caso, os dados dos containers que correspondem a pesquisa e ao status fornecidos
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar container: " + ex.Message);
            }

            return tabela;
        }

        public static void GerarPdfContainers()
        {
            try
            {
                // Pega os dados do seu método
                DataTable tabela = ListarContainers();

                // Pasta onde salvar
                string pasta = @"C:\PDF";

                Directory.CreateDirectory(pasta); // Cria a pasta se não existir

                string caminho = Path.Combine(pasta, "containers.pdf"); // Caminho completo do arquivo PDF

                // Cria documento PDF
                Document documento = new Document(PageSize.A4.Rotate());

                // Cria o PDF e salva no caminho especificado
                PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));

                documento.Open(); // Abre o documento para escrita

                // Título
                Paragraph titulo = new Paragraph("RELATORIO DE CONTAINERS");
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;

                documento.Add(titulo); // Adiciona o título ao documento

                // Cria tabela PDF
                PdfPTable pdfTabela = new PdfPTable(tabela.Columns.Count);

                // Cabeçalhos
                foreach (DataColumn coluna in tabela.Columns)
                {
                    PdfPCell celula = new PdfPCell(new Phrase(coluna.ColumnName));
                    pdfTabela.AddCell(celula);
                }

                // Dados
                foreach (DataRow linha in tabela.Rows)
                {
                    foreach (var item in linha.ItemArray)
                    {
                        pdfTabela.AddCell(item.ToString());
                    }
                }

                documento.Add(pdfTabela); // Adiciona a tabela ao documento

                documento.Close(); // Fecha o documento

                MessageBox.Show("PDF gerado com sucesso!"); // Exibe uma mensagem de sucesso

                // Abre o PDF
                Process.Start(caminho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
        }
    }
}
