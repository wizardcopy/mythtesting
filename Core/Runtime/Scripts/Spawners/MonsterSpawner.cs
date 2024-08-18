using UnityEngine;

namespace Gyvr.Mythril2D
{
    public class MonsterSpawner : AMonsterSpawner
    {
        [Header("Spawner Location Settings")]
        [SerializeField] private Vector2 m_offset = Vector2.zero;

        protected override Vector2 FindSpawnLocation()
        {
            return new Vector2(
                transform.position.x,
                transform.position.y
            ) + m_offset;
        }
    }
}
