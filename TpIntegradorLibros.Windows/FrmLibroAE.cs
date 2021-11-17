using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIntegradorLibros.Datos;
using TpIntegradorLibros.Entidades;
using Editorial = TpIntegradorLibros.Entidades.Editorial;
using Tema = TpIntegradorLibros.Entidades.Tema;


namespace TpIntegradorLibros.Windows
{
    public partial class FrmLibroAE : Form
    {
        public FrmLibroAE()
        {
            InitializeComponent();
        }

        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditorial(ref EditorialCB);
            CargarDatosComboTema(ref TemaCB);
            if (libro != null)
            {
                NombreLibroTB.Text = libro.NombreDelLibro;
                EditorialCB.SelectedItem = libro.Editorial;
                TemaCB.SelectedItem = libro.Tema;
                PaginasNum.Value = libro.Paginas;
                ISBNtb.Text = libro.ISBN.ToString();
                AutorTB.Text = libro.Autor;

            }
        }

        public Libro GetLibro()
        {
            return libro;
        }


        private void CargarDatosComboEditorial(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Editorial));
        }

        private void CargarDatosComboTema(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Tema));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private Libro libro;
        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libro == null)
                {
                    libro = new Libro();
                }

                libro.NombreDelLibro = NombreLibroTB.Text;
                libro.Editorial = (Editorial)EditorialCB.SelectedItem;
                libro.Tema = (Tema)TemaCB.SelectedItem;
                libro.Paginas = (int)PaginasNum.Value;
                libro.ISBN = (long) long.Parse(ISBNtb.Text);
                libro.Autor = AutorTB.Text;

                DialogResult = DialogResult.OK;

                if (RepositorioDeLibros.GetInstancia().Existe(libro))
                {
                    errorProvider1.SetError(ISBNtb, "Libro repetido!");
                    return;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void SetLibro(Libro libro)
        {
            this.libro = libro;

        }
    }
}
