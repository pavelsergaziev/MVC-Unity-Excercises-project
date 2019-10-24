using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace ComponentsMVC
{

    public class TextFieldView : MonoBehaviour
    {
        private ITextInteractionListener _textEvents;
        private TextMeshProUGUI _textField;

        private void Awake()
        {
            _textField = GetComponent<TextMeshProUGUI>();


        }

        private void OnEnable()
        {
            _textEvents = FindObjectOfType<TextController>(); //onenable

            _textEvents.OnTextChangeInvoked += ChangeText;
        }

        private void ChangeText(string textToShow)
        {
            _textField.text = textToShow;
            Debug.Log(SceneManager.GetActiveScene().name);
        }

        private void OnDestroy()
        {
            _textEvents.OnTextChangeInvoked -= ChangeText;
        }
    }

}