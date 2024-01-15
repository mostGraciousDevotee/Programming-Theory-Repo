using UnityEngine;

namespace ThreeDObject.Main
{
    // INHERITANCE: This class inherit from Polygon3D abstract class
    public class Cylinder : Polygon3D
    {
        public override string GetName()
        {
            return "Cylinder";
        }

        public override string GetVolume()
        {
            Vector3 scale = _childPolygon.transform.localScale;
            float volume = scale.x * scale.z * Mathf.PI * scale.x / 4.0f;
            return volume.ToString();
        }

        public override void HandleScaleChange(float scale)
        {
            Transform cylinder = GetComponentInChildren<Transform>();
            Vector3 newScale = new Vector3(scale, scale/2.0f, scale);
            
            _childPolygon.transform.localScale = newScale;
        }
    }
}
