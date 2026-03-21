using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SillyScript2 : MonoBehaviour
{
    public Button HappyAcresButton;
	public int index;
	void Start()
	{
		Button btn = HappyAcresButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(index);
	}
}