using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CourseManagementSystem
{
    internal class sqlbaglantisi
    {
        public NpgsqlConnection baglanti()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=CourseTracking; user ID=postgres; password=emir; ");
            baglan.Open();
            return baglan;
        }
    }
}
