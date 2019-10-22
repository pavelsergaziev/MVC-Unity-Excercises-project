using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SingletonMVC
{

    public class TextFieldView : MonoBehaviour
    {
        private ITextInteractionListener _textEvents;
        private TextMeshProUGUI _textField;

        private void Awake()
        {
            _textField = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            _textEvents = FindObjectOfType<ControllerHolder>().TextInteractionListener;

            _textEvents.OnTextChangeInvoked += ChangeText;
        }

        private void ChangeText(string textToShow)
        {
            _textField.text = textToShow;
        }

        private void OnDestroy()
        {
            _textEvents.OnTextChangeInvoked -= ChangeText;
        }
    }

}