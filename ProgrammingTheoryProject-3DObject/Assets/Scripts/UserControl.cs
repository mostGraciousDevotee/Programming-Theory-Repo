using ThreeDObject.UI;
using UnityEngine;

namespace ThreeDObject.Main
{
    public class UserControl : MonoBehaviour
    {
        [SerializeField] Camera _camera;
        [SerializeField] GameObject _marker;
        Polygon3D _selected;

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
                // TODO: GetComponent in Parent to maintain scale.
                _selected = hit.collider.GetComponent<Polygon3D>();
                
                IUIInfoContent content = hit.collider.GetComponent<IUIInfoContent>();
                UIMain.Instance.UpdateContent(content);
            }
            else
            {
                _selected = null;
            }
        }

        void HandleMarker()
        {
            if (_selected == null && _marker.activeInHierarchy)
            {
                _marker.SetActive(false);
                _marker.transform.SetParent(null);
            }

            else if (_selected != null && _marker.transform.parent != _selected.transform)
            {
                _marker.SetActive(true);
                _marker.transform.SetParent(_selected.transform, false);

                _marker.transform.localPosition = new Vector3(0, 1.5f, 0);
            }
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                HandleSelection();
            }

            HandleMarker();
        }
    }
}
