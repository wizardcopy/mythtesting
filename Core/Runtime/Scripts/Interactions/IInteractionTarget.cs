using UnityEngine.Events;

namespace Gyvr.Mythril2D
{
    public interface IInteractionTarget
    {
        public string GetSpeakerName();
        public void OnInteract(CharacterBase source);
        public void Say(DialogueSequence sequence, UnityAction<DialogueMessageFeed> onDialogueEnded = null, params string[] args);
    }
}
