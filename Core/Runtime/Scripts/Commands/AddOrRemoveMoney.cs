﻿using System;
using UnityEngine;

namespace Gyvr.Mythril2D
{
    [Serializable]
    public class AddOrRemoveMoney : ICommand
    {
        [SerializeField] private EAction m_action = EAction.Add;
        [SerializeField][Min(0)] private int m_amount = 0;

        public void Execute()
        {
            Debug.Assert(m_amount != 0, "Invalid quantity! Expected != 0");

            switch (m_action)
            {
                case EAction.Add:
                    GameManager.InventorySystem.AddMoney(m_amount);
                    break;

                case EAction.Remove:
                    GameManager.InventorySystem.RemoveMoney(m_amount);
                    break;
            }
        }
    }
}
