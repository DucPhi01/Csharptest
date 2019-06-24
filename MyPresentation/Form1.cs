using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPresentation
{
    public partial class Form1 : Form
    {
        public static DataSet SvDataSet = new DataSet("KhoaDataSet");
        public static String BANGKHOA = "dbo.KHOA";
        bool AddNew = false;
        public Form1()
        {
            InitializeComponent();
            MyConnection Mc = new MyConnection();
            Mc.fillDataSet(SvDataSet, @"Server=localhost\SQLEXPRESS;uid=sa;pwd=123123;database=QLSVien", "Select * from dbo.KHOA");
            bool checkDataSource = loadDataSource(SvDataSet, "dbo.KHOA", KhoaDataGridView);
            KhoaDataGridView.Columns["NAMTHANHLAP"].Visible = false;
            AddDataSetToCbx(SvDataSet, CbxMaKhoa, BANGKHOA);
            TxtTongKhoa.Text = Convert.ToString(SvDataSet.Tables[BANGKHOA].Rows.Count);
        }



        /// <summary>
        /// tong quat viec fill vao DataGridView
        /// </summary>
        /// <param name="Dg">Your DataGridView</param>
        /// <param name="Ds">Dataset you work with</param>
        /// <param name="tableName">tablename fill in dataGridView</param>
        /// <returns></returns>
        private bool loadDataSource(DataSet Ds, String tableName, DataGridView Dg)
        {
            Dg.DataSource = Ds.Tables[tableName];
            if (Dg.DataSource != null) return true;
            return false;
        }

        private void AddDataSetToCbx(DataSet Ds, ComboBox cbx, String TableName)
        {
            foreach (DataRow item in Ds.Tables[TableName].Rows)
            {
                cbx.Items.Add(item["MAKHOA"]);
            }
        }
        /// <summary>
        /// find information base on input
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Ds"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        private DataRow findInformationByPK(String Text, DataSet Ds, String TableName)
        {
            foreach (DataRow item in Ds.Tables[TableName].Rows)
            {
                    if (item["MAKHOA"].ToString().Equals(Text))
                    {
                        return item;
                    }
            }
            return null;
        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {

        }

        private void MaKhoaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedItem = CbxMaKhoa.SelectedItem.ToString();
            DataRow item = findInformationByPK(SelectedItem, SvDataSet, BANGKHOA);
            int Index = SvDataSet.Tables[BANGKHOA].Rows.IndexOf(item);// tìm index
            KhoaDataGridView.ClearSelection();
            KhoaDataGridView.Rows[Index].Selected = true;// chọn hàng trùng vs index
            // fill in the blank
            TxtTenKhoa.Text = item["TENKHOA"].ToString();
            TxtMaKhoa.Text = item["MAKHOA"].ToString();
            TxtTenKhoa2.Text = item["TENKHOA"].ToString();
            TxtNamThanhLap.Text = item["NAMTHANHLAP"].ToString();
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
            TxtMaKhoa.Enabled = false;
        }
        /// <summary>
        /// Addd new Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!AddNew)
            {
                ClearDataSelection();
                AddNew = true;
                TxtMaKhoa.Enabled = true;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
                CbxMaKhoa.Enabled = false;
                TxtMaKhoa.Focus();
            }
            else
            {
                DataRow NewKhoa = SvDataSet.Tables[BANGKHOA].NewRow();
                NewKhoa["MAKHOA"] = TxtMaKhoa.Text;
                NewKhoa["TENKHOA"] = TxtTenKhoa2.Text;
                NewKhoa["NAMTHANHLAP"] = int.Parse(TxtNamThanhLap.Text);
                SvDataSet.Tables[BANGKHOA].Rows.Add(NewKhoa);
                AddNew = false;
                CbxMaKhoa.Enabled = true;
                ClearDataSelection();
                MessageBox.Show("Them thanh cong", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
        private void ClearDataSelection()
        {
            TxtMaKhoa.Text = null;
            TxtTenKhoa2.Text = null;
            TxtNamThanhLap.Text = null;
            KhoaDataGridView.ClearSelection();
        }
        // 1 hàm cập nhật cbx


        private void KhoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDataGridView.ClearSelection();
            
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataRow DataNeedDeleted = findInformationByPK(CbxMaKhoa.Text, SvDataSet, BANGKHOA);
            if (SvDataSet.Tables[BANGKHOA].Rows.IndexOf(DataNeedDeleted) >= 0)
            {
                int DeleteIndex=SvDataSet.Tables[BANGKHOA].Rows.IndexOf(DataNeedDeleted);
                SvDataSet.Tables[BANGKHOA].Rows[DeleteIndex].Delete();
            }
            else
            {
                MessageBox.Show("Chon dong de xoa", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataRow DataNeedUpdated = findInformationByPK(CbxMaKhoa.Text, SvDataSet, BANGKHOA);
            if (DataNeedUpdated != null)
            {
                DataNeedUpdated["MAKHOA"] = TxtMaKhoa.Text;
                DataNeedUpdated["TENKHOA"] = TxtTenKhoa2.Text;
                DataNeedUpdated["NAMTHANHLAP"] = TxtNamThanhLap.Text;
                TxtTenKhoa.Text = TxtTenKhoa2.Text;
                MessageBox.Show("Sua thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chon 1 dong de Sua", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
