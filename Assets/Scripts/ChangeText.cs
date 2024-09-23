using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _changeValue;
    [SerializeField] private string _addValue;
    [SerializeField] private string _changeOverkillValue;
    [SerializeField] private float _duration;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private int _repeats;

    private void Start() =>
        DOTween.Sequence().Append(_text.DOText(_changeValue, _duration))
            .Append(_text.DOText(_addValue, _duration).SetRelative())
            .Append(_text.DOText(_changeOverkillValue, _duration, true, _scrambleMode))
            .SetLoops(_repeats);
}
