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
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void idCheck_Click(object sender, EventArgs e)
        {
            string id = userId.Text;

            string result = userIdCheck(id);

            if (result == "T")
            {
                MessageBox.Show("사용중인 아이디");
            }
            else if (id == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            else {
                MessageBox.Show("사용가능한 아이디입니다!");
                return;
            }
            


        }

        private string userIdCheck(string id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_RegisterIdCheck", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", id);

                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
                        resultParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultParam);

                        SqlDataReader rd =  command.ExecuteReader();

                        while (rd.Read())
                        {
                            if (id == rd["userId"].ToString())
                            {
                                return "T";
                            }
                            return "F";
                        }
                        return "F";

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "F";
            }

        }

        private void userJoin_Click(object sender, EventArgs e)
        {
            string Id = userId.Text;
            string Pw = userPw.Text;
            string Name = userName.Text;
            Console.WriteLine(Id + Pw + Name + "값잘들어오고있어 ???");
            bool result = RegisterUser(Id, Pw, Name);

            if (result == true)
            {
                MessageBox.Show("회원가입 성공");
                Form2 loginForm = new Form2();

                // 다른 폼을 표시
                loginForm.Show();

                // 현재 폼을 숨김
                this.Hide();
            }
            else
            {
                MessageBox.Show("회원가입 실패");
            }
        }
        private bool RegisterUser(string Id, string Pw, string Name)
        {
            Console.WriteLine(Id + Pw + Name + "여기까지는 와 ????");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_RegisterUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Pw", Pw);
                        command.Parameters.AddWithValue("@Name", Name);

                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
                        resultParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultParam);
                        
                        command.ExecuteNonQuery();

                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private void LoginFormN_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();

            loginForm.Show();
        }
    }
}
