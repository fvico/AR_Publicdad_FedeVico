using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject _menuInicio;
    [SerializeField]
    private GameObject _menuSelectionCard;
    [SerializeField]
    private GameObject _menuSelectionCan;
    [Space]
    [SerializeField]
    private SoundController _soundController;
    [SerializeField]
    private GameObject _listCan;
    [SerializeField]
    private GameObject _listCard;

    private void Start()
    {
        _listCan.SetActive(false);
        _listCard.SetActive(false);
        LoadInicio();
    }

    public void LoadInicio()
    {
       
        _menuInicio.SetActive(true);
        _menuSelectionCard.SetActive(false);
        _menuSelectionCan.SetActive(false);
        _listCan.SetActive(false);
        _listCard.SetActive(false);
    }
    public void LoadMenuSelectionCard()
    {
        _menuInicio.SetActive(false);
        _menuSelectionCard.SetActive(true);
        _menuSelectionCan.SetActive(false);
        _listCan.SetActive(false);
        _listCard.SetActive(true);


    }
    public void LoadMenuSelectionCan()
    {
        _menuInicio.SetActive(false);
        _menuSelectionCard.SetActive(false);
        _menuSelectionCan.SetActive(true);
        _listCan.SetActive(true);
        _listCard.SetActive(false);

    }

    public void LoadMenuCard()
    {
        _menuInicio.SetActive(false);
        _menuSelectionCard.SetActive(false);
        _menuSelectionCan.SetActive(false);
       

    }
    public void LoadMenuCan()
    {
        _menuInicio.SetActive(false);
        _menuSelectionCard.SetActive(false);
        _menuSelectionCan.SetActive(false);
        

    }
    public void DetectObject()
    {
        _menuInicio.SetActive(false);
        _menuSelectionCard.SetActive(false);
        _menuSelectionCan.SetActive(false);
       
    }

    
}
