using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Loja.DAL;
using Loja.Modelos;


namespace Loja.BLL
{
    public class VendasBLL
    {

        //Este é um campo privado para armazenar uma instância da classe DAL.
        private VendasDAL objDAL;

        //Esse é o construtor da classe VendasBLL
        public VendasBLL()
        {
            objDAL = new VendasDAL();
        }

        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }

        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }

        public void Incluir(VendaInformation venda)
        {
            objDAL.Incluir(venda);
        }
    }
}
