// SQL CONNECTION (Connect to CRMDB)//
//using System;
//using System.Data.SqlClient;

//class Program
//{
    //static void Main()
   // {
        //string connectionString = 
        //"Server=localhost;Database=CRMDB;Trusted_Connection=True;";

        //using (SqlConnection con = new SqlConnection(connectionString))
        //{
        //    con.Open();
      //      Console.WriteLine("Connected Successfully!");
    //    }
  //  }
//}



// insert record //

//using System;
//using System.Data.SqlClient;

//class Program
//{
    //static void Main()
    //{
        //string connectionString =
        //@"Server=localhost;
        //  Database=CRMDB;
         // Trusted_Connection=True;
         // TrustServerCertificate=True;";

       // using (SqlConnection con = new SqlConnection(connectionString))
       // {
            //con.Open();

            //string query = "SELECT CustomerId, FirstName, LastName, City FROM custTable";

            //SqlCommand cmd = new SqlCommand(query, con);

            //SqlDataReader reader = cmd.ExecuteReader();

            // Table Header
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine("| ID  | First Name   | Last Name    | City        |");
            //Console.WriteLine("-------------------------------------------------------------");

            //while (reader.Read())
            //{
                //Console.WriteLine(
                  //  $"| {reader["CustomerId"],-3} " +
                //    $"| {reader["FirstName"],-12} " +
              //      $"| {reader["LastName"],-12} " +
            //        $"| {reader["City"],-11} |"
          //      );
        //    }

      //      Console.WriteLine("-------------------------------------------------------------");
    //    }
  //  }
//}



// update record // (ExecuteNonQuery)

//using System;
//using System.Data.SqlClient;

//class Program
//{
    //static void Main()
    //{
       // string connectionString =
       // @"Server=localhost;
          //Database=CRMDB;
          //Trusted_Connection=True;
          //TrustServerCertificate=True;";

        //using (SqlConnection con = new SqlConnection(connectionString))
       // {
            //con.Open();

            // 🔹 UPDATE
           // string updateQuery = "UPDATE custTable SET City=@City WHERE CustomerId=@Id";

            //using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
            //{
                //updateCmd.Parameters.AddWithValue("@City", "Chennai");
                //updateCmd.Parameters.AddWithValue("@Id", 1);

                //int rows = updateCmd.ExecuteNonQuery();

              //  Console.WriteLine($"{rows} Record Updated Successfully!\n");
            //}

            // 🔹 DISPLAY TABLE AFTER UPDATE
            //string selectQuery = "SELECT CustomerId, FirstName, LastName, City FROM custTable";

          //  using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
        //    using (SqlDataReader reader = selectCmd.ExecuteReader())
      //      {
    //            Console.WriteLine("-------------------------------------------------------------");
  //              Console.WriteLine("| ID  | First Name   | Last Name    | City        |");
//                Console.WriteLine("-------------------------------------------------------------");

                //while (reader.Read())
              //  {
            //        Console.WriteLine(
          //              $"| {reader["CustomerId"],-3} " +
        //                $"| {reader["FirstName"],-12} " +
      //                  $"| {reader["LastName"],-12} " +
    //                    $"| {reader["City"],-11} |"
  //                  );
//                }

        //        Console.WriteLine("-------------------------------------------------------------");
      //      }
    //    }
  //  }
//}


//Count record //

//using System;
//using System.Data.SqlClient;

//class Program
//{
    //static void Main()
    //{
      //  string connectionString =
      //  "Server=localhost;Database=CRMDB;Trusted_Connection=True;";

        //using (SqlConnection con = new SqlConnection(connectionString))
        //{
        //    con.Open();

          //  string query = "SELECT COUNT(*) FROM custTable";

           // SqlCommand cmd = new SqlCommand(query, con);

          //  int count = (int)cmd.ExecuteScalar();

            //Console.WriteLine("Total Customers: " + count);
        //}
   // }
//}





// SQL INJECTION // 



//using System;
//using System.Data.SqlClient;

