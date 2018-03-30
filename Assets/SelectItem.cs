using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
    public GameObject selectedItem;
    public Image namepic;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void onClicked()
    { 
        Debug.Log("sasaassasa : "+GetInstanceID());
    }
}
