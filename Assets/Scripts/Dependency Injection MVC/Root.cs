using UnityEngine;
using Adic;
using Adic.Container;

namespace DependencyInjectionMVC
{

    public class Root : ContextRoot
    {

        public override void Init()
        {
        }

        public override void SetupContainers()
        {
            AddContainer<InjectionContainer>().
                Bind<ITextInteractionData>().ToSingleton<TextController>().
                Bind<ITextInteractionCommand>().ToSingleton<TextController>().
                Bind<ITextInteractionListener>().ToSingleton<TextController>();
        }
    }

}
