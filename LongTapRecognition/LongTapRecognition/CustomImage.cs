using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LongTapRecognition
{
    public class CustomImage : Image
    {
        public delegate void LongPress(object sender);
        public event LongPress LongPressed;

        public void InvokeLongPressedEvent()
        {
            LongPressed(this);
        }
    }
}
