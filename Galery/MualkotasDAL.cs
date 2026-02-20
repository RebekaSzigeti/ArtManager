using HouseRent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public struct Mualkotas
    {
        int mualktotasId;
        int alkotasEve;
        string mualkotasCim;
        int mualkotasAr;
        string mualkotasStilusiranyzat;
        string mualkotasMuveszek;
        int verzioszam;
        

        public int MualkotasId {  
            get { return mualktotasId;}
            set { mualktotasId = value; }
        }

        public int AlkotasEve
        {
            get { return alkotasEve; }
            set { alkotasEve = value; }
        }
        public string MualkotasCim
        {
            get { return mualkotasCim; }
            set { mualkotasCim = value; }
        }

        public int MualkotasAr
        {
            get { return mualkotasAr; }
            set { mualkotasAr = value; }
        }

        public string MualkotasStilusiranyzat
        {
            get { return mualkotasStilusiranyzat; }
            set { mualkotasStilusiranyzat = value; }
        }

        public string MualkotasMuveszek
        {
            get { return mualkotasMuveszek; }
            set { mualkotasMuveszek = value; }
        }

        public int Verzioszam
        {
            get { return verzioszam; }
            set { verzioszam = value; } 
        }



    }
    internal class MualkotasDAL : DALGen
    {
        public MualkotasDAL (ref string error)
        {
            base.CreateConnection (ref error);
        }

        public List<Mualkotas> GetMualkotasListDataReader(bool nezSzoveget, string szoveg, int muveszId, ref string error)
        {
            string query = "SELECT m.MualkotasID, m.Cim,m.AlkotasEve ,m.Ar, m.StilusIranyzat, STRING_AGG(mu.Nev, ', ') AS Muveszek, m.Verzioszam " +
                            " FROM Mualkotasok m " +
                            "JOIN AlkotasMuvesz am ON m.MualkotasID = am.MualkotasID " +
                            "JOIN Muveszek mu ON am.MuveszID = mu.MuveszID ";

            if (nezSzoveget)
            {
                if (muveszId >= 0)
                {
                    query += " WHERE m.MualkotasID IN  ( SELECT Mualkotasok.MualkotasID  FROM Muveszek " +
                             "JOIN AlkotasMuvesz ON Muveszek.MuveszID = AlkotasMuvesz.MuveszID " +
                             "JOIN Mualkotasok ON Mualkotasok.MualkotasID = AlkotasMuvesz.MualkotasID WHERE Muveszek.MuveszID = @pMuveszID ) ";
                    query += "AND m.Cim LIKE @pSzoveg";
                }
                else
                {
                    query += "WHERE m.Cim LIKE @pSzoveg";
                }
            }
            else
            {
                if (muveszId >= 0)
                {
                    query += " WHERE m.MualkotasID IN  ( SELECT Mualkotasok.MualkotasID  FROM Muveszek " +
                             "JOIN AlkotasMuvesz ON Muveszek.MuveszID = AlkotasMuvesz.MuveszID " +
                             "JOIN Mualkotasok ON Mualkotasok.MualkotasID = AlkotasMuvesz.MualkotasID WHERE Muveszek.MuveszID = @pMuveszID )";
                }

            }

                query += " GROUP BY m.MualkotasID, m.Cim, m.AlkotasEve, m.Ar, m.StilusIranyzat, m.Verzioszam ORDER BY m.MualkotasID; ";

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            if (!nezSzoveget)
            {
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@pMuveszID";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = muveszId;
                command.Parameters.Add(parameter);
            }
            else
            {
                if(muveszId >= 0)
                {
                    SqlParameter parameter1 = new SqlParameter();
                    parameter1.ParameterName = "@pSzoveg";
                    parameter1.SqlDbType = SqlDbType.Text;
                    parameter1.Direction = ParameterDirection.Input;
                    parameter1.Value = szoveg + "%";
                    command.Parameters.Add(parameter1);

                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@pMuveszID";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = muveszId;
                    command.Parameters.Add(parameter);

                }
                else
                {
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@pSzoveg";
                    parameter.SqlDbType = SqlDbType.Text;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = szoveg + "%";
                    command.Parameters.Add(parameter);
                }

            }

            SqlDataReader dataReader = ExecuteReaderParameter(command, ref error);
            List<Mualkotas> list = new List<Mualkotas>();

            if (error == "OK")
            {
                Mualkotas item = new Mualkotas();
                while (dataReader.Read())
                {
                    try
                    {
                        item.MualkotasId = Convert.ToInt32(dataReader["MualkotasID"]);
                        item.AlkotasEve = Convert.ToInt32(dataReader["AlkotasEve"]);
                        item.MualkotasCim = dataReader["Cim"].ToString();
                        item.MualkotasAr = Convert.ToInt32(dataReader["Ar"]);
                        item.MualkotasStilusiranyzat = dataReader["StilusIranyzat"].ToString();
                        item.MualkotasMuveszek = dataReader["Muveszek"].ToString();
                        item.Verzioszam = Convert.ToInt32(dataReader["Verzioszam"]);

                        list.Add(item);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }
                }
            }

            CloseDataReader(dataReader);
            return list;
        }


        public void deleteSelectedMualkotas(int mualkotasID, ref string error)
        {

            string query = "DELETE m FROM Mualkotasok m WHERE MualkotasID = @pMualkotasID ;";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pMualkotasID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = mualkotasID;
            command.Parameters.Add(parameter);
            base.ExecuteNonQuery(command, ref error);

        }


        public int selectVerzioSzam(int mualkotasID, ref string error)
        {
            string query = "SELECT Verzioszam FROM Mualkotasok WHERE MualkotasID = @pMualkotasID ;";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pMualkotasID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = mualkotasID;
            command.Parameters.Add(parameter);
            int value = Convert.ToInt32(base.ExecuteScalarUsingParametrizedQuery(command, ref error));
            return value;
        }

        public int selectAr(int mualkotasID, ref string error)
        {
            string query = "SELECT Ar FROM Mualkotasok WHERE MualkotasID = @pMualkotasID ;";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pMualkotasID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = mualkotasID;
            command.Parameters.Add(parameter);
            int value = Convert.ToInt32(base.ExecuteScalarUsingParametrizedQuery(command, ref error));
            return value;
        }


        /*public void updateMualkotasAr(int mualkotasID, int regiVerzio, int ujAr, ref string error)
        {
            string query = "UPDATE Mualkotasok SET Ar = @ujAr, Verzioszam = Verzioszam + 1 WHERE MualkotasID = @pMualkotasID AND Verzioszam = @pRegiVerzio";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pMualkotasID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = mualkotasID;
            command.Parameters.Add(parameter);
           
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@pRegiVerzio";
            parameter1.SqlDbType = SqlDbType.Int;
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = regiVerzio;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@ujAr";
            parameter2.SqlDbType = SqlDbType.Int;
            parameter2.Direction = ParameterDirection.Input;
            parameter2.Value = ujAr;
            command.Parameters.Add(parameter2);

            base.ExecuteNonQuery(command, ref error);

        }*/

        public void updateMualkotasAr(int mualkotasID, int ujAr, ref string error)
        {
            string query = "UPDATE Mualkotasok SET Ar = @ujAr, Verzioszam = Verzioszam + 1 WHERE MualkotasID = @pMualkotasID";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pMualkotasID";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = mualkotasID;
            command.Parameters.Add(parameter);


            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@ujAr";
            parameter2.SqlDbType = SqlDbType.Int;
            parameter2.Direction = ParameterDirection.Input;
            parameter2.Value = ujAr;
            command.Parameters.Add(parameter2);

            base.ExecuteNonQuery(command, ref error);

        }



    }
}
