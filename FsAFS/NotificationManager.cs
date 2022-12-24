using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace FsAFS
{
	sealed class NotificationManager
    {
		static Timer tmrAnimation;
		static Timer tmrDelay;

		//Control where the message will be displayed.
		public static ToastControl displaycontrol;
		

		//Some property variables.
		static Color GlowColor = Color.Blue;
		static Color BackGroundColor = Color.Blue;
		static Color ForeColor = Color.White;
		static float alphaval = 0;
		static float incr = (float)(0.1F);
		static bool isVisible = false;
		static SizeF textSize;
		static string msg = "";
		static Control prnt;

	

		//Handles the paint event of the display control.
		private static void Displaycontrol_Paint(object sender, PaintEventArgs pe)
		{
			//This BITMAP object will hold the appearance of the notification dialog.
			//Why paint in bitmap? because we will set its opacity and paint it on the control later with a specified alpha.
			Bitmap img = new Bitmap(displaycontrol.Width, displaycontrol.Height);
			Graphics e = Graphics.FromImage(img);

			//Set smoothing.
			e.SmoothingMode = SmoothingMode.AntiAlias;

			//Prepare drawing tools.
			Brush bru = new SolidBrush(Color.FromArgb(50, GlowColor));
			Pen pn = new Pen(bru, 6);
			GraphicsPath gp = new GraphicsPath();

			//Make connecting edges rounded.
			pn.LineJoin = LineJoin.Round;

			//Draw borders
			//Outmost, 50 alpha
			gp.AddRectangle(new Rectangle(3, 3, displaycontrol.Width - 10, displaycontrol.Height - 10));
			e.DrawPath(pn, gp);

			//level 3, A bit solid
			gp.Reset();
			gp.AddRectangle(new Rectangle(5, 5, displaycontrol.Width - 14, displaycontrol.Height - 14));
			e.DrawPath(pn, gp);

			//level 2, a bit more solid
			gp.Reset();
			gp.AddRectangle(new Rectangle(7, 7, displaycontrol.Width - 18, displaycontrol.Height - 18));
			e.DrawPath(pn, gp);

			//level 1, more solidness
			gp.Reset();
			gp.AddRectangle(new Rectangle(9, 9, displaycontrol.Width - 22, displaycontrol.Height - 22));
			e.DrawPath(pn, gp);

			//Draw Content Rectangle.
			gp.Reset();
			bru = new SolidBrush(BackGroundColor);
			pn = new Pen(bru, 5) { LineJoin = LineJoin.Round  };
			
			var bounds = new Rectangle(8, 8, displaycontrol.Width - 20, displaycontrol.Height - 20);
			gp.AddRectangle(bounds);
			e.DrawPath(pn, gp);
			
			e.FillRectangle(bru, new Rectangle(9, 9, displaycontrol.Width - 21, displaycontrol.Height - 21));

			
			//Set COLORMATRIX (RGBAw).
			//Matrix [3,3] will be the Alpha. Alpha is in float, 0(transparent) - 1(opaque).
			ColorMatrix cma = new ColorMatrix() { Matrix33 = alphaval};
			
			ImageAttributes imga = new ImageAttributes();
			imga.SetColorMatrix(cma);

			//Draw the notification message..
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			e.DrawString(msg, prnt.Font, new SolidBrush(ForeColor), new Rectangle(9, 9, displaycontrol.Width - 21, displaycontrol.Height - 21), sf);

			//Now, draw the content on the control.
			pe.Graphics.DrawImage(img, new Rectangle(0, 0, displaycontrol.Width, displaycontrol.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);

			
			//Free the memory.
			cma = null;
			sf.Dispose();
			imga.Dispose();
			e.Dispose();
			img.Dispose();
			bru.Dispose();
			pn.Dispose();
			gp.Dispose();

		}
		public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
		{
			int diameter = radius * 2;
			Size size = new Size(diameter, diameter);
			Rectangle arc = new Rectangle(bounds.Location, size);
			GraphicsPath path = new GraphicsPath();

			if (radius == 0)
			{
				path.AddRectangle(bounds);
				return path;
			}

			// top left arc  
			path.AddArc(arc, 180, 90);

			// top right arc  
			arc.X = bounds.Right - diameter;
			path.AddArc(arc, 270, 90);

			// bottom right arc  
			arc.Y = bounds.Bottom - diameter;
			path.AddArc(arc, 0, 90);

			// bottom left arc 
			arc.X = bounds.Left;
			path.AddArc(arc, 90, 90);

			path.CloseFigure();
			return path;
		}

		//Handles the window animation.
		private static void tmr_tick(object sender, EventArgs e)
		{
			if (incr > 0)
			{
				if (alphaval < 1)
				{
					if (alphaval + incr <= 1)
					{
						alphaval += incr;
						displaycontrol.Refresh();
					}
					else
					{
						alphaval = 1;
						displaycontrol.Refresh();
						tmrAnimation.Enabled = false;
						tmrDelay.Enabled = true;
					}
				}
			}
			else
			{
				if (alphaval > 0)
				{
					if (alphaval + incr >= 0)
					{
						alphaval += incr;
						displaycontrol.Refresh();
					}
					else
					{
						alphaval = 0;
						tmrAnimation.Enabled = false;
						tmrAnimation.Dispose();
						tmrDelay.Dispose();
						displaycontrol.Dispose();
						incr = (float)(0.1F);
						isVisible = false;
					}
				}
			}
		}

		private static void tmrDelay_tick(object sender, EventArgs e)
		{
			incr = (float)(-0.1F);
			tmrAnimation.Enabled = true;
			tmrDelay.Enabled = false;
		}

	
		public static void Show(Control Parent, string Message, Color glw,   Color backgroundColor, Color foreColor, int delay)
		{
			
         
			if (!(isVisible))
			{
				isVisible = true;
				prnt = Parent;
				msg = Message;
				//Set up notification window.
				displaycontrol = new ToastControl();
				displaycontrol.Paint += Displaycontrol_Paint;
				displaycontrol.IsTransparent = true;

				//Measure message
				textSize = displaycontrol.CreateGraphics().MeasureString(Message, Parent.Font);
				displaycontrol.Height = System.Convert.ToInt32(25 + textSize.Height);
				displaycontrol.Width = System.Convert.ToInt32(35 + textSize.Width);
				if (textSize.Width > Parent.Width - 100)
				{
					displaycontrol.Width = Parent.Width - 100;
					int hf = System.Convert.ToInt32((double)(System.Convert.ToInt32(textSize.Width)) / (Parent.Width - 100));
					displaycontrol.Height += System.Convert.ToInt32(textSize.Height * hf);
				}

				//Position control in parent
				displaycontrol.Left = System.Convert.ToInt32((double)(Parent.Width - displaycontrol.Width) / 2);
				displaycontrol.Top = (Parent.Height - displaycontrol.Height) - 50;
				Parent.Controls.Add(displaycontrol);
				displaycontrol.BringToFront();
				GlowColor = glw;
				BackGroundColor = backgroundColor;
				ForeColor = foreColor;
				//Set up animation
				tmrAnimation = new Timer();
				tmrAnimation.Interval = 15;
				tmrAnimation.Enabled = true;
				tmrAnimation.Tick += tmr_tick;

				tmrDelay = new Timer();
				tmrDelay.Interval = delay;
				tmrDelay.Tick += tmrDelay_tick;
			}
			else
			{
				tmrDelay.Stop();
				tmrDelay.Start();
			}
		}

       
    }
}
