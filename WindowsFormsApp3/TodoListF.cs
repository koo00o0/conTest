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
using static WindowsFormsApp3.Index;


namespace WindowsFormsApp3
{
    public partial class TodoListF : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";


        private string SessionID;
        public TodoListF(string sessionID)
        {
            InitializeComponent();
            this.SessionID = sessionID;
            LoadTodoListData(SessionID);
        }

        private void Context_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContextInput_Click(object sender, EventArgs e)
        {
            string contextData = Context.Text;
            bool result = ContextDataInput(contextData);

            if (result == true)
            {
                MessageBox.Show("성공");
                LoadTodoListData(SessionID);
                return;
            }
        }

        private bool ContextDataInput(string contextData)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_ContextInsert", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Context", contextData);
                        command.Parameters.AddWithValue("@Id", SessionID);

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

        private void LoadTodoListData(string SessionID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetTodoListByUserId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // 프로시저의 매개변수에 userId 전달
                        command.Parameters.AddWithValue("@UserId", SessionID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // ListBox에 데이터 바인딩
                        listBoxTodo.DataSource = dataTable;
                        listBoxTodo.DisplayMember = "context";

                        // ListBox의 모든 컨트롤(버튼) 제거
                        listBoxTodo.Controls.Clear();

                        Button[] btnDelete = new Button[100];
                        int buttonWidth = 100;
                        int buttonHeight = 16;
                        int buttonSpacingY = 0;

                        for (int i = 0; i < listBoxTodo.Items.Count; i++)
                        {
                            DataRowView dataRowView = (DataRowView)listBoxTodo.Items[i];

                            
                            string contextValue = dataRowView["context"].ToString();
                            Console.WriteLine(contextValue);

                            btnDelete[i] = new Button();
                            btnDelete[i].Text = "삭제";
                            btnDelete[i].Tag = contextValue;

                            btnDelete[i].Click += BtnDelete_Click;
                            int buttonX = 400;

                            int buttonY = -6 + i * (buttonHeight + buttonSpacingY);

                            btnDelete[i].Location = new Point(buttonX, buttonY);
                            btnDelete[i].Size = new Size(buttonWidth, buttonHeight);
                            btnDelete[i].Font = new Font("굴림", 6);


                            
                            listBoxTodo.Controls.Add(btnDelete[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터를 불러오는 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 삭제 버튼 클릭 이벤트 처리
            Button btnDelete = (Button)sender;
            string contextValue = btnDelete.Tag.ToString();

            bool result = TodoListContextDelete(contextValue);


            if (result == true)
            {
                MessageBox.Show("성공");
                LoadTodoListData(SessionID);
                return;
            }
        }

        private bool TodoListContextDelete(string contextValue)
        {
            Console.WriteLine(SessionID + "asfsafuhwuigfhqwiuhfqwui");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_ContextDelete", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Context", contextValue);
                        command.Parameters.AddWithValue("@Id", SessionID);

                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
                        resultParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultParam);

                        command.ExecuteNonQuery();

                        string result = resultParam.Value.ToString();
                        Console.WriteLine(result);

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
    }
}