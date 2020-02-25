using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueRunner : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Text nameText;
    [SerializeField] private Text dialogueText;
    [SerializeField] private GameObject contentParent;

    private bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isShowing)
        {
            if (Input.anyKeyDown)
            {
                contentParent.SetActive(false);
                isShowing = false;
            }
        }
    }

    public void ShowDialogue(NPC npc)
    {
        isShowing = true;
        contentParent.SetActive(true);

        image.sprite = npc.NPCImage;
        nameText.text = npc.name;
        dialogueText.text = npc.dialogue;
    }
}
