using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Controlls
{
    public sealed class TextBoxEx : TextBox
    {
        protected override void OnLeave(EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(Text, out value))
            {
                Text = "0";
            }
            base.OnLeave(e);

        }
    }
}
