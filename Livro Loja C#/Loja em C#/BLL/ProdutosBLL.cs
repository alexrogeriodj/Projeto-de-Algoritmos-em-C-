using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Loja.Modelos;
using Loja.DAL;


namespace Loja.BLL
{
    public class ProdutosBLL
    {

        public ArrayList ProdutosEmFalta()
        {
            
            ProdutosDAL obj = new ProdutosDAL();
            return obj.ProdutosEmFalta();

        }

        public void Incluir(ProdutoInformation produto)
        {
            // Nome do produto � obrigat�rio
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto � obrigat�rio.");
            }

            // O pre�o do produto n�o pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Pre�o do produto n�o pode ser negativo.");
            }

            // O estoque do produto n�o pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto n�o pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de grava��o
            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);

        }

        public void Alterar(ProdutoInformation produto)
        {
            // Nome do produto � obrigat�rio
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto � obrigat�rio.");
            }

            // O pre�o do produto n�o pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Pre�o do produto n�o pode ser negativo.");
            }

            // O estoque do produto n�o pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto n�o pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de altera��o
            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produto);
        }

        public void Excluir(int codigo)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }
    }
}
