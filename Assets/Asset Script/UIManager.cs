using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform Menu1, Menu2, PI1, PI2, Button, Informasi, Petunjuk;
    public GameObject Backgorund1, Background2;
    // Start is called before the first frame update
    void Start()
    {
        Backgorund1.SetActive(true);
        Background2.SetActive(false);
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PI1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PI2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void Kembalibutton()
    {
        Backgorund1.SetActive(true);
        Background2.SetActive(false);
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PI1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PI2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void Informasibutton()
    {
        Backgorund1.SetActive(false);
        Background2.SetActive(true);
        Menu1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PI1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PI2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void Petunjukbutton()
    {
        Backgorund1.SetActive(false);
        Background2.SetActive(true);
        Menu1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PI1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PI2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}