using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace reinforcement_cancel_confirm
{
	public class Button : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
			gameObject.SetActive(false);
		}

		public void yes()
		{
			print("yes");
		}

		public void no()
		{
			print("no");
		}
	}
}
