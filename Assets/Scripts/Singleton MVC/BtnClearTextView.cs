using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonMVC
{
    public class BtnClearTextView : BtnViewBase
    {
        public void ClearText()
        {
            _textController.ClearText();
        }
    }
}