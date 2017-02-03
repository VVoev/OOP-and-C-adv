using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAreHere
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    class ListWithChangedEvent : ArrayList
    {
        public event ChangedEventHandler Changed;

        public override int Add(object value)
        {
            int i = base.Add(value);
            this.OnChanged();
            return i;
        }
        public override void Clear()
        {
            base.Clear();
            this.OnChanged();
        }
        public override object this[int index]
        {
            set
            {
                base[index] = value;
                this.OnChanged();
            }
        }


        private void OnChanged()
        {
            if (this.Changed != null)
            {
                this.Changed(this, EventArgs.Empty);
            }
        }
    }
}
