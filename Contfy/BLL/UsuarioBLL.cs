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

namespace Contfy.BLL
{
    
    internal class UsuarioBLL
    {
        public static void conectar()
        {
            DAL.UsuarioDAL.conectar();
        }
        public static void desconectar()
        {
            DAL.UsuarioDAL.desconectar();
        }

        public static void validaDadosLogin(UsuarioMdl umUsuario)
        {
            Erro.setErro(false);
            if (umUsuario.getUsuario().Equals(""))
            {
                Erro.setMens("O usuário é de preenchimento obrigatório!");
                return;
            }

            if (umUsuario.getSenha().Equals(""))
            {
                Erro.setMens("A senha é de preenchimento obrigatória!");
                return;
            }
        }

        public static void ValidaDadosCadastro(UsuarioMdl usuario, char op)
        {
            Erro.setErro(false);

            // NOME
            if (usuario.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é de preenchimento obrigatório!");
                return;
            }
            // USUÁRIO
            if (usuario.getUsuario().Equals(""))
            {
                Erro.setMens("O usuário é de preenchimento obrigatório!");
                return;
            }

            // EMAIL
            if (usuario.getEmail().Trim().Equals(""))
            {
                Erro.setMens("O email é de preenchimento obrigatório!");
                return;
            }

            // VALIDA FORMATO DO EMAIL
            string padraoEmail =
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(usuario.getEmail(), padraoEmail))
            {
                Erro.setMens("Formato de email inválido!");
                return;
            }

            // SENHA
            if (usuario.getSenha().Trim().Equals(""))
            {
                Erro.setMens("A senha é de preenchimento obrigatória!");
                return;
            }

            if (usuario.getSenha().Length < 6)
            {
                Erro.setMens("A senha deve ter no mínimo 6 caracteres!");
                return;
            }

            // CRIPTOGRAFAR SENHA
            usuario.setSenha(
                Criptografia.criptografarSenha(usuario.getSenha())
            );

            if (usuario.getLogradouro().Trim().Equals(""))
            {
                Erro.setMens("A rua é de preenchimento obrigatória!");
                return;
            }

            if (usuario.getBairro().Trim().Equals(""))
            {
                Erro.setMens("O bairro é de preenchimento obrigatória!");
                return;
            }

            if (usuario.getLocalidade().Trim().Equals(""))
            {
                Erro.setMens("A cidade é de preenchimento obrigatória!");
                return;
            }

            if (usuario.getUf().Trim().Equals(""))
            {
                Erro.setMens("O estado é de preenchimento obrigatória!");
                return;
            }

            // VERIFICAR USUARIO/EMAIL
            UsuarioDAL dal = new UsuarioDAL();

            if (UsuarioDAL.ExisteUsuario(usuario.getUsuario()))
            {
            Erro.setMens("Usuário já cadastrado!");

            return;

            
        }

            if         
                (UsuarioDAL.ExisteEmail(usuario.getEmail()))
            {
                    Erro.setMens("Email já cadastrado!");

                    return;
            }
            // CRIAR OBJETO DAL
            UsuarioDAL.CadastrarUsuario(usuario);
        }
            public static UsuarioMdl FazerLogin(string email, string senha)
            {
                     return UsuarioDAL.Login(email, senha);
            }

        
        }
    }
