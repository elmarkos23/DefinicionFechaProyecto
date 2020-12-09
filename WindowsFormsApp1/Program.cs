using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  static class Program
  {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //aqui declaramos para todo el programa la fecha y cultura que se va a utilizar
      CultureInfo culture = new CultureInfo("es-EC");
      culture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
      culture.DateTimeFormat.LongDatePattern = "dd-MM-yyyy HH:mm:ss";
      culture.DateTimeFormat.ShortTimePattern = "HH:mm";
      culture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
      culture.NumberFormat.NumberDecimalSeparator = ".";
      Thread.CurrentThread.CurrentCulture = culture;
      //inicio de programa
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
