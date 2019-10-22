using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace ComponentsMVC
{

    public class TextFieldView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _textEventsGO;
        private ITextInteractionListener _textEvents;
        private TextMeshProUGUI _textField;

        private void Awake()
        {
            _textField = GetComponent<TextMeshProUGUI>();

            _textEvents = _textEventsGO.GetComponent<ITextInteractionListener>();

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