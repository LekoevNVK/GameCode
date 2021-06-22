using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WoodplatesWin : MonoBehaviour, IPointerClickHandler
{
    public GameObject obj;
    public GameObject objActive;
    public GameObject choiceText;
    public GameObject textTrue;
    public GameObject textTrueActive;
    public GameObject woodplate_right;
    public void Start()
    {
        obj = GameObject.Find("Graphic");
        objActive = obj;
        if (obj)
        {
            Debug.Log(obj.name);
            obj.SetActive(false);
        }
        else
        {
            Debug.Log("No Graphic object");
        }
        choiceText = GameObject.Find("Choice_text");
        textTrue = GameObject.Find("Text_true");
        textTrueActive = textTrue;
        if (textTrue)
        {
            Debug.Log(textTrue.name);
            textTrue.SetActive(false);
        }
        else Debug.Log("No Text_true");
        woodplate_right = GameObject.Find("Woodplate_Right");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click received");
        objActive.SetActive(true);
        if (choiceText)
        {
            Debug.Log(choiceText.name);
            choiceText.SetActive(false);
        }
        textTrueActive.SetActive(true);
        woodplate_right.SetActive(false);
    }
}
