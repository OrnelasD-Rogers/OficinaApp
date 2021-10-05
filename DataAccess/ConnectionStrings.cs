using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal static class ConnectionStrings
    {
        public static String OficinaAppTeste { get; } = @"Data Source=tcp:DbOficina\ORNELASTEC,49500;Initial Catalog=OficinaAppTeste;User ID=OficinaUser;Password=oficinadoesculacho";
        public static String OficinaApp { get; } = @"Data Source=tcp:DbOficina\ORNELASTEC,49500;Initial Catalog=OficinaApp;User ID=OficinaUser;Password=oficinadoesculacho";
        public static String Vendas { get; } = @"Data Source=tcp:DbOficina\ORNELASTEC,49500;Initial Catalog=VendasOficina;User ID=OficinaUser;Password=oficinadoesculacho";
        public static String VendasTeste { get; } = @"Data Source=tcp:DbOficina\ORNELASTEC,49500;Initial Catalog=VendasOficinaTeste;User ID=OficinaUser;Password=oficinadoesculacho";
    }
}
