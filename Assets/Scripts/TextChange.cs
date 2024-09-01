using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _textUI;
    [SerializeField] private string _text1;
    [SerializeField] private string _text2;
    [SerializeField] private string _text3;
    [SerializeField] private float _interval = 1f;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_textUI.DOText(_text1, _duration));
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text2, _duration).SetRelative());
        sequence.AppendInterval(_interval);
        sequence.Append(_textUI.DOText(_text3, _duration, true, ScrambleMode.All));
    }
}
