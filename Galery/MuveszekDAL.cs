using HouseRent;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{

    public struct Muvesz
    {
        string muveszNev;
        int muveszId;
        string muveszStilus;

        public int MuveszId
        {
            get { return muveszId; }
            set { muveszId = value; }
        }

        public string MuveszStilus
        {
            get { return muveszStilus; }
            set { muveszStilus = value; }
        }

        public string MuveszNev
        {
            get { return muveszNev; }
            set { muveszNev = value; }
        }

        public Muvesz(int mId, string mNev, string mStilus)
        {
            muveszNev = mNev;
            muveszId = mId;
            muveszStilus = mStilus;
        }
    }

    internal class MuveszekDAL : DALGen
    {
        public List<Muvesz> GetMuveszList(ref string error)
        {
            string query = "SELECT * FROM Muveszek;";
            SqlDataReader dataReader = ExecuteReader(query, ref error);
            List<Muvesz> muveszList = new List<Muvesz>();

            Muvesz Default = new Muvesz();
            Default.MuveszId = -1;
            Default.MuveszNev = "All";
            Default.MuveszStilus = "?";
            muveszList.Add(Default);

            if (error == "OK")
            {
                Muvesz item = new Muvesz();
                while (dataReader.Read()){
                    try
                    {
                        item.MuveszId = Convert.ToInt32(dataReader[0]);
                        item.MuveszNev = dataReader[1].ToString();
                        item.MuveszStilus = dataReader[2].ToString();
                        muveszList.Add(item);
                    }
                    catch (Exception e)
                    {
                        error = "Invalid data " + e.Message;
                    }
                }

            }

            CloseDataReader(dataReader);

            return muveszList;

        }

    }
}
