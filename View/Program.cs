using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
            UpdateApp();
        }

        private static async Task  UpdateApp()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/OrnelasD-Rogers/OficinaApp"))
            {
                await mgr.Result.UpdateApp();
            }
        }

    }
}
