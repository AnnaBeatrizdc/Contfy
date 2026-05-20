using Contfy.BLL.Utils;
using Contfy.DAL;
using Contfy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contfy.BLL
{
    internal class UsuarioBLL
    {
        // VALIDAÇÃO DOS DADOS DE LOGIN
        public static void validaDadosLogin(UsuarioMdl usuario)
        {
            Erro.setErro(false); // Zero o erro

            // EMAIL
            // Padronizar email: tudo minúsculo e sem espaços
            usuario.setEmail(usuario.getEmail().ToLower().Trim());

            // Valida se o compo email foi preenchido
            if (usuario.getEmail().Equals(""))
            {
                Erro.setMens("O email é de preenchimento obrigatório!");
                return;
            }

            // SENHA
            // Valida se o campo senha foi preenchido
            if (usuario.getSenha().Equals(""))
            {
                Erro.setMens("A senha é de preenchimento obrigatória!");
                return;
            }
        }

        public static UsuarioMdl FazerLogin(UsuarioMdl usuario)
        {
            // Pega o email e senha do usuário, envie para o método Login da camada de banco de dados e devolva o resultado se existir um usuário com aquele email e senha
            return UsuarioDAL.Login(usuario.getEmail(),usuario.getSenha());
        }

        // VALIDAÇÃO DOS DADOS DE CADASTRO
        public static void ValidaDadosCadastro(UsuarioMdl usuario, char op)
        {
            Erro.setErro(false); // Zero o erro

            // Padronizar email: tudo minúsculo e sem espaços
            usuario.setEmail(usuario.getEmail().ToLower().Trim());

            // Padronizar nome: primeira letra maiúscula e o resto minúsculo
            usuario.setNome(char.ToUpper(usuario.getNome()[0]) + usuario.getNome().Substring(1).ToLower());

            // Criptografa a senha usando o método criptografarSenha da classe Criptografia
            usuario.setSenha(Criptografia.criptografarSenha(usuario.getSenha()));

            // NOME
            // Valida se o campo nome foi preenchido
            if (usuario.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é de preenchimento obrigatório!");
                return;
            }

            // EMAIL
            // Valida se o campo email foi preenchido
            if (usuario.getEmail().Trim().Equals(""))
            {
                Erro.setMens("O email é de preenchimento obrigatório!");
                return;
            }

            // Valida se o email tem um formato válido usando expressão regular (REGEX)
            string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // O método IsMatch da classe Regex retorna true se o email corresponder ao padrão definido, caso contrário, retorna false
            if (!Regex.IsMatch(usuario.getEmail(), padraoEmail))
            {
                Erro.setMens("Formato de email inválido!");
                return;
            }

            // Valida se o email já existe no banco de dados usando o método ExisteEmail da camada de banco de dados
            if (UsuarioDAL.ExisteEmail(usuario.getEmail()))
            {
                Erro.setMens("Email já cadastrado!");
                return;
            }

            // TIPO DE USUÁRIO
            // Valida se o campo tipo de usuário foi selecionado
            if (usuario.getTipoUsuario().Trim().Equals(""))
            {
                Erro.setMens("Selecione o tipo da conta!");
                return;
            }

            // SENHA
            // Valida se o campo senha foi preenchido
            if (usuario.getSenha().Trim().Equals(""))
            {
                Erro.setMens("A senha é de preenchimento obrigatória!");
                return;
            }

            // Valida se a senha tem no mínimo 6 caracteres
            if (usuario.getSenha().Length < 6)
            {
                Erro.setMens("A senha deve ter no mínimo 6 caracteres!");
                return;
            }

            // TELEFONE
            // Formata o telefone para o formato (XX) XXXXX-XXXX usando expressão regular (REGEX)
            Regex regexTelefone = new Regex(@"^\(\d{2}\)\s\d{5}-\d{4}$");

            // Valida se o campo telefone foi preenchido
            if (usuario.getTelefone().Equals("()     -"))
            {
                Erro.setMens("Preencha o telefone!");
                return;
            }

            // Valida se o telefone tem um formato válido usando expressão regular (REGEX)
            if (!regexTelefone.IsMatch(usuario.getTelefone()))
            {
                Erro.setMens("Telefone inválido!");
                return;
            }

            // CEP
            // Formata o CEP para o formato XXXXX-XXX usando expressão regular (REGEX)
            Regex regexCEP = new Regex(@"^\d{5}-\d{3}$");

            // Remove os caracteres "-" e espaços do CEP para validar apenas os números
            string cep = usuario.getCep().Replace("-", "").Trim();

            // Valida se o campo CEP foi preenchido, se não for preenchido, vai ser salvo como null no banco de dados, caso contrário, valida se o CEP tem um formato válido usando expressão regular (REGEX)
            if (cep == "")
            {
                usuario.setCep(null);
            }
            else
            {
                if (!regexCEP.IsMatch(usuario.getCep()))
                {
                    Erro.setMens("CEP inválido!");
                    return;
                }
            }

            // LOGRADOURO, BAIRRO, LOCALIDADE E UF
            // Valida se o campo logradouro foi preenchido
            if (usuario.getLogradouro().Trim().Equals(""))
            {
                Erro.setMens("A rua é de preenchimento obrigatória!");
                return;
            }

            // Valida se o campo bairro foi preenchido
            if (usuario.getBairro().Trim().Equals(""))
            {
                Erro.setMens("O bairro é de preenchimento obrigatória!");
                return;
            }

            // Valida se o campo localidade foi preenchido
            if (usuario.getLocalidade().Trim().Equals(""))
            {
                Erro.setMens("A cidade é de preenchimento obrigatória!");
                return;
            }

            // Valida se o campo UF foi preenchido
            if (usuario.getUf().Trim().Equals(""))
            {
                Erro.setMens("O estado é de preenchimento obrigatória!");
                return;
            }

            // Se não houver erros, chama o método CadastrarUsuario da camada de banco de dados para salvar o usuário no banco de dados
            UsuarioDAL.CadastrarUsuario(usuario);
        }
    }
}
