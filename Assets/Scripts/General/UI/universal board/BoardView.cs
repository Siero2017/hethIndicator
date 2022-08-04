using Assets.Scripts.General.UI.universal_board.Extensions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BoardView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _date;

    private Transform _dragingParent;
    private Transform _previousParent;

    public void Init(Transform dragingParent)
    {
        _dragingParent = dragingParent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _previousParent = transform.parent;
        transform.parent = _dragingParent;        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var container = EventSystem.current.GetFirstComponentUnderPoint<DropContainer>(eventData);

        if(container != null)
        {
            transform.parent = container.Container;
        }
        else
        {
            transform.parent = _previousParent;
        }
    }

    public void Render(Board board)
    {
        _image.sprite = board.Image;
        _date.text = board.CreationTime.ToString();
    }
}
