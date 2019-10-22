using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonMVC
{

    public abstract class BtnViewBase : MonoBehaviour
    {
        protected ITextInteractionCommand _textController;

        private void Start()
        {
            _textController = ControllerHolder.Instance.TextInteractionCommand;
        }
    }

}