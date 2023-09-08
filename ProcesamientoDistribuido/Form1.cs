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
            string[] estados = { "SINALOA", "SONORA", "BC", "DURANGO" };

            double credito;
            double deuda;
            char vigencia = 'A';

            string nombreAleatorio, apellidoAleatorio, estadoAleatorio;

            Random random = new Random();


            string connectionString = "Data Source=localhost;Initial Catalog=EMPRESA;User ID=sa;Password=1234;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                for(int i=0; i<=20000; i++) { 
                        try
                        {
                            connection.Open();

                            estadoAleatorio = estados[random.Next(estados.Length)];
                            nombreAleatorio = nombres[random.Next(nombres.Length)];
                            apellidoAleatorio = apellidos[random.Next(apellidos.Length)];
                            credito = random.NextDouble() * (5000 - 1000) + 1000;
                            deuda = credito * (random.NextDouble()/10);
                    

                            string query = "INSERT CLIENTES VALUES (@Nombre, @Credito, @Deuda, @Estado, @Vigencia)";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@Nombre", nombreAleatorio + " " + apellidoAleatorio);
                                cmd.Parameters.AddWithValue("@Credito", credito);
                                cmd.Parameters.AddWithValue("@Deuda", deuda);
                                cmd.Parameters.AddWithValue("@Estado", estadoAleatorio);
                                cmd.Parameters.AddWithValue("@Vigencia", vigencia);



                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                            
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
                    MessageBox.Show("Inserción exitosa.");
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
