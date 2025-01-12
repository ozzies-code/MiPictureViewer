using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectedPicture_Click(object sender, EventArgs e)
        {
            //Mostrar el cuadro de diálogo para seleccionar una imagen

        if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                //Mostrar el cuadro de dialogo Abrir Archivo
                PicMostrarImagen.Image = Image.FromFile(ofdSelectPicture.FileName);
                //Mostrar el nombre del archivo como titulo del formulario
                this.Text = string.Concat("Visor de Imagenes(" + ofdSelectPicture.FileName + ")");
            }
           
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {   //Cerrar la Ventana y Salir de la aplicacion.
            this.Close();
        }
    }
}