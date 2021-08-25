using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace Business
{
    public static class MetodosBd
    {
        public static List<Vw_GridPrincipal> GetVw_GridPrincipal()
        {
            Bd bd = new Bd();
            return bd.GetVw_GridPrincipal();
        }

        public static List<Vw_GridPrincipal> GetVw_GridPrincipalByName(string nome)
        {
            Bd bd = new Bd();
            return bd.GetVw_GridPrincipalByName(nome);
        }

        public static List<Vw_GridPrincipal> GetVw_GridPrincipalByTel(string telefone)
        {
            Bd bd = new Bd();
            return bd.GetVw_GridPrincipalByTel(telefone);
        }

        public static List<Vw_GridPrincipal> GetVw_GridPrincipalByCpf(string cpf)
        {
            Bd bd = new Bd();
            return bd.GetVw_GridPrincipalByCpf(cpf);
        }

        public static List<Vw_GridPrincipal> GetVw_GridPrincipalByIdCli(int idCli)
        {
            Bd bd = new Bd();
            return bd.GetVw_GridPrincipalByIdCli(idCli);
        }

        public static Vw_AparelhoInfo GetAparelhoInfosByIdAparelho(int idAparelho)
        {
            Bd bd = new Bd();
            return bd.GetAparelhoInfosByIdAparelho(idAparelho).FirstOrDefault();
        }

        public static List<Tipos> GetTipos()
        {
            Bd bd = new Bd();
            return bd.GetTipos();
        }

        public static List<Marcas> GetMarcas()
        {
            Bd bd = new Bd();
            return bd.GetMarcas();
        }

        public static List<Modelos> GetModelos()
        {
            Bd bd = new Bd();
            return bd.GetModelos();
        }

        public static List<Tecnicos> GetTecnicos()
        {
            Bd bd = new Bd();
            return bd.GetTecnicos();
        }

        public static List<Clientes> GetClientesCpf()
        {
            Bd bd = new Bd();
            return bd.GetClientesCpf();
        }

        public static List<Vw_GridPrincipal> GetClienteByNome(string nome)
        {
            Bd bd = new Bd();
            return bd.GetClienteByNome(nome);
        }

        public static List<Vw_GridPrincipal> GetClienteByCpf(string cpf)
        {
            Bd bd = new Bd();
            return bd.GetClienteByCpf(cpf);
        }

        public static List<Vw_GridPrincipal> GetClienteByNumero(string numero)
        {
            Bd bd = new Bd();
            return bd.GetClienteByNumero(numero);
        }

        public static List<Vw_GridPrincipal> GetClienteById(int idCli)
        {
            Bd bd = new Bd();
            return bd.GetClienteById(idCli);
        }

        public static List<Vw_AparelhoCores> GetCoresByIdAp(int idAp)
        {
            Bd bd = new Bd();
            return bd.GetCoresByIdAp(idAp);
        }

        public static void UpdateAparelhoDataModificacao(int idAp, int idEstado, DateTime DataModificacao)
        {
            Bd bd = new Bd();
            bd.UpdateAparelhoDataModificacao(idAp, idEstado, DataModificacao);
        }

        public static List<Produtos> GetProdutosDbVendasOficina()
        {
            Bd bd = new Bd();
            return bd.GetProdutosDbVendasOficina();
        }

        public static void UpdateMaoDeObra(Produtos item)
        {
            Bd bd = new Bd();
            bd.UpdateMaoDeObra(item);
        }

        public static void UpdateQuantidadeItem(Produtos item)
        {
            Bd bd = new Bd();
            bd.UpdateQuantidadeItem(item);
        }

        //----------------Avaliar a Necessidade destas Querys---------------//
        public static List<Vw_GridPrincipal> GetToGridPrincipalByIdAp(int idAp)
        {
            Bd bd = new Bd();
            return bd.GetToGridPrincipalByIdAp(idAp);
        }

        public static List<Vw_GridPrincipal> SearchClientByName(string nome)
        {
            Bd bd = new Bd();
            return bd.SearchVw_GridPrincipalByName(nome); 
        }

        public static List<Vw_GridPrincipal> SearchClientByNumero(string numero)
        {
            Bd bd = new Bd();
            return bd.SearchVw_GridPrincipalByNumero(numero); 
        }

        //-----------------------------------------------------------------//


        public static List<Clientes> GetClientesById(int idCli)
        {
            Bd bd = new Bd();
            return bd.GetClientesById(idCli);
        }

        public static void UpdateCliente(Clientes cliente)
        {
            Bd bd = new Bd();
            bd.UpdateCliente(cliente);
        }

        public static void UpdateTelefone(Telefones telefone)
        {
            Bd bd = new Bd();
            bd.UpdateTelefone(telefone);
        }

        public static void DeleteTelefone(int idTel)
        {
            Bd bd = new Bd();
            bd.DeleteTelefone(idTel);
        }

        public static List<Telefones> GetTelefonesByIdCli(int idCli)
        {
            Bd bd = new Bd();
            return bd.GetTelefonesByIdCli(idCli); ;
        }

        public static void DeleteItem(int idItem)
        {
            Bd bd = new Bd();
            bd.DeleteItem(idItem);
        }


        ////////////////////////////////////////

        public static List<Vw_Contatos> GetContatosByIdAp(int idAp)
        {
            Bd bd = new Bd();
            return bd.GetContatosByIdAp(idAp); ;
        }

        public static List<Produtos> GetItensByIdAp(int idAp)
        {
            Bd bd = new Bd();
            return bd.GetItensByIdAp(idAp); ;
        }


        public static void UpdateDialogoContato(int idContato, string dialogo)
        {
            Bd bd = new Bd();
            bd.UpdateDialogoContato(idContato, dialogo);
        }

        /////////////////////////////
        public static void InsertItem(Produtos item, int idAparelho)
        {
            Bd bd = new Bd();
            bd.InsertItem(item, idAparelho);
        }

        public static void InsertItens(List<Produtos> itensList, int idAparelho)
        {
            foreach (Produtos item in itensList)
            {
                Bd bd = new Bd();
                bd.InsertItem(item, idAparelho);
                //Remove a quantidade de intes do estoque
                bd.SubtractProdutoEstoque(item);
            }            
        }

        public static void AddProdutoEstoque(Produtos produto)
        {
            Bd bd = new Bd();
            bd.AddProdutoEstoque(produto);
        }

        public static void SubtractProdutoEstoque(Produtos produto)
        {
            Bd bd = new Bd();
            bd.SubtractProdutoEstoque(produto);
        }

        ////////////////////////
        public static int InsertAparelho(Aparelhos aparelhos)
        {
            Bd bd = new Bd();
            return bd.InsertAparelho(aparelhos);
        }

        public static int InsertTipo(Tipos tipo)
        {
            Bd bd = new Bd();
            return bd.InsertTipo(tipo);
        }

        public static int InsertMarca(Marcas marca)
        {
            Bd bd = new Bd();
            return bd.InsertMarca(marca);
        }

        public static int InsertModelo(Modelos modelo)
        {
            Bd bd = new Bd();
            return bd.InsertModelo(modelo);
        }

        public static void InsertCor(Cores cor)
        {
            Bd bd = new Bd();
            bd.InsertCor(cor);
        }

        public static void InsertAparelho_Cor(List<Cores> cores, int idAp)
        {
            Bd bd = new Bd();
            foreach (Cores cor in cores)
            {
                if (cor.IdCor != 0)
                {
                    bd.InsertAparelho_Cor(new Aparelhos_Cores
                    {
                        Id_Aparelho = idAp,
                        Cor = cor
                    }); 
                }
            }
            
        }



        public static List<Cores> GetCores()
        {
            Bd bd = new Bd();
            return bd.GetCores();
        }

        public static int InsertClienteAndTelefone(Clientes cliente, List<Telefones> telefones)
        {
            Bd bd = new Bd();
            int idCli = bd.InsertCliente(cliente);
            foreach (Telefones tel in telefones)
            {
                tel.Id_Cliente = idCli;
                bd.InsertTelefone(tel);
            }
            return idCli;
        }

        public static void InsertTelefone(Telefones telefone)
        {
            Bd bd = new Bd();
            bd.InsertTelefone(telefone);
        }

        /////////////////////////////


        public static void InsertContato(Contatos contato)
        {
            Bd bd = new Bd();
            bd.InsertContato(contato);
        }


        ////////////////////////////////// Updates ///////////////////////
        public static void UpdateAparelho(Aparelhos aparelho)
        {
            Bd bd = new Bd();
            bd.UpdateAparelho(aparelho);
        }

        public static void UpdateEstadoAparelho(int idAparelho, DateTime dataAlteracao, DateTime dataSaida, Estado novoStatus)
        {
            Bd bd = new Bd();
            bd.UpdateEstadoAparelho(idAparelho, novoStatus, dataAlteracao, dataSaida);
        }

    }
}
