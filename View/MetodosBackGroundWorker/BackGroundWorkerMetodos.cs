using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace View.MetodosBackGroundWorker
{
    public static class BackGroundWorkerMetodos
    {
        public static void ChamaBackGroundWorker (BackgroundWorker worker)
        {
            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
    }
}
