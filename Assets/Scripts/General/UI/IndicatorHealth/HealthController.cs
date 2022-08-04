using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthController : MonoBehaviour
{
    private Slider _helthPoints;

    private Coroutine _proccesChangeHelth;

    private float _healthValue = 10;
    private float _tergetHelath;
    private const int Factor = 8;

    private void Start()
    {
        _helthPoints = GetComponent<Slider>();
        _tergetHelath = _helthPoints.value;
    }

    public void HealPlayer()
    {
        _tergetHelath = _helthPoints.value + _healthValue;

        CorutineController();
    }

    public void HitPlayer()
    {
        _tergetHelath = _helthPoints.value - _healthValue;

        CorutineController();
    }

    private void CorutineController()
    {
        if (_proccesChangeHelth != null)
        {
            StopCoroutine(_proccesChangeHelth);
        }
        _proccesChangeHelth = StartCoroutine(ChangeHelth());
    }

    private IEnumerator ChangeHelth()
    {
        while(_helthPoints.value != _tergetHelath)
        {
            _helthPoints.value = Mathf.MoveTowards(_helthPoints.value, _tergetHelath, Time.deltaTime * Factor);
            yield return null;
        }        
    }
}
