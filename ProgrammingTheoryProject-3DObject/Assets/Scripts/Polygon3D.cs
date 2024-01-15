using UnityEngine;
using ThreeDObject.UI;

namespace ThreeDObject.Main
{
    public abstract class Polygon3D : MonoBehaviour, IUIInfoContent
    {
        public virtual string GetName()
        {
            return "Polygon3D";
        }

        public virtual string GetData()
        {
            return "";
        }
    }
}

