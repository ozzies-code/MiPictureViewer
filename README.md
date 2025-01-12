# Titulo del Proyecto: MiPictureViewer 

 Este proyecto consiste en usar el objeto PicMostrarImagen para cargar 
 una imagen en el cuadro de imagen y colocar la direccion relativa 
 de la ruta de la imagen como titulo del formulario

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 la importacion de imagenes que seran afectadas por medio del objeto
 PictureBox que emplea un filtro para buscar una imagen en formato
 BMP o JPEG en una carpeta local y al cargarla en cuadro de imagen se
 muestra en el cuadro de imagen y en el titulo del formulario se muestra
 la ruta relativa de la carpeta donde esta la imagen seleccionada.
 
 # Actualizacion: 12/01/2025
 # Hora: 12:47

Detalles técnicos del proyecto:
Idioma: Visual C#.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo de imágenes a través del objeto PictureBox
- Manejo del filtro de formato de archivo
- Manejo de rutas relativas de una carpeta local

## Proyectos Relacionados

A continuación se muestran algunos proyectos relacionados

[Awesome README](https://github.com/ozzies-code/VisorImagenesVb4/blob/main/README.md)

## image of the Project

![imagen](https://github.com/user-attachments/assets/7f8b0e2a-ee1e-4b8a-afe1-76d4693a2570)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual C#.NET

Codigo del Proyecto:

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
