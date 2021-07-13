using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entities
{
    public class ValidaRegex
    {
        Regex regexNome = new Regex(@"[^\w\s]|\d|\s{2,}", RegexOptions.None, TimeSpan.FromSeconds(1.5));

        public bool ValidaNome(string nome)
        {
            return regexNome.IsMatch(nome);     
        }

    }
}
