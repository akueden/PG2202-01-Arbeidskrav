using UnityEngine;
public class VelocityScript : MonoBehaviour
{
    //setter startfart på objektet
    public float startSpeed = 5f;
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(startSpeed, 0, startSpeed), ForceMode.Impulse);

        //orginal fra pp: rigidbody.linearVelocity = new Vector3(startSpeed, 0, startSpeed);
    }
}