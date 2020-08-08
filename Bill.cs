using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 
namespace CMS
{
    public partial class Bill : Form
    {
        int cid = 0,iId=0,custId=0;
        String empId="";
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=CrackersManagementSystem;Integrated Security=True");
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
          //  Image myimage = new Bitmap(@"E:\Study\SEM4\GUI Programming\Project\CMS\CMS\Resources\2560x1440 Animal Lion Blur.jpg");
            //this.BackgroundImage = myimage; 
            LoadData();
            GroupCustomer.Show();
            groupProduct.Hide();
            TxtBillId.Enabled = false;
            TxtPrice.Enabled = false;
            TxtItemId.Enabled = false;
            TxtTotalAmt.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void LoadData()
        {
            empId = Login.UserName;
            LblUser.Text ="User Name : "+ empId;
            try
            {
                con.Close();
                SqlDataReader dr0;
                cmd = new SqlCommand("select MAX(billid) from tblBill; ", con);
                con.Open();
                dr0 = cmd.ExecuteReader();
                while (dr0.Read())
                {
                    int id = Convert.ToInt32(dr0.GetValue(0));
                    TxtBillId.Text = (id + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                TxtBillId.Text = "1";
            }
            
            con.Close();
            SqlDataReader dr,dr1,dr2;
            cmd = new SqlCommand("select categoryName from tblICategory;", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbCatagoryName.Items.Add(dr[0]);
            }
            con.Close();
            
            cmd = new SqlCommand("select name from tblSubcategory ;", con);
            con.Open();
            dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cbSubcategoryName.Items.Add(dr2[0]);
                
            }
            con.Close();
            cmd = new SqlCommand("select Fname,Lname from tblCustomer;", con);
            con.Open();
            dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cbFirstName.Items.Add(dr2[0]);
            }
            con.Close();
            SqlDataReader dr3;
            cmd = new SqlCommand("select Fname,Lname from tblCustomer;", con);
            con.Open();
            dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                CbLastName.Items.Add(dr3[1]);
            }
            con.Close();
            //throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Close();
            SqlDataReader dr1;
            cmd = new SqlCommand("select categoryId from tblICategory where categoryName='" + cbCatagoryName.Text + "';", con);
            con.Open();
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                cid = Convert.ToInt32(dr1.GetValue(0).ToString());
                
            }

