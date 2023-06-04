﻿using Model.Physics;
using UnityEngine;

namespace Sources.View
{
	public class CollisionBroadcaster : MonoBehaviour
	{
		private ICollidable _model;

		public void Initialize(ICollidable model)
		{
			_model = model;
		}

		private void OnCollisionEnter(Collision other)
		{
			_model.OnCollisionEnter(other);	
		}

		private void OnCollisionStay(Collision other)
		{
			_model.OnCollisionStay(other);
		}

		private void OnCollisionExit(Collision other)
		{
			_model.OnCollisionExit(other);
		}
	}
}