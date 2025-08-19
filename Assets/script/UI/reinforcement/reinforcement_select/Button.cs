using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace reinforcement_select
{
	public class Button : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
			gameObject.SetActive(false);
		}

		public void reinforcement()
		{
			print("reinforcement");
		}

		public void cancel()
		{
			print("cancel");
		}
	}
}
