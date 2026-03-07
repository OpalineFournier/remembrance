using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SillyScript3 : MonoBehaviour
{
	public Button VampireVillageButton;
	public int index;
	void Start()
	{
		Button btn = VampireVillageButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}