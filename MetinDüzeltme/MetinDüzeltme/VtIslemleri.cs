using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinDüzeltme
{
    internal class VtIslemleri
    {
        #region BaglantiCumleleri
        static SqlConnection MetinConn = new SqlConnection(Baglanti.BaglantiCumlesi);
        static SqlDataAdapter metinDataAdp;
        static SqlCommand metinCmd = new SqlCommand();
        #endregion

        #region TabloDoldurma

        public static DataTable VeriGetir(string sorgu)
        {
            DataTable Metinler = new DataTable();
            //MetinTablosu.Clear();
            metinDataAdp = new SqlDataAdapter(sorgu, MetinConn);
            metinDataAdp.Fill(Metinler);
            return Metinler;
        }
        public static void KomutCalistir(string Komut)
        {
            try
            {
                if (MetinConn.State == ConnectionState.Closed)
                    MetinConn.Open();
                metinCmd.CommandText = Komut;
                metinCmd.Connection = MetinConn;
                //MusCmd = new SqlCommand(Komut, MusConn);
                metinCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (MetinConn.State == ConnectionState.Open)
                    MetinConn.Close();
            }
        }
        #endregion


    }
}
