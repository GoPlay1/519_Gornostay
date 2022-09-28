namespace _519_Gornostay
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.окно1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.окно2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.окно3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окно1ToolStripMenuItem,
            this.окно2ToolStripMenuItem,
            this.окно3ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// окно1ToolStripMenuItem
			// 
			this.окно1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
			this.окно1ToolStripMenuItem.Name = "окно1ToolStripMenuItem";
			this.окно1ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.окно1ToolStripMenuItem.Text = "Окно 1";
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// окно2ToolStripMenuItem
			// 
			this.окно2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1});
			this.окно2ToolStripMenuItem.Name = "окно2ToolStripMenuItem";
			this.окно2ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.окно2ToolStripMenuItem.Text = "Окно 2";
			// 
			// открытьToolStripMenuItem1
			// 
			this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
			this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
			this.открытьToolStripMenuItem1.Text = "Открыть";
			this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
			// 
			// окно3ToolStripMenuItem
			// 
			this.окно3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem2});
			this.окно3ToolStripMenuItem.Name = "окно3ToolStripMenuItem";
			this.окно3ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.окно3ToolStripMenuItem.Text = "Окно 3";
			// 
			// закрытьToolStripMenuItem2
			// 
			this.закрытьToolStripMenuItem2.Name = "закрытьToolStripMenuItem2";
			this.закрытьToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
			this.закрытьToolStripMenuItem2.Text = "Закрыть";
			this.закрытьToolStripMenuItem2.Click += new System.EventHandler(this.закрытьToolStripMenuItem2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выход";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form3";
			this.Text = "Окно 3";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem окно1ToolStripMenuItem;
		private ToolStripMenuItem открытьToolStripMenuItem;
		private ToolStripMenuItem окно2ToolStripMenuItem;
		private ToolStripMenuItem открытьToolStripMenuItem1;
		private ToolStripMenuItem окно3ToolStripMenuItem;
		private ToolStripMenuItem закрытьToolStripMenuItem2;
		private Button button1;
	}
}