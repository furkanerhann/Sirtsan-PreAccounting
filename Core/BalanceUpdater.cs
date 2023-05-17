using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class BalanceUpdater
    {
        public static decimal updateBalance(string constring, int customer_id, decimal additional_balance, decimal old_balance = 0, decimal current_balance = 0)
        {
            string comstring = "UPDATE Musteriler SET Bakiye = @b WHERE Musteri_No = @id";
            decimal new_balance = current_balance + additional_balance - old_balance;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(comstring, con))
                    {
                        com.Parameters.Add("@b", SqlDbType.Decimal).Value = new_balance;
                        com.Parameters.Add("@id", SqlDbType.Int).Value = customer_id;
                        com.ExecuteNonQuery();
                    }
                    con.Close();
                    return new_balance;
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
