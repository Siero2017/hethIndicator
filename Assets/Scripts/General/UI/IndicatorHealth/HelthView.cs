using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HelthView : MonoBehaviour
{
    private Coroutine _proccesChangeHelth;
    private Slider _helthPoints;

    private const int Factor = 8;

    private void Start()
    {
        _helthPoints = GetComponent<Slider>();
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
        while (_helthPoints.value != targetHealth)
        {
            _helthPoints.value = Mathf.MoveTowards(_helthPoints.value, targetHealth, Time.deltaTime * Factor);
            yield return null;
        }
    }
}
