using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    //UI References
    [SerializeField]
    private TMP_Text SpeakerText;

    [SerializeField]
    private TMP_Text dialogueText;

    [SerializeField]
    private Image PortraitImage;


    //Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;



      // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("E"))
        {
            SpeakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            PortraitImage.sprite = portrait[0];
        }
    }
}
