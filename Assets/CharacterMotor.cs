using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public float moveSpeed;
    public DialogueRunner dialogueRunner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.W))
            input.y = 1;
        if (Input.GetKeyDown(KeyCode.A))
            input.x = -1;
        if (Input.GetKeyDown(KeyCode.S))
            input.y = -1;
        if (Input.GetKeyDown(KeyCode.D))
            input.x = 1;

        transform.Translate(input * moveSpeed);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var npc = GetComponent<NPC>();

            if (npc != null)
            {
                dialogueRunner.ShowDialogue(npc);
            }
        }
    }
}
