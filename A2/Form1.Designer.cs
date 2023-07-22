namespace Lab1
{
    partial class Form1
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
            UpdateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            parentTableView = new DataGridView();
            childTableView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)parentTableView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childTableView).BeginInit();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.AccessibleName = "UpdateButton";
            UpdateButton.Location = new Point(665, 189);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += updateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 405);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "Parent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 405);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Child";
            // 
            // parentTableView
            // 
            parentTableView.AccessibleName = "parentTableView";
            parentTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parentTableView.Location = new Point(12, 12);
            parentTableView.Name = "parentTableView";
            parentTableView.RowTemplate.Height = 25;
            parentTableView.Size = new Size(240, 331);
            parentTableView.TabIndex = 17;
            parentTableView.SelectionChanged += parentTableView_SelectionChanged;
            // 
            // childTableView
            // 
            childTableView.AccessibleName = "childTableView";
            childTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            childTableView.Location = new Point(301, 12);
            childTableView.Name = "childTableView";
            childTableView.RowTemplate.Height = 25;
            childTableView.Size = new Size(240, 331);
            childTableView.TabIndex = 18;
            childTableView.DataError += childTableView_DataError;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(childTableView);
            Controls.Add(parentTableView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)parentTableView).EndInit();
            ((System.ComponentModel.ISupportInitialize)childTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateButton;
        private Label label1;
        private Label label2;
        private DataGridView parentTableView;
        private DataGridView childTableView;
    }
}