using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contfy.Models
{
    internal class UsuarioMdl
    {
        public String nome;
        public String usuario;
        public String tipoUsuario;
        public String email;
        public String senha;
        public String telefone;
        public String cep;
        public String logradouro;
        public String bairro;
        public String localidade;
        public String uf;

        public void setNome(String _nome) { nome = _nome; }
        public void setUsuario(String _usuario) { usuario = _usuario; }
        public void setTipoUsuario(String _tipoUsuario) { usuario = _tipoUsuario; }
        public void setSenha(String _senha) { senha = _senha; }
        public void setEmail(String _email) { email = _email; } 
        public void setTelefone(String _telefone) { telefone = _telefone; }
        public void setCep(String _cep) { cep = _cep; }
        public void setLogradouro(String _logradouro) { logradouro = _logradouro; }
        public void setBairro(String _bairro) { bairro = _bairro; }
        public void setLocalidade(String _localidade) { localidade = _localidade; }
        public void setUf(String _uf) { uf = _uf; }

        public String getNome() { return nome; }
        public String getUsuario() { return usuario; }
        public String getTipoUsuario() { return tipoUsuario; }
        public String getSenha() { return senha; }
        public String getEmail() { return email; }
        public String getTelefone() { return telefone; }
        public String getCep() { return cep; }
        public String getLogradouro() { return logradouro; }
        public String getBairro() { return bairro; }
        public String getLocalidade() { return localidade; }
        public String getUf() { return uf; }

    }
}
