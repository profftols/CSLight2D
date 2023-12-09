using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    
    private Animator _animator;
    private SpriteRenderer _sprite;
    private float _jump = 7;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _sprite.flipX = false;
        _animator.SetFloat(PlayerAnimatorData.Params.Speed, 0);
        float move = _speedMove * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetFloat(PlayerAnimatorData.Params.Speed, move);
            transform.Translate(move, 0 , 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetFloat(PlayerAnimatorData.Params.Speed, move);
            _sprite.flipX = true;
            transform.Translate(-move, 0 , 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetTrigger(PlayerAnimatorData.Params.Jump);
            transform.Translate(0, _jump*Time.deltaTime, 0);
        }
    }
}
