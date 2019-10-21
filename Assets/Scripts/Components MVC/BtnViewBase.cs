using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentsMVC
{

    public abstract class BtnViewBase : MonoBehaviour
    {
        [SerializeField]
        private GameObject _textControllerGO;
        protected ITextInteractionCommand _textController;

        private void Awake()
        {
            _textController = _textControllerGO.GetComponent<ITextInteractionCommand>();
        }

    }

}