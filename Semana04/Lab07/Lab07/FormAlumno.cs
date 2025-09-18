using Lab07.entities;
using Lab07.repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FormAlumno : Form
    {
        private AlumnoController alumnoController = new AlumnoController();

        public FormAlumno()
        {
            InitializeComponent();
        }

        private void MostrarAlumnosEnDataGrid(List<Alumno> alumnos)
        {
            dgAlumnos.DataSource = null;

            if (alumnos.Count != 0)
            {
                dgAlumnos.DataSource = alumnos;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (textBoxNombre.Text == "" || textBoxDni.Text == "" || textBoxEdad.Text == "")
            {
                MessageBox.Show("Ingrese campos");
                return;
            }

            // Creación del objeto
            Alumno alumno = new Alumno()
            {
                Nombre = textBoxNombre.Text,
                Dni = textBoxDni.Text,
                Edad = int.Parse(textBoxEdad.Text)
            };

            // Agrega a la lista
            alumnoController.Registrar(alumno);

            // Mostrar en ListView
            MostrarAlumnosEnDataGrid(AlumnoController.ListarTodo());
            LimpiarCampos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione alumno");
                return;
            }

            DataGridViewRow fila = dgAlumnos.CurrentRow;
            int codigo = int.Parse(fila.Cells["Codigo"].Value.ToString());
            alumnoController.Eliminar(codigo);

            // Mostrar en ListView
            MostrarAlumnosEnDataGrid(AlumnoController.ListarTodo());
            LimpiarCampos();
        }

        private void dgAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count != 0)
            {
                DataGridViewRow fila = dgAlumnos.CurrentRow;

                textBoxCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                textBoxNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textBoxDni.Text = fila.Cells["Dni"].Value.ToString();
                textBoxEdad.Text = fila.Cells["Edad"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxDni.Clear();
            textBoxEdad.Clear();
        }
    }
}
