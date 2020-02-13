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
            //O nome do cliente � obrigat�rio
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente � obrigat�rio");
            }

            //E-mail � sempre em letras min�sculas
            cliente.Email = cliente.Email.ToLower();
            
            //Se tudo est� Ok, chama a rotina de inser��o.
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }

        public void Alterar(ClienteInformation cliente)
        {
            //O nome do cliente � obrigat�rio
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente � obrigat�rio");
            }

            //E-mail � sempre em letras min�sculas
            cliente.Email = cliente.Email.ToLower();
            
            //Se tudo est� Ok, chama a rotina de altera��o.
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de exclu�-lo.");
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
