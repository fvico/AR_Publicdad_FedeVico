using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCard : MonoBehaviour
{
    [SerializeField]
    private string _frameText;
    [SerializeField]
    private float _timeToWrite;
    private bool _isWriting = false;

    private TMP_Text _frame;
  
   public IEnumerator WritingText(int i)
    {
        Debug.Log($"Call Writing{i}: is writing {_isWriting}");
        if (_isWriting)
        {
            yield break;
        }
    else
        {
            Debug.Log($"Start Writing {i} object {transform.name}");
            _isWriting = true;
            _frame.text = "";
            yield return new WaitForSeconds(0.7f);
            _frame.text = "";
            foreach (var character in _frameText)
            {
                _frame.text += character;
                yield return new WaitForSeconds(_timeToWrite);
                //_isWriting = false;
            }
            _isWriting = false;
            Debug.Log($"End Writing {i} object {transform.name}");
        }
        
    }
       
   public void StopWriting()
    {
        _frame.text = "";
        _isWriting = false;
    }

    private void Start()
    {
        _frame = GetComponent<TMP_Text>();
        _frame.text = "";
        _isWriting = false;

    }
}
