using UnityEngine;
using ThreeDObject.UI;

namespace ThreeDObject.Main
{
    // INHERITANCE : This is the base class of all polygon classes
    public abstract class Polygon3D : MonoBehaviour, IUIInfoContent
    {
        [SerializeField] protected GameObject _childPolygon;

        public abstract string GetName();

        public abstract string GetVolume();

        public virtual void HandleScaleChange(float scale)
        {
            Vector3 newScale = new Vector3(scale, scale, scale);
            _childPolygon.transform.localScale = newScale;
        }

        public virtual float GetScale()
        {
            return _childPolygon.transform.localScale.x;
        }
    }
}

