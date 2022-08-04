using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("Я заменил этот текст", 3);
        _text2.DOText(" и я дополнил этот текст", 3).SetRelative();
        _text3.DOText("Взлом жопы", 3, true, ScrambleMode.All);
        _text3.DOColor(Color.red, 3);
    }
}
