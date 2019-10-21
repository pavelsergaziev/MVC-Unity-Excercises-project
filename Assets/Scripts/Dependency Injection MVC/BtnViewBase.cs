using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adic;

namespace DependencyInjectionMVC
{

    public abstract class BtnViewBase : BaseView
    {
        [Inject]
        protected ITextInteractionCommand _textController;
    }

}