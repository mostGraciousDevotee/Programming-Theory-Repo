using UnityEngine;

namespace ThreeDObject.Main
{
    public class UserControl : MonoBehaviour
    {
        [SerializeField] GameObject _marker;

        void Start()
        {
            _marker.SetActive(false);
        }
    }
}
