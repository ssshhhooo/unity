using UnityEngine;
using System.Collections;

public class PlayerAnime : MonoBehaviour
{
	private Animator anime;

	void Start ()
	{
		anime = GetComponent<Animator>();
	}
	
	void Update ()
	{
		if (FlagManager.Instance.flags [1] == true)
		{
			anime.SetBool ("changeN", true);
			anime.SetBool ("changeS", false);
			anime.SetBool ("changeW", false);
			anime.SetBool ("changeE", false);
		}

		else if (FlagManager.Instance.flags [2] == true)
		{
			anime.SetBool ("changeN", false);
			anime.SetBool ("changeS", true);
			anime.SetBool ("changeW", false);
			anime.SetBool ("changeE", false);
		}

		else if (FlagManager.Instance.flags [3] == true)
		{
			anime.SetBool ("changeN", false);
			anime.SetBool ("changeS", false);
			anime.SetBool ("changeW", true);
			anime.SetBool ("changeE", false);
		}

		else if (FlagManager.Instance.flags [4] == true)
		{
			anime.SetBool ("changeN", false);
			anime.SetBool ("changeS", false);
			anime.SetBool ("changeW", false);
			anime.SetBool ("changeE", true);
		}
	}
}