//class Program
//{
    //static void Main()
    //{
        //string connectionString =
        //@"Server=localhost;
          //Database=CRMDB;
          //Trusted_Connection=True;
          //TrustServerCertificate=True;";

        //using SqlConnection connection = new SqlConnection(connectionString);

        //try
        //{
            //connection.Open();
            //Console.WriteLine("Connected Successfully!\n");

            //Console.WriteLine("1. SQL Injection Demo (Unsafe)");
            //Console.WriteLine("2. Safe Parameterized Query");
            //Console.Write("\nChoose Option (1 or 2): ");

            //string choice = Console.ReadLine();

            //if (choice == "1")
              //  SqlInjectionDemo(connection);
            //else if (choice == "2")
            //    SafeQueryDemo(connection);
          //  else
        //        Console.WriteLine("Invalid Choice!");
        //}
        //catch (Exception ex)
        //{
      //      Console.WriteLine("Error: " + ex.Message);
    //    }
    //}

    // 🚨 UNSAFE VERSION
    //static void SqlInjectionDemo(SqlConnection connection)
    //{
        //Console.Write("\nEnter Customer Id: ");
        //string userInput = Console.ReadLine();

        //string query = $"SELECT * FROM custTable WHERE CustomerId = {userInput}";

        //using SqlCommand command = new SqlCommand(query, connection);
       // using SqlDataReader reader = command.ExecuteReader();

     //   DisplayTable(reader);
    //}

    // ✅ SAFE VERSION
    //static void SafeQueryDemo(SqlConnection connection)
    //{
        //Console.Write("\nEnter Customer Id: ");
        //string userInput = Console.ReadLine();

        //string query = "SELECT * FROM custTable WHERE CustomerId = @Id";

        //using SqlCommand command = new SqlCommand(query, connection);
        //command.Parameters.AddWithValue("@Id", userInput);

      //  using SqlDataReader reader = command.ExecuteReader();

    //    DisplayTable(reader);
    //}

    // 🔹 TABLE FORMAT METHOD
    //static void DisplayTable(SqlDataReader reader)
    //{
        //Console.WriteLine("\n-------------------------------------------------------------");
        //Console.WriteLine("| ID  | First Name   | Last Name    | City        |");
        //Console.WriteLine("-------------------------------------------------------------");

        //while (reader.Read())
        //{
           // Console.WriteLine(
                //$"| {reader["CustomerId"],-3} " +
              //  $"| {reader["FirstName"],-12} " +
            //    $"| {reader["LastName"],-12} " +
          //      $"| {reader["City"],-11} |"
        //    );
      //  }

    //    Console.WriteLine("-------------------------------------------------------------");
  //  }
//}


// paramaterised //
//using System;
//using System.Data.SqlClient;

//class Program
//{
 //   static void Main()
  //  {
  //      string connectionString =
  //      @"Server=localhost;
  //        Database=CRMDB;
   //       Trusted_Connection=True;
   //       TrustServerCertificate=True;";

  //      using SqlConnection connection = new SqlConnection(connectionString);

    //    try
      //  {
        //    connection.Open();
          //  Console.WriteLine("Connected Successfully!\n");

           // Console.WriteLine("Search By:");
            //Console.WriteLine("1. Customer Id");
            //Console.WriteLine("2. Email");
            //Console.WriteLine("3. First Name");

            //Console.Write("\nChoose option: ");
            //string choice = Console.ReadLine();

            //switch (choice)
            //{
             //   case "1":
               //     SearchById(connection);
                 //   break;

                //case "2":
                  //  SearchByEmail(connection);
                    //break;

                //case "3":
                  //  SearchByFirstName(connection);
                    //break;

              //  default:
                //    Console.WriteLine("Invalid Option!");
                  //  break;
            //}
        //}
        //catch (Exception ex)
        //{
          //  Console.WriteLine("Error: " + ex.Message);
     //   }
    //}

    // ✅ Search By CustomerId
    //static void SearchById(SqlConnection connection)
    //{
      //  Console.Write("Enter Customer Id: ");
        //string id = Console.ReadLine();

        //string query = "SELECT * FROM custTable WHERE CustomerId = @Id";

        //using SqlCommand cmd = new SqlCommand(query, connection);
        //cmd.Parameters.AddWithValue("@Id", id);

        //using SqlDataReader reader = cmd.ExecuteReader();
        //DisplayTable(reader);
    //}

    // ✅ Search By Email
    //static void SearchByEmail(SqlConnection connection)
    //{
      //  Console.Write("Enter Email: ");
        //string email = Console.ReadLine();

        //string query = "SELECT * FROM custTable WHERE Email = @Email";

        //using SqlCommand cmd = new SqlCommand(query, connection);
        //cmd.Parameters.AddWithValue("@Email", email);

        //using SqlDataReader reader = cmd.ExecuteReader();
     //   DisplayTable(reader);
    //}

    // ✅ Search By FirstName (LIKE)
    //static void SearchByFirstName(SqlConnection connection)
    //{
      //  Console.Write("Enter First Name: ");
        //string name = Console.ReadLine();

        //string query = "SELECT * FROM custTable WHERE FirstName LIKE @Name";

        //using SqlCommand cmd = new SqlCommand(query, connection);
        //cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

        //using SqlDataReader reader = cmd.ExecuteReader();
       // DisplayTable(reader);
    //}

    // 🔹 Table Format Display
    //static void DisplayTable(SqlDataReader reader)
    //{
      //  Console.WriteLine("\n--------------------------------------------------------------------------");
       // Console.WriteLine("| ID  | First Name   | Last Name    | Email               | City        |");
        //Console.WriteLine("--------------------------------------------------------------------------");

        //bool found = false;

        //while (reader.Read())
        //{
          //  found = true;

            //Console.WriteLine(
              //  $"| {reader["CustomerId"],-3} " +
                //$"| {reader["FirstName"],-12} " +
                //$"| {reader["LastName"],-12} " +
                //$"| {reader["Email"],-19} " +
                //$"| {reader["City"],-11} |"
            //);
       // }

       // if (!found)
        //{
          //  Console.WriteLine("| No matching record found.                                             |");
        //}

   //     Console.WriteLine("--------------------------------------------------------------------------");
   // }
//}
