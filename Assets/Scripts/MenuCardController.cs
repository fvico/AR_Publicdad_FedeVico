using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCardController : MonoBehaviour
{
    [SerializeField]
    private string _istagram;
    [SerializeField]
    private string _facebook;
    [SerializeField]
    private string _twitter;
    [SerializeField]
    private string _location;
    [SerializeField]
    private string _web;

    public void LoadInstagram(string url)
    {
        url = _istagram;
        Application.OpenURL(url);
    }

    public void LoadFacebook(string url)
    {
        url = _facebook;
        Application.OpenURL(url);
    }

    public void LoadTwitter(string url)
    {
        url = _twitter;
        Application.OpenURL(url);
    }

    public void LoadLocation(string url)
    {
        url = _location;
        Application.OpenURL(url);
    }

    public void LoadWeb(string url)
    {
        url = _web;
        Application.OpenURL(url);
    }

}
