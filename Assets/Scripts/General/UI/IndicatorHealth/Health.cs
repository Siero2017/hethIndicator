using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Health : MonoBehaviour
{
    private Slider _healthPoints;


    private float _currentHealth;
    private float _healthValue = 10;
    private float _maxHelath = 100f;
    private float _minHelath = 0f;

    public UnityAction<float> ChangedValue;

    private void Start()
    {
        _healthPoints = GetComponent<Slider>();
        _currentHealth = _healthPoints.value;
    }

    public void Heal()
    {
        _currentHealth = Mathf.Clamp(_healthPoints.value + _healthValue, _minHelath, _maxHelath);
        ChangedValue?.Invoke(_currentHealth);
    }

    public void Damage()
    {
        _currentHealth = Mathf.Clamp(_healthPoints.value - _healthValue, _minHelath, _maxHelath);
        ChangedValue?.Invoke(_currentHealth);
    }

    
}
