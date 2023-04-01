//https://www.youtube.com/watch?v=R5mo_eoy3Cw
using System;
using System.Windows.Forms;
using Transitions;
using System.Drawing;
using MetroFramework.Animation;
using MetroFramework.Controls;

namespace BankPunk.Panel
{
    public partial class pnlSlider : MetroFramework.Controls.MetroUserControl
    {
        #region FIELDS

        MetroPanel _owner = null;
        bool _loaded = false;

        #endregion

        #region PROPERTIES
        public string Title
        {
            set { this.metroLink1.Text = value; }
        }
        #endregion

        #region CONSTRUCTOR

        public pnlSlider()
        {
            InitializeComponent();
        }

        public pnlSlider(MetroPanel Owner) : this()
        {
            this.Visible = false;
            _owner = Owner;
            Owner.Controls.Add(this);
            this.BringToFront();
            Owner.Resize += Owner_Resize;
            this.Click += pnlTwo_Click;

            ResizeForm();
        }


        #endregion
        
        #region EVENTS

        public event EventHandler Closed;
        public event EventHandler Shown;

        protected virtual void closed(EventArgs e)
        {
            EventHandler Handler = Closed;
            if (Handler != null) Handler(this, e);
        }

        protected virtual void shown(EventArgs e)
        {
            EventHandler Handler = Shown;
            if (Handler != null) Handler(this, e);
        }


        void pnlTwo_Click(Object sender, EventArgs e)
        {
            //swipe(false);
        }


        void Owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }
        #endregion

        #region METHODS

        void ResizeForm()
        {
            this.Width = _owner.Width  ;
            this.Height = _owner.Height;// - 72;
            this.Location = new Point(_loaded ? 0 : _owner.Width, 0);
        }

        public void swipe(bool show = true)
        {
            this.Visible = true;
            Transition _transition = new Transition(new TransitionType_EaseInEaseOut(500));
            _transition.add(this, "Left", show ? 0 : this.Width);
            _transition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                closed(new EventArgs());
                _owner.Resize -= Owner_Resize;
                _owner.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                _loaded = true;
                ResizeForm();
                shown(new EventArgs());
            }
        }
        #endregion
    }
}
