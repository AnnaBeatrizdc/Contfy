using Contfy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contfy.DAL;
using System.Data;

namespace Contfy.BLL
{
    internal class ContainerAdminBLL
    {
        // ADICIONAR CONTAINER
        public static void validaDadosAdicionar(ContainerMdl ADDContainer, char op)
        {
            Erro.setErro(false); // Zera o erro antes de iniciar a validação

            //CODIGO
            // Valida se o codigo foi preenchido
            if (ADDContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }

            // Valida se o container já existe no banco de dados
            if (AdminContainerDAL.ExisteContainer(ADDContainer.getCodigo()))
            {
                Erro.setMens("Container já cadastrado!");
                return;
            }

            // NOME
            // Valida se o nome foi preenchido
            if (ADDContainer.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é de preenchimento obrigatório!");
                return;
            }

            // STATUS 
            // Valida se o status foi preenchido
            if (ADDContainer.getStatus().Trim().Equals(""))
            {
                Erro.setMens("O status é de preenchimento obrigatório!");
                return;
            }

            // LOCALIZAÇÃO
            // Valida se a localização foi preenchida
            if (ADDContainer.getLocalizacao().Trim().Equals(""))
            {
                Erro.setMens("A localização é de preenchimento obrigatório!");
                return;
            }

            // RESPONSÁVEL
            // Valida se o responsável foi preenchido
            if (ADDContainer.getResponsavel().Trim().Equals(""))
            {
                Erro.setMens("O responsável é de preenchimento obrigatório!");
                return;
            }

            // Se todas as validações passarem, chama o método para adicionar o container
            AdminContainerDAL.AdicionarContainer(ADDContainer);
        }

        //ALTERAR CONTAINER
        public static void validaDadosAlterar(ContainerMdl ALTContainer, char op)
        {
            Erro.setErro(false); // Zera o erro antes de iniciar a validação

            // CODIGO
            // Valida se o codigo foi preenchido
            if (ALTContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }

            // NOME
            // Valida se o nome foi preenchido
            if (ALTContainer.getNome().Trim().Equals(""))
            {
                Erro.setMens("O nome é de preenchimento obrigatório!");
                return;
            }

            // STATUS
            // Valida se o status foi preenchido
            if (ALTContainer.getStatus().Trim().Equals(""))
            {
                Erro.setMens("O status é de preenchimento obrigatório!");
                return;
            }

            // LOCALIZAÇÃO
            // Valida se a localização foi preenchida
            if (ALTContainer.getLocalizacao().Trim().Equals(""))
            {
                Erro.setMens("A localização é de preenchimento obrigatório!");
                return;
            }

            // RESPONSÁVEL
            // Valida se o responsável foi preenchido
            if (ALTContainer.getResponsavel().Trim().Equals(""))
            {
                Erro.setMens("O responsável é de preenchimento obrigatório!");
                return;
            }

            if (!int.TryParse(ALTContainer.getResponsavel(), out _))
            {
                Erro.setMens("O codigo responsável deve conter apenas números!");
                return;
            }

            // Se todas as validações passarem, chama o método para alterar o container
            AdminContainerDAL.AlterarContainer(ALTContainer);
        }

        // BUSCAR CONTAINER POR CÓDIGO
        public static ContainerMdl BuscarPorCodigo(String codigo)
        {
            // Valida se o código foi preenchido
            if (codigo.Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return null;
            }

            // Se as validações passarem, chama o método para buscar o container por código
            return AdminContainerDAL.BuscarPorCodigo(codigo);
        }

        // DELETAR CONTAINER
        public static void validaDadosDeletar(ContainerMdl DELContainer, char op)
        {
            Erro.setErro(false); // Zera o erro antes de iniciar a validação

            // Valida se o código foi preenchido
            if (DELContainer.getCodigo().Trim().Equals(""))
            {
                Erro.setMens("O código é de preenchimento obrigatório!");
                return;
            }

            // Se as validações passarem, chama o método para deletar o container
            AdminContainerDAL.DeletarContainer( DELContainer.getCodigo());
        }

        // LISTAR CONTAINERS
        public static DataTable ListarContainers()
        {
            // Chama o método para listar os containers
            return AdminContainerDAL.ListarContainers();
        }

        // FILTRAR CONTAINERS
        public static DataTable FiltrarContainers(string pesquisa,string status)
        {
            // Chama o método para filtrar os containers
            return AdminContainerDAL.FiltrarContainers(pesquisa,status);
        }


    }
}
