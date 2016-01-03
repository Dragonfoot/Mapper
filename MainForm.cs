/*
 * Created by SharpDevelop.
 * User: lso544
 * Date: 12/28/2015
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
//using System.Tuple;
using System.Windows.Forms;

namespace mapper2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int ImageLocationX = 16;
		int ImageLocationY = 24;
		int LabelLocationX = 47;
		int LabelLocationY = 24;		
		int ImageCount = 0;
		string iconpath = AppDomain.CurrentDomain.BaseDirectory + "icons\\";
		
		public MainForm()
		{
			InitializeComponent();
			addImages();
			
			foreach (Control c in this.splitContainer1.Panel1.Controls)  
			{  
				if (c is PictureBox)
				{
					c.MouseDown += new MouseEventHandler(c_MouseDown);
				}
			}			
			
		}
		
		public void addImages()
		{
			string[] fileEntries = Directory.GetFiles(iconpath);
			foreach (string fileName in fileEntries)
			{
				
				string strFileName = fileName.Substring(iconpath.Length);
				strFileName = strFileName.Substring(0, strFileName.Length - 4);
				
				PictureBox p = new PictureBox();
				p.Name = "pbox" + strFileName;
				p.Size = new Size(16,16);
				p.AllowDrop = true;
				setImageLocationY();
				p.Location = new Point(ImageLocationX,ImageLocationY);
				p.BackgroundImage = new Bitmap(fileName);
				p.BorderStyle = BorderStyle.FixedSingle;
				splitContainer1.Panel1.Controls.Add(p);
				
				Label l = new Label();
				l.Size = new Size(100,16);
				setLabelLocationY();
				l.Location = new Point(LabelLocationX,LabelLocationY);
				l.Name = "lbl" + strFileName;
				l.Text = strFileName;
				splitContainer1.Panel1.Controls.Add(l);
				ImageCount = ImageCount + 1;
				
			}			
		}
		
		public int setImageLocationY()
		{
			if (ImageCount > 0)
			{
				ImageLocationY = ImageLocationY + 23;
			}
			return ImageLocationY;
		}
		
		public int setLabelLocationY()
		{
			if (ImageCount > 0)
			{
				LabelLocationY = LabelLocationY + 23;
			}
			return LabelLocationY;
		}	

		public void c_MouseDown(object sender, MouseEventArgs e)  
		{
        	    Control c = sender as Control;  
   				c.DoDragDrop(c, DragDropEffects.Move);
		}


		void Panel2DragEnter(object sender, DragEventArgs e)
		{
			
		}
		
		void Panel2DragDrop(object sender, DragEventArgs e)
		{
			PictureBox pOriginal = e.Data.GetData(e.Data.GetFormats()[0]) as PictureBox;
		
		    if (pOriginal != null)  
		    {  
				PictureBox pNew = new PictureBox();
		    	pNew.Image = pOriginal.Image;
				pNew.Size = pOriginal.Size;
				
		        pNew.Location = this.splitContainer1.Panel2.PointToClient(new Point(e.X, e.Y));  
		        this.splitContainer1.Panel2.Controls.Add(pNew);  
		    }	
		}
		
		void Panel1DragDrop(object sender, DragEventArgs e)
		{
 			
		}
		
		void Panel1DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move; 			
		}
	}
}
