﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudgetManagement
{
    public partial class ManageForm : Form
    {
        DatabaseConnector databaseConnector = new DatabaseConnector();

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into family_budget_management.operations(sum, type, date) " +
                "values(" + textBox1.Text + ", '+', '2021-06-21');";
            
            MySqlConnection connection = databaseConnector.getConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into family_budget_management.operations(sum, type, date) " +
                "values(" + textBox2.Text + ", '-', '2021-06-21');";

            MySqlConnection connection = databaseConnector.getConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
