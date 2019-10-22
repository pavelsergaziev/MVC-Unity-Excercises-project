using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonMVC
{

    public class ControllerHolder : MonoBehaviour
    {
        public static ControllerHolder Instance { get; private set; }

        private TextController _textController;
        public ITextInteractionCommand TextInteractionCommand { get { return _textController; } }
        public ITextInteractionData TextInteractionData { get { return _textController; } }
        public ITextInteractionListener TextInteractionListener { get { return _textController; } }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }

            _textController = new TextController();
        }
    }

}