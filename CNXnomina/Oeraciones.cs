﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace crud_nomina
    
{
    class Operaciones
    {
       
        public string Conectar()
           
            
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source = C:\\SQLite\\cnxpruva.db;Version=3;");
            try

            {
                cnx.Open();
                return "Conectado!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }
        public string ConsultaSinResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source= C:\\SQLite\\cnxpruva.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }
        public DataSet ConsultaConResultado(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source= C:\\SQLite\\cnxpruva.db;Version=3;");
            try
            {
                cnx.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, cnx);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
               return null;
            }
            finally
            {
                cnx.Close();
            }

        }
       


    }
}

