using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BellarmineCS
{

    public static class ColliderExtensions
    {
        public static bool IsTriggerButton(this Collider collider)
        {
            return collider.tag == "ButtonDetector";
        }
    }
}
