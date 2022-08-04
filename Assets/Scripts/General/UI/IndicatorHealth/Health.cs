using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Health : MonoBehaviour
{
    private Slider _helthPoints;

    private float _healthValue = 10;
    private float _tergetHelath;

    public UnityAction<float> ChangeValue;

    private void Start()
    {
        _helthPoints = GetComponent<Slider>();
        _tergetHelath = _helthPoints.value;
    }

    public void Heal()
    {
        float sum = _helthPoints.value + _healthValue;
        _tergetHelath = sum <= 100 ? sum : 0f;

        ChangeValue?.Invoke(_tergetHelath);
    }

    public void Damage()
    {
        float subtraction = _helthPoints.value - _healthValue;
        _tergetHelath = subtraction >= 0 ? subtraction : 0f;

        ChangeValue?.Invoke(_tergetHelath);
    }

    
}
