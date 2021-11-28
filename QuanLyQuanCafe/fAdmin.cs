using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadDrinkList()
        {
            string query = "select * from drink";

            dtgvDrink.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadAccountList()
        {

            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "Cuong" });
        }
        private void tpDrinkCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
