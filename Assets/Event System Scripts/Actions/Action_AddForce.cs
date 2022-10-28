using UnityEngine;

public class Action_AddForce : MonoBehaviour
{
    public GameObject GameObject;
    private Rigidbody m_Rigidbody;

    public enum ForceActionTypes
    {
        Force,
        Acceleration,
        Impulse,
        VelocityChange
    }

    [Header("Type of Force Action")]
    public ForceActionTypes actionType = ForceActionTypes.Force;

    public Vector3 ForceDirection;

    public float ForceValue = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GameObject.GetComponent<Rigidbody>();
    }

    public void AddForce()
    {
        if(actionType == ForceActionTypes.Force)
        {
            m_Rigidbody.AddForce(ForceDirection * ForceValue);
        }

        if (actionType == ForceActionTypes.Acceleration)
        {
            m_Rigidbody.AddForce(ForceDirection * ForceValue, ForceMode.Acceleration);
        }

        if (actionType == ForceActionTypes.Impulse)
        {
            m_Rigidbody.AddForce(ForceDirection * ForceValue, ForceMode.Impulse);
        }

        if (actionType == ForceActionTypes.VelocityChange)
        {
            m_Rigidbody.AddForce(ForceDirection * ForceValue, ForceMode.VelocityChange);
        }
    }
}