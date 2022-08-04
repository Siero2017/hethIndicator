using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HelthView : MonoBehaviour
{
    private Coroutine _proccesChangeHelth;
    private Slider _healthPoints;
    private Health _healthCheck;

    private const int Factor = 8;

    private void Start()
    {
        _healthPoints = GetComponent<Slider>();
        _healthCheck = GetComponent<Health>();
        _healthCheck.ChangeValue += CorutineController;
    }

    public void CorutineController(float targetHealth)
    {
        if (_proccesChangeHelth != null)
        {
            StopCoroutine(_proccesChangeHelth);
        }
        _proccesChangeHelth = StartCoroutine(ChangeHelth(targetHealth));
    }

    private IEnumerator ChangeHelth(float targetHealth)
    {
        while (_healthPoints.value != targetHealth)
        {
            _healthPoints.value = Mathf.MoveTowards(_healthPoints.value, targetHealth, Time.deltaTime * Factor);
            yield return null;
        }
    }
}
