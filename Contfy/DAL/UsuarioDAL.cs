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
        // MÉTODO DE LOGIN
        public static UsuarioMdl Login(string email, string senha)
        {
            SqlConnection conexao = ConexaoDAL.getConexao(); // Obter a conexão com o banco de dados
            conexao.Open(); // Abrir a conexão

            // Criptografar a senha antes de compará-la com a senha armazenada no banco de dados
            senha = BLL.Utils.Criptografia.criptografarSenha(senha);

            // Consulta SQL para verificar se o email e a senha correspondem a um usuário no banco de dados
            string sql = @"SELECT * FROM Usuario
                         WHERE ds_email = @Email
                         AND ds_senha = @Senha";

            // Cria um comando SQL no C# para enviar instruções ao banco de dados. Ele executa a busca do usuario no banco de dados usando os parâmetros fornecidos (email e senha).
            SqlCommand cmd = new SqlCommand(sql, conexao);

            // Envia os parâmetros para o comando SQL, substituindo os marcadores @Email e @Senha pelos valores fornecidos pelo usuário. Isso ajuda a evitar ataques de injeção de SQL.
            cmd.Parameters.AddWithValue("@Email", email); 
            cmd.Parameters.AddWithValue("@Senha", senha);

            SqlDataReader reader = cmd.ExecuteReader(); // Executa o comando SQL e obtém um leitor de dados para ler os resultados da consulta.

            UsuarioMdl usuario = null; // Inicializa a variável usuario como null. Se a consulta retornar um resultado, essa variável será preenchida com os dados do usuário.

            if (reader.Read()) // Verifica se há um resultado da consulta. Se houver, significa que o email e a senha correspondem a um usuário no banco de dados.
            {
                // Cria um novo objeto UsuarioMdl e preenche seus campos com os dados obtidos do banco de dados. Neste caso, apenas o tipo de usuário é preenchido.
                usuario = new UsuarioMdl();

                usuario.setTipoUsuario(reader["nm_tipoUsuario"].ToString());
            }

            conexao.Close();// Fecha a conexão com o banco de dados.

            return usuario; // Retorna o objeto usuario. Se a consulta não encontrar um usuário correspondente, o valor retornado será null.

        }

        // MÉTODO DE CADASTRO
        public static void CadastrarUsuario(UsuarioMdl usuario)
        {
            try // Tenta executar o código dentro do bloco try. 
            {
                // Cria uma conexão com o banco de dados e usa o using para garantir que a conexão seja fechada corretamente, mesmo que ocorra uma exceção.
                using (SqlConnection conexao = ConexaoDAL.getConexao())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados.

                    // Consulta SQL para inserir um novo usuário na tabela Usuario. Os valores a serem inseridos são representados por parâmetros (marcadores) que serão substituídos pelos valores reais do objeto usuario.
                    string sql = @"INSERT INTO Usuario
                           (nm_nome, nm_tipoUsuario, ds_email, ds_senha, cd_telefone, cd_CEP, nm_logradouro, nm_bairro, nm_localidade, sg_uf)
                           VALUES
                           (@Nome, @TipoUsuario, @Email, @Senha, @Telefone, @CEP, @Logradouro, @Bairro, @Localidade, @UF)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        // Envia os parâmetros para o comando SQL, substituindo os marcadores pelos valores correspondentes do objeto usuario. Isso ajuda a evitar ataques de injeção de SQL.
                        cmd.Parameters.AddWithValue("@Nome", usuario.getNome());

                        cmd.Parameters.AddWithValue("@TipoUsuario", usuario.getTipoUsuario());

                        cmd.Parameters.AddWithValue("@Email", usuario.getEmail());

                        cmd.Parameters.AddWithValue("@Senha", usuario.getSenha());

                        cmd.Parameters.AddWithValue("@Telefone", usuario.getTelefone());

                        // Verifica se o valor do CEP é nulo. Se for nulo, o parâmetro @CEP será definido como DBNull.Value, indicando que o valor é nulo no banco de dados. Caso contrário, o valor do CEP será enviado como parâmetro.
                        if (usuario.getCep() == null)
                        {
                            cmd.Parameters.AddWithValue("@CEP", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CEP", usuario.getCep());
                        }

                        cmd.Parameters.AddWithValue("@Logradouro", usuario.getLogradouro());

                        cmd.Parameters.AddWithValue("@Bairro", usuario.getBairro());

                        cmd.Parameters.AddWithValue("@Localidade", usuario.getLocalidade());

                        cmd.Parameters.AddWithValue("@UF", usuario.getUf());

                        cmd.ExecuteNonQuery(); // Executa o comando SQL para inserir o novo usuário no banco de dados. ExecuteNonQuery é usado para comandos SQL que não retornam resultados, como INSERT, UPDATE ou DELETE.
                    }
                }
            }
            catch (Exception ex) // Se ocorrer uma exceção, o controle será transferido para o bloco catch, onde a exceção será tratada. Se ocorrer uma exceção, o controle será transferido para o bloco catch, onde a exceção será tratada.
            {
                throw new Exception("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        //VERIFICAR SE EXISTE EMAIL
        public static bool ExisteEmail(string email)
        {
            bool existe = false; // Inicializa a variável existe como false. Se a consulta encontrar um email correspondente, essa variável será definida como true.
            try // Tenta executar o código dentro do bloco try.
            {
                // Cria uma conexão com o banco de dados e usa o using para garantir que a conexão seja fechada corretamente, mesmo que ocorra uma exceção.
                using (SqlConnection conexao = ConexaoDAL.getConexao()) 
                {
                    conexao.Open();// Abre a conexão com o banco de dados.

                    // Consulta SQL para contar quantos registros na tabela Usuario possuem o email fornecido. O resultado será um número inteiro representando a quantidade de registros encontrados.
                    string sql = @"SELECT COUNT(*)
                                FROM Usuario
                                WHERE ds_email = @Email";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))// Cria um comando SQL no C# para enviar instruções ao banco de dados. Ele executa a contagem de registros na tabela Usuario usando o parâmetro fornecido (email).
                    {
                        cmd.Parameters.AddWithValue("@Email", email); // Envia o parâmetro para o comando SQL, substituindo o marcador @Email pelo valor fornecido pelo usuário. Isso ajuda a evitar ataques de injeção de SQL.

                        // Executa o comando SQL e obtém o resultado da contagem. ExecuteScalar é usado para comandos SQL que retornam um único valor, como COUNT(*). O resultado é convertido para um inteiro usando Convert.ToInt32.
                        int quantidade =Convert.ToInt32(cmd.ExecuteScalar());
                        existe = quantidade > 0; // Define a variável existe como true se a quantidade de registros encontrados for maior que 0, indicando que o email já existe no banco de dados. Caso contrário, existe permanecerá false, indicando que o email não existe.
                    }
                }
            }
            catch (Exception ex) // Se ocorrer uma exceção, o controle será transferido para o bloco catch, onde a exceção será tratada. Se ocorrer uma exceção, o controle será transferido para o bloco catch, onde a exceção será tratada.
            {
                throw new Exception("Erro ao verificar email: " + ex.Message);
            }

            return existe;
        }  
    }
}

