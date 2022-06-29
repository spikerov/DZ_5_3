using UnityEngine;

public abstract class Transition : MonoBehaviour
{
    [SerializeField] private State _targetState;

    protected Player Target { get; private set; }

    public State TargetState => _targetState;

    public bool NeedTransit { get; protected set; }

    private void OnEnable()
    {
        NeedTransit = false;
    }

    public void Init(Player player)
    {
        Target = player;
    }

    public void PlayerIsOutOffReach(bool needTransit)
    {
        NeedTransit = needTransit;
    }

}
