using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;
using FontAwesome.Sharp;
using System.Threading;
using View.MetodosBackGroundWorker;

namespace View
{
    public partial class FormCadCli : Form
    {
        public int idCli { get; set; }
        string cpfMask = @"000\.000\.000\-00";
        Vw_GridPrincipal cliente = new Vw_GridPrincipal();
        List<Telefones> telefonesListEdit = new List<Telefones>();
        FormHome formHome;
        FormAparelho formAparelho;
        MaskedTextBox[] mtbNumeros;
        ComboBox[] cbTiposArray;
        CheckBox[] chbWhatsArray;
        Panel[] pnTelefonesArray;
        IconButton[] btnsEditarArray;
        IconButton[] btnsSalvarArray;
        IconButton[] btnAddTelArray;
        Panel[] pnEdicoesArray;

        public FormCadCli(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
            PreencheArrays();
            InicializarCadastro();
        }

        public FormCadCli(FormAparelho formAparelho, int idCli)
        {
            InitializeComponent();
            this.formAparelho = formAparelho;
            this.idCli = idCli;
            PreencheArrays();
            AlinharPaineisAoMeio();
            InicializarEdicao();
        }



        //----------------------------------------- Inicializações ----------------------------------------//

        /// <summary>
        /// Método de inicialização para quando o Formulário é chamado para o Cadastro de um novo Cliente
        /// </summary>
        private void InicializarCadastro()
        {

            tbNome.Text = string.Empty;
            cbSexo.Text = "Masculino";
            mtbCpf.Clear();
            mtbCpf.Mask = cpfMask;
            LimpaControlesPaineisTelefone();
            pnTel1.Show();
            pnTel2.Hide();
            pnTel3.Hide();
            PosicionaBotoes(0);
            AlteraCheckBoxes(cbTipo1, chWhats1);
            AlteraCheckBoxes(cbTipo2, chWhats2);
            AlteraCheckBoxes(cbTipo3, chWhats3);

        }

        /// <summary>
        /// Método chamado durante a edição de um cliente já existente
        /// </summary>
        private void InicializarEdicao()
        {
            LimpaControlesPaineisTelefone();
            BackGroundWorkerMetodos.ChamaBackGroundWorker(bgwCliente);
            BackGroundWorkerMetodos.ChamaBackGroundWorker(bgwTelefones);
            this.Name = "FormEditarCli";
            btn_Close.Show();
            btnLimpar.Enabled = false;
        }

        /// <summary>
        /// Preenche os Arrays criandos no escopo global do formulário
        /// </summary>
        private void PreencheArrays()
        {
            pnEdicoesArray = new Panel[] { pnEdicao1, pnEdicao2, pnEdicao3 };
            btnsSalvarArray = new IconButton[] { btnSalvarEdicao1, btnSalvarEdicao2, btnSalvarEdicao3 };
            btnsEditarArray = new IconButton[] { btnEditar1, btnEditar2, btnEditar3 };
            btnAddTelArray = new IconButton[] { btnAddTel2, btnAddTel3 };
            pnTelefonesArray = new Panel[] { pnTel1, pnTel2, pnTel3 };
            mtbNumeros = new MaskedTextBox[] { mtbNum1, mtbNum2, mtbNum3 };
            cbTiposArray = new ComboBox[] { cbTipo1, cbTipo2, cbTipo3 };
            chbWhatsArray = new CheckBox[] { chWhats1, chWhats2, chWhats3 };
        }


        //--------------------------               FrontEnd            -----------------------------------//


        /// <summary>
        /// Centraliza todos os paineis no meio da tela
        /// </summary>
        private void AlinharPaineisAoMeio()
        {
            AlinharPanelAoMeio(pnDadosCli);
            foreach (Panel pn in pnTelefonesArray)
            {
                AlinharPanelAoMeio(pn);
            }
        }

