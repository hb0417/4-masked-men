using UnityEngine;

public class PetProjectile : MonoBehaviour
{
    private float projectilleDamage;
    [SerializeField]private float speed = 10f;

    private Rigidbody2D rb;
    public Transform target;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Initialize(float petAtk)
    {
        projectilleDamage = petAtk;
        target = GameManager.Instance.Boss.curBoss.bossImage.transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.Boss.OnDmagable(projectilleDamage);
        gameObject.SetActive(false);
    }

    public void GetTargetVector()
    {
        Vector2 direction = (target.position - this.transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}