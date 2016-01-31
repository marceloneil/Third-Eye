using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public void ChangeScene (string sceneToChange){
		Application.LoadLevel (sceneToChange);
	}
}
