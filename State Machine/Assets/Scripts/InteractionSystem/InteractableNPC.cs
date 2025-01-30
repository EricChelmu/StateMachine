using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class InteractableNPC : Interactable
    {
        private Animator animator;
        public GameObject npcText;

        public override void Start()
        {
            base.Start();
            animator = GetComponent<Animator>();
        }
        protected override void Interaction()
        {
            base.Interaction();
            print("Hello! Unfortunately I don't have a dialog system yet.");
            //animator.SetTrigger("Wave");
            npcText.SetActive(true);
            StartCoroutine(HideTextAfterDelay(3f));
        }

        private IEnumerator HideTextAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            npcText.SetActive(false);
        }
    }
}