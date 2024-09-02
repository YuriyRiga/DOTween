using DG.Tweening;
using UnityEngine;

public class ObjectText : TweenObject
{
    [SerializeField] private UnityEngine.UI.Text _textUI;
    [SerializeField] private string _text1;
    [SerializeField] private string _text2;
    [SerializeField] private string _text3;
    [SerializeField] private float _interval = 1f;

    private string _originalText;

    private void Start()
    {
        _originalText = _textUI.text;
        AnimateText();
    }

    private void AnimateText()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_textUI.DOText(_text1, Duration));
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text2, Duration).SetRelative());
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text3, Duration, true, ScrambleMode.All));
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_originalText, Duration));

        AnimateLoop(sequence);
    }
}
