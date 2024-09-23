using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _value;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    private void Start() =>
        transform.DORotate(_value, _duration)
            .SetLoops(_repeats, _loopType)
            .SetEase(_ease);
}
