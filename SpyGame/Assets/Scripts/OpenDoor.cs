using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;

	private Vector3 defaultRot;
	private Vector3 openRot;
	private bool open;
	void Start()
	{
		defaultRot = transform.eulerAngles;
		openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
	}

	void Update()
	{
		if (open)
		{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
		}
		else
		{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			open = true;
		}
	}
}
