using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        public Form2()
        {
            InitializeComponent();
        }

        public static class SessionManager
        {
            public static string SessionID { get; set; }
            // 다른 필요한 세션 정보들도 추가할 수 있음
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string id = userId.Text;
            string pw = userPw.Text;


            bool result = LoginUser(id, pw);

            if (result == true)
            {
                SessionManager.SessionID = id;
                MessageBox.Show("로그인 성공");
                Index main = new Index(SessionManager.SessionID);
                main.Show();

            }
            else
            {
                MessageBox.Show("로그인 실패");
            }


        }

        private bool LoginUser(string id, string pw)
        {
            Console.WriteLine(id + pw +  "여기까지는 와 ????");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_LoginUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Pw", pw);

                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
                        resultParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultParam);
                        SqlDataReader rd=command.ExecuteReader();

                        while (rd.Read())
                        {
                            string resultValue = rd["Result"].ToString();
                            Console.WriteLine(resultValue + "어떤게 들어오는지 ????");
                            if (resultValue == "Success")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
