using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonMVC
{

    public class TextController : ITextInteractionData, ITextInteractionListener, ITextInteractionCommand
    {
        private string _text = "кнопка нажата";

        public event Action<string> OnTextChangeInvoked = delegate { };

        public string GetText()
        {
            return _text;
        }

        public void ClearText()
        {
            OnTextChangeInvoked.Invoke(default);
        }

        public void ShowText()
        {
            OnTextChangeInvoked.Invoke(_text);
        }
    }

}
