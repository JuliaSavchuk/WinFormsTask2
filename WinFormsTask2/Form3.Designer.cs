namespace WinFormsTask2
{
    partial class Form3
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
            TopLevel = new Button();
            SubItemButton = new Button();
            topLevelMenu = new TextBox();
            subItem = new TextBox();
            menuStrip = new MenuStrip();
            SuspendLayout();
            // 
            // TopLevel
            // 
            TopLevel.BackColor = SystemColors.ActiveCaption;
            TopLevel.Location = new Point(236, 262);
            TopLevel.Name = "TopLevel";
            TopLevel.Size = new Size(144, 23);
            TopLevel.TabIndex = 0;
            TopLevel.Text = "Додати пункт меню";
            TopLevel.UseVisualStyleBackColor = false;
            // 
            // SubItemButton
            // 
            SubItemButton.BackColor = SystemColors.ActiveCaption;
            SubItemButton.Location = new Point(435, 262);
            SubItemButton.Name = "SubItemButton";
            SubItemButton.Size = new Size(144, 23);
            SubItemButton.TabIndex = 1;
            SubItemButton.Text = "Додати підменю";
            SubItemButton.UseVisualStyleBackColor = false;
            // 
            // topLevelMenu
            // 
            topLevelMenu.Location = new Point(280, 233);
            topLevelMenu.Name = "topLevelMenu";
            topLevelMenu.Size = new Size(100, 23);
            topLevelMenu.TabIndex = 2;
            // 
            // subItem
            // 
            subItem.Location = new Point(435, 233);
            subItem.Name = "subItem";
            subItem.Size = new Size(100, 23);
            subItem.TabIndex = 3;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(792, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(subItem);
            Controls.Add(topLevelMenu);
            Controls.Add(SubItemButton);
            Controls.Add(TopLevel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TopLevel;
        private Button SubItemButton;
        private TextBox topLevelMenu;
        private TextBox subItem;
        private MenuStrip menuStrip;
    }
}