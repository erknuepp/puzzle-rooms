namespace Assets.Scripts
{
    using UnityEngine;

    public class Player : MonoBehaviour
    {
        private bool _jumpKeyWaPressed;
        private float _horizontalInput;
        private Rigidbody _rigidBodyComponent;
        
        [SerializeField]
        private Transform _groundCheckTransform = null;
        [SerializeField]
        private LayerMask playerLayerMask;

        // Use this for initialization
        void Start()
        {
            _rigidBodyComponent = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumpKeyWaPressed = true;
            }

            _horizontalInput = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            _rigidBodyComponent.velocity = new Vector3(_horizontalInput, _rigidBodyComponent.velocity.y, 0);

            if (Physics.OverlapSphere(_groundCheckTransform.position, 0.1f, playerLayerMask).Length == 0)
            {
                return;
            }

            if (_jumpKeyWaPressed)
            {
                _rigidBodyComponent.AddForce(Vector3.up * 9, ForceMode.VelocityChange);
                _jumpKeyWaPressed = false;
            }

        }

        
    }
}