namespace DevTaskApp
{
    partial class addUserForm

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserForm));
            this.lblOib = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchOib = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchOib = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Location = new System.Drawing.Point(12, 9);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(33, 20);
            this.lblOib.TabIndex = 0;
            this.lblOib.Text = "OIB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name and Surname";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(12, 98);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(44, 20);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Place";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(378, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(378, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(378, 98);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 20);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(158, 9);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(204, 27);
            this.txtOib.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 7;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(158, 98);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(204, 27);
            this.txtPlace.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(446, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(446, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 27);
            this.txtPhone.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(446, 98);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(204, 27);
            this.txtMail.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(533, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 59);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(533, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 61);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 61);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Location = new System.Drawing.Point(12, 339);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(638, 219);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(12, 186);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(114, 20);
            this.lblSearchName.TabIndex = 14;
            this.lblSearchName.Text = "Search by name";
            // 
            // lblSearchOib
            // 
            this.lblSearchOib.AutoSize = true;
            this.lblSearchOib.Location = new System.Drawing.Point(12, 232);
            this.lblSearchOib.Name = "lblSearchOib";
            this.lblSearchOib.Size = new System.Drawing.Size(101, 20);
            this.lblSearchOib.TabIndex = 15;
            this.lblSearchOib.Text = "Search by OIB";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(158, 183);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(282, 27);
            this.txtSearchName.TabIndex = 16;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // txtSearchOib
            // 
            this.txtSearchOib.Location = new System.Drawing.Point(158, 225);
            this.txtSearchOib.Name = "txtSearchOib";
            this.txtSearchOib.Size = new System.Drawing.Size(282, 27);
            this.txtSearchOib.TabIndex = 17;
            this.txtSearchOib.TextChanged += new System.EventHandler(this.txtSearchOib_TextChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(287, 272);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(117, 61);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // addUserForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 570);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSearchOib);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSearchOib);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lblOib);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGrid);
            this.Name = "addUserForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOib;
        private Label lblName;
        private Label lblPlace;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblMail;
        private TextBox txtOib;
        private TextBox txtName;
        private TextBox txtPlace;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtMail;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGrid;
        private Label lblSearchName;
        private Label lblSearchOib;
        private TextBox txtSearchName;
        private TextBox txtSearchOib;
        private Button btnImport;
    }
}