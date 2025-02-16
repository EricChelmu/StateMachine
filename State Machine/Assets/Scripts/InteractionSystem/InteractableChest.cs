using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class InteractableChest : Interactable
    {
        private Animator animator;
        [Header("Locked Chest Options")]
        public bool isLocked;
        public string chestID;
        public bool isOpen;
        public GameObject chestText;

        public override void Start()
        {
            base.Start();
            animator = GetComponent<Animator>();
            isOpen = false;
        }

        protected override void Interaction()
        {
            base.Interaction();

            if (!isLocked)
            {
                if (!isOpen)
                {
                    OpenChest();
                    print("Opening the chest");

                }
                else
                {
                    CloseChest();
                    print("Closing the chest");
                }

            }
            else
            {
                /*
                Inventory inventory = player.GetComponent<Inventory>();
                List<Item> items = inventory.GetItems(Resources.Load<Item>("heavyChestKey"));
                foreach (Item item in items)
                {
                    if (((KeyItem)item).keyID == chestID)
                    {
                        print("unlocked");
                        isLocked = false;
                        Events.RemoveInventoryItem(item, 1);
                        OpenChest();
                    }
                    else
                    {
                        print("locked & wrong key");
                    }
                }
                */

            }
        }


        void CloseChest()
        {
            //Events.ShowLoot(false);
            //animator.SetTrigger("CloseChest");
            isOpen = !isOpen;
            chestText.SetActive(false);
        }

        void OpenChest()
        {
            //GetComponent<ItemContainer>().SetLoot();
            //Events.ShowLoot(true);
            //animator.SetTrigger("OpenChest");
            isOpen = !isOpen;
            chestText.SetActive(true);

            //Events.OnShowLoot += TriggerChest;
        }
        /*
        void TriggerChest(bool openChest)
        {
            if (openChest)
            {
                GetComponent<ItemContainer>().SetLoot();
                Events.ShowLoot(true);
                animator.SetTrigger("OpenChest");
                isOpen = !isOpen;
            }
            else
            {
                GetComponent<ItemContainer>().ResetLoot();
                animator.SetTrigger("CloseChest");
                isOpen = !isOpen;
                Events.OnShowLoot -= TriggerChest;
            }
        }
        */
    }
}