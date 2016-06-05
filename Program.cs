using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *
 * Memory Game
 * Par Mélanie DUBREUIL et Ophélie EOUZAN, 3APP
 * Module ISI2
 * 
 */

namespace Memory
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMemoryGame());
        }
    }
}
