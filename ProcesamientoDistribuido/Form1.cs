using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProcesamientoDistribuido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertarClientes()
        {
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis" };
            string[] apellidos = { "Gómez", "Pérez", "Martínez", "López", "Rodríguez" };

            double credito = 155.55;
            double deuda = 15.55;
            string estado = "Sinaloa";
            char vigencia = 'A';

            string nombreAleatorio, apellidoAleatorio;

            Random random = new Random();


            string connectionString = "Data Source=localhost;Initial Catalog=EMPRESA;User ID=sa;Password=1234;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    nombreAleatorio = nombres[random.Next(nombres.Length)];
                    apellidoAleatorio = apellidos[random.Next(apellidos.Length)];
                    

                    string query = "INSERT CLIENTES VALUES (@Nombre, @Credito, @Deuda, @Estado, @Vigencia)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreAleatorio + " " + apellidoAleatorio);
                        cmd.Parameters.AddWithValue("@Credito", credito);
                        cmd.Parameters.AddWithValue("@Deuda", deuda);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@Vigencia", vigencia);



                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inserción exitosa.");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron filas.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                
            }

        }

        private void CargarDataTable()
        {
            DataTable dt = new DataTable();
            MostrarClientes(ref dt);
            dtgClientes.DataSource = dt;
        }

        public void MostrarClientes(ref DataTable dt)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=EMPRESA;User ID=sa;Password=1234;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from CLIENTES", connection);
                    da.Fill(dt);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
            }
                
        }

        private void btnInsertarClientes_Click(object sender, EventArgs e)
        {
            InsertarClientes();
            CargarDataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDataTable();
        }
    }
}
