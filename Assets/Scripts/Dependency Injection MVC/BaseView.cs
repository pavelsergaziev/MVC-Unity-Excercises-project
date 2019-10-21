using UnityEngine;

namespace DependencyInjectionMVC
{

    public abstract class BaseView : MonoBehaviour
    {
        protected virtual void Start()
        {
            this.Inject();
        }
    }

}