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
            AddButton = new Button();
            RemoveButton = new Button();
            UpdateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            FMidText = new TextBox();
            LidText = new TextBox();
            SidText = new TextBox();
            NameText = new TextBox();
            SupplyText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LakesView = new DataGridView();
            FishermenView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)LakesView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FishermenView).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.AccessibleName = "AddButton";
            AddButton.Location = new Point(937, 138);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.AccessibleName = "RemoveButton";
            RemoveButton.Location = new Point(937, 193);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.AccessibleName = "UpdateButton";
            UpdateButton.Location = new Point(937, 248);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 405);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Lakes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 405);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Fishermen";
            // 
            // FMidText
            // 
            FMidText.AccessibleName = "FMidText";
            FMidText.Location = new Point(742, 87);
            FMidText.Name = "FMidText";
            FMidText.Size = new Size(100, 23);
            FMidText.TabIndex = 7;
            // 
            // LidText
            // 
            LidText.AccessibleName = "LidText";
            LidText.Location = new Point(742, 138);
            LidText.Name = "LidText";
            LidText.Size = new Size(100, 23);
            LidText.TabIndex = 8;
            // 
            // SidText
            // 
            SidText.AccessibleName = "SidText";
            SidText.Location = new Point(742, 193);
            SidText.Name = "SidText";
            SidText.Size = new Size(100, 23);
            SidText.TabIndex = 9;
            // 
            // NameText
            // 
            NameText.AccessibleName = "NameText";
            NameText.Location = new Point(742, 248);
            NameText.Name = "NameText";
            NameText.Size = new Size(100, 23);
            NameText.TabIndex = 10;
            // 
            // SupplyText
            // 
            SupplyText.AccessibleName = "SupplyText";
            SupplyText.Location = new Point(742, 305);
            SupplyText.Name = "SupplyText";
            SupplyText.Size = new Size(100, 23);
            SupplyText.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 90);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "FishermenID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 141);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 13;
            label4.Text = "LakeID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 196);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 14;
            label5.Text = "SalaryID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 251);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 15;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(608, 308);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 16;
            label7.Text = "Supply";
            // 
            // LakesView
            // 
            LakesView.AccessibleName = "LakesView";
            LakesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LakesView.Location = new Point(12, 12);
            LakesView.Name = "LakesView";
            LakesView.RowTemplate.Height = 25;
            LakesView.Size = new Size(240, 331);
            LakesView.TabIndex = 17;
            LakesView.SelectionChanged += LakesView_SelectionChanged;
            // 
            // FishermenView
            // 
            FishermenView.AccessibleName = "FishermenView";
            FishermenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FishermenView.Location = new Point(301, 12);
            FishermenView.Name = "FishermenView";
            FishermenView.RowTemplate.Height = 25;
            FishermenView.Size = new Size(240, 331);
            FishermenView.TabIndex = 18;
            FishermenView.SelectionChanged += FishermenView_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(FishermenView);
            Controls.Add(LakesView);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SupplyText);
            Controls.Add(NameText);
            Controls.Add(SidText);
            Controls.Add(LidText);
            Controls.Add(FMidText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LakesView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FishermenView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private Button RemoveButton;
        private Button UpdateButton;
        private Label label1;
        private Label label2;
        private TextBox FMidText;
        private TextBox LidText;
        private TextBox SidText;
        private TextBox NameText;
        private TextBox SupplyText;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView LakesView;
        private DataGridView FishermenView;
    }
}