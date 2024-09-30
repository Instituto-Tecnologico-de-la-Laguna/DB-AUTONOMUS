using System.Diagnostics.Eventing.Reader;

namespace DB_AUTONOMUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos persona=new Datos();
            bool f = false;
            f = persona.Comando("Insert Into Persona(nombre,paterno,materno,mail,telefono)" +
                "Values('" +txtNombre.Text+"','" + txtPaterno .Text+
                "','"+txtMaterno .Text + "','"+ txtMail.Text +
                "','"+txtTelefono .Text +"')");
            if (f == true)
            {
                MessageBox.Show("Dato Agregado");
            }
            else
            { 
                MessageBox.Show("Error"); 
            }
           }
        }
    }

