
namespace CMPG223_Assignment
{
    partial class Author_Form
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAuthorId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertAuthor = new System.Windows.Forms.Button();
            this.txtEnterAuthorSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterAuthorId = new System.Windows.Forms.TextBox();
            this.txtEnterAuthorname = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGWAuthor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGWAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(739, 496);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(147, 63);
            this.btnSelect.TabIndex = 52;
            this.btnSelect.Text = "Select Auhtor for order";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(606, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Select Author:";
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(610, 529);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 28);
            this.cbSelect.TabIndex = 50;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 63);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to Acces Form ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.Location = new System.Drawing.Point(842, 207);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(109, 35);
            this.btnUpdateAuthor.TabIndex = 5;
            this.btnUpdateAuthor.Text = "Update Book";
            this.btnUpdateAuthor.UseVisualStyleBackColor = false;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(313, 529);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 30);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Author";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Author ID:";
            // 
            // cbAuthorId
            // 
            this.cbAuthorId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthorId.FormattingEnabled = true;
            this.cbAuthorId.Location = new System.Drawing.Point(313, 495);
            this.cbAuthorId.Name = "cbAuthorId";
            this.cbAuthorId.Size = new System.Drawing.Size(121, 28);
            this.cbAuthorId.TabIndex = 6;
            this.cbAuthorId.SelectedIndexChanged += new System.EventHandler(this.cbAuthorId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 42;
            // 
            // btnInsertAuthor
            // 
            this.btnInsertAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInsertAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAuthor.Location = new System.Drawing.Point(842, 158);
            this.btnInsertAuthor.Name = "btnInsertAuthor";
            this.btnInsertAuthor.Size = new System.Drawing.Size(109, 35);
            this.btnInsertAuthor.TabIndex = 3;
            this.btnInsertAuthor.Text = "Insert Author";
            this.btnInsertAuthor.UseVisualStyleBackColor = false;
            this.btnInsertAuthor.Click += new System.EventHandler(this.btnInsertAuthor_Click);
            // 
            // txtEnterAuthorSurname
            // 
            this.txtEnterAuthorSurname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnterAuthorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterAuthorSurname.Location = new System.Drawing.Point(726, 158);
            this.txtEnterAuthorSurname.Name = "txtEnterAuthorSurname";
            this.txtEnterAuthorSurname.Size = new System.Drawing.Size(100, 26);
            this.txtEnterAuthorSurname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Enter Auhtor Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Enter Author Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Enter author ID to Update:";
            // 
            // txtEnterAuthorId
            // 
            this.txtEnterAuthorId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnterAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterAuthorId.Location = new System.Drawing.Point(726, 211);
            this.txtEnterAuthorId.Name = "txtEnterAuthorId";
            this.txtEnterAuthorId.Size = new System.Drawing.Size(100, 26);
            this.txtEnterAuthorId.TabIndex = 4;
            // 
            // txtEnterAuthorname
            // 
            this.txtEnterAuthorname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnterAuthorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterAuthorname.Location = new System.Drawing.Point(726, 121);
            this.txtEnterAuthorname.Name = "txtEnterAuthorname";
            this.txtEnterAuthorname.Size = new System.Drawing.Size(100, 26);
            this.txtEnterAuthorname.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(786, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search by book Author Name/ID";
            // 
            // txtSearchBookID
            // 
            this.txtSearchBookID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookID.Location = new System.Drawing.Point(749, -49);
            this.txtSearchBookID.Name = "txtSearchBookID";
            this.txtSearchBookID.Size = new System.Drawing.Size(100, 26);
            this.txtSearchBookID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, -52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search by book ID:";
            // 
            // DGWAuthor
            // 
            this.DGWAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWAuthor.Location = new System.Drawing.Point(12, 12);
            this.DGWAuthor.Name = "DGWAuthor";
            this.DGWAuthor.RowHeadersWidth = 51;
            this.DGWAuthor.RowTemplate.Height = 24;
            this.DGWAuthor.Size = new System.Drawing.Size(469, 360);
            this.DGWAuthor.TabIndex = 28;
            // 
            // Author_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Assignment.Properties.Resources.author_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateAuthor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAuthorId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertAuthor);
            this.Controls.Add(this.txtEnterAuthorSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterAuthorId);
            this.Controls.Add(this.txtEnterAuthorname);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGWAuthor);
            this.Name = "Author_Form";
            this.Text = "Author_Form";
            this.Load += new System.EventHandler(this.Author_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAuthorId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertAuthor;
        private System.Windows.Forms.TextBox txtEnterAuthorSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterAuthorId;
        private System.Windows.Forms.TextBox txtEnterAuthorname;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGWAuthor;
    }
}