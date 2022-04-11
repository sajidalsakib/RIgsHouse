using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace RigsHouse
{
    class cartDB
    {
       /* public static void cart(string productID)
        {
            connectionString cs = new connectionString();

            SqlConnection con = new SqlConnection(cs.cs());

            //don't miss to pass the mf "cs" that is how you are creating the connection string
            string query = "update cart set Username=@Username, ID=@ID, Name=@Name";
            SqlCommand passing = new SqlCommand(query, con);

            //now we are going to tell what are this @id, @name????
            passing.Parameters.AddWithValue("@Username", Username);
            passing.Parameters.AddWithValue("@ID", id);
            passing.Parameters.AddWithValue("@Name", label2.Text);



            con.Open(); //opening the connection
            int a = passing.ExecuteNonQuery(); //execute query
            //sending me a value 0 or 1, if greater than 0 then insertion happend


            if (a > 0)
            {
                MessageBox.Show("Addedt to the cart");
                // BindGridView();
                // refresh();
            }
            else
            {
                MessageBox.Show("Not added");
            }

        }*/

    }
}
