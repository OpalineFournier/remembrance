using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopScript2 : MonoBehaviour
{
	public Button NeighborhoodTwo;
	public int index;
	void Start()
	{
		Button btn = NeighborhoodTwo.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}