using UnityEngine;

namespace BarthaSzabolcs.IsometricAiming
{
    public class shootToTarget : MonoBehaviour
    {
        [SerializeField] GameObject projectile;
        [SerializeField] private float speed;

        public Transform bulletSpwanPoint;
        public GameObject bulletprefab;
        public float bulletSpeed = 10f;
      //  [SerializeField] private GameObject explosionEffect;
        #region Datamembers

        #region Editor Settings

        [SerializeField] private LayerMask groundMask;

        #endregion
        #region Private Fields
       // private bool destoryed = false;
        private Camera mainCamera;

        #endregion

        #endregion


        #region Methods

        #region Unity Callbacks


        private void Start()
        {
            // Cache the camera, Camera.main is an expensive operation.
            mainCamera = Camera.main;
            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.velocity = transform.forward * speed;

        }
        private void OnCollisionEnter(Collision col)
        {
            
        }

        private void Update()
        {
            Aim();

            if (Input.GetMouseButton(0))
            {
                var bullet = Instantiate(bulletprefab, bulletSpwanPoint.position, bulletSpwanPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpwanPoint.forward * bulletSpeed;
                Destroy(bullet,5f);
            }
            
        }

        #endregion

        private void Aim()
        {
            var (success, position) = GetMousePosition();
            if (success)
            {
                // Calculate the direction
                var direction = position - transform.position;

                // You might want to delete this line.
                // Ignore the height difference.
                direction.y = 0;

                // Make the transform look in the direction.
                transform.forward = direction;
            }
        }

        private (bool success, Vector3 position) GetMousePosition()
        {
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, groundMask))
            {
                // The Raycast hit something, return with the position.
                return (success: true, position: hitInfo.point);
            }
            else
            {
                // The Raycast did not hit anything.
                return (success: false, position: Vector3.zero);
            }
        }

        #endregion
    }
   
}