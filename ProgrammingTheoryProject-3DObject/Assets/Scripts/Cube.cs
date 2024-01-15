using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThreeDObject.Main
{
    // INHERITANCE: This class inherit from Polygon3D abstract class
    public class Cube : Polygon3D
    {
        // POLYMORPHISM : Same method name but different outcome through overriding and interfaces.
        public override string GetName()
        {
            return "Cube";
        }

        public override string GetVolume()
        {
            Vector3 scale = _childPolygon.transform.localScale;
            float volume = scale.x * scale.y * scale.z;
            
            return volume.ToString();
        }
    }
}

