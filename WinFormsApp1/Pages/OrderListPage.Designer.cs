namespace DemoVar2023.Pages
{
    partial class OrderListPage
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
            dataViewOrder = new DataGridView();
            btnAddOrder = new Button();
            lblCountComplited = new Label();
            ((System.ComponentModel.ISupportInitialize)dataViewOrder).BeginInit();
            SuspendLayout();
            // 
            // dataViewOrder
            // 
            dataViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewOrder.Location = new Point(14, 14);
            dataViewOrder.Margin = new Padding(5);
            dataViewOrder.Name = "dataViewOrder";
            dataViewOrder.RowTemplate.Height = 25;
            dataViewOrder.Size = new Size(771, 476);
            dataViewOrder.TabIndex = 0;
            dataViewOrder.CellContentDoubleClick += dataViewCellClick;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(14, 498);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(171, 32);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Добавить";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Visible = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lblCountComplited
            // 
            lblCountComplited.AutoSize = true;
            lblCountComplited.Location = new Point(582, 496);
            lblCountComplited.Name = "lblCountComplited";
            lblCountComplited.Size = new Size(22, 25);
            lblCountComplited.TabIndex = 2;
            lblCountComplited.Text = "д";
            // 
            // OrderListPage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 561);
            Controls.Add(lblCountComplited);
            Controls.Add(btnAddOrder);
            Controls.Add(dataViewOrder);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "OrderListPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов";
            SizeChanged += OrderListPage_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dataViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewOrder;
        private Button btnAddOrder;
        private Label lblCountComplited;
    }
}