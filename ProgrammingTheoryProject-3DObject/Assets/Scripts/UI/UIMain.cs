using UnityEngine;

namespace ThreeDObject.UI
{
    public class UIMain : MonoBehaviour
    {
        public static UIMain Instance { get; private set; }
        [SerializeField] InfoPopUp _popUp;
        IUIInfoContent _currentContent;

        void Awake()
        {
            Instance = this;
            // TODO Add InfoPopUp code here
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
                // _currentContent = content;

                // TODO:
                // - update content name
                // - update content data
                // - clear content

                _popUp.Name.text = content.GetName();
                _popUp.Volume.text = content.GetData();
            }

            // TODO PRINT CONTENT TO UIPANEL
        }
    }
}