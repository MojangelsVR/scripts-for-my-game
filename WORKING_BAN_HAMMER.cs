using UnityEngine;

public class BanScript : MonoBehaviour
{
    [SerializeField] private float banRadius = 2f;
    [SerializeField] private LayerMask banMask;
    [SerializeField] private float force = 100f;
    [SerializeField] private float upwardModifier = 1f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left-click input
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, banRadius, banMask)) // Check if hit object is in specified layer mask and within range
            {
                BanPlayer(hit.collider.gameObject);
            }
        }
    }

    private void BanPlayer(GameObject player)
    {
        // TODO: Send ban request to server or backend to ban player

        Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
        playerRigidbody.AddForce(transform.forward * force + transform.up * upwardModifier, ForceMode.Impulse);

        // Disable the player's character controller and collider
        CharacterController characterController = player.GetComponent<CharacterController>();
        characterController.enabled = false;
        Collider playerCollider = player.GetComponent<Collider>();
        playerCollider.enabled = false;

        // Destroy the player's gameobject after a delay
        Destroy(player, 5f);
    }
}