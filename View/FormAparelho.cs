using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using Entities;
using Business;
using Business.Faturamento;


namespace View
{
    public partial class FormAparelho : Form
    {
        MetodosGridVwP metodosGrid = new MetodosGridVwP();

        Vw_AparelhoInfo AparelhoInfo = new Vw_AparelhoInfo();
        List<Vw_GridPrincipal> vwGridPrincipalList = new List<Vw_GridPrincipal>();
        public FormGridPrincipal frmGridPrincipal = new FormGridPrincipal();
        List<Produtos> ItensList = new List<Produtos>();
        List<Vw_Contatos> contatos = new List<Vw_Contatos>();
        List<Tecnicos> tecnicos = new List<Tecnicos>();

        int idAparelho;
        private double aPagar { get; set; }

        public FormAparelho()
        {
            InitializeComponent();
            Inicializacao();
        }

        public FormAparelho(FormGridPrincipal frmGP, int idAparelho)
        {
            this.DoubleBuffered = true;
            this.idAparelho = idAparelho;
            frmGridPrincipal = frmGP;
            InitializeComponent();
            Inicializacao();

        }

        //------------------------------------   Drag Form   ----------------------------------------//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //----------------------------------- Eventos Botões --------------------------------//

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditarObs_Click(object sender, EventArgs e)
        {
            EdicaoBoxes(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aparelhos apEditado = new Aparelhos
            {
                IdAparelho = idAparelho,
                Id_Tecnico = Convert.ToInt32(cbTecnico.SelectedValue),
                Problema = tbProblema.Text.Trim(),
                Observacao = tbObservacao.Text.Trim(),
                Orcamento = tbOrc.Text.Trim(),
                Urgencia = chbUrgencia.Checked,
                Revisao = chbRevisao.Checked,
            };

            if (apEditado.ValidaIdTec(cbTecnico, ep))
            {
                MetodosBd.UpdateAparelho(apEditado);
                EdicaoBoxes(false);
                Inicializacao();
            }
        }


        //------------------------------------   Eventos DataGrid  ----------------------------------------//

        private void dgHome_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            metodosGrid.RowPrePainting(dgHome, e, 9, 10);
        }

