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

namespace Lab1_DB
{
    public partial class Form1 : Form
    {
        SqlConnection dbConnection;
        DataSet dataSet;
        SqlDataAdapter dataAdapterManager, dataAdapterHotel;
        BindingSource bindingSourceManager, bindingSourceHotel;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(@"Data Source = DESKTOP-I844GOG\MSSQLSERVER01;" + "Initial Catalog = Hotel ; Integrated Security = SSPI ");
            displayData();

        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (managerID_txt.Text != "" && hotelID_txt.Text != "" && name_txt.Text != "" && capacity_txt.Text != "")
            {
                SqlCommand command = new SqlCommand("UPDATE Hotel SET ManagerID = @managerID, HotelName = @name, Capacity = @capacity WHERE HotelID = @hotelID", dbConnection);
                dbConnection.Open();
                command.Parameters.AddWithValue("@hotelID", hotelID_txt.Text);
                command.Parameters.AddWithValue("@managerID", managerID_txt.Text);
                command.Parameters.AddWithValue("@name", name_txt.Text);
                command.Parameters.AddWithValue("@capacity", capacity_txt.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

                dbConnection.Close();

                clearText();
                displayData();
            }
            else
            {
                MessageBox.Show("Complete all the required fills !");

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (managerID_txt.Text != "" && hotelID_txt.Text != "" && name_txt.Text != "" && capacity_txt.Text != "")
            {
                SqlCommand command = new SqlCommand("INSERT INTO Hotel VALUES (@hotelID, @managerID,@name,@capacity) ",dbConnection);
                dbConnection.Open();
                command.Parameters.AddWithValue("@hotelID", hotelID_txt.Text);
                command.Parameters.AddWithValue("@managerID", managerID_txt.Text);
                command.Parameters.AddWithValue("@name", name_txt.Text);
                command.Parameters.AddWithValue("@capacity", capacity_txt.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

                dbConnection.Close();

                clearText();
                displayData();
            }

            else {
                MessageBox.Show("Complete all the required fills !");

            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (hotelID_txt.Text != "")
            {
                SqlCommand command = new SqlCommand("DELETE FROM Hotel WHERE HotelID=@hotelID", dbConnection);
                dbConnection.Open();
                command.Parameters.AddWithValue("@hotelID", hotelID_txt.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

                dbConnection.Close();

                clearText();
                displayData();
            }
            else
            {
                MessageBox.Show("Complete the hotelID field !");
            }
        }

        private void displayData()
        {
            dataSet = new DataSet();
            dataAdapterManager = new SqlDataAdapter("SELECT * FROM Manager", dbConnection);
            dataAdapterHotel = new SqlDataAdapter("SELECT * FROM Hotel", dbConnection);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterHotel);

            dataAdapterManager.Fill(dataSet, "Manager");
            dataAdapterHotel.Fill(dataSet, "Hotel");
            DataRelation dataRelation = new DataRelation("FK_Hotel_Manager", dataSet.Tables["Manager"].Columns["ManagerID"], dataSet.Tables["Hotel"].Columns["ManagerID"]);
            dataSet.Relations.Add(dataRelation);

            bindingSourceManager = new BindingSource();
            bindingSourceManager.DataSource = dataSet;
            bindingSourceManager.DataMember = "Manager";

            bindingSourceHotel = new BindingSource();
            bindingSourceHotel.DataSource = bindingSourceManager;
            bindingSourceHotel.DataMember = "FK_Hotel_Manager";

            gridManager.DataSource = bindingSourceManager;
            gridHotel.DataSource = bindingSourceHotel;
        }


        private void clearText() {
            managerID_txt.Text = "";
            hotelID_txt.Text = "";
            name_txt.Text = "";
            capacity_txt.Text = "";
        }


        

        

        

    }
}
