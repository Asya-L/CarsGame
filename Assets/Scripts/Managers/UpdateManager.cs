using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game {

    public class UpdateManager : MonoBehaviour {

	[SerializeField]
	private ScriptableEvent _updateEvent;

	[SerializeField]
	private ScriptableEvent _fixedUpdate;

	private void Update() {
	    _updateEvent.Dispatch();
	}

	private void FixedUpdate() {
	    _fixedUpdate.Dispatch();

	}

    }
}
