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
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }

            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de gravação
            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);

        }

        public void Alterar(ProdutoInformation produto)
        {
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }

            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de alteração
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