        /// <summary>
        /// Posiciona os Botões Salvar e Limpar abaixo de um painel contido no array de Paineis
        /// </summary>
        /// <param name="indice">Indice do painel qual os botões devem ser posicionados</param>
        private void PosicionaBotoes(int indice)
        {
            btnSalvar.Location = CoordenatasBotoes(pnTelefonesArray[indice], btnSalvar);
            btnLimpar.Location = CoordenatasBotoes(pnTelefonesArray[indice], btnLimpar);
        }

        /// <summary>
        /// Centraliza um painel ao meio da tela
        /// </summary>
        /// <param name="panel">Painel a ser centralizado</param>
        private void AlinharPanelAoMeio(Panel panel)
        {
            int leftBorder = panel.Left;
            int rightBorder = panel.Right;
            int panelLenght = panel.Width;
            int totalWidth = leftBorder + panelLenght + rightBorder;
            int x = (totalWidth / 2) - (panelLenght) + 70;
            panel.Location = new Point(x, panel.Location.Y);
        }

        /// <summary>
        /// Gerencia as coordenatas para os botões limpar e salvar
        /// </summary>
        /// <param name="panel">painel que esta acima dos botoes</param>
        /// <param name="btn">Deve ser inserido o botão limpar ou salvar</param>
        /// <returns>Retorna um Point com a nova localização do botão</returns>
        private Point CoordenatasBotoes(Panel panel, IconButton btn)
        {
            int x = 0, y = 0;
            switch (btn.Name)
            {
                //Da as coordenatas para o botao salvar
                case "btnSalvar":
                    x = pnTel1.Location.X + cbTipo1.Location.X;
                    y = panel.Location.Y + panel.Height + 10;
                    return new Point(x, y);
                //Da as coordenatas para o Botão limpar
                default:
                    x = btnSalvar.Location.X + btnSalvar.Width;
                    y = panel.Location.Y + panel.Height + 10;
                    return new Point(x, y);
            }
        }

        /// <summary>
        /// Faz a alteração do icone e da cor de um dos botões btnAddTel
        /// </summary>
        /// <param name="btnAddTel"></param>
        private void AlteraIconeBtnAddTel(IconButton btnAddTel)
        {

            if (btnAddTel.IconChar == IconChar.Plus)
            {
                btnAddTel.IconChar = IconChar.Minus;
                btnAddTel.IconColor = Color.IndianRed;
            }
            else
            {
                btnAddTel.IconChar = IconChar.Plus;
                btnAddTel.IconColor = Color.ForestGreen;
            }
        }

        /// <summary>
        /// Move e altera os paineis conforme o indice
        /// </summary>
        /// <param name="indice">indice do painel atual</param>
        private void AlteraControlesParaBtnAddTel(int indice)
        {
            pnTelefonesArray[indice].Visible = !pnTelefonesArray[indice].Visible;
            pnEdicoesArray[indice].Hide();
            btnsEditarArray[indice].Show();
            AlteraIconeBtnAddTel(btnAddTelArray[indice - 1]);
            int i = indice - 1;
            if (pnTelefonesArray[indice].Visible)
            {
                i = indice;
            }
            PosicionaBotoes(i);
        }

        //-------------------------------------------      Eventos Botões     ---------------------------------------------------//

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            formAparelho.pnItens.Show();
            formAparelho.Inicializacao();
        }

        private void btnDelTel1_Click(object sender, EventArgs e)
        {
            ExcluirNumero(0);
        }

        private void btnDelTel2_Click(object sender, EventArgs e)
        {
            ExcluirNumero(1);
        }

        private void btnDelTel3_Click(object sender, EventArgs e)
        {
            ExcluirNumero(2);
        }


        private void btnAddTel2_Click(object sender, EventArgs e)
        {
            if (pnTel3.Visible == false && mtbNum2.Text.Trim().Length == 0)
            {
                AlteraControlesParaBtnAddTel(1);
            }
        }


