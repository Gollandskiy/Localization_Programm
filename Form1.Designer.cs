namespace Localization_Programm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pANELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pANELToolStripMenuItem,
            this.pANELToolStripMenuItem1,
            this.pANELToolStripMenuItem2});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // pANELToolStripMenuItem
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem, "pANELToolStripMenuItem");
            this.pANELToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pANELToolStripMenuItem3});
            this.pANELToolStripMenuItem.Name = "pANELToolStripMenuItem";
            // 
            // pANELToolStripMenuItem3
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem3, "pANELToolStripMenuItem3");
            this.pANELToolStripMenuItem3.Name = "pANELToolStripMenuItem3";
            // 
            // pANELToolStripMenuItem1
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem1, "pANELToolStripMenuItem1");
            this.pANELToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pANELToolStripMenuItem4});
            this.pANELToolStripMenuItem1.Name = "pANELToolStripMenuItem1";
            // 
            // pANELToolStripMenuItem4
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem4, "pANELToolStripMenuItem4");
            this.pANELToolStripMenuItem4.Name = "pANELToolStripMenuItem4";
            // 
            // pANELToolStripMenuItem2
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem2, "pANELToolStripMenuItem2");
            this.pANELToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pANELToolStripMenuItem5});
            this.pANELToolStripMenuItem2.Name = "pANELToolStripMenuItem2";
            // 
            // pANELToolStripMenuItem5
            // 
            resources.ApplyResources(this.pANELToolStripMenuItem5, "pANELToolStripMenuItem5");
            this.pANELToolStripMenuItem5.Name = "pANELToolStripMenuItem5";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pANELToolStripMenuItem5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

