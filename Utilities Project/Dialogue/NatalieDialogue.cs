using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatalieDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        SoundManager.Instance.PlaySoundEffect(SoundManager.Instance.natHello);
        DialogueManager.Instance.StartDialogue(dialogue);
    }
}
