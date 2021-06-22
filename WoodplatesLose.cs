using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WoodplatesLose : MonoBehaviour, IPointerClickHandler
{
    public GameObject choiceText;
    public GameObject textWrong;
    public GameObject textWrongActive;
    public GameObject graphicWrong;
    public GameObject graphicWrongActive;
    public GameObject woodplate_Left;
    public void Start()
    {
        choiceText = GameObject.Find("Choice_text");
        textWrong = GameObject.Find("Text_wrong");
        textWrongActive = textWrong;
        if (textWrong)
        {
            Debug.Log(textWrong.name);
            textWrong.SetActive(false);
        }
        else Debug.Log("No Text_wrong");
        graphicWrong = GameObject.Find("Wrong_graphic");
        graphicWrongActive = graphicWrong;
        if (graphicWrong)
        {
            Debug.Log(graphicWrong.name);
            graphicWrong.SetActive(false);
        }
        woodplate_Left = GameObject.Find("Woodplate_Left");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click received");
        if (choiceText)
        {
            Debug.Log(choiceText.name);
            choiceText.SetActive(false);
        }
        textWrongActive.SetActive(true);
        graphicWrongActive.SetActive(true);
        woodplate_Left.SetActive(false);
    }
}
