namespace GRPC_Form_App
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            getData_btn = new Button();
            label4 = new Label();
            search_txt = new TextBox();
            search_btn = new Button();
            savechange_btn = new Button();
            label3 = new Label();
            price_txt = new TextBox();
            label2 = new Label();
            brand_txt = new TextBox();
            label1 = new Label();
            name_txt = new TextBox();
            groupBox2 = new GroupBox();
            datagrid_product = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_product).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(getData_btn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(search_txt);
            groupBox1.Controls.Add(search_btn);
            groupBox1.Controls.Add(savechange_btn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(price_txt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(brand_txt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(name_txt);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // getData_btn
            // 
            getData_btn.BackColor = Color.Honeydew;
            getData_btn.FlatAppearance.BorderColor = Color.LightGreen;
            getData_btn.FlatAppearance.BorderSize = 2;
            getData_btn.FlatStyle = FlatStyle.Flat;
            getData_btn.Location = new Point(715, 11);
            getData_btn.Name = "getData_btn";
            getData_btn.Size = new Size(53, 15);
            getData_btn.TabIndex = 11;
            getData_btn.UseVisualStyleBackColor = false;
            getData_btn.Click += getData_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 19);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Search...";
            // 
            // search_txt
            // 
            search_txt.Location = new Point(557, 37);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(152, 23);
            search_txt.TabIndex = 9;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(715, 32);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(53, 30);
            search_btn.TabIndex = 8;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // savechange_btn
            // 
            savechange_btn.Location = new Point(441, 32);
            savechange_btn.Name = "savechange_btn";
            savechange_btn.Size = new Size(110, 30);
            savechange_btn.TabIndex = 7;
            savechange_btn.Text = "SaveChange";
            savechange_btn.UseVisualStyleBackColor = true;
            savechange_btn.Click += savechange_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 19);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // price_txt
            // 
            price_txt.Location = new Point(296, 37);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(139, 23);
            price_txt.TabIndex = 5;
            price_txt.KeyPress += price_txt_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Brand";
            // 
            // brand_txt
            // 
            brand_txt.Location = new Point(151, 37);
            brand_txt.Name = "brand_txt";
            brand_txt.Size = new Size(139, 23);
            brand_txt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(6, 37);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(139, 23);
            name_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(datagrid_product);
            groupBox2.Location = new Point(12, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 347);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // datagrid_product
            // 
            datagrid_product.AllowUserToDeleteRows = false;
            datagrid_product.AllowUserToResizeColumns = false;
            datagrid_product.AllowUserToResizeRows = false;
            datagrid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            datagrid_product.BackgroundColor = Color.White;
            datagrid_product.BorderStyle = BorderStyle.None;
            datagrid_product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_product.Location = new Point(6, 22);
            datagrid_product.Name = "datagrid_product";
            datagrid_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_product.Size = new Size(762, 319);
            datagrid_product.TabIndex = 0;
            datagrid_product.VirtualMode = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid_product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox name_txt;
        private GroupBox groupBox2;
        private Button savechange_btn;
        private Label label3;
        private TextBox price_txt;
        private Label label2;
        private TextBox brand_txt;
        private DataGridView datagrid_product;
        private Label label4;
        private TextBox search_txt;
        private Button search_btn;
        private Button getData_btn;
    }
}
