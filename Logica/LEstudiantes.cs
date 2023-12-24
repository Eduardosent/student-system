using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Data;
using LinqToDB;

namespace Logica
{
    public class LEstudiantes : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        //private Librarys librarys;
        //private object[] objetos;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //librarys = new Librarys();
            image = (PictureBox)objetos[0];
        }

        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "el campo Nid es requerido";
                listLabel[0].ForeColor = Color.Red;
                listLabel[0].Focus();
            }
            if (listTextBox[1].Text.Equals(""))
            {
                listLabel[1].Text = "el campo Nombre es requerido";
                listLabel[1].ForeColor = Color.Red;
                listLabel[1].Focus();
            }
            if (listTextBox[2].Text.Equals(""))
            {
                listLabel[2].Text = "el campo Apellido es requerido";
                listLabel[2].ForeColor = Color.Red;
                listLabel[2].Focus();
            }
            if (listTextBox[3].Text.Equals(""))
            {
                listLabel[3].Text = "el campo Email es requerido";
                listLabel[3].ForeColor = Color.Red;
                listLabel[3].Focus();
            }else if (textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
            {
                var user = _Estudiante.Where(u => u.email.Equals(listTextBox[3])).ToList();
                if (user.Count.Equals(0))
                {
                var imageArray = uploadImage.ImageToByte(image.Image);
                var db = new Conexion();
                db.Insert(new Estudiante()
                {
                    nid = listTextBox[0].Text,
                    nombre = listTextBox[1].Text,
                    apellido = listTextBox[2].Text,
                    email = listTextBox[3].Text,
                    image = imageArray
                });
                }
                else
                {
                    listLabel[3].Text = "Email ya esta registrado";
                    listLabel[3].ForeColor = Color.Red;
                    listLabel[3].Focus();
                }
                /*_Estudiante.Value(e => e.nid, listTextBox[0].Text)
                    .Value(e => e.nombre, listTextBox[1].Text)
                    .Value(e => e.apellido, listTextBox[2].Text)
                    .Value(e => e.email, listTextBox[3].Text)
                    .Insert();*/
            }
            else
            {
                listLabel[3].Text = "Email no valido";
                listLabel[3].ForeColor = Color.Red;
                listLabel[3].Focus();
            }
        }
    }
}
