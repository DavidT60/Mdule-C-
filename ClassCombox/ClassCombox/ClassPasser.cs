using System;
using System.Collections.Generic;
using System.Text;

//Módulos para conexión y consultas//
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace ClassCombox
{

    class ClassPasser
    {

        //Conexión de cadena//
        readonly SqlConnection strConnection = new SqlConnection("Server=DESKTOP-FB9EHDC;Database=dat;Trusted_Connection=True;");

        //Carga Provincias//
        public DataTable Fill(string commnadSql)
        {
            //class table
            DataTable tablaDeProdustos = new DataTable();
            SqlDataAdapter dataProdustsAdater = new SqlDataAdapter(commnadSql, strConnection);
            dataProdustsAdater.Fill(tablaDeProdustos);
            return tablaDeProdustos;

        }

        public String DataId(string command)
        {
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FB9EHDC;Database=dat;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                string result = cmd.ExecuteScalar().ToString();
                return result;
                conn.Close();
            }
        }

    }
}
