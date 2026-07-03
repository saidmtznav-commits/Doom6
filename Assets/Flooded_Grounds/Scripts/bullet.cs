using UnityEngine;
public class Bullet : MonoBehaviour
{
   [SerializeField]
   private float speed = 20f;
   protected float damage = 10f;
   public float Damage { set { damage = value; } }
   private Rigidbody rb;
   private void Awake()
   {
       rb = GetComponent<Rigidbody>();
   }
   void OnEnable()
   {
       rb.angularVelocity = Vector3.zero;
       rb.linearVelocity = Vector3.zero;
       rb.linearVelocity = transform.forward * speed;
   }
   public virtual void OnCollisionEnter(Collision collision)
   {
       gameObject.SetActive(false);
   }
}