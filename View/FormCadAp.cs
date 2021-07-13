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
    public partial class FormCadAp : Form
    {
        public List<Vw_GridPrincipal> listSearch = new List<Vw_GridPrincipal>();
        List<Cores> coresList1 = new List<Cores>();
        List<Cores> coresList2 = new List<Cores>();

        List<Tipos> tipos = new List<Tipos>();
        List<Marcas> marcas = new List<Marcas>();
        List<Modelos> modelos = new List<Modelos>();

        Aparelhos novoAparelho = new Aparelhos();

        Clientes cliente = new Clientes();


        public FormCadAp()
        {
            InitializeComponent();
            ClienteIndefinido();
            InicializacaoBase();
        }

        public FormCadAp(Clientes cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            ClienteSelecionado(cliente);
        }

        //---------------------------- Eventos DataGridView && BackGroundWorker -------------------------//

        //Faz o carregamento das Listas no Banco de dados
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            coresList1 = MetodosBd.GetCores();
            coresList2 = MetodosBd.GetCores();
            tipos = MetodosBd.GetTipos();
            marcas = MetodosBd.GetMarcas();
            modelos = MetodosBd.GetModelos();
        }

        //Aplica as listas aos controles
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cbCor1.DataSource = coresList1;
            cbCor2.DataSource = coresList2;
            cbTipo.DataSource = tipos;
            cbMarca.DataSource = marcas;
            cbModelo.DataSource = modelos;
            ApagaTextoComboBoxes();
        }

        //Pega o Cliente pesquisado e define seus dados para o aparelho a ser cadastrado
        private void dgPesq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vw_GridPrincipal cli = (Vw_GridPrincipal)dgPesq.Rows[0].DataBoundItem;
            cliente.IdCliente = cli.IdCliente;
            cliente.Nome = cli.Nome;
            dgPesq.Hide();
            ClienteSelecionado(cliente);
        }

        //---------------------------------------- Eventos TextBoxes --------------------------//

        private void tbCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLimpaCli_Click(btnLimpaCli, e);
            }
        }

        //------------------------------------------------ Eventos Botões -----------------------//

        //Faz com que Apenas uma CheckBox fique marcada por vez
        private void chbUrgencia_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbRevisao.Checked)
            {
                chbRevisao.Checked = false;
                chbUrgencia.Checked = true;
            }
        }

        //Faz com que Apenas uma CheckBox fique marcada por vez
        private void chbRevisao_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbUrgencia.Checked)
            {
                chbUrgencia.Checked = false;
                chbRevisao.Checked = true;
            }
        }

        //Aplica dois nomes e funções a um mesmo botão de acordo com o Case chamado
        private void btnLimpaCli_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            switch (btn.Name)
            {
                //Se o botão for de pesquisa, Então é chamado o metodo para pesquisar o cliente e alterado o botão
                case "btnPesq":
                    if (tbCli.Text.Trim() != string.Empty)
                    {
                        PesquisarCliente(dgPesq, true);
                        AlteraBtnPesq_Limpar(btn);
                    }
                    break;

                    //Se o botão for de limpar, então é removido o cliente
                case "btnLimpaCli":
                    PesquisarCliente(dgPesq, false);
                    ClienteIndefinido();
                    break;
            }
        }

        //Limpa os campos do pnAparelho
        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Cria um novo objeto para as Classes Aparelhos e Cores e chama seus respectivos metodos de Validacao
        //Se tudo for validado, é então feito o cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            novoAparelho = new Aparelhos
            {
                Id_Cliente = cliente.IdCliente,
                Id_Tipo = Convert.ToInt32(cbTipo.SelectedValue),
                Id_Marca = Convert.ToInt32(cbMarca.SelectedValue),
                Id_Modelo = Convert.ToInt32(cbModelo.SelectedValue),
                Id_Estado = (int)Estado.NFV,
                Tipo = cbTipo.Text.Trim(),
                Marca = cbMarca.Text.Trim(),
                Modelo = cbModelo.Text.Trim(),
                Entrada = dtpEntrada.Value,
                Observacao = tbObs.Text.Trim(),
                Problema = tbProblema.Text.Trim(),
                Urgencia = chbUrgencia.Checked,
                Revisao = chbRevisao.Checked
            };

            List<Cores> cores = new List<Cores>();

            cores.Add(new Cores { IdCor = Convert.ToInt32(cbCor1.SelectedValue), Cor = cbCor1.Text });
            cores.Add(new Cores { IdCor = Convert.ToInt32(cbCor2.SelectedValue), Cor = cbCor2.Text });

            if (ValidaCampos(novoAparelho, cores))
            {
                CadastrarTipoMarcaModelo(novoAparelho);
                //Se todas as Ids forem != 0, então é cadastrado o aparelho
                if (novoAparelho.ValidaIds(cbTipo, cbMarca, cbModelo, ep))
                {                                       
                    int idAp = MetodosBd.InsertAparelho(novoAparelho);
                    MetodosBd.InsertAparelho_Cor(cores, idAp);
                    novoAparelho.IdAparelho = idAp;
                    MessageBox.Show("Cadastro Finalizado!");
                    MessageBox.Show(novoAparelho.ToString());                    
                    CadNovoAparelho();
                }
                else
                {
                    PreencheComboBoxes(novoAparelho, cores);
                }
            }


        }

        //Chama o GroupBox gbNovaCor
        private void btnNovaCor_Click(object sender, EventArgs e)
        {
            gbNovaCor.Location = new Point(15, 85);
            gbNovaCor.Show();
        }

        //Fecha o GroupBox gbNovaCor
        private void btnCancelaNovaCor_Click(object sender, EventArgs e)
        {
            tbNovaCor.Clear();
            gbNovaCor.Hide();
        }
        //Adiciona uma nova Cor no Banco de Dados
        private void btnAddNovaCor_Click(object sender, EventArgs e)
        {
            MetodosBd.InsertCor(new Cores { Cor = tbNovaCor.Text.Trim() });
            MessageBox.Show("Cor Adicionada");
            coresList1 = MetodosBd.GetCores();
            coresList2 = MetodosBd.GetCores();
            cbCor1.DataSource = coresList1;
            cbCor2.DataSource = coresList2;
            cbCor1.Text = null;
            cbCor2.Text = null;
            gbNovaCor.Hide();
            tbNovaCor.Clear();
        }

        //----------------------------------------- Metodos ------------------------------------------------------------------//

        private void CadNovoAparelho()
        {
           DialogResult res = MessageBox.Show("","Deseja Cadastrar outro Aparelho para Este Cliente?", MessageBoxButtons.YesNo);
            switch (res)
            {     
                case DialogResult.Yes:
                    LimparCampos();                    
                    break;                
                default:
                    LimparCampos();
                    ClienteIndefinido();
                    break;
            }
        }

        //Seleciona o texto das comboBoxes com base nos Ids contidos no objeto Aparelhos
        private void PreencheComboBoxes(Aparelhos novoAparelho, List<Cores> cores)
        {
            cbTipo.SelectedValue = novoAparelho.Id_Tipo;
            cbMarca.SelectedValue = novoAparelho.Id_Marca;
            cbModelo.SelectedValue = novoAparelho.Id_Modelo;

            cbCor1.SelectedValue = cores[0].IdCor;
            cbCor2.SelectedValue = cores[1].IdCor;
        }

        //Chamado quando o Cliente é selecionado pelo DatagridView ou Pelo Construtor do FormCadAp
        private void ClienteSelecionado(Clientes cliente)
        {
            InicializacaoBase();
            lblCli.Text = "Nome Cliente";
            pnIdCliente.Show();
            tbIdCli.Text = cliente.IdCliente.ToString();
            tbCli.Text = cliente.Nome;
            tbCli.Enabled = false;
            tbIdCli.Enabled = false;
            pnAparelho.Show();

        }

        //Chamado quando o Cliente ainda não foi escolhido ou no Construtor Vazio deste Form
        private void ClienteIndefinido()
        {
            LimparCampos();
            lblCli.Text = "Pesquisar Cliente";
            pnIdCliente.Hide();
            pnAparelho.Hide();
            pnIdCliente.Hide();
            tbIdCli.Clear();
            tbCli.Clear();
            AlteraBtnPesq_Limpar(btnLimpaCli);
        }

        //Inicialização com recursos em comum para todas as inicializações
        private void InicializacaoBase()
        {
            backgroundWorker1.RunWorkerAsync();
            ConfiguraBoxesCores(cbCor1);
            ConfiguraBoxesCores(cbCor2);
            ConfiguraBoxesTipoMarcaModelo();
        }

        //Define o texto das ComboBoxes como null
        private void ApagaTextoComboBoxes()
        {
            cbTipo.Text = null;
            cbMarca.Text = null;
            cbModelo.Text = null;
            cbCor1.Text = null;
            cbCor2.Text = null;
        }

        //Altera o nome, icone e cor do btnLimpaCli para fazer um botão se comportar como dois
        private void AlteraBtnPesq_Limpar(IconButton btn)
        {
            switch (btn.Name)
            {
                case "btnPesq":
                    tbCli.Enabled = false;
                    btn.IconChar = IconChar.Times;
                    btn.IconColor = Color.Red;
                    btn.Name = "btnLimpaCli";
                    break;

                case "btnLimpaCli":
                    tbCli.Enabled = true;
                    btn.IconChar = IconChar.Search;
                    btn.IconColor = Color.White;
                    btn.Name = "btnPesq";
                    break;
            }
        }
        //Configura as ComboBoxes de cores
        private void ConfiguraBoxesCores(ComboBox cbCores)
        {
            cbCores.DisplayMember = "Cor";
            cbCores.ValueMember = "IdCor";
        }

        //Configura as ComboBoxes de Tipo, Marca e Modelo
        private void ConfiguraBoxesTipoMarcaModelo()
        {
            cbTipo.DisplayMember = "Tipo";
            cbTipo.ValueMember = "IdTipo";

            cbMarca.DisplayMember = "Marca";
            cbMarca.ValueMember = "IdMarca";

            cbModelo.DisplayMember = "Modelo";
            cbModelo.ValueMember = "IdModelo";
        }

        //Se visivel = true, então o grid fica visivel
        private void PesquisarCliente(DataGridView dataGrid, bool visivel)
        {
            int x = 0, y = 0;
            switch (visivel)
            {
                case true:
                    MetodosGridVwP metodosGrid = new MetodosGridVwP();
                    //Faço a pesquisa no Banco de Dados e Aplico o resultado no grid
                    metodosGrid.PesquisarCliente(dataGrid, tbCli.Text.Trim());

                    metodosGrid.ConfiguraGridPrincipal(dataGrid);

                    //Define os pontos X e Y do grid
                    x = pnPesquisa.Location.X + 200;
                    y = pnAparelho.Location.Y;
                    dataGrid.Location = new Point(x, y);
                    dataGrid.Show();
                    break;

                case false:
                    dataGrid.Hide();
                    break;
            }
        }

        //Limpa os Campos dos Controles do Panel pnAparelho
        private void LimparCampos()
        {
            dtpEntrada.Value = DateTime.Now;
            ApagaTextoComboBoxes();
            tbNovaCor.Clear();
            tbProblema.Clear();
            tbObs.Clear();
            chbRevisao.Checked = false;
            chbUrgencia.Checked = false;
            ep.Clear();
        }

        //Caso os Ids de Tipo ou Marca ou Modelo == 0, Então é cadastrado um novo Tipo ou Marca ou Modelo e Armazenado os Respectivos Ids
        private void CadastrarTipoMarcaModelo(Aparelhos novoAparelho)
        {
            if (novoAparelho.Id_Tipo == 0)
            {
                DialogResult res = MessageBox.Show("", "Deseja Cadastrar este Tipo de Aparelho?", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        novoAparelho.Id_Tipo = MetodosBd.InsertTipo(new Tipos { Tipo = novoAparelho.Tipo });
                        tipos = MetodosBd.GetTipos();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            if (novoAparelho.Id_Marca == 0)
            {
                DialogResult res = MessageBox.Show("", "Deseja Cadastrar esta Marca de Aparelho?", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        novoAparelho.Id_Marca = MetodosBd.InsertMarca(new Marcas { Marca = novoAparelho.Marca });
                        marcas = MetodosBd.GetMarcas();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            if (novoAparelho.Id_Modelo == 0)
            {
                DialogResult res = MessageBox.Show("", "Deseja Cadastrar este Modelo de Aparelho?", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        novoAparelho.Id_Modelo = MetodosBd.InsertModelo(new Modelos { Modelo = novoAparelho.Modelo });
                        modelos = MetodosBd.GetModelos();
                        break;
                    case DialogResult.No:
                        break;
                }
            }

        }
        //Faz a validação para as Classes Aparelhos e Cores
        private bool ValidaCampos(Aparelhos novoAparelho, List<Cores> cores)
        {
            Cores cor = new Cores();
            bool validado = true;
            //Faz a Validacao do Aparelho
            if (novoAparelho.ValidaNovoAparelho(cbTipo, cbMarca, cbModelo, tbObs, tbProblema, dtpEntrada, ep) == false)
            {
                validado = false;
            }
            //Faz a validação das cores
            if (cor.ValidaCor(cores, cbCor1, ep) == false)
            {
                validado = false;
            }

            return validado;
        }

        private void dgPesq_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = Convert.ToUInt64(e.Value).ToString(@"000\.000\.000\-00");
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString().Length == 11)
                {
                    e.Value = string.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
                else
                {
                    e.Value = string.Format("{0:(##) ####-####}", Convert.ToInt64(e.Value));
                }
            }
        }


    }
}
