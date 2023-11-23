namespace DemoVar2023.Pages
{
    partial class UpdateOrderPage
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
            txtBoxDescriptionError = new TextBox();
            label5 = new Label();
            listBoxStatus = new ListBox();
            btnAddOrder = new Button();
            listBoxUser = new ListBox();
            label1 = new Label();
            label3 = new Label();
            txtBoxIndex = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxDescriptionError
            // 
            txtBoxDescriptionError.Location = new Point(14, 91);
            txtBoxDescriptionError.Margin = new Padding(5);
            txtBoxDescriptionError.Multiline = true;
            txtBoxDescriptionError.Name = "txtBoxDescriptionError";
            txtBoxDescriptionError.Size = new Size(245, 90);
            txtBoxDescriptionError.TabIndex = 4;
            txtBoxDescriptionError.TextChanged += textBoxChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 186);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 9;
            label5.Text = "Статус";
            // 
            // listBoxStatus
            // 
            listBoxStatus.FormattingEnabled = true;
            listBoxStatus.ItemHeight = 25;
            listBoxStatus.Items.AddRange(new object[] { "В работе", "Выполнено", "Не выполнено" });
            listBoxStatus.Location = new Point(14, 214);
            listBoxStatus.Name = "listBoxStatus";
            listBoxStatus.Size = new Size(243, 79);
            listBoxStatus.TabIndex = 10;
            listBoxStatus.SelectedIndexChanged += listBoxChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(44, 512);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(178, 37);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "Изменить";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // listBoxUser
            // 
            listBoxUser.FormattingEnabled = true;
            listBoxUser.ItemHeight = 25;
            listBoxUser.Location = new Point(14, 324);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.ScrollAlwaysVisible = true;
            listBoxUser.Size = new Size(243, 154);
            listBoxUser.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 296);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 13;
            label1.Text = "Список исполнителей";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 61);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 5;
            label3.Text = "Описание";
            // 
            // txtBoxIndex
            // 
            txtBoxIndex.Location = new Point(12, 33);
            txtBoxIndex.Name = "txtBoxIndex";
            txtBoxIndex.ReadOnly = true;
            txtBoxIndex.Size = new Size(243, 33);
            txtBoxIndex.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 5);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 15;
            label2.Text = "Индекс";
            // 
            // UpdateOrderPage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 561);
            Controls.Add(label2);
            Controls.Add(txtBoxIndex);
            Controls.Add(label1);
            Controls.Add(listBoxUser);
            Controls.Add(btnAddOrder);
            Controls.Add(listBoxStatus);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtBoxDescriptionError);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "UpdateOrderPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение заказа";
            SizeChanged += UpdateOrderPage_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxDescriptionError;
        private Label label5;
        private ListBox listBoxStatus;
        private Button btnAddOrder;
        private ListBox listBoxUser;
        private Label label1;
        private Label label3;
        private TextBox txtBoxIndex;
        private Label label2;
    }
}