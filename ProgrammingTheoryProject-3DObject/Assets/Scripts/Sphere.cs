using UnityEngine;

namespace ThreeDObject.Main
{
    // INHERITANCE: This class inherit from Polygon3D abstract class
    public class Sphere : Polygon3D
    {
        public override string GetName()
        {
            return "Sphere";
        }

        public override string GetVolume()
        {
            Vector3 scale = _childPolygon.transform.localScale;
            float volume = scale.x * scale.y * scale.z * 4 * Mathf.PI / 24.0f;
            return volume.ToString();
        }
    }
}

