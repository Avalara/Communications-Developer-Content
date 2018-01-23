using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZGeoCSharpSample
{
    public static class ExtensionMethods
    {
        public static void SelectAllText(this TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                textBox.SelectionStart = 0;
                textBox.SelectionLength = textBox.Text.Length;
            }
        }
    }
}
