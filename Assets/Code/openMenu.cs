using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openMenu : MonoBehaviour
{

    
    public GameObject menu;
    public Image thisImage;
    public Sprite exitSprite;
    public Sprite defaultSprite;

    // Start is called before the first frame update
    [System.Obsolete]
    public void enableMenu(bool i)
    {
        //GameObject menu = GameObject.Find("Menu");
        if (menu.active == false)
        {
            menu.SetActive(true);
            thisImage.sprite = exitSprite;
        }
        else if (menu.active)
        {
            menu.SetActive(false);
            thisImage.sprite = defaultSprite;
        }
    }




}
