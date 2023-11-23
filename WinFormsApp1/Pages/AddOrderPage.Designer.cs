namespace DemoVar2023.Pages
{
    partial class AddOrderPage
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
            txtBoxDevise = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxTypeError = new TextBox();
            label3 = new Label();
            txtBoxDescriptionError = new TextBox();
            label4 = new Label();
            txtBoxUser = new TextBox();
            label5 = new Label();
            listBoxStatus = new ListBox();
            btnAddOrder = new Button();
            SuspendLayout();
            // 
            // txtBoxDevise
            // 
            txtBoxDevise.Location = new Point(14, 39);
            txtBoxDevise.Margin = new Padding(5);
            txtBoxDevise.Name = "txtBoxDevise";
            txtBoxDevise.Size = new Size(245, 33);
            txtBoxDevise.TabIndex = 0;
            txtBoxDevise.TextChanged += textBoxChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 1;
            label1.Text = "Что нужно ремонтировать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 82);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 3;
            label2.Text = "Тип неисправности";
            // 
            // txtBoxTypeError
            // 
            txtBoxTypeError.Location = new Point(14, 112);
            txtBoxTypeError.Margin = new Padding(5);
            txtBoxTypeError.Name = "txtBoxTypeError";
            txtBoxTypeError.Size = new Size(245, 33);
            txtBoxTypeError.TabIndex = 2;
            txtBoxTypeError.TextChanged += textBoxChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 159);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 5;
            label3.Text = "Описание";
            // 
            // txtBoxDescriptionError
            // 
            txtBoxDescriptionError.Location = new Point(14, 189);
            txtBoxDescriptionError.Margin = new Padding(5);
            txtBoxDescriptionError.Multiline = true;
            txtBoxDescriptionError.Name = "txtBoxDescriptionError";
            txtBoxDescriptionError.Size = new Size(245, 90);
            txtBoxDescriptionError.TabIndex = 4;
            txtBoxDescriptionError.TextChanged += textBoxChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 294);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 7;
            label4.Text = "ФИО клиента";
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(14, 324);
            txtBoxUser.Margin = new Padding(5);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(245, 33);
            txtBoxUser.TabIndex = 6;
            txtBoxUser.TextChanged += textBoxChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 362);
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
            listBoxStatus.Items.AddRange(new object[] { "В ожидание", "В работе", "Выполнено" });
            listBoxStatus.Location = new Point(14, 390);
            listBoxStatus.Name = "listBoxStatus";
            listBoxStatus.Size = new Size(243, 79);
            listBoxStatus.TabIndex = 10;
            listBoxStatus.SelectedIndexChanged += listBoxChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Enabled = false;
            btnAddOrder.Location = new Point(44, 512);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(178, 37);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // AddOrderPage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 561);
            Controls.Add(btnAddOrder);
            Controls.Add(listBoxStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxUser);
            Controls.Add(label3);
            Controls.Add(txtBoxDescriptionError);
            Controls.Add(label2);
            Controls.Add(txtBoxTypeError);
            Controls.Add(label1);
            Controls.Add(txtBoxDevise);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddOrderPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление заказа";
            SizeChanged += AddOrderPage_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxDevise;
        private Label label1;
        private Label label2;
        private TextBox txtBoxTypeError;
        private Label label3;
        private TextBox txtBoxDescriptionError;
        private Label label4;
        private TextBox txtBoxUser;
        private Label label5;
        private ListBox listBoxStatus;
        private Button btnAddOrder;
    }
}