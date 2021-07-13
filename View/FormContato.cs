using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Entities;
using Business;

namespace View
{
    public partial class FormContato : Form
    {
        List<Telefones> telefones = new List<Telefones>();
        List<Tecnicos> tecnicos;
        int idAparelho;
        int idCliente;
        FormAparelho formAparelho;
        Vw_Contatos vw_Contatos;
        public FormContato(int idAparelho, int idCliente, List<Tecnicos> tecnicos, FormAparelho formAparelho)
        {            
            InitializeComponent();
            this.idAparelho = idAparelho;
            this.idCliente = idCliente;
            this.tecnicos = tecnicos;
            this.formAparelho = formAparelho;
            bgwIni.RunWorkerAsync();
        }
        public FormContato(Vw_Contatos vw_Contatos, FormAparelho formAparelho)
        {
            InitializeComponent();
            this.vw_Contatos = vw_Contatos;
            this.formAparelho = formAparelho;
            btnSalvarContato.Text = "Editar Contato";
            PreencherEdicao(vw_Contatos);
        }

        private void PreencheComboBox(object list, ComboBox comboBox, string valueMember, string displayMember)
        {
            comboBox.DataSource = list;
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
        }

        private void PreencherEdicao(Vw_Contatos vw_Contatos)
        {
            tbDialogo.Text = vw_Contatos.Dialogo;
            cbTipoContato.Text = vw_Contatos.Tipo;
            cbNumero.Text = vw_Contatos.Numero;
            cbContatante.Text = vw_Contatos.NomeTecnico;
            cbStatusContato.Text = vw_Contatos.StatusLig;
            cbEstado.Text = vw_Contatos.Estado.ToString();

            tbDialogo.Enabled = true;
            cbTipoContato.Enabled = false;
            cbNumero.Enabled = false;
            cbContatante.Enabled = false;
            cbStatusContato.Enabled = false;
            cbEstado.Enabled = false;
        }

        private void SalvaEdicaoContato(Vw_Contatos vw_Contatos)
        {
            if (tbDialogo.Text.Trim() != string.Empty)
            {
                MetodosBd.UpdateDialogoContato(vw_Contatos.IdContato, tbDialogo.Text.Trim());
                formAparelho.Inicializacao();
                this.Close();
                formAparelho.dgContatos.ResumeLayout();
            }
            
        }




        private void AddContato(Contatos contato)
        {
            MetodosBd.InsertContato(contato);
            MetodosBd.UpdateAparelhoDataModificacao(idAparelho, contato.Id_Estado, DateTime.Now);
            formAparelho.Inicializacao();
            this.Close();
            formAparelho.dgContatos.ResumeLayout();
        }

        private int? RetornaIdTel(ComboBox cbNumero)
        {
            int? idTel = Convert.ToInt32(cbNumero.SelectedValue);
            if (idTel == 0)
            {
                return null;
            }
            else
            {
                return idTel;
            }
        }

        private void NovoContato()
        {
           
            Contatos contato = new Contatos
            {
                
                DataContato = DateTime.Now,
                IdTecnico = Convert.ToInt32(cbContatante.SelectedValue),
                Id_Telefone = RetornaIdTel(cbNumero),
                Id_Aparelho = idAparelho,
                Tipo = cbTipoContato.Text,
                Dialogo = tbDialogo.Text,
                StatusLig = cbStatusContato.Text,
                Id_Estado = Convert.ToInt32(Enum.Parse(typeof(Estado), cbEstado.Text))
            };
            switch (cbTipoContato.Text)
            {
                case "Presencial":
                    if (contato.ValidaContatoPresencial(cbContatante, cbEstado, cbTipoContato, tbDialogo, ep))
                    {
                        AddContato(contato);
                    }
                    break;
                default:
                    if (cbTipoContato.SelectedIndex == 0)
                    {
                        contato.StatusLig = "Mensagem";
                    }
                    if (contato.ValidaContato(cbContatante, cbEstado, cbTipoContato, cbNumero, cbStatusContato, tbDialogo, ep))
                    {
                        AddContato(contato);
                    }
                    break;
            }
        }

        private void bgwIni_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            telefones = MetodosBd.GetTelefonesByIdCli(idCliente);
        }

        private void bgwIni_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheComboBox(telefones, cbNumero, "IdTelefone", "Numero");
            PreencheComboBox(tecnicos, cbContatante, "IdTecnico", "NomeTecnico"); 
            string[] estados = Enum.GetNames(typeof(Estado));            
            cbEstado.DataSource = new string[] { estados[0], estados[1], estados[2], estados[3] };
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {            
            this.Close();
            formAparelho.dgContatos.ResumeLayout();  
        }



        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            switch (btnSalvarContato.Text)
            {
                case "Adicionar Contato":
                    NovoContato();
                    break;
                default:
                    SalvaEdicaoContato(vw_Contatos);
                    break;
            }
            

        }

        private void cbTipoContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipoContato.SelectedIndex)
            {
                case 0:                    
                    cbStatusContato.Enabled = false;
                    cbStatusContato.Text = "Mensagem";
                    break;
                case 2:
                    cbNumero.Text = null;
                    cbNumero.Enabled = false;
                    cbStatusContato.Text = null;
                    cbStatusContato.Enabled = false;
                    break;
                
                default:
                    cbNumero.Enabled = true;
                    cbStatusContato.Text = "";
                    cbStatusContato.Enabled = true;
                    break;
            }  

        }
    }
}
