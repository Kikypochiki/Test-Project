namespace TestProject
{
    partial class TestProject
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestProject));
            label1 = new Label();
            lbl_name = new Label();
            txtbx_name = new TextBox();
            txtbx_dateOfBirth = new TextBox();
            lbl_dateOfBirth = new Label();
            txtbx_address = new TextBox();
            lbl_address = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_clear = new Button();
            dgv_listOfPeople = new DataGridView();
            lbl_search = new Label();
            txtbx_search = new TextBox();
            close_app = new PictureBox();
            lbl_gender = new Label();
            cb_gender = new ComboBox();
            lbl_id = new Label();
            txtbx_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_listOfPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_app).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(956, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 60);
            label1.TabIndex = 0;
            label1.Text = "Test Project";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = SystemColors.Control;
            lbl_name.Font = new Font("Arial", 13.875F);
            lbl_name.Location = new Point(94, 373);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(116, 42);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Name";
            // 
            // txtbx_name
            // 
            txtbx_name.Font = new Font("Arial", 13.875F);
            txtbx_name.Location = new Point(362, 365);
            txtbx_name.Name = "txtbx_name";
            txtbx_name.Size = new Size(556, 50);
            txtbx_name.TabIndex = 2;
            // 
            // txtbx_dateOfBirth
            // 
            txtbx_dateOfBirth.Font = new Font("Arial", 13.875F);
            txtbx_dateOfBirth.Location = new Point(362, 445);
            txtbx_dateOfBirth.Name = "txtbx_dateOfBirth";
            txtbx_dateOfBirth.Size = new Size(556, 50);
            txtbx_dateOfBirth.TabIndex = 4;
            // 
            // lbl_dateOfBirth
            // 
            lbl_dateOfBirth.AutoSize = true;
            lbl_dateOfBirth.BackColor = SystemColors.Control;
            lbl_dateOfBirth.Font = new Font("Arial", 13.875F);
            lbl_dateOfBirth.Location = new Point(94, 448);
            lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            lbl_dateOfBirth.Size = new Size(221, 42);
            lbl_dateOfBirth.TabIndex = 3;
            lbl_dateOfBirth.Text = "Date of Birth";
            // 
            // txtbx_address
            // 
            txtbx_address.Font = new Font("Arial", 13.875F);
            txtbx_address.Location = new Point(362, 525);
            txtbx_address.Name = "txtbx_address";
            txtbx_address.Size = new Size(556, 50);
            txtbx_address.TabIndex = 6;
            txtbx_address.TextChanged += textBox3_TextChanged;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.BackColor = SystemColors.Control;
            lbl_address.Font = new Font("Arial", 13.875F);
            lbl_address.Location = new Point(94, 528);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(153, 42);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "Address";
            lbl_address.Click += label4_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Chocolate;
            btn_add.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(670, 832);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(152, 100);
            btn_add.TabIndex = 7;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Chocolate;
            btn_edit.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(895, 832);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(152, 100);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Chocolate;
            btn_delete.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(1123, 832);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(228, 100);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Chocolate;
            btn_clear.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(1413, 832);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(196, 100);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // dgv_listOfPeople
            // 
            dgv_listOfPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listOfPeople.Location = new Point(971, 286);
            dgv_listOfPeople.Name = "dgv_listOfPeople";
            dgv_listOfPeople.RowHeadersWidth = 82;
            dgv_listOfPeople.Size = new Size(1258, 522);
            dgv_listOfPeople.TabIndex = 11;
            dgv_listOfPeople.RowHeaderMouseClick += dgv_listOfPeople_RowHeaderMouseClick;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_search.Location = new Point(971, 212);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(135, 42);
            lbl_search.TabIndex = 12;
            lbl_search.Text = "Search";
            // 
            // txtbx_search
            // 
            txtbx_search.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbx_search.Location = new Point(1112, 204);
            txtbx_search.Name = "txtbx_search";
            txtbx_search.Size = new Size(1117, 50);
            txtbx_search.TabIndex = 13;
            // 
            // close_app
            // 
            close_app.Image = (Image)resources.GetObject("close_app.Image");
            close_app.Location = new Point(2189, 12);
            close_app.Name = "close_app";
            close_app.Size = new Size(73, 65);
            close_app.SizeMode = PictureBoxSizeMode.StretchImage;
            close_app.TabIndex = 14;
            close_app.TabStop = false;
            close_app.Click += close_app_Click;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.BackColor = SystemColors.Control;
            lbl_gender.Font = new Font("Arial", 13.875F);
            lbl_gender.Location = new Point(94, 610);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(141, 42);
            lbl_gender.TabIndex = 15;
            lbl_gender.Text = "Gender";
            lbl_gender.Click += label2_Click;
            // 
            // cb_gender
            // 
            cb_gender.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cb_gender.Location = new Point(362, 601);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(292, 50);
            cb_gender.TabIndex = 16;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = SystemColors.Control;
            lbl_id.Font = new Font("Arial", 13.875F);
            lbl_id.Location = new Point(94, 304);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(54, 42);
            lbl_id.TabIndex = 17;
            lbl_id.Text = "ID";
            lbl_id.Click += label2_Click_1;
            // 
            // txtbx_id
            // 
            txtbx_id.Font = new Font("Arial", 13.875F);
            txtbx_id.Location = new Point(362, 286);
            txtbx_id.Name = "txtbx_id";
            txtbx_id.Size = new Size(118, 50);
            txtbx_id.TabIndex = 18;
            // 
            // TestProject
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2274, 1110);
            Controls.Add(txtbx_id);
            Controls.Add(lbl_id);
            Controls.Add(cb_gender);
            Controls.Add(lbl_gender);
            Controls.Add(close_app);
            Controls.Add(txtbx_search);
            Controls.Add(lbl_search);
            Controls.Add(dgv_listOfPeople);
            Controls.Add(btn_clear);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txtbx_address);
            Controls.Add(lbl_address);
            Controls.Add(txtbx_dateOfBirth);
            Controls.Add(lbl_dateOfBirth);
            Controls.Add(txtbx_name);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestProject";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listOfPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_app).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
        }

        #endregion

        private Label label1;
        private Label lbl_name;
        private TextBox txtbx_name;
        private TextBox txtbx_dateOfBirth;
        private Label lbl_dateOfBirth;
        private TextBox txtbx_address;
        private Label lbl_address;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_clear;
        private DataGridView dgv_listOfPeople;
        private Label lbl_search;
        private TextBox txtbx_search;
        private PictureBox close_app;
        private Label lbl_gender;
        private ComboBox cb_gender;
        private Label lbl_id;
        private TextBox txtbx_id;
    }
}
