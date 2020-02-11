using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace first_app
{
    class Connection_Class
    {
       
            string str = "server=localhost;user id=root;persistsecurityinfo=True;database=c_sharp";
            MySqlConnection conn = null;
            MySqlDataReader reader = null;
        

        public void  connection_start()
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();
                Console.WriteLine("DB started ");
            }


            catch (MySqlException ex)
            {
                Console.WriteLine(ex + "");
            }
        }


        public void connection_close()
        {
           
                conn.Close();
           

        }

        public int Run_Query(string str)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(str, conn);
               int result = cmd.ExecuteNonQuery();
                return result;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex + "");

            }
            return 0;
        }

        public MySqlDataReader Data_Reader(string str)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(str, conn);
                reader = cmd.ExecuteReader();
                return reader; 
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex + "");

            }
            return reader;
        }

        public object ShowDataInGridView(string str)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(str, conn);
          
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }



    }
}
