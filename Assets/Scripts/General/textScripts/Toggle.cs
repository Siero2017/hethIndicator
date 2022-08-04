using UnityEngine;

public class Toggle : MonoBehaviour
{
    [SerializeField] private GameObject _text;

    public void OnToggleChanged(bool state)
    {
        _text.SetActive(state);
    }
}
