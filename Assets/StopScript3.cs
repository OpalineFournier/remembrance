using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopScript3 : MonoBehaviour
{
	public Button NeighborhoodThree;
	public int index;
	void Start()
	{
		Button btn = NeighborhoodThree.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}