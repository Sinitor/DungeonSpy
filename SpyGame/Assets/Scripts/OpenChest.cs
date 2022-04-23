using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
	public float smooth = 2.0f;
	public float ChestOpenAngle = 90.0f; 

	public Image winImage; 

	private Vector3 defaultRot;
	private Vector3 openRot;
	private bool open;
	void Start()
	{
		defaultRot = transform.eulerAngles;
		openRot = new Vector3(defaultRot.x, defaultRot.y, defaultRot.z + ChestOpenAngle);
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
			winImage.gameObject.SetActive(true);
		}
	}
}
