using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Health : MonoBehaviour
{
    private Slider _helthPoints;

    private float _healthValue = 10;
    private float _maxHelath = 100f;
    private float _minHelath = 0f;

    public UnityAction<float> ChangedValue;

    private void Start()
    {
        _helthPoints = GetComponent<Slider>();
    }

    public void Heal()
    {
        ChangedValue?.Invoke(Mathf.Clamp(_helthPoints.value + _healthValue, _minHelath, _maxHelath));
    }

    public void Damage()
    {
        ChangedValue?.Invoke(Mathf.Clamp(_helthPoints.value - _healthValue, _minHelath, _maxHelath));
    }

    
}