        private void btnAddTel3_Click(object sender, EventArgs e)
        {
            if (mtbNum3.Text.Trim().Length == 0)
            {
                AlteraControlesParaBtnAddTel(2);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            InicializarCadastro();
            if (btnAddTel2.IconChar == IconChar.Minus)
            {
                AlteraIconeBtnAddTel(btnAddTel2);
            }
            if (btnAddTel3.IconChar == IconChar.Minus)
            {
                AlteraIconeBtnAddTel(btnAddTel3);
            }

            btnSalvar.Location = CoordenatasBotoes(pnTel1, btnSalvar);
            btnLimpar.Location = CoordenatasBotoes(pnTel1, btnLimpar);
            ep.Clear();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (this.Name)
            {
                case "FormCadCli":
                    CadastraCliente();
                    break;
                default:
                    EditarInformacoes();
                    break;
            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            AlterarEdicao(0);
        }


        private void btnEditar2_Click(object sender, EventArgs e)
        {
            AlterarEdicao(1);
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            AlterarEdicao(2);
        }

        private void btnSalvarEdicao1_Click(object sender, EventArgs e)
        {
            AtualizaNumero(0);
        }

        private void btnSalvarEdicao2_Click(object sender, EventArgs e)
        {
            AtualizaNumero(1);
        }

        private void btnSalvarEdicao3_Click(object sender, EventArgs e)
        {
            AtualizaNumero(2);
        }

        //---------------------------------------     Metodos       -----------------------------------------------------//

        /// <summary>
        /// Edita os dados do cliente e faz a adição de novos telefones durante a edição
        /// </summary>
        private void EditarInformacoes()
        {
            List<Telefones> telefones = new List<Telefones>(ExtrairTelefones());
            Clientes cliente = new Clientes
            {
                IdCliente = idCli,
                Cpf = mtbCpf.Text,
                Nome = tbNome.Text.Trim(),
                Sexo = cbSexo.Text == "Masculino" ? 'M' : 'F'
            };
            if (ValidaClasses(cliente, telefones))
            {
                EditarCliente(cliente);
                AddNumero(telefones);
                formAparelho.ChamaMessageBoxOk("Cliente Atualizado!");
            }
        }

        /// <summary>
        /// Exclui um contato com base no indice passado
        /// </summary>
        /// <param name="indice">Deve ser o mesmo indice contido na lista telefonesListEdit</param>
        private void ExcluirNumero(int indice)
        {
            if (MetodosBd.GetTelefonesByIdCli(idCli).Count <= 1)
            {
                ep.SetError(mtbNumeros[indice], "Não é possivel excluir este número pois o cliente só possui o mesmo cadastrado");
                return;
            }
            DialogResult result = formAparelho.ChamaMessageBoxYesNo("Excluir este numero fará com que os contatos assossiados \na este numero também sejam excluidos. Deseja Prosseguir?");
            if (result == DialogResult.Yes)
            {
                MetodosBd.DeleteTelefone(telefonesListEdit[indice].IdTelefone);
                InicializarEdicao();
                ep.SetError(mtbNumeros[indice], string.Empty);

            }
        }

        /// <summary>
        /// Faz as edições do Cliente
        /// </summary>
        /// <param name="cliente"></param>
        private void EditarCliente(Clientes cliente)
        {
            MetodosBd.UpdateCliente(cliente);
        }

        /// <summary>
        /// Compara os números de telefones no banco de dados com os contidos dentro dos telefones extraindos. 
        /// Se forem iguais, eles serão adicionados ao banco de dados
        /// </summary>
        /// <param name="telefonesExtraidos">Telefones contidos em cada Painel</param>
        private void AddNumero(List<Telefones> telefonesExtraidos)
        {

            List<Telefones> newTels = new List<Telefones>();
            newTels = telefonesExtraidos.Except(telefonesListEdit).ToList();
            //salvar newTels no bd
            foreach (Telefones tel in newTels)
            {
                tel.Id_Cliente = idCli;
                MetodosBd.InsertTelefone(tel);
            }
            InicializarEdicao();
        }

        /// <summary>
        /// Atualiza os numeros já existentes e que foram editados
        /// </summary>
        /// <param name="indice"></param>
        private void AtualizaNumero(int indice)
        {
            Telefones telefoneEditado = ExtrairNumero(indice);
            if (telefoneEditado.ValidaTelefone(mtbNumeros[indice], ep))
            {
                MetodosBd.UpdateTelefone(telefoneEditado);
                btnsEditarArray[indice].Show();
                pnEdicoesArray[indice].Hide();
                AlterarEdicoesCampos(indice, false);
            }

        }

        /// <summary>
        /// Faz a extração dos campos dos controles filhos contidos dentro de um panel
        /// </summary>
        /// <param name="indice">Indice do panel a ter os dados extraídos</param>
        /// <returns></returns>
        private Telefones ExtrairNumero(int indice)
        {
            return new Telefones
            {
                IdTelefone = telefonesListEdit[indice].IdTelefone,
                Numero = mtbNumeros[indice].Text.Trim(),
                Tipo = (Tipo)Enum.Parse(typeof(Tipo), cbTiposArray[indice].Text, true),
                Whats = chbWhatsArray[indice].Checked
            };
        }

        /// <summary>
        /// Extrai os dados do cliente e faz seu cadastro caso seus dados sejam validados
        /// </summary>
        private void CadastraCliente()
        {
            List<Telefones> telefones = new List<Telefones>();

            Clientes cliente = new Clientes
            {
                Nome = tbNome.Text.Trim(),
                Sexo = cbSexo.Text == "Masculino" ? 'M' : 'F',
                Cpf = mtbCpf.Text,
                DataCad = DateTime.Now
            };

            telefones = ExtrairTelefones();
            if (ValidaClasses(cliente, telefones))
            {
                try
                {
                    int idCli = MetodosBd.InsertClienteAndTelefone(cliente, telefones);
                    MessageBox.Show("Cliente Cadastrado!");
                    DialogResult result = MessageBox.Show("Deseja Cadastrar um Aparelho para Este Cliente?", "", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //Abre o Form através dos controles do FormHome
                            cliente.IdCliente = idCli;
                            formHome.ActivateButton(formHome.btn_CadAp, FormHome.RGBColors.color1);
                            formHome.OpenChildForm(new FormCadAp(cliente));
                            this.Close();
                            break;
                        case DialogResult.No:
                            InicializarCadastro();
                            break;
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Não Foi possivel cadastrar o cliente. Erro : " + er.Message);
                }
            }
        }

        /// <summary>
        /// Preenche os dados do Cliente
        /// </summary>
        private void PreencheCliente(Vw_GridPrincipal cliente)
        {
            tbNome.Text = cliente.Nome;
            mtbCpf.Mask = cpfMask;
            mtbCpf.Text = cliente.Cpf;
            cbSexo.SelectedIndex = cliente.Sexo == 'M' ? 0 : 1;
        }

        /// <summary>
        /// Preenche os telefones durante a edição conforme o numero de telefones contidos na telefonesListEdit 
        /// </summary>
        private void PreencheTelefones()
        {

            this.SuspendLayout();
            foreach (Panel pn in pnTelefonesArray)
            {
                pn.Hide();
            }
            foreach (IconButton btn in btnAddTelArray)
            {
                btn.IconChar = IconChar.Plus;
                btn.IconColor = Color.ForestGreen;
            }

            int count = telefonesListEdit.Count;
            for (int i = 0; i < count; i++)
            {

                //Preenche campos
                mtbNumeros[i].Text = telefonesListEdit[i].Numero;
                cbTiposArray[i].SelectedItem = telefonesListEdit[i].Tipo.ToString();
                chbWhatsArray[i].Checked = telefonesListEdit[i].Whats;
                pnTelefonesArray[i].Show();
                //
                //Altera campos
                AlterarEdicoesCampos(i, false);
                btnsEditarArray[i].Show();
                pnEdicoesArray[i].Hide();
                AlteraCheckBoxes(cbTiposArray[i], chbWhatsArray[i]);
                //
                AlteraBtnAddTelEdicao(i);
            }
            PosicionaBotoes(count - 1);
            this.ResumeLayout();
        }

        /// <summary>
        /// Altera o icone e a cor dos botões btnAddTel durante a edição
        /// </summary>
        /// <param name="indice">indice do panel atual</param>
        private void AlteraBtnAddTelEdicao(int indice)
        {
            if (indice > 0)
            {
                if (mtbNumeros[indice].Text != string.Empty)
                {
                    AlteraIconeBtnAddTel(btnAddTelArray[indice - 1]);
                }
            }
        }


        //Define uma mascara a ComboBox Associada
        /// <summary>
        /// Define uma mascara para a MaskedTextBox associada
        /// </summary>
        /// <param name="cbtipo">ComboBox a ter o tipo analisado</param>
        /// <param name="mtbNumero">MaskedTextBox a receber a máscara</param>
        private void MascaraNumero(object cbtipo, MaskedTextBox mtbNumero)
        {
            ComboBox box = (ComboBox)cbtipo;
            switch (box.Text)
            {
                case "Celular":
                    mtbNumero.Mask = "(00)00000-0000";
                    break;
                case "Fixo":
                    mtbNumero.Mask = "(00)0000-0000";
                    break;
                default:
                    mtbNumero.Mask = "";
                    break;
            }

        }


        /// <summary>
        /// Limpa os Controles de todos os panels de telefone
        /// </summary>
        private void LimpaControlesPaineisTelefone()
        {
            foreach (Panel pn in pnTelefonesArray)
            {
                foreach (Control cn in pn.Controls)
                {
                    MaskedTextBox mtbNumero = new MaskedTextBox();
                    ComboBox cbTipo = new ComboBox();
                    CheckBox chbWhats = new CheckBox();

                    if (cn is MaskedTextBox)
                    {
                        mtbNumero = (MaskedTextBox)cn;
                    }
                    if (cn is ComboBox)
                    {
                        cbTipo = (ComboBox)cn;
                    }
                    if (cn is CheckBox)
                    {
                        chbWhats = (CheckBox)cn;
                    }
                    cbTipo.Text = null;
                    mtbNumero.Clear();
                    MascaraNumero(cbTipo, mtbNumero);
                    chbWhats.Checked = false;
                }
            }
        }

        /// <summary>
        /// Ativa ou Desativa a CheckBox referenciada
        /// </summary>
        /// <param name="cbTipo">ComboBox a ter seu tipo analizado</param>
        /// <param name="chbWhats">CheckBox qual será exibida ou não</param>
        private void AlteraCheckBoxes(ComboBox cbTipo, CheckBox chbWhats)
        {
            if (cbTipo.Text != "Celular")
            {
                chbWhats.Hide();
                return;
            }
            chbWhats.Show();

        }

        /// <summary>
        /// Valida as Classes de Clientes e Telefones
        /// </summary>
        /// <param name="cliente">Cliente a ser validado</param>
        /// <param name="telList">Lista de telefones a ser validada</param>
        /// <returns></returns>
        private bool ValidaClasses(Clientes cliente, List<Telefones> telList)
        {
            bool validado = true;
            //Se o Cliente não for validado, irá retornar False
            switch (this.Name)
            {
                case "FormCadCli":
                    //Pega os Cpfs do banco para poder fazer validacao
                    List<Clientes> clientesCpfs = MetodosBd.GetClientesCpf();
                    if (cliente.ValidaCliente(tbNome, cbSexo, mtbCpf, clientesCpfs, ep) == false)
                    {
                        validado = false;
                    }
                    break;
                default:
                    if (cliente.ValidaClienteEdicao(tbNome, cbSexo, mtbCpf, ep) == false)
                    {
                        validado = false;
                    }
                    break;
            }

            //Para Cada Telefone Adicionado na Lista, Faz a Verificação
            for (int i = 0; i < telList.Count; i++)
            {
                if (telList[i].ValidaTelefone(mtbNumeros[i], ep) == false)
                {
                    validado = false;
                }
            }
            //Por ultimo, é validado se a lista de Numeros está vazia
            if (Telefones.ValidaNumeroVazio(telList, mtbNum1, ep) == false)
            {
                validado = false;
            }

            return validado;

        }

        /// <summary>
        /// Pega os dados de todos os campos preenchidos dentro dos Paines Telefones
        /// </summary>
        /// <returns>Lista de Telefones</returns>
        private List<Telefones> ExtrairTelefones()
        {
            List<Telefones> telefones = new List<Telefones>();

            for (int i = 0; i < mtbNumeros.Length; i++)
            {
                if (mtbNumeros[i].Text.Trim() != string.Empty)
                {
                    Telefones tel = new Telefones
                    {
                        Numero = mtbNumeros[i].Text.Trim(),
                        Tipo = (Tipo)Enum.Parse(typeof(Tipo), cbTiposArray[i].Text, true),
                        Whats = chbWhatsArray[i].Checked
                    };
                    telefones.Add(tel);
                }
            }
            return telefones;

        }

        /// <summary>
        /// Habilida e desabilida os campos dentro dos paines Telefones para edição
        /// </summary>
        /// <param name="indice">indice do painel que estão contidos os controles de telefone</param>
        /// <param name="habilitado">diz se devem ser habilitados ou não para edição</param>
        private void AlterarEdicoesCampos(int indice, bool habilitado)
        {
            //Caso os campos estejam ativados, eles são desativados
            switch (habilitado)
            {
                case true:
                    cbTiposArray[indice].Enabled = true;
                    mtbNumeros[indice].ReadOnly = false;
                    chbWhatsArray[indice].Enabled = true;
                    break;

                default:
                    cbTiposArray[indice].Enabled = false;
                    mtbNumeros[indice].ReadOnly = true;
                    chbWhatsArray[indice].Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Altera os botões e paineis para edição de um número
        /// </summary>
        /// <param name="indice">Indice do painel a ter suas informações editadas</param>
        private void AlterarEdicao(int indice)
        {
            pnTelefonesArray[indice].Controls.Add(pnEdicoesArray[indice]);
            pnEdicoesArray[indice].Location = btnsEditarArray[indice].Location;
            btnsEditarArray[indice].Hide();
            pnEdicoesArray[indice].Show();
            AlterarEdicoesCampos(indice, true);
        }

        //---------------------- Eventos Combo Boxes --------------------------------//
        private void cbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum1);
            AlteraCheckBoxes(cbTipo1, chWhats1);
        }

        private void cbTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum2);
            AlteraCheckBoxes(cbTipo2, chWhats2);
        }

        private void cbTipo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum3);
            AlteraCheckBoxes(cbTipo3, chWhats3);
        }


        //---------------------BackGroundWorkers-------------------------------//


        //Telefones
        private void bgwTelefones_DoWork(object sender, DoWorkEventArgs e)
        {
            telefonesListEdit = null;
            telefonesListEdit = MetodosBd.GetTelefonesByIdCli(idCli);
        }

        //Telefones
        private void bgwTelefones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PreencheTelefones();
        }

        //Cliente
        private void bgwCliente_DoWork(object sender, DoWorkEventArgs e)
        {
            cliente = null;
            cliente = MetodosBd.GetClienteById(idCli).FirstOrDefault();
        }

        //Cliente
        private void bgwCliente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PreencheCliente(cliente);
        }
    }
}
