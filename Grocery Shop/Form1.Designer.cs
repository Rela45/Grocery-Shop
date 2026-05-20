namespace Grocery_Shop
{
    partial class ShoppingList
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
            btnAdd = new Button();
            btnDelete = new Button();
            gbItemInformation = new GroupBox();
            comboUnits = new ComboBox();
            tbxAmount = new TextBox();
            tbxItemDescription = new TextBox();
            lblAmount = new Label();
            lblDescription = new Label();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            lbxShoppingList = new ListBox();
            lblError = new Label();
            gbItemInformation.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(476, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Location = new Point(476, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbItemInformation
            // 
            gbItemInformation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbItemInformation.Controls.Add(comboUnits);
            gbItemInformation.Controls.Add(btnDelete);
            gbItemInformation.Controls.Add(tbxAmount);
            gbItemInformation.Controls.Add(btnAdd);
            gbItemInformation.Controls.Add(tbxItemDescription);
            gbItemInformation.Controls.Add(lblAmount);
            gbItemInformation.Controls.Add(lblDescription);
            gbItemInformation.Location = new Point(45, 65);
            gbItemInformation.Name = "gbItemInformation";
            gbItemInformation.Size = new Size(583, 142);
            gbItemInformation.TabIndex = 3;
            gbItemInformation.TabStop = false;
            gbItemInformation.Text = "Item Information";
            // 
            // comboUnits
            // 
            comboUnits.FormattingEnabled = true;
            comboUnits.Location = new Point(306, 74);
            comboUnits.Name = "comboUnits";
            comboUnits.Size = new Size(121, 23);
            comboUnits.TabIndex = 4;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(118, 74);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(161, 23);
            tbxAmount.TabIndex = 3;
            // 
            // tbxItemDescription
            // 
            tbxItemDescription.Location = new Point(118, 33);
            tbxItemDescription.Name = "tbxItemDescription";
            tbxItemDescription.Size = new Size(352, 23);
            tbxItemDescription.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(35, 82);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(35, 41);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(858, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(93, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // lbxShoppingList
            // 
            lbxShoppingList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbxShoppingList.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxShoppingList.FormattingEnabled = true;
            lbxShoppingList.Location = new Point(45, 234);
            lbxShoppingList.Name = "lbxShoppingList";
            lbxShoppingList.Size = new Size(668, 140);
            lbxShoppingList.TabIndex = 5;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Aqua;
            lblError.Location = new Point(0, 415);
            lblError.Name = "lblError";
            lblError.Size = new Size(858, 35);
            lblError.TabIndex = 6;
            lblError.Text = "label1";
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // ShoppingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 449);
            Controls.Add(lblError);
            Controls.Add(lbxShoppingList);
            Controls.Add(gbItemInformation);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ShoppingList";
            Text = "Shopping List";
            Load += ShoppingList_Load;
            gbItemInformation.ResumeLayout(false);
            gbItemInformation.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private GroupBox gbItemInformation;
        private ComboBox comboUnits;
        private TextBox tbxAmount;
        private TextBox tbxItemDescription;
        private Label lblAmount;
        private Label lblDescription;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ListBox lbxShoppingList;
        private Label lblError;
    }
}
