using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.DAO
{
    internal class TaiKhoan
    {
        private static TaiKhoan instance;

        public static TaiKhoan Instance
        {
            get { if (instance == null) instance = new TaiKhoan(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoan() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_taikhoan @matk , @matkhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
    }
}
