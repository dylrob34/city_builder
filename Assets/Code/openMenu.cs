using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openMenu : MonoBehaviour
{

    
    public GameObject menu;
    public Image thisImage;
    public Sprite exitSprite;

    // Start is called before the first frame update
    public void enableMenu(bool i)
    {
        //GameObject menu = GameObject.Find("Menu");
        menu.SetActive(i);
        thisImage.sprite = exitSprite;
    }




}
