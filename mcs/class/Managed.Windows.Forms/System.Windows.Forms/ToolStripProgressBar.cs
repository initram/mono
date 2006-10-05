//
// ToolStripProgressBar.cs
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2006 Jonathan Pobst
//
// Authors:
//	Jonathan Pobst (monkey@jpobst.com)
//
#if NET_2_0
using System.Drawing;
using System.ComponentModel;

namespace System.Windows.Forms
{
	public class ToolStripProgressBar : ToolStripControlHost
	{
		#region Public Constructors
		public ToolStripProgressBar () : base (new ProgressBar ())
		{
		}

		public ToolStripProgressBar (string name) : this ()
		{
			this.Control.Name = name;
		}
		#endregion

		#region Public Properties
		public int Maximum {
			get { return this.ProgressBar.Maximum; }
			set { this.ProgressBar.Maximum = value; }
		}

		public int Minimum {
			get { return this.ProgressBar.Minimum; }
			set { this.ProgressBar.Minimum = value; }
		}

		public ProgressBar ProgressBar {
			get { return (ProgressBar)base.Control; }
		}

		public int Step {
			get { return this.ProgressBar.Step; }
			set { this.ProgressBar.Step = value; }
		}

		public ProgressBarStyle Style {
			get { return this.ProgressBar.Style; }
			set { this.ProgressBar.Style = value; }
		}

		public override string Text {
			get { return base.Text; }
			set { base.Text = value; }
		}

		[Bindable (true)]
		public int Value {
			get { return this.ProgressBar.Value; }
			set { this.ProgressBar.Value = value; }
		}
		#endregion

		#region Protected Properties
		protected internal override Padding DefaultMargin { get { return new Padding (1, 2, 1, 1); } }
		protected override Size DefaultSize { get { return new Size (100, 15); } }
		#endregion

		#region Public Methods
		public void Increment (int value)
		{
			this.ProgressBar.Increment (value);
		}

		public void PerformStep ()
		{
			this.ProgressBar.PerformStep ();
		}
		#endregion

		#region Protected Methods
		protected override void OnSubscribeControlEvents (Control control)
		{
			base.OnSubscribeControlEvents (control);
		}

		protected override void OnUnsubscribeControlEvents (Control control)
		{
			base.OnUnsubscribeControlEvents (control);
		}
		#endregion

		#region Public Events
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event KeyEventHandler KeyDown;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event KeyPressEventHandler KeyPress;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event KeyEventHandler KeyUp;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event EventHandler LocationChanged;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event EventHandler OwnerChanged;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event EventHandler TextChanged;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event EventHandler Validated;
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public event CancelEventHandler Validating;
		#endregion
	}
}
#endif