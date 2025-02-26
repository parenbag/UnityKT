using UnityEngine;

public class MovingObject : MonoBehaviour
{
    private Score _score;
    private HingeJoint hingeJoint;
    private JointMotor motor;

    public void Initialize(Score score)
    {
        _score = score;
    }

    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        motor = hingeJoint.motor;
        motor.targetVelocity = 100;
        motor.force = 1000;
        hingeJoint.motor = motor;
        hingeJoint.useMotor = true;
    }

    void Update()
    {
        if (hingeJoint.angle >= hingeJoint.limits.max || hingeJoint.angle <= hingeJoint.limits.min)
        {
            motor.targetVelocity = -motor.targetVelocity;
            hingeJoint.motor = motor;
        }
    }

    void OnMouseDown()
    {
        _score.ChangeScore(1);
    }
}