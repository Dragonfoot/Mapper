/*
 * Created by SharpDevelop.
 * User: lso544
 * Date: 12/28/2015
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mapper2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.AllowDrop = true;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AllowDrop = true;
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.splitContainer1.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1DragDrop);
			this.splitContainer1.Panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel1DragOver);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AllowDrop = true;
			this.splitContainer1.Panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel2DragDrop);
			this.splitContainer1.Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2DragEnter);
			this.splitContainer1.Size = new System.Drawing.Size(716, 565);
			this.splitContainer1.SplitterDistance = 238;
			this.splitContainer1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 565);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "mapper2";
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
