using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Contfy.BLL.Utils
{
    internal class CepBLL1
    {
        public static Models.UsuarioMdl BuscarCEP(string cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/"; // Chama a API do ViaCEP para obter os dados do CEP

                WebClient client = new WebClient(); // Uma classe do C# que acessa o site, consumi a API e baixa os dados do CEP
                                                    //Client conversa com a API, baixa os dados do CEP e armazena em uma string

                string json = client.DownloadString(url); // O método DownloadString() da classe WebClient é usado para baixar o conteúdo da URL especificada e armazená-lo em uma string chamada "json".

                Models.UsuarioMdl endereco = // Transforma JSON em um objeto C#
                    JsonConvert.DeserializeObject<Models.UsuarioMdl>(json); // O método DeserializeObject() da classe JsonConvert é usado para converter a string JSON em um objeto do tipo UsuarioMdl, que é armazenado na variável "endereco".

                // Verifica se o CEP existe
                if (endereco.erro)
                {
                    Erro.setMens("CEP não encontrado!");
                    return null;
                }

                Erro.setErro(false);

                return endereco; // Retorna o objeto UsuarioMdl  com os dados do endereço correspondente ao CEP fornecido.

            }
            catch (Exception ex)
            {
                Erro.setMens(ex.Message);
                return null;
            }
        }
    }
}
