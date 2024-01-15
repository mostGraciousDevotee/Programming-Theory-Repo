using ThreeDObject.UI;
using UnityEngine;

namespace ThreeDObject.Main
{
    public class UserControl : MonoBehaviour
    {
        
        // ENCAPSULATION
        public static UserControl Instance { get; private set; }
        [SerializeField] Camera _camera;
        [SerializeField] GameObject _marker;
        Polygon3D _selected;

        void Awake()
        {
            Instance = this;
        }
        void OnDestroy()
        {
            Instance = null;
        }
        void Start()
        {
            _marker.SetActive(false);
        }

        void HandleSelection()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // POLYMORPHISM : All subclasses of Polygon3D can be treated as Polygon3D;
                _selected = hit.collider.GetComponentInParent<Polygon3D>();
                
                IUIInfoContent content = hit.collider.GetComponentInParent<IUIInfoContent>();
                UIMain.Instance.UpdateContent(content);
            }
        }

        void HandleDeselection()
        {
            _marker.SetActive(false);
            _marker.transform.SetParent(null);
        }

        void HandleMarker()
        {
            if (_selected != null && _marker.transform.parent != _selected.transform)
            {
                _marker.SetActive(true);
                _marker.transform.SetParent(_selected.transform, false);

                _marker.transform.localPosition = new Vector3(0, 1.5f, 0);
            }
        }

        void Update()
        {
            // ABSTRACTION : All code in Update is abstracted away in each individual code.
            if (Input.GetMouseButtonDown(0))
            {
                HandleSelection();
            }
            if (Input.GetMouseButtonDown(1))
            {
                HandleDeselection();
            }

            HandleMarker();
        }

        public void HandleScaleChange(float scale)
        {
            _selected.HandleScaleChange(scale);
            
            UIMain.Instance.UpdateContent(_selected as IUIInfoContent);
        }
    }
}
