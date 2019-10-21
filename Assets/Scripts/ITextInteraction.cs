using System;
using System.Collections.Generic;
using UnityEngine;

public interface ITextInteractionData
{
    string GetText();
}

public interface ITextInteractionListener
{
    event Action<string> OnTextChangeInvoked;
}

public interface ITextInteractionCommand
{
    void ShowText();
    void ClearText();
}