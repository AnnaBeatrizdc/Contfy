using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Contfy.BLL.Utils
{
    internal class Criptografia
    {
        // Criptografa a senha utilizando o algoritmo SHA256 que é um algoritmo de hash.
        // Ele pega qualquer texto e gera um código único de 256 bits.
        public static string criptografarSenha(string senha)
        {
            // Cria um objeto SHA256 para realizar a criptografia.
            SHA256 sha = SHA256.Create();

            byte[] bytes = Encoding.UTF8.GetBytes(senha); // Converte a senha de string em um array de bytes usando a codificação UTF-8.

            byte[] hash = sha.ComputeHash(bytes); // Calcula o hash da senha convertida em bytes. O resultado é um array de bytes que representa o hash da senha.

            StringBuilder sb = new StringBuilder(); // Cria um StringBuilder para construir a string do hash em formato hexadecimal.

            for (int i = 0; i < hash.Length; i++) // Converte cada byte do hash em hexadecimal e adiciona ao StringBuilder.
            {
                sb.Append(hash[i].ToString("x2")); // O formato "x2" garante que cada byte seja representado por dois caracteres hexadecimais, preenchendo com zero à esquerda se necessário.
            }

            return sb.ToString(); // Retorna a string do hash da senha em formato hexadecimal.
        }
    }
}
