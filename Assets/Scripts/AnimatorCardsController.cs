using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCardsController : MonoBehaviour
{
    [Header("Coke")]
    [SerializeField]
    private List<Animator> _listCokeAnimator;
    [SerializeField]
    private List<TextCard> _listCokeTextCard;

    [Space]

    [Header("Monster")]
    [SerializeField]
    private List<Animator> _listMonsterAnimator;
    [SerializeField]
    private List<TextCard> _listMonsterTextCard;

    [Space]

    [Header("Fanta")]
    [SerializeField]
    private List<Animator> _listFantaAnimator;
    [SerializeField]
    private List<TextCard> _listFantaTextCard;

    [Space]

    [Header("Redbull")]
    [SerializeField]
    private List<Animator> _listRedbullAnimator;
    [SerializeField]
    private List<TextCard> _listRedbullTextCard;

    [Space]

    [Header("KAS")]
    [SerializeField]
    private List<Animator> _listKasAnimator;
    [SerializeField]
    private List<TextCard> _listKasTextCard;

    [Space]

    [Header("Aquarius")]
    [SerializeField]
    private List<Animator> _listAquariusAnimator;
    [SerializeField]
    private List<TextCard> _listAquariusTextCard;

    //COKE
    public void ActiveAnimatorCoke()
    {
        for (int i = 0; i < _listCokeAnimator.Count; i++)
        {
            _listCokeAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listCokeTextCard.Count; i++)
        {
            StartCoroutine(_listCokeTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorCoke()
    {
        for (int i = 0; i < _listCokeAnimator.Count; i++)
        {
            _listCokeAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listCokeTextCard.Count; i++)
        {
            _listCokeTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }

    //MONSTER
    public void ActiveAnimatorMonster()
    {
        for (int i = 0; i < _listMonsterAnimator.Count; i++)
        {
            _listMonsterAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listMonsterTextCard.Count; i++)
        {
            StartCoroutine(_listMonsterTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorMonster()
    {
        for (int i = 0; i < _listMonsterAnimator.Count; i++)
        {
           _listMonsterAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listMonsterTextCard.Count; i++)
        {
            _listMonsterTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }

    //FANTA 
    public void ActiveAnimatorFanta()
    {
        for (int i = 0; i < _listFantaAnimator.Count; i++)
        {
            _listFantaAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listFantaTextCard.Count; i++)
        {
            StartCoroutine(_listFantaTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorFanta()
    {
        for (int i = 0; i < _listFantaAnimator.Count; i++)
        {
            _listFantaAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listFantaTextCard.Count; i++)
        {
            _listFantaTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }
    //REDBULL   

    public void ActiveAnimatorRedbull()
    {
        for (int i = 0; i < _listRedbullAnimator.Count; i++)
        {
            _listRedbullAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listRedbullTextCard.Count; i++)
        {
            StartCoroutine(_listRedbullTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorRedbull()
    {
        for (int i = 0; i < _listRedbullAnimator.Count; i++)
        {
            _listRedbullAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listRedbullTextCard.Count; i++)
        {
            _listRedbullTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }

    //KAS

    public void ActiveAnimatorKas()
    {
        for (int i = 0; i < _listKasAnimator.Count; i++)
        {
            _listKasAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listKasTextCard.Count; i++)
        {
            StartCoroutine(_listKasTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorKas()
    {

        for (int i = 0; i < _listKasAnimator.Count; i++)
        {
            _listKasAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listKasTextCard.Count; i++)
        {
           _listKasTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }


    //AQUARIUS  

    public void ActiveAnimatorAquarius()
    {
        for (int i = 0; i < _listAquariusAnimator.Count; i++)
        {
            _listAquariusAnimator[i].SetBool("IsMoving", true);
        }
        for (int i = 0; i < _listAquariusTextCard.Count; i++)
        {
            StartCoroutine(_listAquariusTextCard[i].WritingText(i));
        }

    }

    public void UnActivateAnimatorAquarius()
    {
        for (int i = 0; i < _listAquariusAnimator.Count; i++)
        {
            _listAquariusAnimator[i].SetBool("IsMoving", false);
        }
        for (int i = 0; i < _listAquariusTextCard.Count; i++)
        {
            _listAquariusTextCard[i].StopWriting();
        }
        StopAllCoroutines();
    }
}
