﻿using System;
using System.Collections.Generic;
using UnityEngine;
using SDG.Unturned;
using TsunamiHack.Tsunami.Lib;
using TsunamiHack.Tsunami.Menu;
using TsunamiHack.Tsunami.Util;

// ReSharper disable EmptyGeneralCatchClause

/*namespace TsunamiHack.Tsunami.Types
{
    internal class GlowItem
    {
      
        internal GameObject GameObject;

        internal GlowItem(GameObject obj)
        {
            GameObject = obj;
        }
        
        
        public static List<GlowItem> GetListZombie(List<VisualsV2.ESPObject> inputlist)
        {
            List<GlowItem> rlist = new List<GlowItem>();

            try
            {
                foreach (var item in inputlist)
                {
                    var go = new GlowItem(item.value);
                    rlist.Add(go);
                }
            } catch (Exception){}
           

            return rlist;
        }
        
        public static List<GlowItem> GetListPlayer(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    if(item.steamID != Provider.client.m_SteamID && item.value != null)
                        rlist.Add(new GlowItem(item.value));
                    
//                    if(item.player != null && item.player != Player.player)        //legacy 
//                        rlist.Add(new GlowItem(item.player.gameObject));
                }  
            } catch(Exception) {}

            return rlist;
        }
        
        public static List<GlowItem> GetListVehicle(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListItem(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                } 
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListAnimal(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }

            } catch(Exception) {}
                       
            return rlist;
        }
        
        public static List<GlowItem> GetListStorage(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListBed(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListDoor(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListFlag(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                { 
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListSentry(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListNpc(List<VisualsV2.ESPObject> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.value));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
    }
    
    
}*/

using System;
using System.Collections.Generic;
using UnityEngine;
using SDG.Unturned;
// ReSharper disable EmptyGeneralCatchClause

namespace TsunamiHack.Tsunami.Types
{
    internal class GlowItem
    {
      
        internal GameObject GameObject;

        internal GlowItem(GameObject obj)
        {
            GameObject = obj;
        }
        
        
        public static List<GlowItem> GetListZombie(List<Zombie> inputlist)
        {
            List<GlowItem> rlist = new List<GlowItem>();

            try
            {
                foreach (var item in inputlist)
                {
                    var go = new GlowItem(item.gameObject);
                    rlist.Add(go);
                }
            } catch (Exception){}
           

            return rlist;
        }
        
        public static List<GlowItem> GetListPlayer(List<SteamPlayer> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    if(item.player != null && item.player != Player.player)
                        rlist.Add(new GlowItem(item.player.gameObject));
                }  
            } catch(Exception) {}

            return rlist;
        }
        
        public static List<GlowItem> GetListVehicle(List<InteractableVehicle> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListItem(List<InteractableItem> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                } 
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListAnimal(List<Animal> list)
        {
            var rlist = new List<GlowItem>();

            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }

            } catch(Exception) {}
                       
            return rlist;
        }
        
        public static List<GlowItem> GetListStorage(List<InteractableStorage> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListBed(List<InteractableBed> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListDoor(List<InteractableDoor> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
        
        public static List<GlowItem> GetListFlag(List<InteractableClaim> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                { 
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListSentry(List<InteractableSentry> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            
            return rlist;
        }
        
        public static List<GlowItem> GetListNpc(List<InteractableObjectNPC> list)
        {
            var rlist = new List<GlowItem>();
            try
            {
                foreach (var item in list)
                {
                    rlist.Add(new GlowItem(item.gameObject));
                }    
            } catch(Exception) {}
            

            return rlist;
        }
    }
    
    
}