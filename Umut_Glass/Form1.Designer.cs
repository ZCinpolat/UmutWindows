namespace Umut_Glass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Date = new MetroFramework.Controls.MetroLabel();
            this.txtClientName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.btnClose);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 691);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(844, 37);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(675, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(761, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.grdProduct);
            this.metroPanel2.Controls.Add(this.txtTotalPrice);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtInvoiceNo);
            this.metroPanel2.Controls.Add(this.dtDate);
            this.metroPanel2.Controls.Add(this.txtAddress);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.Date);
            this.metroPanel2.Controls.Add(this.txtClientName);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(844, 631);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // grdProduct
            // 
            this.grdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Total});
            this.grdProduct.ContextMenuStrip = this.metroContextMenu1;
            this.grdProduct.Location = new System.Drawing.Point(15, 145);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(817, 480);
            this.grdProduct.TabIndex = 5;
            this.grdProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellValueChanged);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "NAME";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 400;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QTY";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PRICE";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle8;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "TOTAL";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 170;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLineToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(133, 26);
            // 
            // deleteLineToolStripMenuItem
            // 
            this.deleteLineToolStripMenuItem.Name = "deleteLineToolStripMenuItem";
            this.deleteLineToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteLineToolStripMenuItem.Text = "Delete Line";
            this.deleteLineToolStripMenuItem.Click += new System.EventHandler(this.deleteLineToolStripMenuItem_Click);
            // 
            // txtTotalPrice
            // 
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[] {
        " "};
            this.txtTotalPrice.Location = new System.Drawing.Point(101, 97);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 23);
            this.txtTotalPrice.TabIndex = 4;
            this.txtTotalPrice.Text = " ";
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Total Price";
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.Lines = new string[] {
        " "};
            this.txtInvoiceNo.Location = new System.Drawing.Point(307, 42);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(200, 23);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.Text = " ";
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDate
            // 
            this.dtDate.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(101, 7);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(107, 29);
            this.dtDate.TabIndex = 0;
            this.dtDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(701, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[] {
        " "};
            this.txtAddress.Location = new System.Drawing.Point(101, 71);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(723, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = " ";
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Name";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(15, 16);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 19);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            // 
            // txtClientName
            // 
            // 
            // 
            // 
            this.txtClientName.CustomButton.Image = null;
            this.txtClientName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtClientName.CustomButton.Name = "";
            this.txtClientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientName.CustomButton.TabIndex = 1;
            this.txtClientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientName.CustomButton.UseSelectable = true;
            this.txtClientName.CustomButton.Visible = false;
            this.txtClientName.Lines = new string[0];
            this.txtClientName.Location = new System.Drawing.Point(101, 42);
            this.txtClientName.MaxLength = 32767;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PasswordChar = '\0';
            this.txtClientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientName.SelectedText = "";
            this.txtClientName.SelectionLength = 0;
            this.txtClientName.SelectionStart = 0;
            this.txtClientName.ShortcutsEnabled = true;
            this.txtClientName.Size = new System.Drawing.Size(200, 23);
            this.txtClientName.TabIndex = 1;
            this.txtClientName.UseSelectable = true;
            this.txtClientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(513, 42);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(144, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Save Invoice Number";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 748);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Invoice Details";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Date;
        private MetroFramework.Controls.MetroTextBox txtClientName;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem deleteLineToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

