using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Entities;
using System.Collections;
using DataAccess.Properties;

namespace DataAccess
{
    public class Bd
    {
        private SqlConnection ConOficina()
        {
            //Producao
            // return new SqlConnection(Settings.Default.StringConOficina);
            
            //Teste
            return new SqlConnection(ConnectionStrings.OficinaAppTeste);
        }

        private SqlConnection ConVendas()
        {
            //Producao
            // return new SqlConnection(Settings.Default.StringConVendas);

            //Teste
            return new SqlConnection(ConnectionStrings.VendasTeste);
        }

        public List<Telefones> GetTelefonesByIdCli(int idCli)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Telefones>(@"SELECT IdTelefone, Id_Cliente, Numero, Whats, Tipo FROM TELEFONES WHERE Id_Cliente = @idCli", new { idCli })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }


        public List<Clientes> GetClientesById(int idCli)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Clientes>(@"SELECT IdCliente,Nome,Sexo,DataCad FROM CLIENTES WHERE IdCliente = @idCli", new { idCli })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Cores> GetCores()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Cores>(@"SELECT IdCor ,Cor FROM CORES")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }


        public List<Vw_GridPrincipal> GetVw_GridPrincipal()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal")).ToList();

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vw_GridPrincipal> GetVw_GridPrincipalByName(string name)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where Nome like @n ", new { n = "%" + name + "%" })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }



        public List<Vw_GridPrincipal> GetVw_GridPrincipalByTel(string tel)
        {

            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where Numero like @n ", new { n = "%" + tel + "%" })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_GridPrincipal> GetVw_GridPrincipalByCpf(string cpf)
        {

            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where Cpf like @n ", new { n = "%" + cpf + "%" })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_GridPrincipal> GetToGridPrincipalByIdAp(int idAp)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where IdAparelho = @idAp", new { idAp })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public List<Vw_GridPrincipal> GetVw_GridPrincipalByIdCli(int idCli)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where IdCliente = @idCli", new { idCli })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vw_GridPrincipal> SearchVw_GridPrincipalByName(string nome)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where Nome Like @n", new { n = "%" + nome + "%" }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vw_GridPrincipal> SearchVw_GridPrincipalByNumero(string numero)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select IdAparelho, IdCliente, Entrada, Nome, Cpf, Numero, Tipo, Marca, Modelo, Problema, Cor, Estado, Saida, Urgencia, Revisao, DataModificacao From VW_GridPrincipal Where Numero Like @n", new { n = "%" + numero + "%" }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vw_GridPrincipal> GetClienteByNome(string nome)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select Top 1 IdCliente, Nome, Cpf, Sexo, Numero From Clientes
                                                                    Left join Telefones on IdCliente = Id_Cliente
                                                                    Where Nome Like @n",
                                                            new { n = "%" + nome + "%" }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_GridPrincipal> GetClienteByCpf(string cpf)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select Top 1 IdCliente, Nome, Cpf, Sexo, Numero From Clientes
                                                                Left join Telefones on IdCliente = Id_Cliente
                                                                Where Cpf Like @n",
                                                            new { n = "%" + cpf + "%" }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_GridPrincipal> GetClienteByNumero(string numero)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select Top 1 IdCliente, Nome, Cpf, Sexo, Numero From Clientes
                                                                Left join Telefones on IdCliente = Id_Cliente
                                                                Where Numero Like @n",
                                                            new { n = "%" + numero + "%" }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_GridPrincipal> GetClienteById(int idCli)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_GridPrincipal>(@"Select Top 1 IdCliente, Nome, Cpf, Sexo, Numero From Clientes
                                                                Left join Telefones on IdCliente = Id_Cliente
                                                                Where IdCliente = @idCli",
                                                            new { idCli }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }



        public List<Vw_Contatos> GetContatosByIdAp(int idAp)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var list = ConOficina().Query<Vw_Contatos>(@"Select IdContato, DataContato, Dialogo, Tipo, StatusLig, NomeTecnico, Numero, Estado From Vw_Contato Where Id_Aparelho = @idAp", new { idAp }).ToList();
                    ConOficina().Close();
                    return list;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Produtos> GetItensByIdAp(int idAp)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var list = ConOficina().Query<Produtos>(@"Select IdItem, Id_Aparelho, Id_Produto as IdProduto, Item as Produto, Valor as ValorVenda, Quantidade from Itens Where Id_Aparelho=@idAp", new { idAp }).ToList();
                    ConOficina().Close();
                    return list;

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Clientes> GetClientesCpf()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Clientes>(@"Select Cpf From Clientes").ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Pagamentos> GetPagamentosByDay(DateTime dataAtual)
        {
            DateTime dataFinal = dataAtual.AddDays(1);
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Pagamentos>(@"Select IdPagamento, Id_Aparelho, Valor, TipoPagamento, DataPagamento From PAGAMENTOS Where DataPagamento between @dataAtual and @dataFinal", new { dataAtual, dataFinal }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Vw_AparelhoInfo> GetAparelhoInfosByIdAparelho(int idAparelho)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return ConOficina().Query<Vw_AparelhoInfo>(@"Select IdAparelho, IdCliente, Nome, Entrada, Saida, Problema, Observacao, Orcamento, MaoDeObra, Urgencia, Revisao, Tipo, Marca, Modelo, NomeTecnico, IdTecnico, Estado, Cor from Vw_AparelhoInfo Where IdAparelho = @idAparelho", new { idAparelho }).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<Tipos> GetTipos()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Tipos>(@"SELECT IdTipo ,Tipo FROM Tipos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Marcas> GetMarcas()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Marcas>(@"SELECT IdMarca, Marca FROM Marcas")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Modelos> GetModelos()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Modelos>(@"SELECT IdModelo, Modelo FROM Modelos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Tecnicos> GetTecnicos()
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Tecnicos>(@"SELECT IdTecnico, NomeTecnico, Numero FROM Tecnicos")).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Vw_AparelhoCores> GetCoresByIdAp(int idAp)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    return (ConOficina().Query<Vw_AparelhoCores>(@"Select Id_Aparelho, IdAparelhos_Cores, IdCor, Cor From Vw_AparelhoCores
                                                                Where Id_Aparelho = @idAp",
                                                                new { idAp })).ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        /////////////////////////// Inserts

        public int InsertCliente(Clientes cli)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var res = ConOficina().ExecuteScalar(@"exec SP_InsertCliente @Nome, @DataCad, @Cpf, @Sexo ",
                        new
                        {
                            cli.Nome,
                            cli.DataCad,
                            cli.Cpf,
                            cli.Sexo
                        });
                    return Convert.ToInt32(res);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertTelefone(Telefones tel)
        {
            try
            {
                string tipo = Convert.ToString(tel.Tipo);
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into TELEFONES Values(@Id_Cliente, @Numero, @Whats, @tipo)",
                        new { tel.Id_Cliente, tel.Numero, tel.Whats, tipo });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public int InsertAparelho(Aparelhos ap)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var res = ConOficina().ExecuteScalar(@"exec SP_InsertAparelhos @Id_Cliente, @Id_Tipo, @Id_Marca, @Id_Modelo, @Id_Estado, @Entrada, @Problema, @Observacao, @Urgencia, @Revisao ",
                        new
                        {
                            ap.Id_Cliente,
                            ap.Id_Tipo,
                            ap.Id_Marca,
                            ap.Id_Modelo,
                            ap.Id_Estado,
                            ap.Entrada,
                            ap.Problema,
                            ap.Observacao,
                            ap.Urgencia,
                            ap.Revisao
                        });
                    return Convert.ToInt32(res);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public int InsertTipo(Tipos t)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var id = ConOficina().ExecuteScalar(@"Exec SP_InsertTipo @Tipo", new { t.Tipo });
                    return Convert.ToInt32(id);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int InsertMarca(Marcas m)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var id = ConOficina().ExecuteScalar(@"Exec SP_InsertMarca @Marca", new { m.Marca });
                    return Convert.ToInt32(id);

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public int InsertModelo(Modelos m)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    var id = ConOficina().ExecuteScalar(@"Exec SP_InsertModelo @Modelo", new { m.Modelo });
                    return Convert.ToInt32(id);

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertTecnico(Tecnicos tecnico)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into TECNICOS Values(@NomeTecnico, @Numero)", new { tecnico.Numero, tecnico.NomeTecnico });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertAparelho_Cor(Aparelhos_Cores ac)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into Aparelhos_Cores Values(@idAp, @idCor)", new { idAp = ac.Id_Aparelho, idCor = ac.Cor.IdCor });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertCor(Cores cor)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into CORES Values(@Cor)", new { cor.Cor });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertContato(Contatos contato)
        {
            try
            {
                string query = @"Insert into CONTATOS Values(@Id_Aparelho, @IdTecnico, @Id_Telefone, @Id_Estado, @Tipo, @StatusLig, @DataContato, @Dialogo)";
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(query, new
                    {
                        contato.Id_Aparelho,
                        contato.IdTecnico,
                        contato.Id_Telefone,
                        contato.Id_Estado,
                        contato.Tipo,
                        contato.StatusLig,
                        contato.DataContato,
                        contato.Dialogo
                    });
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertItem(Produtos it, int idAparelho)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into Itens values (@idAparelho, @IdProduto, @Produto, @ValorVenda, @Quantidade)",
                        new
                        {
                            idAparelho,
                            it.IdProduto,
                            it.Produto,
                            it.ValorVenda,
                            it.Quantidade

                        });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void InsertPagamentos_Aparelhos(int idAp, int idPag)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Insert into Pagamentos_Aparelhos values(@idAp, @idPag)",
                        new
                        {
                            idAp,
                            idPag
                        });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }







        /////////////////////////// Updates

        public void UpdateCliente(Clientes c)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update CLIENTES Set Nome = @Nome, Sexo = @Sexo, Cpf = @Cpf Where IdCliente =@IdCliente", new { c.IdCliente, c.Nome, c.Sexo, c.Cpf });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateAparelho(Aparelhos ap)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Aparelhos Set Entrada = @Entrada, Problema = @Problema, Observacao = @Observacao, Orcamento = @Orcamento, Id_Tecnico = @Id_Tecnico, Urgencia = @Urgencia, Revisao = @Revisao Where IdAparelho = @IdAparelho", new { ap.IdAparelho, ap.Observacao, ap.Orcamento, ap.Problema, ap.Id_Tecnico, ap.Urgencia, ap.Revisao, ap.DataModificacao, ap.Entrada });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateAparelhoDataModificacao(int idAp, int idEstado, DateTime DataModificacao)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Aparelhos Set DataModificacao = @DataModificacao, Id_Estado = @idEstado Where IdAparelho = @idAp", new { idAp, DataModificacao, idEstado });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateRevisaoAp(int idAp, bool revisao)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update APARELHOS Set Revisao = @revisao where IdAparelho =@idAp", new { idAp, revisao });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateDialogoContato(int idContato, string dialogo)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Contatos Set Dialogo = @dialogo Where IdContato = @idContato", new { idContato, dialogo });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateQuantidadeItem(Produtos item)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Itens Set Quantidade = @quantidade Where IdItem =@IdItem",
                        new
                        {
                            item.IdItem,
                            item.Quantidade
                        });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public void UpdateMaoDeObra(Produtos item)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Itens Set Valor = @ValorVenda Where IdItem =@IdItem",
                        new
                        {
                            item.IdItem,
                            item.ValorVenda
                        });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateSaidaAparelho(int idAp, string obs, DateTime saida)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update APARELHOS Set Observacao = @obs, Saida = @saida  where IdAparelho =@idAp", new { idAp, obs, saida });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateEstadoAparelho(int idAp, Estado estado, DateTime dataAlter, DateTime dataSaida)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Update Aparelhos Set Id_Estado = @estado, DataModificacao = @dataAlter, Saida = @dataSaida Where IdAparelho =@idAp", new { idAp, estado, dataAlter, dataSaida });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void UpdateTelefone(Telefones telefones)
        {
            try
            {
                using (ConOficina())
                {
                    var query = @"Update TELEFONES Set Tipo = @Tipo, Numero = @Numero, Whats = @Whats 
                                Where IdTelefone = @IdTelefone";
                    var p = new
                    {
                        telefones.IdTelefone,
                        telefones.Tipo,
                        telefones.Numero,
                        telefones.Whats
                    };
                    ConOficina().Open();
                    ConOficina().Execute(query, p);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }





        /////////////////////////// Exclusões

        public void DeleteTelefone(int idTelefone)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Delete From TELEFONES Where IdTelefone = @idTelefone", new { idTelefone });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                ConOficina().Close();
            }
        }

        public void DeleteItem(int idItem)
        {
            try
            {
                using (ConOficina())
                {
                    ConOficina().Open();
                    ConOficina().Execute(@"Delete From Itens Where IdItem = @idItem", new { idItem });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        //---------------------------- Db VendasOficina --------------------------//

        public List<Produtos> GetProdutosDbVendasOficina()
        {
            try
            {
                using (ConVendas())
                {
                    ConVendas().Open();
                    return ConVendas().Query<Produtos>(@"Select IdProduto, Produto, Descricao, ValorVenda, Estoque, Estado from VW_ProdutosString").ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int InsertPagamentoDbVendasOficina(Pagamentos p)
        {
            try
            {
                using (ConVendas())
                {
                    ConVendas().Open();
                    var idPag = ConVendas().ExecuteScalar(@"Exec SP_InsertPagamento @DataPag, @TipoPag, @Valor, @Categoria", new { p.DataPag, p.TipoPag, p.Valor, p.Categoria });
                    return Convert.ToInt32(idPag);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void SubtractProdutoEstoque(Produtos p)
        {
            try
            {
                using (ConVendas())
                {
                    ConVendas().Open();
                    ConVendas().Execute(@"Update Produtos Set Estoque = (Select Estoque from Produtos Where IdProduto = @IdProduto) - @Quantidade Where IdProduto = @IdProduto",
                        new { p.IdProduto, p.Quantidade });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void AddProdutoEstoque(Produtos p)
        {
            try
            {
                using (ConVendas())
                {
                    ConVendas().Open();
                    ConVendas().Execute(@"Update Produtos Set Estoque = (Select Estoque from Produtos Where IdProduto = @IdProduto) + @Quantidade Where IdProduto = @IdProduto",
                        new { p.IdProduto, p.Quantidade });

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
