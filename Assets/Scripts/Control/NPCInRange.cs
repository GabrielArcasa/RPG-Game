using BlackCat.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlackCat.Control {
	public class NPCInRange : MonoBehaviour
	{
		private List<GameObject> ListNPC = null;
        private ControlManager controlManager = null;

        private void Start()
        {
            ListNPC = new List<GameObject>();
            controlManager = GameObject.FindObjectOfType<ControlManager>();
        }
        public List<GameObject> GetNPCInRange() 
        { 
            return ListNPC;
        }

        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.GetComponent<ActionScheduler>() == null) return;
            if (other.gameObject.tag == "Player") return;
            if (controlManager.IsDisable)
                controlManager.DisableTargetControl(other.gameObject);

           ListNPC.Add(other.gameObject);

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.GetComponent<ActionScheduler>() == null) return;
            if (other.gameObject.tag == "Player") return;

            if (ListNPC.Exists(p => p == other.gameObject))
            {
                ListNPC.Remove(other.gameObject);
            }
        }

    }
}
