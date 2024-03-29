using UnityEngine;
using UnityEngine.UI;

namespace ThreeDObject.UI
{
    public class InfoPopUp : MonoBehaviour
    {
        [SerializeField] Text _name;
        [SerializeField] Slider _scale;
        [SerializeField] Text _scaleText;
        float _scaleValue;
        [SerializeField] Text _volume;

        void Awake()
        {
            _scale.onValueChanged.AddListener(OnScaleChange);
        }

        void OnDestroy()
        {
            _scale.onValueChanged.RemoveListener(OnScaleChange);
        }
        
        public Text Name
        {
            get => _name;
        }
        public Text Volume
        {
            get => _volume;
        }

        public void OnScaleChange(float value)
        {
            UIMain.Instance.HandleScaleChange(value);
            _scaleText.text = _scale.value.ToString();
        }

        public void SetScaleSlider(float scale)
        {
            if (scale >= 0 && scale <= 1.0f)
            {
                _scale.value = scale;
                _scaleText.text = scale.ToString();
            }
            else if (scale < 0)
            {
                _scale.value = 0;
                _scaleText.text = "0";
            }
            else if (scale > 1.0f)
            {
                _scale.value = 1.0f;
                _scaleText.text = "1";
            }
        }
    }
}

