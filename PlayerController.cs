using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	private Inputhandler _inputhandler;
	public bool useable = false;
	public bool usemask = false;
	
	 Windows open;
	Score score;
	public GameObject item ;
	public GameObject mask;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		_inputhandler = new Inputhandler();
		
	}
	
	
	public void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "useable" )
		{
			item = other.gameObject;
			//item.GetComponent<Windows>().open = true;
			//	Debug.Log(item);
			useable = true;

		}else if (other.gameObject.tag =="mask")
		{
			mask = other.gameObject;
			usemask = true;
			
		}
		else
		{
			usemask = false;
			useable = false;
		}
		
	}
	public void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "useable" )
		{
			
			useable = false;

		}else if (other.gameObject.tag =="mask")
		{
			
			usemask = false;
			
		}
		
		
	}
	void Update()
	{
		
		if (useable == true && item.GetComponent<Windows>().open == false)
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					//Debug.Log("je gebruikt iets");
					item.GetComponent<Windows>().open = true;
					//Windows.open = true;
					Score.score++;
					Debug.Log(Score.score);
				}
			}
			else if (useable == true && item.GetComponent<Windows>().open == true)
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					//Debug.Log("je gebruikt iets");
					item.GetComponent<Windows>().open = false;
					//Windows.open = false;
					Score.score--;
					Debug.Log(Score.score);
				}
			}
			else if (usemask == true && mask.tag =="mask")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				mask.active = false;
				Debug.Log("doe iets");
			}
			
		}
		}
	

	
		
	

	
}
