using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class LinaerColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private SpriteRenderer _spriteRenderer;    

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOFade(0, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
