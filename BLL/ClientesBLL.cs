using System;
using System.Data;
using Loja.Modelos;
using Loja.DAL;

namespace Loja.BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            //E-mail é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            
            //Se tudo está Ok, chama a rotina de inserção.
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }

        public void Alterar(ClienteInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            //E-mail é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            
            //Se tudo está Ok, chama a rotina de alteração.
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }
    }
}
