using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        SoundManager.Instance.PlaySoundEffect(SoundManager.Instance.chefHello);
        DialogueManager.Instance.StartDialogue(dialogue);
    }
}
