/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Punto de entrada de la aplicación (WinForms).
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-22
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            AutoMarketContexto contexto = new AutoMarketContexto();
            Application.Run(new FrmMenuPrincipal(contexto));
        }
    }
}