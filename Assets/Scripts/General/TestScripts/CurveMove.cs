using UnityEngine;

[RequireComponent(typeof(AnimationCurve))]
public class CurveMove : MonoBehaviour
{
    [SerializeField] private AnimationCurve _moveIntensite;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private float _currenTime = 0;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(_startPoint.position, _endPoint.position, _moveIntensite.Evaluate(_currenTime));

        _currenTime += Time.deltaTime;
    }
}
