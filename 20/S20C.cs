﻿/*Write C# program to connect with MySQL database booksdb from WAMP server and search
for a book titled ‘ASP dot NET’ from the table books that has bookname as the field to compare the book name to. */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMYSQL
{
    class s20C
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=booksdb;UID=root;PASSWORD=''");
            conn.Open();

            string query = "select * from books where bookname ='ASP dot NET'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Searched book exists");
                while (reader.Read())
                {
                    Console.WriteLine(reader["bookname"]);
                }
            }
            else
            {
                Console.WriteLine("Searched book does not exist");
            }

            Console.ReadLine();
        }
    }
}
