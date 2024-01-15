using UnityEngine;

namespace ThreeDObject.Main
{
    public abstract class Polygon3D : MonoBehaviour, IUIInfoContent
    {
        public string GetName()
        {
            return "Polygon3D";
        }

        public virtual string GetData()
        {
            return "";
        }
    }
}

