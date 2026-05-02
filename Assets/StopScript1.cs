using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopScript1 : MonoBehaviour
{
	public Button NeighborhoodOne;
	public int index;
	void Start()
	{
		Button btn = NeighborhoodOne.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}