using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Clientes : Validacao
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCad { get; set; }

        //VALIDAÇÕES
        public bool ValidaCliente(TextBox tbNome, ComboBox cbSexo, MaskedTextBox mtbCpf, List<Clientes> clientes, ErrorProvider ep)
        {
            ValidaNome(tbNome, ep);
            ValidaSexo(cbSexo, ep);
            ValidaCpf(clientes, mtbCpf, ep);
            return ValidaObj();
        }

        public bool ValidaClienteEdicao(TextBox tbNome, ComboBox cbSexo, MaskedTextBox mtbCpf, ErrorProvider ep)
        {
            ValidaNome(tbNome, ep);
            ValidaSexo(cbSexo, ep);
            ValidaCpfEdicao(mtbCpf, ep);
            return ValidaObj();
        }

        private void ValidaSexo(ComboBox cbSexo, ErrorProvider ep)
        {
            if (cbSexo.Text == null)
            {
                ep.SetError(cbSexo, "Entre com o Sexo do Cliente");
                erros.Add(false);
            }
            else
            {
                ep.SetError(cbSexo, "");
            }
        }

        private void ValidaCpf(List<Clientes> clientes, MaskedTextBox mtb, ErrorProvider ep)
        {
            if (CpfValido(this.Cpf))
            {
                bool cpfExistente = clientes.Where(x => x.Cpf == this.Cpf).Select(x => x).Any();
                if (cpfExistente)
                {
                    ep.SetError(mtb, "Cpf já Cadastrado!");
                    erros.Add(false);
                }
                else
                {
                    ep.SetError(mtb, "");
                }

            }
            else
            {
                ep.SetError(mtb, "CPF Inválido");
                erros.Add(false);
            }
        }

        private void ValidaCpfEdicao(MaskedTextBox mtb, ErrorProvider ep)
        {
            if (CpfValido(this.Cpf))
            {
                ep.SetError(mtb, "");
            }
            else
            {
                ep.SetError(mtb, "CPF Inválido");
                erros.Add(false);
            }
        }

        private void ValidaNome(TextBox tbNome, ErrorProvider ep)
        {
            ValidaRegex reg = new ValidaRegex();
            if (reg.ValidaNome(this.Nome))
            {
                ep.SetError(tbNome, "Nome Inválido");
                erros.Add(false);
            }
            if (tbNome.Text == string.Empty)
            {
                ep.SetError(tbNome, "Digite o Nome do Cliente");
                erros.Add(false);
            }
            else
            {
                ep.SetError(tbNome, "");
            }
        }




    }
}
