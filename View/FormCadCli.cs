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
        public FormCadCli(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
            InicializarCadastro();
        }

        public FormCadCli(FormAparelho formAparelho, int idCli)
        {
            InitializeComponent();
            this.formAparelho = formAparelho;
            this.idCli = idCli;
            InicializarEdicao();
        }

        //----------------------------------------- Inicializações ----------------------------------------//

        private void InicializarCadastro()
        {
            tbNome.Text = string.Empty;
            cbSexo.Text = "Masculino";
            mtbCpf.Clear();
            mtbCpf.Mask = cpfMask;
            LimparControlesPanel(pnTel1);
            pnTel1.Show();
            pnTel2.Hide();
            pnTel3.Hide();
            PosicionaBotoes(pnTel1, pnTel1);
            AlteraCheckBoxes(cbTipo1, chWhats1);
            AlteraCheckBoxes(cbTipo2, chWhats2);
            AlteraCheckBoxes(cbTipo3, chWhats3);
        }


        private void InicializarEdicao()
        {
            this.Name = "FormEditarCli";
            btnDelTel1.Hide();
            btnDelTel2.Hide();
            btnDelTel3.Hide();
            AlinharPanelAoMeio(pnDadosCli);
            AlinharPanelAoMeio(pnTel1);
            AlinharPanelAoMeio(pnTel2);
            AlinharPanelAoMeio(pnTel3);
            pnTel2.Hide();
            pnTel3.Hide();
            btn_Close.Show();
            btnLimpar.Enabled = false;
            GetClienteInfo(idCli);
            PreencheCliente();
            PreencheTelefones();
            AlteraCheckBoxes(cbTipo1, chWhats1);
            AlteraCheckBoxes(cbTipo2, chWhats2);
            AlteraCheckBoxes(cbTipo3, chWhats3);
        }


        //--------------------------               FrontEnd            -----------------------------------//
        private void PosicionaBotoes(Panel anterior, Panel atual)
        {
            if (atual.Visible == false)
            {
                atual.Visible = true;
                btnSalvar.Location = CoordenatasBotoes(atual, btnSalvar);
                btnLimpar.Location = CoordenatasBotoes(atual, btnLimpar);
            }
            else
            {
                if (atual != anterior)
                {
                    atual.Visible = false;
                    LimparControlesPanel(atual);
                    btnSalvar.Location = CoordenatasBotoes(anterior, btnSalvar);
                    btnLimpar.Location = CoordenatasBotoes(anterior, btnLimpar);
                }
            }
        }

        private void AlinharPanelAoMeio(Panel panel)
        {
            int leftBorder = panel.Left;
            int rightBorder = panel.Right;
            int panelLenght = panel.Width;
            int totalWidth = leftBorder + panelLenght + rightBorder;
            int x = (totalWidth / 2) - (panelLenght) + 70;
            panel.Location = new Point(x, panel.Location.Y);
        }
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

        private void AlteraIconeBtnAddTel(object btnAddTel)
        {
            IconButton btn = (IconButton)btnAddTel;
            if (btn.IconChar == IconChar.Plus)
            {
                btn.IconChar = IconChar.Minus;
                btn.IconColor = Color.IndianRed;
            }
            else
            {
                btn.IconChar = IconChar.Plus;
                btn.IconColor = Color.ForestGreen;
            }
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
            DialogResult result = formAparelho.ChamaMessageBoxYesNo("Excluir este numero fará com que os contatos assossiados a este numero também sejam excluidos. Deseja Prosseguir?");
            if (result == DialogResult.Yes)
            {
                MetodosBd.DeleteTelefone(telefonesListEdit[0].IdTelefone);
                telefonesListEdit.RemoveAt(0);
                InicializarEdicao();
            }
        }

        private void btnDelTel2_Click(object sender, EventArgs e)
        {
            DialogResult result = formAparelho.ChamaMessageBoxYesNo("Excluir este numero fará com que os contatos assossiados a este numero também sejam excluidos. Deseja Prosseguir?");
            if (result == DialogResult.Yes)
            {
                MetodosBd.DeleteTelefone(telefonesListEdit[1].IdTelefone);
                telefonesListEdit.RemoveAt(1);
                InicializarEdicao();
            }
        }

        private void btnDelTel3_Click(object sender, EventArgs e)
        {
            DialogResult result = formAparelho.ChamaMessageBoxYesNo("Excluir este numero fará com que os contatos assossiados a este numero também sejam excluidos. Deseja Prosseguir?");
            if (result == DialogResult.Yes)
            {
                MetodosBd.DeleteTelefone(telefonesListEdit[2].IdTelefone);
                telefonesListEdit.RemoveAt(2);
                InicializarEdicao();
            }
        }

        private void btnAddTel2_Click(object sender, EventArgs e)
        {
            if (pnTel3.Visible == false)
            {
                AlteraIconeBtnAddTel(sender);
                PosicionaBotoes(pnTel1, pnTel2);
            }

        }

        private void btnAddTel3_Click(object sender, EventArgs e)
        {
            AlteraIconeBtnAddTel(sender);
            PosicionaBotoes(pnTel2, pnTel3);
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

        //---------------------------------------     Metodos       -----------------------------------------------------//

        //Edita Numero e Informações do Cliente
        private void EditarInformacoes()
        {
            List<Telefones> telefones = new List<Telefones>(ExtrairTelefones());
            Clientes cliente = new Clientes
            {
                Cpf = mtbCpf.Text,
                Nome = tbNome.Text.Trim(),
                Sexo = cbSexo.Text == "Masculino" ? 'M' : 'F'
            };
            if (ValidaClasses(cliente, telefones))
            {
                EditarCliente(cliente);
                EditarNumero();
                AddNumero(telefones);
                formAparelho.ChamaMessageBoxOk("Cliente Atualizado!");
            }           
        }
        //Edita infos do cliente
        private void EditarCliente(Clientes cliente)
        {
            MetodosBd.UpdateCliente(cliente);
        }
        //Adiciona um novo Numero enquanto o clietne está sendo editado
        private void AddNumero(List<Telefones> telefones)
        {            
            
            List<Telefones> newTels = new List<Telefones>();
            newTels = telefones.Except(telefonesListEdit).ToList();
            //salvar newTels no bd
            foreach (Telefones tel in newTels)
            {
                tel.Id_Cliente = idCli;
                MetodosBd.InsertTelefone(tel);
            }
        }
        //Edita o numero do cliente
        private void EditarNumero()
        {
            MaskedTextBox[] maskeds = new MaskedTextBox[] { mtbNum1, mtbNum2, mtbNum3 };
            ComboBox[] combos = new ComboBox[] { cbTipo1, cbTipo2, cbTipo3 };
            CheckBox[] checks = new CheckBox[] { chWhats1, chWhats2, chWhats3 };

            for (int i = 0; i < telefonesListEdit.Count; i++)
            {
                //Se o Id for != 0, significa que o numero existe no banco.
                //Se o numero contido na lista for diferente do numero contido na maskedBox, ele então precisa ser editado
                if (telefonesListEdit[i].IdTelefone != 0 && telefonesListEdit[i].Numero != maskeds[i].Text)
                {
                    telefonesListEdit[i].Tipo = (Tipo)Enum.Parse(typeof(Tipo), combos[i].Text, true);
                    telefonesListEdit[i].Numero = maskeds[i].Text;
                    telefonesListEdit[i].Whats = checks[i].Checked;
                    //BdUpdate
                    MetodosBd.UpdateTelefone(telefonesListEdit[i]);
                }
                if (telefonesListEdit[i].IdTelefone != 0 && telefonesListEdit[i].Whats != checks[i].Checked)
                {                    
                    telefonesListEdit[i].Whats = checks[i].Checked;
                    //BdUpdate
                    MetodosBd.UpdateTelefone(telefonesListEdit[i]);
                }
            }
        }

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

        private void PreencheCliente()
        {
            tbNome.Text = cliente.Nome;
            mtbCpf.Mask = cpfMask;
            mtbCpf.Text = cliente.Cpf;
            cbSexo.SelectedIndex = cliente.Sexo == 'M' ? 0 : 1;
        }

        //Preenche os telefones durante a edição conforme o numero de telefones contidos na telefonesListEdit 
        private void PreencheTelefones()
        {
            Panel[] pnTelefones = new Panel[] { pnTel1, pnTel2, pnTel3 };
            MaskedTextBox[] maskeds = new MaskedTextBox[] { mtbNum1, mtbNum2, mtbNum3 };
            ComboBox[] combos = new ComboBox[] { cbTipo1, cbTipo2, cbTipo3 };
            CheckBox[] checks = new CheckBox[] { chWhats1, chWhats2, chWhats3 };
            IconButton[] btnsDelTel = new IconButton[] { btnDelTel1, btnDelTel2, btnDelTel3 };
            int count = telefonesListEdit.Count;
            for (int i = 0; i < count; i++)
            {
                pnTelefones[i].Show();
                maskeds[i].Text = telefonesListEdit[i].Numero;
                combos[i].SelectedItem = telefonesListEdit[i].Tipo.ToString();
                checks[i].Checked = telefonesListEdit[i].Whats;
                btnsDelTel[i].Visible = true;
            }

            switch (count)
            {
                case 2:
                    PosicionaBotoes(pnTel1, pnTel2);
                    AlteraIconeBtnAddTel(btnAddTel2);
                    break;
                case 3:
                    PosicionaBotoes(pnTel2, pnTel3);
                    AlteraIconeBtnAddTel(btnAddTel2);
                    AlteraIconeBtnAddTel(btnAddTel3);
                    break;
                default:
                    PosicionaBotoes(pnTel1, pnTel1);
                    btnDelTel1.Visible = false;
                    break;
            }
        }

        //Pega os Dados do Cliente
        private void GetClienteInfo(int idCli)
        {
            // Este Metodo Pega apenas o IdCliente, Nome, Cpf, Sexo, Numero.
            cliente = MetodosBd.GetClienteById(idCli).FirstOrDefault();
            telefonesListEdit = MetodosBd.GetTelefonesByIdCli(idCli);
        }

        //Define uma mascara a ComboBox Associada
        private void MascaraNumero(object cbtipo, MaskedTextBox numero)
        {
            ComboBox box = (ComboBox)cbtipo;
            switch (box.Text)
            {
                case "Celular":
                    numero.Mask = "(00)00000-0000";
                    break;
                case "Fixo":
                    numero.Mask = "(00)0000-0000";
                    break;
                default:
                    numero.Mask = "";
                    break;
            }

        }

        //Limpa os Controles com Base no Nome do Panel Chamado
        private void LimparControlesPanel(Panel panel)
        {
            switch (panel.Name)
            {
                case "pnTel2":
                    cbTipo2.Text = null;
                    mtbNum2.Clear();
                    MascaraNumero(cbTipo2, mtbNum2);
                    chWhats2.Checked = false;
                    break;
                case "pnTel3":
                    cbTipo3.Text = null;
                    mtbNum3.Clear();
                    MascaraNumero(cbTipo3, mtbNum3);
                    chWhats3.Checked = false;
                    break;

                default:
                    cbTipo1.Text = null;
                    cbTipo2.Text = null;
                    cbTipo3.Text = null;

                    mtbNum1.Clear();
                    MascaraNumero(cbTipo1, mtbNum1);
                    mtbNum2.Clear();
                    MascaraNumero(cbTipo2, mtbNum2);
                    mtbNum3.Clear();
                    MascaraNumero(cbTipo3, mtbNum3);

                    chWhats1.Checked = false;
                    chWhats2.Checked = false;
                    chWhats3.Checked = false;
                    break;
            }

        }

        //Ativa ou Desativa a CheckBox referenciada
        private void AlteraCheckBoxes(object cbTipo, CheckBox chbWhats)
        {
            ComboBox box = (ComboBox)cbTipo;
            if (box.Text != "Celular")
            {
                chbWhats.Hide();
            }
            else
            {
                chbWhats.Show();
            }
        }

        private bool ValidaClasses(Clientes cliente, List<Telefones> telList)
        {
            List<MaskedTextBox> maskeds = new List<MaskedTextBox> { mtbNum1, mtbNum2, mtbNum3 };
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
                if (telList[i].ValidaTelefone(maskeds[i], ep) == false)
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

        private List<Telefones> ExtrairTelefones()
        {
            List<MaskedTextBox> maskeds = new List<MaskedTextBox> { mtbNum1, mtbNum2, mtbNum3 };
            List<ComboBox> boxes = new List<ComboBox> { cbTipo1, cbTipo2, cbTipo3 };
            List<CheckBox> checks = new List<CheckBox> { chWhats1, chWhats2, chWhats3 };
            List<Telefones> telefones = new List<Telefones>();

            for (int i = 0; i < maskeds.Count; i++)
            {
                if (maskeds[i].Text.Trim() != string.Empty)
                {
                    Telefones tel = new Telefones
                    {
                        Numero = maskeds[i].Text.Trim(),
                        Tipo = (Tipo)Enum.Parse(typeof(Tipo), boxes[i].Text, true),
                        Whats = checks[i].Checked
                    };
                    telefones.Add(tel);
                }
            }
            return telefones;

        }

        //---------------------- Eventos Combo Boxes --------------------------------//
        private void cbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum1);
            AlteraCheckBoxes(sender, chWhats1);
        }

        private void cbTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum2);
            AlteraCheckBoxes(sender, chWhats2);
        }

        private void cbTipo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MascaraNumero(sender, mtbNum3);
            AlteraCheckBoxes(sender, chWhats3);
        }
        
    }
}
