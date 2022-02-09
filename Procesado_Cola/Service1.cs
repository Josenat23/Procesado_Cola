using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesado_Cola
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           

        }


        protected override void OnStop()
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string ruta_carpeta = "C:/Ordenes/ordenes1.csv";
           
            try
            {
                var readcsv = File.ReadAllText(ruta_carpeta);
                string[] csvfilerecord = readcsv.Split('\n');

                foreach (var row in csvfilerecord)
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        var cells = row.Split(',');
                        Console.WriteLine(cells[3]);
                    }
                }
                //ta_Cola.Añadir_Orden();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Enabled = false;

            }
            
        }
    }
}
