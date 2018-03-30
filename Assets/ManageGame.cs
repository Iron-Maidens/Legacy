using frame8.ScrollRectItemsAdapter.Classic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageGame : MonoBehaviour 
{

    public Sprite nullImg;
    public GameObject item1;
    public GameObject item2;
    public static int[] chekItemList;
    // Use this for initalization
    Image image1,image2;
    public bool statusItem1 = false;
    public bool statusItem2 = false;
    void Start () {
        image1 = item1.GetComponent<Image>();
        image2 = item2.GetComponent<Image>();
      /*  for (int i = 0; i < 53; i++)
        {
            if(i<7)
                chekItemList[i] = 1;
            else
                chekItemList[i] = 0;
        }*/
    }
	
	// Update is called once per frame
	void Update () {

    }
        
    public void setNullItem(int i)
    {
        if(i==1)
        {
            image1.sprite = nullImg;
            statusItem1 = false;
        }
        if(i==2)
        {
            image2.sprite = nullImg;
            statusItem2 = false;
        }
    }

}

