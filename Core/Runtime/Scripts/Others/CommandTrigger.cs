﻿using UnityEngine;

namespace Gyvr.Mythril2D
{
    public class CommandTrigger : MonoBehaviour
    {
        public enum EActivationEvent
        {
            OnStart,
            OnEnable,
            OnDisable,
            OnDestroy,
            OnUpdate,
            OnPlayerEnterTrigger,
            OnPlayerExitTrigger,
            OnPlayerInteract,
        }

        [Header("Requirements")]
        [SerializeField] private EActivationEvent m_activationEvent;
        [SerializeReference, SubclassSelector] private ICondition m_condition;

        [Header("Actions")]
        [SerializeReference, SubclassSelector] private ICommand m_toExecute;

        [Header("Settings")]
        [SerializeField] private int m_frameDelay = 0;

        private void AttemptExecution(EActivationEvent currentEvent, GameObject go = null)
        {
            if (currentEvent == m_activationEvent && (!go || go == GameManager.Player.gameObject) && (m_condition?.Evaluate() ?? true))
            {
                if (m_frameDelay <= 0)
                {
                    Execute();
                }
                else
                {
                    StartCoroutine(CoroutineHelpers.ExecuteInXFrames(m_frameDelay, Execute));
                }
            }
        }

        private void Execute()
        {
            m_toExecute?.Execute();
        }

        private void Start() => AttemptExecution(EActivationEvent.OnStart);
        private void Update() => AttemptExecution(EActivationEvent.OnUpdate);
        private void OnEnable() => AttemptExecution(EActivationEvent.OnEnable);
        private void OnDisable() => AttemptExecution(EActivationEvent.OnDisable);
        private void OnDestroy() => AttemptExecution(EActivationEvent.OnDestroy);
        private void OnTriggerEnter2D(Collider2D collider) => AttemptExecution(EActivationEvent.OnPlayerEnterTrigger, collider.gameObject);
        private void OnTriggerExit2D(Collider2D collider) => AttemptExecution(EActivationEvent.OnPlayerExitTrigger, collider.gameObject);
        private void OnInteract(CharacterBase sender) => AttemptExecution(EActivationEvent.OnPlayerInteract, sender.gameObject);
    }
}