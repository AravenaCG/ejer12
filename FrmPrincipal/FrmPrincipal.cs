using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBuscarFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fBDialog.ShowDialog();
            if ( result == DialogResult.OK) 
            {
            txtDireccion.Text= fBDialog.SelectedPath;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
          
                
                string[] dirs = Directory.GetFiles(txtDireccion.Text, "*.xml");
               
                foreach (string dir in dirs)
                {
                    MessageBox.Show(dir);
                }

                foreach (string dir in dirs)
                {
                    Thread serializar = new Thread(new ParameterizedThreadStart(Alumno.Serializanding));
                    serializar.Start(dir);
                    
                }


        }
    }
}
