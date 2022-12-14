using UnityEngine;

public class Jump : MonoBehaviour
{
    [System.Serializable]
    public class MovementSettings
    {
        public float forwardVelocity = 10;
        public float jumpVelocity = 20f;
    }
    [System.Serializable]
    public class PhysicsSettings
    {
        public float downAccelration = 0.75f;
    }
    public MovementSettings movementSettings = new MovementSettings();
    public PhysicsSettings physicsSettings = new PhysicsSettings();

    public Vector3 _velocity;
    private Rigidbody _rigidbody;
    private Animator _animator;
    private int _jumpInput = 0;
    private bool _onGround = false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _velocity = Vector3.zero;
    }

    void FixedUpdate()
    {
        InputHandling();
        CheckGround();
        jump();
        _rigidbody.velocity = _velocity;
    }


    void Run()
    {
        _velocity.z = movementSettings.forwardVelocity;
    }
    void jump()
    {
        if (_jumpInput == 1 && _onGround)
        {

            _animator.SetTrigger("Jump");
        }
        else if (_jumpInput == 0 && _onGround)
        {
            _velocity.y = 0;
        }
        else
        {
            _velocity.y -= physicsSettings.downAccelration;
        }
        _jumpInput = 0;

    }
    // Update is called once per frame
    void Update()
    {
        InputHandling();
        CheckGround();
        jump();
        _rigidbody.velocity = _velocity;
    }

    

    void CheckGround()
    {
        Ray ray = new Ray (transform.position + Vector3.up  * 0.1f, Vector3.down);
        RaycastHit [] hits = Physics.RaycastAll(ray,0.5f);
        _onGround = false;
        _rigidbody.useGravity = true;
        foreach(var hit in hits)
        {
            if(!hit.collider.isTrigger)
            {
                if(_velocity.y <= 0)
                {
                    _rigidbody.position = Vector3.MoveTowards (_rigidbody.position,
                    new Vector3 (hit.point.x, hit.point.y + 0.1f, hit.point.z), Time.deltaTime*10);

                }
                _rigidbody.useGravity = false;
                _onGround = true;
                break;
            }
        }
    }

void InputHandling()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpInput = 1;
        }
    }
}
