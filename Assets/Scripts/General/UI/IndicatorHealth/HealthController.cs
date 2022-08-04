using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthController : MonoBehaviour
{
    private Slider _helthPoints;
    private HelthView _helthView;

    private float _healthValue = 10;
    private float _tergetHelath;

    private void Start()
    {
        _helthPoints = GetComponent<Slider>();
        _helthView = GetComponent<HelthView>();
        _tergetHelath = _helthPoints.value;
    }

    public void HealPlayer()
    {
        _tergetHelath = _helthPoints.value + _healthValue;

        _helthView.CorutineController(_tergetHelath);
    }

    public void HitPlayer()
    {
        _tergetHelath = _helthPoints.value - _healthValue;

        _helthView.CorutineController(_tergetHelath);
    }

    
}
