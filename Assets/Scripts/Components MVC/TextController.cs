using System;
using UnityEngine;

namespace ComponentsMVC
{

    public class TextController : MonoBehaviour, ITextInteractionData, ITextInteractionListener, ITextInteractionCommand
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
