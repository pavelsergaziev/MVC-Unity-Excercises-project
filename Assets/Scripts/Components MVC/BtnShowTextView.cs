using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentsMVC
{

    public class BtnShowTextView : BtnViewBase
    {
        public void ShowText()
        {
            _textController.ShowText();
        }
    }

}