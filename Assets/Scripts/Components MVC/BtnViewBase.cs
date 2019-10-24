using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentsMVC
{

    public abstract class BtnViewBase : MonoBehaviour
    {
        protected ITextInteractionCommand _textController;

        private void OnEnable()
        {
            _textController = FindObjectOfType<TextController>();
        }

    }

}