            con.Close();
            cbSubcategoryName.Items.Clear();
            SqlDataReader dr;
            con.Close();
            cmd = new SqlCommand("select name from tblSubcategory where categoryId=" + cid + ";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbSubcategoryName.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select subcategoryId,price from tblSubcategory where name='" + cbSubcategoryName.SelectedItem + "';", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                iId = Convert.ToInt32(dr.GetValue(0).ToString());
                TxtPrice.Text = dr[0].ToString();
            }
            con.Close();
            TxtItemId.Text = iId.ToString();
        }

        private void TxtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(AvilQty.Text) < Convert.ToInt32(TxtQty.Text))
                {
                    LblError.Text = "not enough qty try less qty";
                    TxtQty.Focus();

                }
                else
                {

                    int TotalAmt = Convert.ToInt32(TxtPrice.Text) * Convert.ToInt32(TxtQty.Text);
                    TxtTotalAmt.Text = TotalAmt.ToString();
                    LblError.Text = " ";
                }
            }
            catch(Exception ex)
            {
                //LblError.Text = "Don't forget Qty";
            }
        }

        private void cbFirstName_Leave(object sender, EventArgs e)
        {
            CbLastName.Items.Clear();
            SqlDataReader dr3;
            cmd = new SqlCommand("select Lname from tblCustomer where FName='"+cbFirstName.Text+"';", con);
            con.Open();
            dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                CbLastName.Items.Add(dr3[0]);
            }
            con.Close();
        }

        private void CbLastName_Leave(object sender, EventArgs e)
        {
            CbLastName.Items.Clear();
            SqlDataReader dr3;
            cmd = new SqlCommand("select CustId from tblCustomer where FName='"+cbFirstName.Text+"'and LName='"+CbLastName.Text+"';", con);
            con.Open();
            dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                custId = Convert.ToInt32(dr3.GetValue(0).ToString());
            }
            con.Close();
        }

        private void  BtnEnable_Click(object sender, EventArgs e)
        {
            TxtBillId.Enabled = true;
            TxtPrice.Enabled = true;
            TxtItemId.Enabled = true;
            TxtTotalAmt.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void BtnAddcus_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(AvilQty.Text) >= Convert.ToInt32(TxtQty.Text))
                {
                    ListViewItem item = new ListViewItem(TxtBillId.Text);
                    item.SubItems.Add(cbSubcategoryName.Text);
                    item.SubItems.Add(TxtPrice.Text);
                    item.SubItems.Add(TxtQty.Text);
                    item.SubItems.Add(cbFirstName.Text + " " + CbLastName.Text);
                    item.SubItems.Add((dateTimePicker1.Value).ToString());

                    listViewItems.Items.Add(item);

                    con.Close();
                    cmd = new SqlCommand("insert into tblBill values (" + TxtBillId.Text + "," + TxtItemId.Text + ",'" + cbSubcategoryName.Text + "'," + custId + ",'" + cbFirstName.Text + " " + CbLastName.Text + "'," + TxtPrice.Text + "," + TxtQty.Text + "," + TxtTotalAmt.Text + ",'" + dateTimePicker1.Value + "','" + empId + "');", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd = new SqlCommand("update tblSubcategory set quantity=quantity-" + TxtQty.Text + " where subcategoryId=" + TxtItemId.Text + ";", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    BindData();
                    ResetData();
                    cbCatagoryName.Focus();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                LblError.Text = "Fill Details First";
            }
        }

        private void BindData()
        {
            int totalAmt = 0,totalQty=0;
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from tblBill where billId="+TxtBillId.Text+";", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            SqlDataReader dr3;
            cmd = new SqlCommand("select totalAmt,qty from tblBill where billId=" + TxtBillId.Text + ";", con);
            con.Open();
            dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                int Amt = Convert.ToInt32(dr3.GetValue(0).ToString());
                int Qty= Convert.ToInt32(dr3.GetValue(1).ToString());
                totalAmt = totalAmt + Amt;
                totalQty = totalQty + Qty;
            }
            con.Close();
           // throw new NotImplementedException();
            LblTotalAmount.Text = "Total Amount : " + totalAmt.ToString();
            LblQty.Text = "Total Qty : " + totalQty.ToString();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetData();

        }

        private void ResetData()
        {
            cbCatagoryName.ResetText();
            cbSubcategoryName.ResetText();
            TxtPrice.ResetText();
            TxtQty.ResetText();
           // CbLastName.ResetText();
            //cbFirstName.ResetText();
            TxtItemId.ResetText();
            TxtTotalAmt.ResetText();
            AvilQty.ResetText();
            //throw new NotImplementedException();
            TxtItemId.ForeColor = Color.White;
        }

        private void listViewItems_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            TxtItemId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("delete from tblBill where itemId=" + TxtItemId.Text + " and billId=" + TxtBillId.Text + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                BindData();
                TxtItemId.ForeColor = Color.White;
                LblError.Text = "Item Removed";
            }
            catch (Exception ex)
            {
                TxtItemId.BackColor = Color.Red;
                LblError.Text = "select Item id first.";
            }

        }

        private void BtnPrintBill_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4_LANDSCAPE,10,10,10,10);
            PdfWriter.GetInstance(document, new FileStream("E:/Study/SEM4/GUI Programming/Project/CMS/"+TxtBillId.Text + ".pdf", FileMode.Create));
            document.Open();

            Paragraph p = new Paragraph("Fire Works");
            p.Alignment=Element.ALIGN_CENTER;
            document.Add(p);

            p = new Paragraph("Date:" + dateTimePicker1.Value);
            p.Alignment = Element.ALIGN_RIGHT;
            document.Add(p);

            p = new Paragraph("\n Bill Id:" + TxtBillId.Text);
            document.Add(p);

            p = new Paragraph("\n Customer Name:"+cbFirstName.Text+CbLastName.Text);
            document.Add(p);

            

            SqlDataAdapter da;
            DataTable order = new DataTable();

            con.Close();
            con.Open();
            da = new SqlDataAdapter("select itemName as 'Item name',customerName as 'Customer name',price as 'MRP',qty as 'QTY',totalAmt as 'Amount' from tblBill where billId="+TxtBillId.Text+";", con);
            da.Fill(order);

            con.Close();

            p = new Paragraph("\n\n");
            document.Add(p);
            int totalAmount = 0;

            PdfPTable table = new PdfPTable(order.Columns.Count);

            for (int i = 0; i < order.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.AddElement(new Chunk(order.Columns[i].ColumnName.ToUpper()));
                table.AddCell(cell);
            }

            for (int i = 0; i < order.Rows.Count; i++)
            {
                for (int j = 0; j < order.Columns.Count; j++)
                {
                    table.AddCell(order.Rows[i][j].ToString());
                }
                totalAmount = totalAmount + Convert.ToInt32(order.Rows[i][4].ToString());
            }
            document.Add(table);

            p = new Paragraph("Total Amount : "+ totalAmount.ToString());
            p.Alignment = Element.ALIGN_RIGHT;
            document.Add(p);

            p = new Paragraph("\nSold by : \n" + Login.UserName);
            document.Add(p);

            p = new Paragraph("\n\n____________________\n          Signature" );
            document.Add(p);
            document.Close();

            MessageBox.Show("Pdf Created at" + "\n E:/Study/SEM4/GUI Programming/Project/CMS/"+ " As "+TxtBillId.Text+",pdf");
           
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            cbFirstName.Enabled = false;
            CbLastName.Enabled = false;
        }

        private void cbSubcategoryName_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                SqlDataReader dr3;
                cmd = new SqlCommand("select quantity from tblSubcategory where subcategoryId=" + TxtItemId.Text + ";", con);
                con.Open();
                dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {
                    AvilQty.Text = dr3.GetValue(0).ToString();
                }
                con.Close();
                cbSubcategoryName.BackColor = Color.White;
                LblError.Text = "";
            }
            catch
            {
                LblError.Text = "Select product";
                cbSubcategoryName.Focus();
                cbSubcategoryName.BackColor = Color.OrangeRed;
            }
        }

        private void BtnContinue_Leave(object sender, EventArgs e)
        {
            cbFirstName.Enabled = false;
            CbLastName.Enabled = false;
        }

        private void btnNextCust_Click(object sender, EventArgs e)
        {
            GroupCustomer.Hide();
            groupProduct.Show();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            GroupCustomer.Show();
            groupProduct.Hide();
        }

        private void btnNextCust_Leave(object sender, EventArgs e)
        {
            GroupCustomer.Hide();
            groupProduct.Show();
        }

        private void BtnPrevious_Leave(object sender, EventArgs e)
        {
            //GroupCustomer.Show();
            //groupProduct.Hide();
        }

        private void BtnSerchItem_Click(object sender, EventArgs e)
        {
            SearchItemForm sif = new SearchItemForm();
            sif.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMS.SearchCustomer sc = new SearchCustomer();
            sc.Show();
        }
    }
}
