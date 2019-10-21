using UnityEngine;
using Adic;
using Adic.Container;

namespace DependencyInjectionMVC
{

    public class Root : ContextRoot
    {
        //[SerializeField]
        //private GameObject _textControllerGO;

        public override void Init()
        {
        }

        public override void SetupContainers()
        {
            AddContainer<InjectionContainer>().
                Bind<ITextInteractionData>().ToSingleton<TextController>().
                Bind<ITextInteractionCommand>().ToSingleton<TextController>().
                Bind<ITextInteractionListener>().ToSingleton<TextController>();

            //AddContainer<InjectionContainer>().
            //    Bind<ITextInteractionData>().To(_textControllerGO.GetComponent< ITextInteractionData>()).
            //    Bind<ITextInteractionCommand>().To(_textControllerGO.GetComponent<ITextInteractionCommand>()).
            //    Bind<ITextInteractionListener>().To(_textControllerGO.GetComponent<ITextInteractionListener>());
        }
    }

}
