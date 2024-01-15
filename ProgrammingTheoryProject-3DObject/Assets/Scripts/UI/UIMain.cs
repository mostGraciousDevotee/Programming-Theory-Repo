using UnityEngine;
using ThreeDObject.Main;

namespace ThreeDObject.UI
{
    public class UIMain : MonoBehaviour
    {
        public static UIMain Instance { get; private set; }
        [SerializeField] InfoPopUp _popUp;

        void Awake()
        {
            Instance = this;
            _popUp.gameObject.SetActive(false);
        }

        void OnDestroy()
        {
            Instance = null;
        }

        public void UpdateContent(IUIInfoContent content)
        {
            if (content == null)
            {
                _popUp.gameObject.SetActive(false);
            }
            else
            {
                _popUp.gameObject.SetActive(true);

                float scale = content.GetScale();
                _popUp.SetScaleSlider(scale);
                _popUp.Name.text = content.GetName();
                _popUp.Volume.text = content.GetVolume();
            }
        }

        public void HandleScaleChange(float scale)
        {
            UserControl.Instance.HandleScaleChange(scale);
        }
    }
}