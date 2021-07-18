using Microsoft.Data.SqlClient;
using System;



namespace BaseDeDatos
{
    class Sensor
    {
        public int Clave { get; set; }
        public string SensorId { get; set; }
        public string SensorTipo { get; set; }
        public string Marca { get; set; }
        public string VariableTipo { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public string Status { get; set; }
    }//Sensor
    class Program
    {
        static void Main(string[] args)
        {
            Sensor objSensor = new Sensor();

            SqlConnection objSqlConnection = new SqlConnection(
                @"Data Source=LAPTOP-O52IDDUM;Initial Catalog=PrograAvanzada;Integrated Security=True");

            objSqlConnection.Open();

            //SqlCommand objSqlCommand_Select = new SqlCommand("SELECT * FROM Sensores", objSqlConnection);
            SqlCommand objSqlCommand_Select = new SqlCommand("SELECT * FROM Sensores WHERE Clave=@Clave", objSqlConnection);
                objSqlCommand_Select.Parameters.AddWithValue("@Clave", 2);

            SqlDataReader objSqlDataReader = objSqlCommand_Select.ExecuteReader();

            while (objSqlDataReader.Read())
            {
                objSensor.Clave = objSqlDataReader.GetInt32(objSqlDataReader.GetOrdinal("Clave"));
                objSensor.SensorId = objSqlDataReader.GetString(objSqlDataReader.GetOrdinal("SensorId"));
                objSensor.SensorTipo = objSqlDataReader.GetString(objSqlDataReader.GetOrdinal("SensorTipo"));
                objSensor.Marca = objSqlDataReader.GetString(objSqlDataReader.GetOrdinal("Marca"));
                objSensor.VariableTipo = objSqlDataReader.GetString(objSqlDataReader.GetOrdinal("VariableTipo"));
                objSensor.ValorMinimo = objSqlDataReader.GetDecimal(objSqlDataReader.GetOrdinal("ValorMinimo"));
                objSensor.ValorMaximo = objSqlDataReader.GetDecimal(objSqlDataReader.GetOrdinal("ValorMaximo"));
                objSensor.Status = objSqlDataReader.GetString(objSqlDataReader.GetOrdinal("Status"));

                Console.WriteLine("Sensor: Clave = {0}; SensorId = {1}; SensorTipo = {2}; Marca = {3};" +
                    " VariableTipo = {4}, ValorMinimo = {5}; ValorMaximo = {6}; Status = {7}",
                    objSensor.Clave, objSensor.SensorId, objSensor.SensorTipo, objSensor.Marca,
                    objSensor.VariableTipo, objSensor.ValorMinimo, objSensor.ValorMaximo, objSensor.Status);
            }
            objSqlDataReader.Close();

            SqlCommand objSqlCommand_Insert = new SqlCommand(
                "INSERT Sensores VALUES(@Clave, @SensorId, @SensorTipo, @Marca, @VariableTipo, @ValorMinimo, @ValorMaximo, @Status)",
                objSqlConnection);

            objSqlCommand_Insert.Parameters.AddWithValue("@Clave", 200);
            objSqlCommand_Insert.Parameters.AddWithValue("@SensorId", "Term");
            objSqlCommand_Insert.Parameters.AddWithValue("@SensorTipo", "Termopar");
            objSqlCommand_Insert.Parameters.AddWithValue("@Marca", "Siemens");
            objSqlCommand_Insert.Parameters.AddWithValue("@VariableTipo", "Temperatura");
            objSqlCommand_Insert.Parameters.AddWithValue("@ValorMinimo", -50);
            objSqlCommand_Insert.Parameters.AddWithValue("@ValorMaximo", 999);
            objSqlCommand_Insert.Parameters.AddWithValue("@Status", "A");

            //int intRegNum = objSqlCommand_Insert.ExecuteNonQuery();

            //UPDATE

            SqlCommand objSQLCommand_Update = new SqlCommand(
                "UPDATE Sensores SET ValorMinimo = @ValorMinimo, ValorMaximo = @ValorMaximo WHERE Clave = @Clave", objSqlConnection);

            objSQLCommand_Update.Parameters.AddWithValue("@ValorMinimo", 12.7);
            objSQLCommand_Update.Parameters.AddWithValue("@ValorMaximo", 20.3);
            objSQLCommand_Update.Parameters.AddWithValue("@Clave", 200);

            int intRegNum = objSQLCommand_Update.ExecuteNonQuery();

            //DELETE
            SqlCommand objSQLCommand_Delete = new SqlCommand(
                "DELETE Sensores WHERE Clave=@Clave", objSqlConnection);
                objSQLCommand_Delete.Parameters.AddWithValue("@Clave", 200);

            intRegNum = objSQLCommand_Delete.ExecuteNonQuery();

            objSqlConnection.Close();
        }
    }
}
