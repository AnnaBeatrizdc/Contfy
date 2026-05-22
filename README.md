# 📦 Contfy

> **Sistema de Gerenciamento de Containers** - Uma aplicação desktop desenvolvida em C# com Windows Forms para gerenciar usuários e containers com autenticação segura.

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue.svg)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/language-C%23-green.svg)](https://learn.microsoft.com/pt-br/dotnet/csharp/)

---

## 🎯 Sobre o Projeto

**Contfy** é uma aplicação Windows Forms desenvolvida em C# que permite o gerenciamento completo de usuários e containers. O sistema oferece:

- ✅ Autenticação de usuários com validação de email e senha
- ✅ Cadastro de novos usuários com dados pessoais e endereço
- ✅ Gerenciamento de containers com status e localização
- ✅ Integração com API de CEP (Consulta de endereços)
- ✅ Segurança com criptografia de senhas
- ✅ Interface intuitiva com Windows Forms
- ✅ Banco de dados SQL Server

---

## 🚀 Começando

### Pré-requisitos

- **Visual Studio 2022** ou superior (Community, Professional ou Enterprise)
- **.NET Framework 4.7.2**
- **SQL Server** (LocalDB ou instalação completa)
- **Windows 10** ou superior

### Instalação

1. **Clone o repositório**
   ```bash
   git clone https://github.com/AnnaBeatrizdc/Contfy.git
   cd Contfy
   ```

2. **Restaure as dependências NuGet**
   - Abra a solução no Visual Studio
   - A restauração de pacotes será automática, ou execute:
   ```bash
   dotnet restore
   ```

3. **Configure o banco de dados**
   - Crie um banco de dados SQL Server chamado `Contfy`
   - Atualize a string de conexão em `DAL/ConexaoDAL.cs` se necessário:
   ```csharp
   @"Server=LOCALHOST;
	 Database=Contfy;
	 Integrated Security=True"
   ```

4. **Compile e execute**
   - Pressione `F5` no Visual Studio ou clique em **Start**
   - A aplicação abrirá a tela de login

---

## 📋 Funcionalidades Principais

### 👤 Autenticação de Usuários
- Login com email e senha
- Validação de credenciais contra banco de dados
- Opção de visualizar/ocultar senha
- Link para criar nova conta

### 📝 Cadastro de Usuários
- Preenchimento de dados pessoais
- Consulta automática de endereço por CEP
- Validação de email e senha
- Seleção de tipo de usuário (Admin/Comum)

### 📦 Gerenciamento de Containers
- Visualizar containers
- Adicionar novos containers
- Definir status e localização
- Atribuir responsáveis

### 🔒 Segurança
- Senhas criptografadas com BouncyCastle
- Validação de entrada de dados
- Autenticação integrada do Windows

---

## 📁 Estrutura do Projeto

```
Contfy/
├── BLL/                          # Business Logic Layer
│   ├── UsuarioBLL.cs            # Lógica de negócio de usuários
│   ├── ContainerAdminBLL.cs     # Lógica de negócio de containers
│   └── Utils/                   # Utilitários
│       ├── Criptografia.cs      # Funções de criptografia
│       └── CepBLL1.cs           # Integração com API de CEP
├── DAL/                          # Data Access Layer
│   ├── ConexaoDAL.cs            # Conexão com SQL Server
│   ├── UsuarioDAL.cs            # Acesso a dados de usuários
│   └── AdminContainerDAL.cs     # Acesso a dados de containers
├── Models/                       # Modelos de dados
│   ├── UsuarioMdl.cs            # Modelo de usuário
│   └── ContainerMdl.cs          # Modelo de container
├── UsuarioForm.cs               # Tela de login
├── CadastroForm.cs              # Tela de cadastro
├── UsuarioContainerForm.cs      # Tela de containers do usuário
├── AdminContainerForm.cs        # Tela de containers do admin
├── Erro.cs                       # Classe para tratamento de erros
├── Program.cs                    # Ponto de entrada
└── App.config                    # Configurações da aplicação
```

### Padrão de Arquitetura

O projeto utiliza a arquitetura em **3 camadas**:

1. **Camada de Apresentação (UI)**
   - Windows Forms (`.cs` e `Designer.cs`)
   - Interação direta com o usuário

2. **Camada de Negócio (BLL)**
   - Validações
   - Regras de negócio
   - Processamento de dados

3. **Camada de Dados (DAL)**
   - Acesso ao banco de dados SQL Server
   - Operações CRUD (Create, Read, Update, Delete)
   - Manipulação de conexões

---

## 🔧 Tecnologias Utilizadas

| Tecnologia | Versão | Propósito |
|-----------|--------|----------|
| C# | .NET Framework 4.7.2 | Linguagem principal |
| Windows Forms | - | Interface gráfica |
| SQL Server | - | Banco de dados |
| BouncyCastle | 2.6.2 | Criptografia |
| iTextSharp | 5.5.13.5 | Manipulação de PDF |
| Newtonsoft.Json | 13.0.4 | Processamento JSON |

---

## 📊 Modelos de Dados

### Usuário
```csharp
public class UsuarioMdl
{
	public string Nome { get; set; }
	public string TipoUsuario { get; set; }    // Admin ou Comum
	public string Email { get; set; }
	public string Senha { get; set; }          // Criptografada
	public string Telefone { get; set; }
	public string CEP { get; set; }
	public string Logradouro { get; set; }
	public string Bairro { get; set; }
	public string Localidade { get; set; }
	public string UF { get; set; }
}
```

### Container
```csharp
public class ContainerMdl
{
	public string Codigo { get; set; }
	public string Nome { get; set; }
	public string Status { get; set; }         // Ativo, Inativo, etc
	public string Localizacao { get; set; }
	public string Responsavel { get; set; }
}
```

---

## 🔐 Segurança

### Criptografia de Senha
As senhas são criptografadas usando a biblioteca **BouncyCastle** antes de serem armazenadas no banco de dados.

```csharp
// Exemplo de uso
string senhaHash = Criptografia.Criptografar(senha);
```

### Validações
- Email deve ser válido e único
- Senha deve ter requisitos mínimos
- Todos os campos obrigatórios são validados

---

## 🛢️ Banco de Dados

### Configuração de Conexão
A aplicação se conecta a um SQL Server local. A string de conexão está configurada em `DAL/ConexaoDAL.cs`:

```csharp
public static SqlConnection getConexao()
{
	SqlConnection conexao = new SqlConnection();
	conexao.ConnectionString =
	@"Server=LOCALHOST;
	  Database=Contfy;
	  Integrated Security=True";
	return conexao;
}
```

### Tabelas Necessárias
Você precisará criar as seguintes tabelas no banco `Contfy`:

- `Usuarios` - Armazena dados de usuários
- `Containers` - Armazena dados de containers

---

## 🎮 Como Usar

### 1. Primeiro Acesso (Cadastro)
- Clique em "Criar Conta" na tela de login
- Preencha todos os campos obrigatórios
- Consulte seu CEP para auto-preencher o endereço
- Selecione o tipo de usuário
- Clique em "Criar Conta"

### 2. Login
- Digite seu email e senha
- Clique em "Logar"
- Você será redirecionado para a tela de containers

### 3. Gerenciar Containers
- **Usuário Comum**: Visualiza e gerencia seus containers
- **Admin**: Possui acesso completo a todos os containers

---

## 📧 Integração com API de CEP

A aplicação integra-se com uma API de CEP para consultar e auto-completar endereços:

```csharp
// Em CadastroForm.cs
CepBLL1.ConsultarCEP(cep);
```

Basta preencher o campo CEP e a aplicação consultará automaticamente os dados do endereço.

---

## 🐛 Tratamento de Erros

A aplicação utiliza a classe `Erro.cs` para centralizar o tratamento de erros:

```csharp
Erro.setErro(true);
Erro.setMens("Mensagem de erro aqui");
if (Erro.getErro())
{
	MessageBox.Show(Erro.getMens());
}
```

---

## 📦 Dependências do NuGet

```xml
- BouncyCastle.Cryptography (2.6.2)
- iTextSharp (5.5.13.5)
- Newtonsoft.Json (13.0.4)
```

---

## 🤝 Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. **Faça um Fork** do repositório
2. **Crie uma branch** para sua feature (`git checkout -b feature/AmazingFeature`)
3. **Commit** suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. **Push** para a branch (`git push origin feature/AmazingFeature`)
5. **Abra um Pull Request**

### Diretrizes
- Siga o padrão de código existente
- Adicione comentários para código complexo
- Teste suas mudanças antes de fazer o PR
- Atualize a documentação se necessário

---

## 📝 Licença

Este projeto está licenciado sob a **Licença MIT** - veja o arquivo [LICENSE](LICENSE) para detalhes.

---

## 👨‍💻 Autor

**Anna Beatriz**
- GitHub: [@AnnaBeatrizdc](https://github.com/AnnaBeatrizdc)
- Repositório: [Contfy](https://github.com/AnnaBeatrizdc/Contfy)

---

## 🔄 Histórico de Versões

### v1.0.0 (2026)
- ✨ Lançamento inicial
- 🎯 Funcionalidades básicas de usuários e containers
- 🔐 Sistema de autenticação
- 📦 Integração com API de CEP

---

## ⭐ Agradecimentos

Agradecimentos especiais aos contribuidores e à comunidade .NET!

---

**Feito com ❤️ por Anna Beatriz**

```
		  _____         
		 / ___ \        
		| |   | |       
		| |   | |       
		| |___| |       
		 \_____/        
	  Contfy v1.0
```

**[⬆ Voltar ao topo](#-contfy)**
