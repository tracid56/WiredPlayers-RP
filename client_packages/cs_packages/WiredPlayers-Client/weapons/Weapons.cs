﻿using RAGE;
using RAGE.Elements;

namespace WiredPlayers_Client.weapons
{
    class Weapons : Events.Script
    {
        private Checkpoint weaponCheckpoint = null;

        public Weapons()
        {
            Events.Add("showWeaponCheckpoint", ShowWeaponCheckpointEvent);
            Events.Add("deleteWeaponCheckpoint", DeleteWeaponCheckpointEvent);
        }

        private void ShowWeaponCheckpointEvent(object[] args)
        {
            // Get the variables from the array
            Vector3 position = (Vector3)args[0];

            // Set the checkpoint with the crates
            weaponCheckpoint = new Checkpoint(0, position, 9.0f, new Vector3(0.0f, 0.0f, 0.0f), new RGBA(255, 0, 0, 70));
        }

        private void DeleteWeaponCheckpointEvent(object[] args)
        {
            // Delete the checkpoint on the map
            weaponCheckpoint.Destroy();
            weaponCheckpoint = null;
        }
    }
}
