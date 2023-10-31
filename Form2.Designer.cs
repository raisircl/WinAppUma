namespace WinAppUma
{
    partial class Form2
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
            dgv1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtLoc = new TextBox();
            label3 = new Label();
            txtDName = new TextBox();
            label2 = new Label();
            txtDNo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(70, 382);
            dgv1.Margin = new Padding(5);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(961, 285);
            dgv1.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(359, 284);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 58);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(224, 284);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 58);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 284);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 58);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLoc
            // 
            txtLoc.Location = new Point(210, 180);
            txtLoc.Margin = new Padding(5);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(216, 41);
            txtLoc.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 192);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 35);
            label3.TabIndex = 14;
            label3.Text = "Loc";
            // 
            // txtDName
            // 
            txtDName.Location = new Point(210, 103);
            txtDName.Margin = new Padding(5);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(216, 41);
            txtDName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 116);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 12;
            label2.Text = "DName";
            // 
            // txtDNo
            // 
            txtDNo.Location = new Point(210, 33);
            txtDNo.Margin = new Padding(5);
            txtDNo.Name = "txtDNo";
            txtDNo.Size = new Size(216, 41);
            txtDNo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 35);
            label1.TabIndex = 10;
            label1.Text = "DNo";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 704);
            Controls.Add(dgv1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLoc);
            Controls.Add(label3);
            Controls.Add(txtDName);
            Controls.Add(label2);
            Controls.Add(txtDNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtLoc;
        private Label label3;
        private TextBox txtDName;
        private Label label2;
        private TextBox txtDNo;
        private Label label1;
    }
}