using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Pet : MonoBehaviour // WK
{
    public string petName;
    public float petCost;
    public Sprite icon;
    public float petAtk;
    public float atkSpeed;

    [SerializeField]private Transform projectileSpawnPosition;


    private void Start()
    {
       StartCoroutine(OnPetAttack());
    }

    private void PetAttack()
    {
        CreateProjectile();
    }

    private IEnumerator OnPetAttack()
    {
        while (true)
        {
            PetAttack();

            yield return new WaitForSeconds(atkSpeed);
        }
    }

    private void CreateProjectile()
    {
        GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool("PetAtk");
        obj.transform.position = projectileSpawnPosition.position;
        PetProjectile petProjectile = obj.GetComponent<PetProjectile>();
        petProjectile.Initialize(petAtk);
        petProjectile.ProjectileShoot();
    }
}
