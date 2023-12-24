using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante;
        private Librarys librarys;
        public Form1()
        {
            InitializeComponent();

            librarys = new Librarys();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNid);
            listTextBox.Add(textBoxName);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);
            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelName);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            Object[] objetos = { pictureBoxImage };
            estudiante = new LEstudiantes(listTextBox,listLabel,objetos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadImage.cargarImagen(pictureBoxImage);
        }

        private void TextBoxNid_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text= "Nid ";
            }

        }

        private void TextBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                labelName.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Nombre ";
            }

        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido ";
            }

        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email ";
            }

        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }
    }
}
