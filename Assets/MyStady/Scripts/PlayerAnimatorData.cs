using UnityEngine;

public class PlayerAnimatorData : MonoBehaviour
{
    public class Params
    {
        public static readonly int Speed = Animator.StringToHash(nameof(Speed));
        public static readonly int Jump = Animator.StringToHash(nameof(Jump));
    }
}
