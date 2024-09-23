using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]
public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    private Material _material;

    private void Awake() =>
        _material = GetComponent<MeshRenderer>().material;

    private void Start() =>
        _material.DOColor(_color, _duration)
            .SetLoops(_repeats, _loopType)
            .SetEase(_ease);
}
