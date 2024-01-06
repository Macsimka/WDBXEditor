using System.Windows.Forms;

namespace WDBXEditor.Common
{
    internal class BufferedListBox : ListBox
    {
        public BufferedListBox()
        {
            DoubleBuffered = true;
        }
    }
}
