using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private SqlConnection cs;
        private SqlDataAdapter daLakes, daFishermen;
        private DataSet tableData;
        private DataRelation drLakesFishermen;
        BindingSource bsLakes, bsFishermen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cs = new SqlConnection(@"Data Source=DESKTOP-677PJ5U\SQLEXPRESS;Initial Catalog=FishFarm;Integrated Security=True;TrustServerCertificate=true");
            cs.Open();

            daLakes = new SqlDataAdapter("SELECT * FROM Lakes", cs);
            tableData = new DataSet();
            daLakes.Fill(tableData, "Lakes");
            LakesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            daFishermen = new SqlDataAdapter("SELECT * FROM Fishermen", cs);
            daFishermen.Fill(tableData, "Fishermen");
            FishermenView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataColumn LakeIdLake = tableData.Tables["Lakes"].Columns["Lid"];
            DataColumn LakeIdFisherman = tableData.Tables["Fishermen"].Columns["Lid"];
            drLakesFishermen = new DataRelation("FK_LAKE_FISHERMEN", LakeIdLake, LakeIdFisherman);
            tableData.Relations.Add(drLakesFishermen);

            bsLakes = new BindingSource();
            bsLakes.DataSource = tableData;
            bsLakes.DataMember = "Lakes";

            bsFishermen = new BindingSource();
            bsFishermen.DataSource = bsLakes;
            bsFishermen.DataMember = "FK_LAKE_FISHERMEN";
            LakesView.DataSource = bsLakes;

        }

        private void ReloadFishermenTableView()
        {
            if (tableData.Tables["Fishermen"] != null)
            {
                tableData.Tables["Fishermen"].Clear();
            }
            daFishermen.Fill(tableData, "Fishermen");
            FishermenView.DataSource = bsFishermen;
        }

        private void FishermenView_SelectionChanged(object sender, EventArgs e)
        {
            if (FishermenView.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = FishermenView.SelectedRows[0];
                FMidText.Text = selectedRow.Cells[0].Value.ToString();
                NameText.Text = selectedRow.Cells[1].Value.ToString();
                SupplyText.Text = selectedRow.Cells[2].Value.ToString();
                SidText.Text = selectedRow.Cells[3].Value.ToString();
                LidText.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void LakesView_SelectionChanged(object sender, EventArgs e)
        {
            FMidText.Clear();
            NameText.Clear();
            SupplyText.Clear();
            SidText.Clear();
            LidText.Clear();
            if (LakesView.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = LakesView.SelectedRows[0];
                daFishermen.SelectCommand = new SqlCommand("SELECT * FROM Fishermen WHERE Lid = " + selectedRow.Cells[0].Value, cs);
                ReloadFishermenTableView();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Fishermen (FMid, FMName, Supply, SAid, Lid) " + "VALUES (@FMid, @FMName, @Supply, @SAid, @Lid)", cs);
            try
            {
                int FMid = Int32.Parse(FMidText.Text);
                if (LidText.Text.Length != 0)
                {
                    int Lid = Int32.Parse(LidText.Text);
                    int SAid = Int32.Parse(SidText.Text);
                    int supply = Int32.Parse(SupplyText.Text);
                    command.Parameters.Add("@FMid", SqlDbType.Int);
                    command.Parameters["@FMid"].Value = FMid;
                    command.Parameters.Add("@FMName", SqlDbType.VarChar, 50);
                    command.Parameters["@FMName"].Value = NameText.Text;
                    command.Parameters.Add("@Supply", SqlDbType.Int);
                    command.Parameters["@Supply"].Value = supply;
                    command.Parameters.Add("@SAid", SqlDbType.Int);
                    command.Parameters["@SAid"].Value = SAid;
                    command.Parameters.Add("@Lid", SqlDbType.Int);
                    command.Parameters["@Lid"].Value = Lid;
                    try
                    {
                        daFishermen.InsertCommand = command;
                        daFishermen.InsertCommand.ExecuteNonQuery();
                        ReloadFishermenTableView();
                    }
                    catch (SqlException sqlException)
                    {
                        if (sqlException.Number == 2267)
                            MessageBox.Show("The fishermen id must be unique");
                        else if (sqlException.Number == 547)
                        {
                            MessageBox.Show("No existing Lake with the given id");
                        }
                        else
                            MessageBox.Show(sqlException.Message);
                    }
                }
                else
                    MessageBox.Show("No lake ID given");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Fishermen WHERE FMid = @FMid", cs);
            if (FMidText.Text.Length != 0)
            {
                int FMid = Int32.Parse(FMidText.Text);
                command.Parameters.Add("@FMid", SqlDbType.Int);
                command.Parameters["@FMid"].Value = FMid;
                try
                {
                    daFishermen.DeleteCommand = command;
                    int numberOfDeletedFishermen = daFishermen.DeleteCommand.ExecuteNonQuery();
                    if (numberOfDeletedFishermen == 0)
                    {
                        MessageBox.Show("No fisherman with given ID");
                    }
                    else
                    {
                        ReloadFishermenTableView();
                    }
                }
                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.ToString());
                }
            }
            else
                MessageBox.Show("No fisherman ID given");
        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Fishermen " + "SET Lid = @Lid, SAid = @SAid, FMName = @FMName, Supply = @Supply " + "WHERE FMid = @FMid", cs);
            int FMid = Int32.Parse(FMidText.Text);
            int Lid = Int32.Parse(LidText.Text);
            int SAid = Int32.Parse(SidText.Text);
            int supply = Int32.Parse(SupplyText.Text);
            command.Parameters.Add("@FMid", SqlDbType.Int);
            command.Parameters["@FMid"].Value = FMid;
            command.Parameters.Add("@Lid", SqlDbType.Int);
            command.Parameters["@Lid"].Value = Lid;
            command.Parameters.Add("@SAid", SqlDbType.Int);
            command.Parameters["@SAid"].Value = SAid;
            command.Parameters.Add("@FMName", SqlDbType.VarChar, 50);
            command.Parameters["@FMName"].Value = NameText.Text;
            command.Parameters.Add("@Supply", SqlDbType.Int);
            command.Parameters["@Supply"].Value = supply;
            try
            {
                daFishermen.UpdateCommand = command;
                int numberOfUpdatedFishermen = daFishermen.UpdateCommand.ExecuteNonQuery();
                if (numberOfUpdatedFishermen != 0)
                {
                    ReloadFishermenTableView();
                }
                else
                {
                    MessageBox.Show("No existing fisherman with given ID");
                }
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number == 2627)
                    MessageBox.Show("The fisherman id must be unique");
                else if (sqlException.Number == 547)
                    MessageBox.Show("There is no Lake with the given id");
                else
                    MessageBox.Show(sqlException.Message);
            }

        }

    }
}