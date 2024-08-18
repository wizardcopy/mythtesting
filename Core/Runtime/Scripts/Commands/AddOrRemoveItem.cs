﻿using System;
using UnityEngine;

namespace Gyvr.Mythril2D
{
    [Serializable]
    public class AddOrRemoveItem : ICommand
    {
        [SerializeField] private EAction m_action = EAction.Add;
        [SerializeField] private Item m_item = null;
        [SerializeField][Min(1)] private int m_quantity = 1;

        public void Execute()
        {
            Debug.Assert(m_quantity != 0, "Invalid quantity! Expected != 0");

            switch(m_action)
            {
                case EAction.Add:
                    GameManager.InventorySystem.AddToBag(m_item, m_quantity);
                    break;

                case EAction.Remove:
                    GameManager.InventorySystem.RemoveFromBag(m_item, m_quantity);
                    break;
            }
        }
    }
}
