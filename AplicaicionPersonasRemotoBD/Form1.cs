using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace AplicaicionPersonasRemotoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (ClaseFunciones.Func_Conectar())
            {
                MessageBox.Show("Conectado a SQL Server Remoto", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Excepcion: " + ClaseFunciones.excepcion);
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y la tecla Backspace (borrar)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClaseFunciones.Func_TraerDatos();
            //muestro el datatable en datagrid
            DgvPersonas.DataSource = dt;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //habilito los texbox
            TxtID.Enabled = true;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;
            //limpiar textbox
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            //habilito el guarda y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            //deshabilito los demas botones
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            //mando el foco al txtID
            TxtID.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //deshabilito los texbox
            TxtID.Enabled = false;
            TxtNombre.Enabled = false;
            TxtTelefono.Enabled = false;
            //limpiar textbox
            TxtID.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            //deshabilito el guardar y cancelar
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            //habilito los demas botones
            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnSalir.Enabled = true;
            //mando el foco
            BtnNuevo.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //creo un dialog result    
            DialogResult Rpta = new DialogResult();
            Rpta = MessageBox.Show("Desea Salir de la Aplicacion ?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Rpta == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //valido que usuario llene los datos
            if (TxtID.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTelefono.Text.Length > 0)
            {
                //Inserta cuando el TextBox id esta habilitado.
                if (TxtID.Enabled == true)
                {
                    if (ClaseFunciones.Func_Insertar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Guardada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro el datatable en datagrid
                        DgvPersonas.DataSource = dt;
                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {

                        MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Editar
                else
                {
                    if (ClaseFunciones.Func_Editar(Convert.ToInt64(TxtID.Text), TxtNombre.Text, TxtTelefono.Text))
                    {
                        MessageBox.Show("Persona Editada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = new DataTable();
                        dt = ClaseFunciones.Func_TraerDatos();
                        //muestro el datatable en datagrid
                        DgvPersonas.DataSource = dt;
                        BtnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //capturo el id del datagrid
            long ideliminar = Convert.ToInt64(DgvPersonas.CurrentRow.Cells["ID"].Value.ToString());
            string name = DgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            MessageBox.Show($"El nombre seleccionado es: {name}");
            //pregunto si quiere eliminar
            //creo un dialog result  
            DialogResult Rpta = new DialogResult();
            Rpta = MessageBox.Show("Desea Eliminar el ID: " + ideliminar, "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Rpta == DialogResult.OK)
            {
                if (ClaseFunciones.Func_Eliminar(ideliminar))
                {
                    MessageBox.Show("Persona Eliminada", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = ClaseFunciones.Func_TraerDatos();
                    //muestro el datatable en datagrid
                    DgvPersonas.DataSource = dt;
                    BtnCancelar_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Hubo una Excepcion: " + ClaseFunciones.excepcion, "Excepcion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //habilito los texbox
            TxtID.Enabled = false;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;
            //capturar datos del datagridview.
            TxtID.Text = DgvPersonas.CurrentRow.Cells["ID"].Value.ToString();
            TxtNombre.Text = DgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtTelefono.Text = DgvPersonas.CurrentRow.Cells["Telefono"].Value.ToString();
            //habilito el guarda y cancelar
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            //deshabilito los demas botones
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            //mando el foco al txtID
            TxtNombre.Focus();
        }
    }

}
