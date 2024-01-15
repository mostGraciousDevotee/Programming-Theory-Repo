using UnityEngine;
using UnityEngine.UI;

namespace ThreeDObject.UI
{
    public class InfoPopUp : MonoBehaviour
    {
        [SerializeField] Text _name;
        [SerializeField] Slider _xScale;
        [SerializeField] Slider _yScale;
        [SerializeField] Slider _zScale;
        [SerializeField] Text _volume;

        public Text Name
        {
            get => _name;
        }
        public Text Volume
        {
            get => _volume;
        }
    }
}

