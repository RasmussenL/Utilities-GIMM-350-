using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        SoundManager.Instance.PlaySoundEffect(SoundManager.Instance.skyHello);
        DialogueManager.Instance.StartDialogue(dialogue);
    }
}
