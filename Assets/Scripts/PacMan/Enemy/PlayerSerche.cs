using UnityEngine;

namespace PackMan_Enemy
{

    public class PlayerSerche : MonoBehaviour
    {
        [SerializeField]
        private EnemyController controller;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(TagName.Player))
            {
                controller.TargetPlayer(other.transform.position);
            }
        }
    }
}
