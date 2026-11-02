using UnityEngine;
public class PlayerShooting : MonoBehaviour
{
    public float range = 100f;
    public int damage = 25;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, range))
            {
                Debug.Log("Влучив у: " + hit.collider.name);

                EnemyHealth enemy = hit.collider.GetComponent<EnemyHealth>();

                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }
        }
    }
}