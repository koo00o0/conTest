using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.Form2;

namespace WindowsFormsApp3
{
    public partial class Index : Form
    {
        private string SessionID;
        public Index(string sessionID)
        {
            InitializeComponent();
            SessionID = sessionID;
            Console.WriteLine(SessionID + "잘안들어와 ??????");
            label1.Text = "ID : "+SessionID;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void todolist_Click(object sender, EventArgs e)
        {
            
            TodoListF todolistFrom = new TodoListF(SessionID);
            todolistFrom.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
