using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ParserVyatsu.Components
{
    public partial class DatePickerExt : DateTimePicker
    {
        private Color _backDisabledColor;

        [Category("Appearance")]
        [Browsable(true)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        [Category("Appearance")]
        [Browsable(true)]
        public Color TextColor { get; set; } = Color.Black;

        [Category("Appearance"),
 Description("The background color of the component when disabled")]
        [Browsable(true)]
        public Color BackDisabledColor
        {
            get { return _backDisabledColor; }
            set { _backDisabledColor = value; }
        }

        public DatePickerExt()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public DatePickerExt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                //The dropDownRectangle defines position and size of dropdownbutton block, 
                //the width is fixed to 17 and height to 16. 
                //The dropdownbutton is aligned to right
                Rectangle dropDownRectangle =
                   new Rectangle(ClientRectangle.Width - 17, 0, 17, 16);
                Brush bkgBrush;
                ComboBoxState visualState;

                //When the control is enabled the brush is set to Backcolor, 
                //otherwise to color stored in _backDisabledColor
                if (this.Enabled)
                {
                    bkgBrush = new SolidBrush(this.BackColor);
                    visualState = ComboBoxState.Normal;
                }
                else
                {
                    bkgBrush = new SolidBrush(this._backDisabledColor);
                    visualState = ComboBoxState.Disabled;
                }

                // Painting...in action

                //Filling the background
                g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

                //Drawing the datetime text
                g.DrawString(this.Text, this.Font, new SolidBrush(TextColor), 0, 2);

                //Drawing the dropdownbutton using ComboBoxRenderer
                ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState);
                bkgBrush.Dispose();
            }
        }
    }
}
