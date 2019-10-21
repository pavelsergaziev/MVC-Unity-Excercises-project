using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonMVC
{

    public class ControllerHolder : MonoBehaviour
    {
        public static ControllerHolder Instance { get; private set; }
        public TextController TextController { get; private set; }

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

            TextController = new TextController();
        }
    }

}