using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FsAFS
{
    public partial class ToastControl : Control
    {
        public ToastControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

		bool m_isTransparent = false;
		[Description("Gets or sets the 'real' transparency of the control.")]
		public bool IsTransparent
		{
			get
			{
				return m_isTransparent;
			}
			set
			{
				m_isTransparent = value;
				if (value == true)
				{
					this.BackColor = Color.Transparent;
				}
				Invalidate();
			}
		}

		protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
		{

			base.OnPaintBackground(e);

			if (IsTransparent)
			{
				if (!(ReferenceEquals(Parent, null)))
				{
					int myIndex = Parent.Controls.GetChildIndex(this);
					for (int i = Parent.Controls.Count - 1; i >= myIndex + 1; i--)
					{
						Control ctrl = Parent.Controls[i];
						if (ctrl.Bounds.IntersectsWith(Bounds))
						{
							if (ctrl.Visible)
							{
								Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height);
								ctrl.DrawToBitmap(bmp, ctrl.ClientRectangle);
								e.Graphics.TranslateTransform(ctrl.Left - Left, ctrl.Top - Top);
								e.Graphics.DrawImage(bmp, Point.Empty);
								e.Graphics.TranslateTransform(Left - ctrl.Left, Top - ctrl.Top);
								bmp.Dispose();
							}
						}
					}
				}

			}

		}

	}
}
