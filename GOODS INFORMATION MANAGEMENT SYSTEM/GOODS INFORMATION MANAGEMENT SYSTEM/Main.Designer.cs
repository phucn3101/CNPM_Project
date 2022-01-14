
namespace GOODS_INFORMATION_MANAGEMENT_SYSTEM
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridcus = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtcusphone = new System.Windows.Forms.TextBox();
            this.txtcuspass = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.addCus = new System.Windows.Forms.Button();
            this.updatecus = new System.Windows.Forms.Button();
            this.deletecus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TblView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSetACcount = new GOODS_INFORMATION_MANAGEMENT_SYSTEM.DBSDataSetACcount();
            this.accountTableAdapter = new GOODS_INFORMATION_MANAGEMENT_SYSTEM.DBSDataSetACcountTableAdapters.accountTableAdapter();
            this.girdproduct = new System.Windows.Forms.DataGridView();
            this.gridcate = new System.Windows.Forms.DataGridView();
            this.btndeleteproduct = new System.Windows.Forms.Button();
            this.btnupdateproduct = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.txtproid = new System.Windows.Forms.TextBox();
            this.txtproprice = new System.Windows.Forms.TextBox();
            this.txtprodescription = new System.Windows.Forms.TextBox();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcatedescription = new System.Windows.Forms.TextBox();
            this.txtcateid = new System.Windows.Forms.TextBox();
            this.btnaddcate = new System.Windows.Forms.Button();
            this.btnupdatecate = new System.Windows.Forms.Button();
            this.btndeletecate = new System.Windows.Forms.Button();
            this.txtcatename = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtproimg = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combocate = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSetACcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 651);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridcus);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridcus
            // 
            this.gridcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcus.Location = new System.Drawing.Point(624, 3);
            this.gridcus.Name = "gridcus";
            this.gridcus.Size = new System.Drawing.Size(444, 619);
            this.gridcus.TabIndex = 7;
            this.gridcus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcus_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcusname);
            this.groupBox2.Controls.Add(this.txtcusphone);
            this.groupBox2.Controls.Add(this.txtcuspass);
            this.groupBox2.Controls.Add(this.txtcusid);
            this.groupBox2.Controls.Add(this.addCus);
            this.groupBox2.Controls.Add(this.updatecus);
            this.groupBox2.Controls.Add(this.deletecus);
            this.groupBox2.Location = new System.Drawing.Point(21, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 499);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUSTOMER";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Full Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer id";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtcusname
            // 
            this.txtcusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusname.Location = new System.Drawing.Point(224, 159);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(320, 26);
            this.txtcusname.TabIndex = 7;
            this.txtcusname.TextChanged += new System.EventHandler(this.txtcusname_TextChanged);
            // 
            // txtcusphone
            // 
            this.txtcusphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusphone.Location = new System.Drawing.Point(224, 221);
            this.txtcusphone.Name = "txtcusphone";
            this.txtcusphone.Size = new System.Drawing.Size(320, 26);
            this.txtcusphone.TabIndex = 6;
            this.txtcusphone.TextChanged += new System.EventHandler(this.txtcusphone_TextChanged);
            // 
            // txtcuspass
            // 
            this.txtcuspass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuspass.Location = new System.Drawing.Point(224, 283);
            this.txtcuspass.Name = "txtcuspass";
            this.txtcuspass.Size = new System.Drawing.Size(320, 26);
            this.txtcuspass.TabIndex = 5;
            this.txtcuspass.TextChanged += new System.EventHandler(this.txtcuspass_TextChanged);
            // 
            // txtcusid
            // 
            this.txtcusid.Enabled = false;
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(224, 96);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(320, 26);
            this.txtcusid.TabIndex = 4;
            this.txtcusid.TextChanged += new System.EventHandler(this.txtcusid_TextChanged);
            // 
            // addCus
            // 
            this.addCus.Location = new System.Drawing.Point(73, 382);
            this.addCus.Name = "addCus";
            this.addCus.Size = new System.Drawing.Size(118, 43);
            this.addCus.TabIndex = 1;
            this.addCus.Text = "ADD";
            this.addCus.UseVisualStyleBackColor = true;
            this.addCus.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatecus
            // 
            this.updatecus.Location = new System.Drawing.Point(263, 382);
            this.updatecus.Name = "updatecus";
            this.updatecus.Size = new System.Drawing.Size(118, 43);
            this.updatecus.TabIndex = 2;
            this.updatecus.Text = "UPDATE";
            this.updatecus.UseVisualStyleBackColor = true;
            this.updatecus.Click += new System.EventHandler(this.updatecus_Click);
            // 
            // deletecus
            // 
            this.deletecus.Location = new System.Drawing.Point(446, 382);
            this.deletecus.Name = "deletecus";
            this.deletecus.Size = new System.Drawing.Size(118, 43);
            this.deletecus.TabIndex = 3;
            this.deletecus.Text = "DELETE";
            this.deletecus.UseVisualStyleBackColor = true;
            this.deletecus.Click += new System.EventHandler(this.deletecus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.gridcate);
            this.tabPage2.Controls.Add(this.girdproduct);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "manage product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.TblView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1089, 625);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage account";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(39, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 499);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(224, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(224, 221);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(320, 26);
            this.txtFullName.TabIndex = 6;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(224, 283);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(320, 26);
            this.txtPhoneNum.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(224, 96);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(320, 26);
            this.txtUserName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(263, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 43);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TblView
            // 
            this.TblView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblView.Location = new System.Drawing.Point(642, 3);
            this.TblView.Name = "TblView";
            this.TblView.Size = new System.Drawing.Size(444, 619);
            this.TblView.TabIndex = 5;
            this.TblView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1089, 625);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.dBSDataSetACcount;
            // 
            // dBSDataSetACcount
            // 
            this.dBSDataSetACcount.DataSetName = "DBSDataSetACcount";
            this.dBSDataSetACcount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // girdproduct
            // 
            this.girdproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdproduct.Location = new System.Drawing.Point(624, 3);
            this.girdproduct.Name = "girdproduct";
            this.girdproduct.Size = new System.Drawing.Size(444, 420);
            this.girdproduct.TabIndex = 9;
            this.girdproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.girdproduct_CellContentClick);
            // 
            // gridcate
            // 
            this.gridcate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcate.Location = new System.Drawing.Point(624, 441);
            this.gridcate.Name = "gridcate";
            this.gridcate.Size = new System.Drawing.Size(444, 174);
            this.gridcate.TabIndex = 11;
            this.gridcate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcate_CellContentClick);
            // 
            // btndeleteproduct
            // 
            this.btndeleteproduct.Location = new System.Drawing.Point(444, 368);
            this.btndeleteproduct.Name = "btndeleteproduct";
            this.btndeleteproduct.Size = new System.Drawing.Size(118, 43);
            this.btndeleteproduct.TabIndex = 3;
            this.btndeleteproduct.Text = "DELETE";
            this.btndeleteproduct.UseVisualStyleBackColor = true;
            // 
            // btnupdateproduct
            // 
            this.btnupdateproduct.Location = new System.Drawing.Point(257, 368);
            this.btnupdateproduct.Name = "btnupdateproduct";
            this.btnupdateproduct.Size = new System.Drawing.Size(118, 43);
            this.btnupdateproduct.TabIndex = 2;
            this.btnupdateproduct.Text = "UPDATE";
            this.btnupdateproduct.UseVisualStyleBackColor = true;
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(70, 368);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(118, 43);
            this.btnaddproduct.TabIndex = 1;
            this.btnaddproduct.Text = "ADD";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // txtproid
            // 
            this.txtproid.Enabled = false;
            this.txtproid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproid.Location = new System.Drawing.Point(222, 35);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(320, 26);
            this.txtproid.TabIndex = 4;
            // 
            // txtproprice
            // 
            this.txtproprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproprice.Location = new System.Drawing.Point(222, 180);
            this.txtproprice.Name = "txtproprice";
            this.txtproprice.Size = new System.Drawing.Size(320, 26);
            this.txtproprice.TabIndex = 5;
            // 
            // txtprodescription
            // 
            this.txtprodescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprodescription.Location = new System.Drawing.Point(222, 133);
            this.txtprodescription.Name = "txtprodescription";
            this.txtprodescription.Size = new System.Drawing.Size(320, 26);
            this.txtprodescription.TabIndex = 6;
            // 
            // txtproname
            // 
            this.txtproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproname.Location = new System.Drawing.Point(222, 82);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(320, 26);
            this.txtproname.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Product Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Description";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.combocate);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txtproimg);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtproname);
            this.groupBox3.Controls.Add(this.txtprodescription);
            this.groupBox3.Controls.Add(this.txtproprice);
            this.groupBox3.Controls.Add(this.txtproid);
            this.groupBox3.Controls.Add(this.btnaddproduct);
            this.groupBox3.Controls.Add(this.btnupdateproduct);
            this.groupBox3.Controls.Add(this.btndeleteproduct);
            this.groupBox3.Location = new System.Drawing.Point(21, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 417);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUCT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtcatename);
            this.groupBox4.Controls.Add(this.btnaddcate);
            this.groupBox4.Controls.Add(this.btnupdatecate);
            this.groupBox4.Controls.Add(this.btndeletecate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtcatedescription);
            this.groupBox4.Controls.Add(this.txtcateid);
            this.groupBox4.Location = new System.Drawing.Point(39, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 173);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CATEGORY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(51, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Category id";
            // 
            // txtcatedescription
            // 
            this.txtcatedescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatedescription.Location = new System.Drawing.Point(224, 88);
            this.txtcatedescription.Name = "txtcatedescription";
            this.txtcatedescription.Size = new System.Drawing.Size(320, 26);
            this.txtcatedescription.TabIndex = 7;
            // 
            // txtcateid
            // 
            this.txtcateid.Enabled = false;
            this.txtcateid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcateid.Location = new System.Drawing.Point(224, 13);
            this.txtcateid.Name = "txtcateid";
            this.txtcateid.Size = new System.Drawing.Size(320, 26);
            this.txtcateid.TabIndex = 4;
            // 
            // btnaddcate
            // 
            this.btnaddcate.Location = new System.Drawing.Point(53, 126);
            this.btnaddcate.Name = "btnaddcate";
            this.btnaddcate.Size = new System.Drawing.Size(118, 47);
            this.btnaddcate.TabIndex = 1;
            this.btnaddcate.Text = "ADD";
            this.btnaddcate.UseVisualStyleBackColor = true;
            this.btnaddcate.Click += new System.EventHandler(this.btnaddcate_Click);
            // 
            // btnupdatecate
            // 
            this.btnupdatecate.Location = new System.Drawing.Point(239, 126);
            this.btnupdatecate.Name = "btnupdatecate";
            this.btnupdatecate.Size = new System.Drawing.Size(118, 47);
            this.btnupdatecate.TabIndex = 2;
            this.btnupdatecate.Text = "UPDATE";
            this.btnupdatecate.UseVisualStyleBackColor = true;
            this.btnupdatecate.Click += new System.EventHandler(this.btnupdatecate_Click);
            // 
            // btndeletecate
            // 
            this.btndeletecate.Location = new System.Drawing.Point(426, 126);
            this.btndeletecate.Name = "btndeletecate";
            this.btndeletecate.Size = new System.Drawing.Size(118, 47);
            this.btndeletecate.TabIndex = 3;
            this.btndeletecate.Text = "DELETE";
            this.btndeletecate.UseVisualStyleBackColor = true;
            this.btndeletecate.Click += new System.EventHandler(this.btndeletecate_Click);
            // 
            // txtcatename
            // 
            this.txtcatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatename.Location = new System.Drawing.Point(224, 50);
            this.txtcatename.Name = "txtcatename";
            this.txtcatename.Size = new System.Drawing.Size(320, 26);
            this.txtcatename.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(51, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Description";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(49, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Quantity";
            // 
            // txtproimg
            // 
            this.txtproimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproimg.Location = new System.Drawing.Point(222, 327);
            this.txtproimg.Name = "txtproimg";
            this.txtproimg.Size = new System.Drawing.Size(320, 26);
            this.txtproimg.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(77, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "IMG";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 26);
            this.textBox1.TabIndex = 16;
            // 
            // combocate
            // 
            this.combocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocate.FormattingEnabled = true;
            this.combocate.Location = new System.Drawing.Point(222, 233);
            this.combocate.Name = "combocate";
            this.combocate.Size = new System.Drawing.Size(320, 28);
            this.combocate.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 241);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "Category";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 652);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSetACcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView TblView;
        private DBSDataSetACcount dBSDataSetACcount;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DBSDataSetACcountTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridView gridcus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.TextBox txtcusphone;
        private System.Windows.Forms.TextBox txtcuspass;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Button addCus;
        private System.Windows.Forms.Button updatecus;
        private System.Windows.Forms.Button deletecus;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcatename;
        private System.Windows.Forms.Button btnaddcate;
        private System.Windows.Forms.Button btnupdatecate;
        private System.Windows.Forms.Button btndeletecate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcatedescription;
        private System.Windows.Forms.TextBox txtcateid;
        private System.Windows.Forms.DataGridView gridcate;
        private System.Windows.Forms.DataGridView girdproduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.TextBox txtprodescription;
        private System.Windows.Forms.TextBox txtproprice;
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.Button btnupdateproduct;
        private System.Windows.Forms.Button btndeleteproduct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtproimg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox combocate;
        private System.Windows.Forms.TextBox textBox1;
    }
}