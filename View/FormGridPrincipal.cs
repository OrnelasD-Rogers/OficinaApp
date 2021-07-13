using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Entities;
using Business;
using System.ComponentModel;
using FontAwesome.Sharp;

namespace View
{
    public partial class FormGridPrincipal : Form
    {
        private List<Vw_GridPrincipal> toGridsList { get; set; } = new List<Vw_GridPrincipal>();
        private List<Vw_GridPrincipal> apvList { get; set; } = new List<Vw_GridPrincipal>();
        private List<Vw_GridPrincipal> napList { get; set; } = new List<Vw_GridPrincipal>();
        private List<Vw_GridPrincipal> dispList { get; set; } = new List<Vw_GridPrincipal>();

        MetodosGridVwP metodosGrid = new MetodosGridVwP();


        public FormGridPrincipal()
        {
            InitializeComponent();
            IniciaBackGroundWorker();
            
        }

        public void IniciaBackGroundWorker()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (tb_Pesquisa.Text.Trim() != "")            
                metodosGrid.PesquisarVw_GridPrincipal(dgHome, tb_Pesquisa.Text);      
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            IniciaBackGroundWorker();
            tb_Pesquisa.Clear();            
        }

        //Formatando a coluna 'Numero' do grid
        private void dgHome_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            metodosGrid.FormataTelefone_CellFormatting(dgHome, 3, e);            
        }

        private void dgHome_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            metodosGrid.RowPrePainting(dgHome, e, 11, 12);       
        }


        private void dgHome_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metodosGrid.Ordenar(dgHome, e.ColumnIndex);
        }

        private void tb_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btn_Pesquisar_Click(sender, e);
            }
        }



        private void dgHome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgHome.SelectedRows[0].Index;
            Vw_GridPrincipal aparelho = new Vw_GridPrincipal();
            aparelho = (Vw_GridPrincipal)dgHome.SelectedRows[0].DataBoundItem;
            FormAparelho frmAparelho = new FormAparelho(this, aparelho.IdAparelho);
            frmAparelho.Show();
        }

        private void DivideListaPrincipal(List<Vw_GridPrincipal> toGridPrincipals)
        {
            dispList.Clear();
            apvList.Clear();
            napList.Clear();
            foreach (Vw_GridPrincipal nt in toGridPrincipals)
            {                
                if (nt.Estado == Entities.Estado.NAP)
                {
                    TimeSpan dif = DateTime.Now.Date - nt.DataModificacao.Date;
                    if (dif.Days > 10)
                    {
                        napList.Add(nt);
                    }
                }
                if (nt.Estado == Entities.Estado.Aprovado)
                {
                    TimeSpan dif = DateTime.Now.Date - nt.DataModificacao.Date;
                    if (dif.Days > 20)
                    {
                        apvList.Add(nt);
                    }
                }
                if (nt.Estado == Entities.Estado.NFV || nt.Estado == Entities.Estado.Aguardando)
                {
                    dispList.Add(nt);
                }
            }
            //Configura as notificações de Aparelhos Aprovados
            ConfiguraBtnNotificacao(btnNotificacaoAprovado, apvList);
            //Configura as notificações de Aparelhos Não Aprovados
            ConfiguraBtnNotificacao(btnNotificacaoNap, napList);
        }

        private void ConfiguraBtnNotificacao(IconButton btnNotificacao, List<Vw_GridPrincipal> notificacaoList)
        {
            btnNotificacao.Text = notificacaoList.Count().ToString();
            if (btnNotificacao.Text != "0")
            {
                btnNotificacao.IconColor = Color.FromArgb(150, 33, 50);
                btnNotificacao.ForeColor = Color.FromArgb(150, 33, 50);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            toGridsList = MetodosBd.GetVw_GridPrincipal();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DivideListaPrincipal(toGridsList);
            dispList.OrderBy(x => x.Entrada);
            metodosGrid.ConfiguraGridPrincipal(dgHome);
            metodosGrid.FillDataGrid(dgHome, dispList);

        }

        private void btnNotificacaoAprovado_Click(object sender, EventArgs e)
        {
            metodosGrid.ConfiguraGridPrincipal(dgHome);
            apvList.OrderBy(x => x.Entrada);
            metodosGrid.FillDataGrid(dgHome, apvList);
        }

        private void btnNotificacaoNap_Click(object sender, EventArgs e)
        {
            metodosGrid.ConfiguraGridPrincipal(dgHome);
            napList.OrderBy(x => x.Entrada);
            metodosGrid.FillDataGrid(dgHome, napList);
        }

    }
}
