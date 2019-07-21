namespace Login
{
    partial class ListForm
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
            this.btnSignout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignout
            // 
            this.btnSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btnSignout.Location = new System.Drawing.Point(325, 216);
=======
            this.btnSignout.Location = new System.Drawing.Point(325, 223);
>>>>>>> ee76106c4b504ac171e0a78d396440fcffe81322
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(70, 23);
            this.btnSignout.TabIndex = 0;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSignout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdUsers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
<<<<<<< HEAD
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 247);
=======
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 254);
>>>>>>> ee76106c4b504ac171e0a78d396440fcffe81322
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToOrderColumns = true;
            this.grdUsers.AllowUserToResizeRows = false;
            this.grdUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Location = new System.Drawing.Point(8, 8);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdUsers.Size = new System.Drawing.Size(387, 194);
            this.grdUsers.TabIndex = 2;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(403, 247);
=======
            this.ClientSize = new System.Drawing.Size(403, 254);
>>>>>>> ee76106c4b504ac171e0a78d396440fcffe81322
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListForm";
            this.Text = "List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdUsers;
    }
}