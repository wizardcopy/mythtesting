using System;
using UnityEngine;

namespace Gyvr.Mythril2D
{
    [Serializable]
    public class IsNot : ABaseCondition
    {
        [SerializeReference, SubclassSelector] private ICondition m_condition = null;

        public override bool Evaluate() => !m_condition?.Evaluate() ?? true;

        public override void StartListening(Action action)
        {
            base.StartListening(action);
            m_condition.StartListening(action);
        }

        public override void StopListening()
        {
            base.StopListening();
            m_condition.StopListening();
        }
    }
}
