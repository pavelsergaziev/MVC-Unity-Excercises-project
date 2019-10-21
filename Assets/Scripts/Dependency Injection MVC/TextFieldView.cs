
using UnityEngine;
using TMPro;
using Adic;

namespace DependencyInjectionMVC
{

    public class TextFieldView : BaseView
    {
        [Inject]
        private ITextInteractionListener _textEvents;

        private TextMeshProUGUI _textField;

        private void Awake()
        {
            _textField = GetComponent<TextMeshProUGUI>();
        }

        protected override void Start()
        {
            base.Start();
            _textEvents.OnTextChangeInvoked += ChangeText;
        }

        private void ChangeText(string textToShow)
        {
            _textField.text = textToShow;
        }
    }

}