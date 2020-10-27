
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umut_Glass.Data_Set;

namespace Umut_Glass
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public DataTable oDtProduct = new DataTable();
        public bool changing = false;
        public decimal toplamMatrah = 0;
        public decimal toplamIndirim = 0;
        public decimal toplamKDV = 0;
        public decimal toplam = 0;
        public int lastInvoiceNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateInvoiceNo();
                GenerateTable();
                grdProduct.DataSource = oDtProduct;
                changing = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "error : " + ex.Message, "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.reportViewer1.RefreshReport();
        }


        private void GenerateInvoiceNo()
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory + "Print\\InvoiceNumberFile.txt";
                string text = System.IO.File.ReadAllText(path);
                int invoiceNoLength = text.Length;
                string leftside = "";

                for (int i = 0; i < 5 - invoiceNoLength; i++)
                {
                    leftside += "0";
                }

                int invoiceNo = Convert.ToInt32(text);
                this.lastInvoiceNumber = invoiceNo;
                txtInvoiceNo.Text = leftside + Convert.ToString(invoiceNo + 1);
            }
            catch (Exception)
            {

                txtInvoiceNo.Text = "0";
            }
           

        }



        private void GenerateTable()
        {
            oDtProduct = new DataTable();
            DataColumn Dc = new DataColumn("NAME", typeof(String));
            DataColumn Dc1 = new DataColumn("QTY", typeof(Decimal));
            DataColumn Dc2 = new DataColumn("PRICE", typeof(Decimal));
            DataColumn Dc3 = new DataColumn("TOTAL", typeof(Decimal));
            oDtProduct.Columns.Add(Dc);
            oDtProduct.Columns.Add(Dc1);
            oDtProduct.Columns.Add(Dc2);
            oDtProduct.Columns.Add(Dc3);
        }
       

        private void deleteLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                grdProduct.Rows.Remove(grdProduct.Rows[grdProduct.SelectedCells[0].RowIndex]);
                ToplamHesapla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "error : " + ex.Message, "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                dsOffer ds = new dsOffer();
                //SET HEADER 
                DataRow dr = ds.Tables[0].NewRow();
                dr["CLIENT_NAME"] = txtClientName.Text;
                dr["CLIENT_ADDRESS1"] = txtAddress.Text;
                dr["REFNO"] = txtInvoiceNo.Text;
                dr["DATE_"] = dtDate.Value;
                dr["TOTAL"] = toplam;
                ds.Tables[0].Rows.Add(dr);
                //SET DETAIL
                foreach (DataRow _dr in oDtProduct.Rows)
                {
                    DataRow drDetail = ds.Tables[1].NewRow();
                    drDetail["NAME"] = _dr["NAME"];
                    drDetail["QTY"] = _dr["QTY"];
                    drDetail["PRICE"] = _dr["PRICE"];
                    drDetail["LINENET"] = _dr["TOTAL"];
                    ds.Tables[1].Rows.Add(drDetail);
                }

                frm_Print_Preview f_Prnt = new frm_Print_Preview("Invoice.rdlc", "Invoice", ds);
                f_Prnt.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "error : " + ex.Message, "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 1|| e.ColumnIndex == 2)
            {
                if (changing)
                    return;
                try
                {
                    int selectedrowindex = grdProduct.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = grdProduct.Rows[selectedrowindex];
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            changing = true;
                            selectedRow.Cells[3].Value = (Decimal)selectedRow.Cells[2].Value * (Decimal)selectedRow.Cells[1].Value;
                            break;
                        case 2:
                            changing = true;
                            selectedRow.Cells[3].Value = (Decimal)selectedRow.Cells[2].Value * (Decimal)selectedRow.Cells[1].Value;
                            break;
                    }

                    changing = false;
                    toplam += (decimal)selectedRow.Cells[3].Value;
                    txtTotalPrice.Text = Convert.ToString(toplam);
                }
                catch
                {
                    changing = false;
                }

            }
        }

         private void ToplamHesapla()
        {
            toplam = 0;
            foreach (DataRow dr in oDtProduct.Rows)
            {
                toplam += (decimal)dr[3];
            }
            txtTotalPrice.Text = Convert.ToString(toplam);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                MessageBox.Show(this, "Invoice number is not valid", "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string strInvoiceNo = txtInvoiceNo.Text;
                int newInvoiceNumber = Convert.ToInt32(strInvoiceNo);
                if(newInvoiceNumber <= lastInvoiceNumber)
                {
                    MessageBox.Show(this, "This number has been used. (BU FATURA NUMARASI DAHA ÖNCE KULLANILMIŞ!!!)", "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string path = System.AppDomain.CurrentDomain.BaseDirectory + "Print\\InvoiceNumberFile.txt";
                    System.IO.File.WriteAllText(path, Convert.ToString(newInvoiceNumber));
                    MessageBox.Show(this, "FATURA NUMARASI KAYDEDİLDİ. BİR SONRAKİ FATURA NO = "+ (newInvoiceNumber +1).ToString(), "System Messsage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
    }
}