        private void dgHome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgHome.Rows.Count > 0)
            {
                Vw_GridPrincipal novoAp = new Vw_GridPrincipal();
                novoAp = (Vw_GridPrincipal)dgHome.Rows[0].DataBoundItem;
                idAparelho = novoAp.IdAparelho;
                Inicializacao();
                ChamaBackGroundWorker(bgwTabAparelhos);
            }

        }

        private void dgContatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            metodosGrid.FormataTelefone_CellFormatting(dgHome, 1, e);
        }

        //------------------------------------   Outros Eventos  ----------------------------------------//

        private void chbUrgencia_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbRevisao.Checked)
            {
                chbRevisao.Checked = false;
                chbUrgencia.Checked = true;
            }
        }

        private void chbRevisao_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbUrgencia.Checked)
            {
                chbUrgencia.Checked = false;
                chbRevisao.Checked = true;
            }
        }

        private void chbUrgencia_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AparelhoInfo.Estado == Entities.Estado.NFV || AparelhoInfo.Estado == Entities.Estado.Aguardando)
            {
                chbRevisao.Enabled = true;
                chbUrgencia.Enabled = true;
            }
            else
            {
                chbRevisao.Enabled = false;
                chbUrgencia.Enabled = false;
            }
        }

        private void tabAparelhoInfos_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    if (!bgwTabContatos.IsBusy)
                        bgwTabContatos.RunWorkerAsync();
                    break;
                case 1:
                    if (!bgwTabAparelhos.IsBusy)
                        bgwTabAparelhos.RunWorkerAsync();
                    break;

            }
        }

        //------------------------------------      Metodos      ----------------------------------------//
        private void ChamaBackGroundWorker(BackgroundWorker worker)
        {
            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void AddFormFilho(Form form, Control controlePai)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            controlePai.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        public void Inicializacao()
        {
            ChamaBackGroundWorker(bgwPadrao);
            ChamaBackGroundWorker(bgwTabContatos);
        }

        private void LimparCampos()
        {
            tbEntrada.Clear();
            tbSaida.Clear();
            tbEstado.Clear();
            tbTipo.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
            tbCor.Clear();
            tbProblema.Clear();
            tbOrc.Clear();
            tbObservacao.Clear();
            cbTecnico.Text = null;
            chbRevisao.Checked = false;
            chbUrgencia.Checked = false;
        }

        private void EdicaoBoxes(bool editar)
        {
            tbEntrada.Enabled = !editar;
            tbSaida.Enabled = !editar;
            tbEstado.Enabled = !editar;
            tbTipo.Enabled = !editar;
            tbMarca.Enabled = !editar;
            tbModelo.Enabled = !editar;
            tbCor.Enabled = !editar;

            tbProblema.ReadOnly = !editar;
            tbOrc.ReadOnly = !editar;
            tbObservacao.ReadOnly = !editar;
            cbTecnico.Enabled = editar;

            chbRevisao.Enabled = editar;
            chbUrgencia.Enabled = editar;

            btnEditar.Enabled = !editar;
            btnSalvar.Enabled = editar;
        }

        private void PreencheBoxes(Vw_AparelhoInfo aparelhoInfo)
        {
            LimparCampos();
            lblIdAp.Text = "Id Aparelho: " + Convert.ToString(aparelhoInfo.IdAparelho);
            lblCli.Text = "Cliente: " + aparelhoInfo.Nome;
            tbEntrada.Text = Convert.ToString(aparelhoInfo.Entrada);
            tbSaida.Text = Convert.ToString(aparelhoInfo.Saida);
            tbTipo.Text = aparelhoInfo.Tipo;
            tbMarca.Text = aparelhoInfo.Marca;
            tbModelo.Text = aparelhoInfo.Modelo;
            tbEstado.Text = aparelhoInfo.Estado.ToString();
            tbProblema.Text = aparelhoInfo.Problema;
            tbObservacao.Text = aparelhoInfo.Observacao;

            tbCor.Text = AparelhoInfo.Cor;
            cbTecnico.Text = aparelhoInfo.NomeTecnico;
            chbRevisao.Checked = aparelhoInfo.Revisao;
            chbUrgencia.Checked = aparelhoInfo.Urgencia;
        }

        private void ConfiguraTecnicos()
        {
            cbTecnico.DataSource = tecnicos;
            cbTecnico.DisplayMember = "NomeTecnico";
            cbTecnico.ValueMember = "IdTecnico";
            cbTecnico.SelectedValue = AparelhoInfo.IdTecnico;
        }

        private double CalculaValorAPAgar(FaturarItens faturarItens)
        {
            double val2Pay = 0;
            if (AparelhoInfo.Estado == Entities.Estado.Aguardando 
                || AparelhoInfo.Estado == Entities.Estado.Aprovado 
                || AparelhoInfo.Estado == Entities.Estado.NFV)
            {
                val2Pay = faturarItens.ValorAPagar();
            }            
            return val2Pay;
        }


        private void PreencheListView(List<Produtos> itens)
        {
            lvItens.Items.Clear();
            ConfiguraListView();
            //Faz o somatório total dos valores 
            FaturarItens faturarItens = new FaturarItens(ItensList);
            double total = faturarItens.ValorTotal();
            aPagar = CalculaValorAPAgar(faturarItens);
            double pago = faturarItens.ValorPago();
            //Adiciona uma linha no ListView para cada objeto da lista
            foreach (Produtos it in itens)
            {
                if (it.Produto != "Pagamento" && it.ValorVenda != 0)
                {
                    it.CalculcaSubTotal();
                    string[] item = { it.Produto, it.ValorVenda.ToString("C2"), it.Quantidade.ToString(), it.SubTotal.ToString("C2") };
                    var itemLine = new ListViewItem(item);
                    lvItens.Items.Add(itemLine);
                }
            }
            //Add uma linha em branco
            var blankLine = new ListViewItem("");
            lvItens.Items.Add(blankLine);

            //Add o Somatorio total dos valores
            string[] totais = { "Valor Total :", "Valor Pago :", "Valor à Pagar :" };
            string[] valTotais = { total.ToString("C2"), pago.ToString("C2"), aPagar.ToString("C2") };
            Color[] colors = { Color.Black, Color.Green, Color.Red };

            for (int i = 0; i < totais.Length; i++)
            {
                string[] item = { totais[i], "", "", valTotais[i] };
                var lvTotal = new ListViewItem(item);
                lvTotal.ForeColor = colors[i];
                lvItens.Items.Add(lvTotal);
            }
        }

        private void ConfiguraListView()
        {
            lvItens.Columns[0].Width = 170;
            lvItens.Columns[1].Width = 80;
            lvItens.Columns[2].Width = 50;
            lvItens.Columns[3].Width = 80;
        }

        public void ChamaMessageBoxOk(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public DialogResult ChamaMessageBoxYesNo(string mensagem)
        {
            return MessageBox.Show("", mensagem, MessageBoxButtons.YesNo);
        }

        private void ConfiguraGridContatos()
        {
            dgContatos.AutoGenerateColumns = false;
            dgContatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgContatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void AtualizarGridContatos()
        {
            MetodosDataGrid metodosDataGrid = new MetodosDataGrid();
            metodosDataGrid.FillDataGrid(dgContatos, contatos);
            dgContatos.Refresh();
        }

        private void TravaControles(Vw_AparelhoInfo aparelhoInfo)
        {
            btnEditar.Enabled = false;
            btnAddContato.Enabled = false;
            btnEditarContato.Enabled = false;
            btnEditarItens.Enabled = false;
            btnAddItens.Enabled = false;
            btnAdiantamento.Enabled = false;
            btnSaidaAp.Enabled = false;

            switch (aparelhoInfo.Estado)
            {
                case Entities.Estado.NFV:

                    btnEditar.Enabled = true;
                    btnAddContato.Enabled = true;
                    btnEditarContato.Enabled = true;
                    btnEditarItens.Enabled = true;
                    btnAddItens.Enabled = true;
                    btnAdiantamento.Enabled = true;
                    break;

                case Entities.Estado.Aprovado:

                    btnEditar.Enabled = true;
                    btnAddContato.Enabled = true;
                    btnEditarContato.Enabled = true;
                    btnEditarItens.Enabled = true;
                    btnAddItens.Enabled = true;
                    btnAdiantamento.Enabled = true;
                    btnSaidaAp.Enabled = true;
                    break;

                case Entities.Estado.Aguardando:

                    btnEditar.Enabled = true;
                    btnAddContato.Enabled = true;
                    btnEditarContato.Enabled = true;
                    btnEditarItens.Enabled = true;
                    btnAddItens.Enabled = true;
                    btnAdiantamento.Enabled = true;
                    break;

                case Entities.Estado.NAP:
                    btnEditar.Enabled = true;
                    btnSaidaAp.Enabled = true;
                    break;
                default:
                    btnEditar.Enabled = false;
                    btnAddContato.Enabled = false;
                    btnEditarContato.Enabled = false;
                    btnEditarItens.Enabled = false;
                    btnAddItens.Enabled = false;
                    btnAdiantamento.Enabled = false;
                    btnSaidaAp.Enabled = false;
                    break;
            }
        }

        //-------------------------------- BackGround Workers ---------------------------------//



        /// ////////// bgwPadrao

        private void bgwPadrao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            AparelhoInfo = MetodosBd.GetAparelhoInfosByIdAparelho(idAparelho);
            ItensList = MetodosBd.GetItensByIdAp(idAparelho);
            tecnicos = MetodosBd.GetTecnicos();

        }



        private void bgwPadrao_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheListView(ItensList);
            PreencheBoxes(AparelhoInfo);
            TravaControles(AparelhoInfo);
            ConfiguraTecnicos();
        }

        /// ////////// bgwTabContatos


        private void bgwTabContatos_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            contatos = MetodosBd.GetContatosByIdAp(idAparelho);
        }

        private void bgwTabContatos_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ConfiguraGridContatos();
            AtualizarGridContatos();
        }

        /// ////////// bgwTabAparelhos

        private void bgwTabAparelhos_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            vwGridPrincipalList = MetodosBd.GetVw_GridPrincipalByIdCli(AparelhoInfo.IdCliente);
        }

        private void bgwTabAparelhos_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Vw_GridPrincipal vw_Grid = new Vw_GridPrincipal();
            vw_Grid = vwGridPrincipalList.Where(x => x.IdAparelho == AparelhoInfo.IdAparelho).Select(x => x).FirstOrDefault();
            vwGridPrincipalList.Remove(vw_Grid);


            MetodosGridVwP metodosGridP = new MetodosGridVwP();
            metodosGridP.ConfiguraGridPrincipal(dgHome);
            metodosGridP.FillDataGrid(dgHome, vwGridPrincipalList);
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            dgContatos.SuspendLayout();
            AddFormFilho(new FormContato(AparelhoInfo.IdAparelho, AparelhoInfo.IdCliente, tecnicos, this), tabContatos);
        }

        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            if (dgContatos.Rows.Count > 0)
            {
                dgContatos.SuspendLayout();
                Vw_Contatos editContato = (Vw_Contatos)dgContatos.Rows[0].DataBoundItem;
                AddFormFilho(new FormContato(editContato, this), tabContatos);
            }

        }

        private void lblIdAp_Click(object sender, EventArgs e)
        {

        }


        private void btnAdiantamento_Click(object sender, EventArgs e)
        {
            AddFormFilho(new FormPagamento(this, AparelhoInfo), pnPagamento);
        }

        private void btnSaidaAp_Click(object sender, EventArgs e)
        {
            AddFormFilho(new FormPagamento(this, AparelhoInfo, aPagar), pnPagamento);
        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            FormItens formItens = new FormItens(this, idAparelho);
            formItens.ShowDialog();
        }

        private void btnEditarItens_Click(object sender, EventArgs e)
        {
            FormItens formItens = new FormItens(this, ItensList, idAparelho);
            formItens.ShowDialog();
        }

        private void lblCli_Click(object sender, EventArgs e)
        {
            pnItens.Hide();
            AddFormFilho(new FormCadCli(this, AparelhoInfo.IdCliente), this);            
        }


    }
}
