using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThreeDObject.Main
{
    public class Cube : Polygon3D
    {
        public override string GetName()
        {
            return "Cube";
        }

        public override string GetData()
        {
            return "1";
        }
    }
}

