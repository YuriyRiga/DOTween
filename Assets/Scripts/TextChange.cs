using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : TweenObject
{
    [SerializeField] private Text _textUI;
    [SerializeField] private string _text1;
    [SerializeField] private string _text2;
    [SerializeField] private string _text3;
    [SerializeField] private float _interval = 1f;

    protected override void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_textUI.DOText(_text1, Duration));
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text2, Duration).SetRelative());
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text3, Duration, true, ScrambleMode.All));
    }
}
