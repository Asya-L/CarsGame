using System;
using System.Collections.Generic;
using UnityEngine;


namespace Events {

    public class EventListener : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public event Action OnEventHappend = delegate { };

        private void OnEnable() {

            _someEvent.AddListeners(EventHappened);

        }

	private void OnDisable() {
            _someEvent.RemoveListener(EventHappened);
	    
	}

        private void EventHappened() {

            OnEventHappend.Invoke();
        }




    }
}
