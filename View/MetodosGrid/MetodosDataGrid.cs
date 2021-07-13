using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class MetodosDataGrid
    {
        //Ativa o doubleBuffered no DataGrid
        protected void SetDoubleBufferingOn(DataGridView dg)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dg, new object[] { true });
        }

        public void FillDataGrid(DataGridView dg, object list)
        {
            dg.DataSource = null;
            dg.AutoGenerateColumns = false;
            dg.DataSource = list;
            dg.Refresh();
            dg.Update();
        }
    }
}
