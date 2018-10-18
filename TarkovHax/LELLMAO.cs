using System;
using System.Collections.Generic;
using UnityEngine;
using EFT;

namespace EvilMorty
{

    public class MortyHak : MonoBehaviour
    {

        public MortyHak()
        {
        }
        float speed;

        private GameObject GameObjectHolder;
        private IEnumerable<LootItem> _lootItems;
        private IEnumerable<Grenade> _Grenade;
        private IEnumerable<Door> _Door;
        private IEnumerable<Player> _players;
        private IEnumerable<ExfiltrationPoint> _extractPoints;
        public bool bones = false;
        public float aimFov = 0.0f;
        public bool scaven;
        public bool marineen;
        private float _maxLootDrawingDistance = 1500f;
        private float _itemNextUpdateTime;
        public bool somethingcool = false;
        public bool _showExfiljewEPS;
        public bool ruskien;
        public bool penchancee;
        public bool doorshit;
        public float r = 0;
        public float g = 0;
        public float b = 0;
        public bool grenadeboy;
        public float rs = 0;
        public float gs = 0;
        public float bs = 0;
        public float rm = 0;
        public float gm = 0;
        public float bm = 0;
        public float mcr = 1;
        public float mcg = 0;
        public float mcb = 0;
        public float cr = 0;
        public float cg = 0;
        public float cb = 0;
        public float ca = 1;
        public float dr = 1f;
        public float dg = 0.5f;
        public float db = 0.1f;
        public float da = 1f;
        public float mr = 0.8f;
        public float mg = 0.3f;
        public float mb = 0.9f;
        public float ma = 1f;
        public float penchance = 100;
        public bool meucolor = false;
        public bool l33t;
        public bool menuActive = false;
        public bool instamag = false;
        public bool crosshair = false;
        public bool norecoil = false;
        public bool aimTab = false;
        public bool aim = false;
        public bool espTab = false;
        public Transform target;
        public bool esp = false;
        public bool yeetmenu = false;
        public bool miscTab = false;
        public bool friendsTab = false;
        public bool crosscolor = false;
        private float _exfilNextUpdateTime;
        private float _espUpdateInterval = 1f;
        private float _playersNextUpdateTime;
        private float _maxDrawingDistance = 1500f;
        public Color ESPColor;
        public Color ScavBoy;
        public Color Menu;
        public Color MarineBoy;
        public Color CrossColor;
        public Color Dazzah;
        public Color Morty;
        public bool boimenu;
        public bool trueboy;

        public void Load()
        {
            GameObjectHolder = new GameObject();
            GameObjectHolder.AddComponent<MortyHak>();

            DontDestroyOnLoad(GameObjectHolder);
        }


        public void Unload()
        {
            Destroy(GameObjectHolder);
            Destroy(this);
        }

        private void LateUpdate()
        {

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.End))
            {
                Unload();
            }
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                yeetmenu = !yeetmenu;
            }

        }

        private void OnGUI()
        {
            if(aim)
            {
                //AimbotBoys();
            }
            if (l33t && Time.time >= _itemNextUpdateTime)
            {
                _lootItems = FindObjectsOfType<LootItem>();
                _itemNextUpdateTime = Time.time + _espUpdateInterval;
            }
            if (_showExfiljewEPS && Time.time >= _exfilNextUpdateTime)
            {
                _extractPoints = FindObjectsOfType<ExfiltrationPoint>();
                _exfilNextUpdateTime = Time.time + _espUpdateInterval;
            }
            if (grenadeboy && Time.time >= _playersNextUpdateTime)
            {
                _Grenade = FindObjectsOfType<Grenade>();
                _playersNextUpdateTime = Time.time + _espUpdateInterval;
            }
            if (_showExfiljewEPS)
            {
                jewExfilEPS();
            }
            if (esp && Time.time >= _playersNextUpdateTime)
            {
                _players = FindObjectsOfType<Player>();
                _playersNextUpdateTime = Time.time + _espUpdateInterval;
            }
            if(Input.GetKeyDown(KeyCode.Home))
            {
                foreach (Door door in _Door)
                {
                    Door.Destroy(door);
                }
            }
            if(boimenu)
            {
                DrawColor();
            }
            if(grenadeboy)
            {
                BulletPen();
            }
            if (yeetmenu)
            {
                DrawESPMenu();
            }
            if(bones == true)
            {
                Bones();
            }
            if(doorshit)
            {
                DoorOUnlocko();
            }
            if (crosshair)
            {
                DrawCrosshair();
            }
            if(l33t == true)
            {
                DrawValuableLoot();
            }
            if(penchancee)
            {
                PenChange();
            }
            if (esp == true)
            {
                yeetusfetus();
            }
            if (norecoil)
            {
                NoRecoil();
            }

        }

        //public void DrawESPMenu()
        //{
        //    GUI.color = Color.black;
        //    GUI.Box(new Rect(100f, 100f, 190f, 400f), "");
        //    GUI.color = Color.white;
        //    GUI.Label(new Rect(180f, 110f, 150f, 20f), "SC 1.0");
        //    _showPlayersESP = GUI.Toggle(new Rect(110f, 140f, 120f, 20f), _showPlayersESP, "  Players");
        //    _showExfiljewEPS = GUI.Toggle(new Rect(110f, 160f, 120f, 20f), _showExfiljewEPS, "  Exit ESP");
        //    _noRecoil = GUI.Toggle(new Rect(110f, 180f, 120f, 20f), _noRecoil, "  No-Recoil");
        //    _crosshair = GUI.Toggle(new Rect(110f, 200f, 120f, 20f), _crosshair, "  Crosshair");
        //    instantMagDrills = GUI.Toggle(new Rect(110f, 220f, 120f, 30f), instantMagDrills, "  Instant Mag Drills");
        //    _isConfigMenuActive = GUI.Toggle(new Rect(110f, 240f, 120f, 20f), _isConfigMenuActive, " Config Menu");
        //    _showItemESP = GUI.Toggle(new Rect(110f, 260f, 120f, 20f), _showItemESP, " Loot ESP");
        //}
        private void weaponESP()
        {
            foreach (var player in _players)
            {
                float distanceToObject = Vector3.Distance(Camera.main.transform.position, player.Transform.position);
            }
        }
        private void jewExfilEPS()
        {
            foreach (var point in _extractPoints)
            {
                if (point != null)
                {
                    float distanceToObject = Vector3.Distance(Camera.main.transform.position, point.transform.position);
                    var exfilContainerBoundingVector = new Vector3(
                        Camera.main.WorldToScreenPoint(point.transform.position).x,
                        Camera.main.WorldToScreenPoint(point.transform.position).y,
                        Camera.main.WorldToScreenPoint(point.transform.position).z);

                    if (exfilContainerBoundingVector.z > 0.01)
                    {
                        GUI.color = Color.green;
                        int distance = (int)distanceToObject;
                        String exfilName = point.name;
                        string boxText = $"{exfilName} - {distance}m";

                        GUI.Label(new Rect(exfilContainerBoundingVector.x - 50f, (float)Screen.height - exfilContainerBoundingVector.y, 100f, 50f), boxText);
                    }
                }
            }
        }

        public void DrawColor()
        {
            GUI.color = Color.red;
            GUI.Box(new Rect(1650, 0, 300, 150), "Menu Color");
            GUI.Label(new Rect(1670, 15, 100, 30), "Red:");
            mcr = GUI.HorizontalSlider(new Rect(1660, 30, 100, 30), 1, 0.0F, 1.0F);
            GUI.Label(new Rect(1670, 35, 100, 30), "Green:");
            mcg = GUI.HorizontalSlider(new Rect(1660, 50, 100, 30), mcg, 0.0F, 1.0F);
            GUI.Label(new Rect(1670, 55, 100, 30), "Blue:");
            mcb = GUI.HorizontalSlider(new Rect(1640, 70, 100, 30), mcb, 0.0F, 1.0F);
        }
        public void DrawESPMenu()
        {
            if(meucolor == false)
            {
                GUI.color = Color.red;
            }
            if (meucolor == true)
            {
                Menu.a = 1;
                Menu.r = mcr;
                Menu.g = mcg;
                Menu.b = mcb;
                GUI.color = Menu;
            }
            GUI.Box(new Rect(0, 0, 400, 60), "MortyCheats");
            if (GUI.Button(new Rect(20, 20, 80, 30), "AIM"))
            {
                aimTab = !aimTab;
            }
            if (GUI.Button(new Rect(110, 20, 80, 30), "ESP"))
            {
                espTab = !espTab;
            }
            if (GUI.Button(new Rect(200, 20, 80, 30), "MISC"))
            {
                miscTab = !miscTab;
            }
            if (GUI.Button(new Rect(290, 20, 80, 30), "COLORS"))
            {
                friendsTab = !friendsTab;
            }
            if (aimTab)
            {
                if (espTab)
                {
                    espTab = false;
                }
                if (miscTab)
                {
                    miscTab = false;
                }
                if (friendsTab)
                {
                    friendsTab = false;
                }
                GUI.Box(new Rect(0, 61, 400, 90), "AIM");
                aim = GUI.Toggle(new Rect(20, 80, 100, 30), aim, "Aimbot");
                GUI.Label(new Rect(20, 95, 100, 30), "FOV:");
                aimFov = GUI.HorizontalSlider(new Rect(55, 100, 100, 30), aimFov, 0.0F, 360.0F);
            }
            if (espTab)
            {
                if (aimTab)
                {
                    aimTab = false;
                }
                if (miscTab)
                {
                    miscTab = false;
                }
                if (friendsTab)
                {
                    friendsTab = false;
                }
                GUI.Box(new Rect(0, 61, 400, 150), "ESP");
                esp = GUI.Toggle(new Rect(20, 80, 100, 30), esp, "Esp");
                bones = GUI.Toggle(new Rect(20, 100, 100, 30), bones, "Bones");
                _showExfiljewEPS = GUI.Toggle(new Rect(20, 120, 100, 30), _showExfiljewEPS, "Exfil ESP");
                l33t = GUI.Toggle(new Rect(20, 140, 100, 30), l33t, "Loot ESP");
                grenadeboy = GUI.Toggle(new Rect(20, 160, 100, 30), grenadeboy, "Grenade ESP");

            }
            if (miscTab)
            {
                if (aimTab)
                {
                    aimTab = false;
                }
                if (espTab)
                {
                    espTab = false;
                }
                if (friendsTab)
                {
                    friendsTab = false;

                }
                GUI.Box(new Rect(0, 61, 400, 90), "Misc");
                crosshair = GUI.Toggle(new Rect(20, 80, 100, 30), crosshair, "Crosshair");
                norecoil = GUI.Toggle(new Rect(20, 100, 100, 30), norecoil, "No Recoil");
                penchancee = GUI.Toggle(new Rect(20, 120, 100, 30), penchancee, "PenChance");


            }
            if (friendsTab)
            {
                if (aimTab)
                {
                    aimTab = false;
                }
                if (espTab)
                {
                    espTab = false;
                }
                if (miscTab)
                {
                    miscTab = false;
                }
                GUI.Box(new Rect(0, 61, 400, 150), "Colors");
                meucolor = GUI.Toggle(new Rect(20, 140, 100, 30), meucolor, "Menu Color");
                ruskien = GUI.Toggle(new Rect(20, 80, 100, 30), ruskien, "Bear");
                marineen = GUI.Toggle(new Rect(20, 100, 100, 30), marineen, "Marine");
                scaven = GUI.Toggle(new Rect(20, 120, 100, 30), scaven, "Scav");
                crosscolor = GUI.Toggle(new Rect(20, 160, 100, 30), crosscolor, "Crosshair");
                if(crosscolor == true)
                {
                    GUI.Box(new Rect(0, 220, 300, 150), "Crosshair Color");
                    GUI.Label(new Rect(30, 240, 100, 30), "Red:");
                    cr = GUI.HorizontalSlider(new Rect(20, 260, 100, 30), cr, 0.0F, 1.0F);
                    GUI.Label(new Rect(30, 270, 100, 30), "Green:");
                    cg = GUI.HorizontalSlider(new Rect(20, 280, 100, 30), cg, 0.0F, 1.0F);
                    GUI.Label(new Rect(30, 290, 100, 30), "Blue:");
                    cb = GUI.HorizontalSlider(new Rect(20, 300, 100, 30), cb, 0.0F, 1.0F);
                }
                if (ruskien == true)
                {
                    GUI.Box(new Rect(410, 0, 300, 150), "Bear Color");
                    GUI.Label(new Rect(430, 15, 100, 30), "Red:");
                    r = GUI.HorizontalSlider(new Rect(420, 30, 100, 30), r, 0.0F, 1.0F);
                    GUI.Label(new Rect(430, 35, 100, 30), "Green:");
                    g = GUI.HorizontalSlider(new Rect(420, 50, 100, 30), g, 0.0F, 1.0F);
                    GUI.Label(new Rect(430, 55, 100, 30), "Blue:");
                    b = GUI.HorizontalSlider(new Rect(420, 70, 100, 30), b, 0.0F, 1.0F);
                }
                if (marineen)
                {
                    GUI.Box(new Rect(820, 0, 300, 150), "Marine Color");
                    GUI.Label(new Rect(840, 15, 100, 30), "Red:");
                    rm = GUI.HorizontalSlider(new Rect(830, 30, 100, 30), rm, 0.0F, 1.0F);
                    GUI.Label(new Rect(840, 35, 100, 30), "Green:");
                    gm = GUI.HorizontalSlider(new Rect(830, 50, 100, 30), gm, 0.0F, 1.0F);
                    GUI.Label(new Rect(840, 55, 100, 30), "Blue:");
                    bm = GUI.HorizontalSlider(new Rect(830, 70, 100, 30), bm, 0.0F, 1.0F);
                }
                if (scaven)
                {
                    GUI.Box(new Rect(1230, 0, 300, 150), "Scav Color");
                    GUI.Label(new Rect(1250, 15, 100, 30), "Red:");
                    rs = GUI.HorizontalSlider(new Rect(1240, 30, 100, 30), rs, 0.0F, 1.0F);
                    GUI.Label(new Rect(1250, 35, 100, 30), "Green:");
                    gs = GUI.HorizontalSlider(new Rect(1240, 50, 100, 30), gs, 0.0F, 1.0F);
                    GUI.Label(new Rect(1250, 55, 100, 30), "Blue:");
                    bs = GUI.HorizontalSlider(new Rect(1240, 70, 100, 30), bs, 0.0F, 1.0F);
                }
                if (meucolor == true)
                {
                    GUI.Box(new Rect(1650, 0, 300, 150), "Menu Color");
                    GUI.Label(new Rect(1670, 15, 100, 30), "Red:");
                    mcr = GUI.HorizontalSlider(new Rect(1660, 30, 100, 30), mcr, 0.0F, 1.0F);
                    GUI.Label(new Rect(1670, 35, 100, 30), "Green:");
                    mcg = GUI.HorizontalSlider(new Rect(1660, 50, 100, 30), mcg, 0.0F, 1.0F);
                    GUI.Label(new Rect(1670, 55, 100, 30), "Blue:");
                    mcb = GUI.HorizontalSlider(new Rect(1670, 70, 100, 30), mcb, 0.0F, 1.0F);
                }
            }
            // menu
            /*GUI.color = Color.red;
             GUI.Box(new Rect(0, 0, 200, 60), "MortyCheats");

             GUI.Box(new Rect(0, 61, 400, 120), "Features");
             esp = GUI.Toggle(new Rect(20, 80, 100, 30), esp, "ESP");
             GUI.Label(new Rect(20, 95, 100, 30), "FOV:");
             aimFov = GUI.HorizontalSlider(new Rect(55, 100, 100, 30), aimFov, 0.0F, 360.0F);
             GUI.Label(new Rect(20, 110, 100, 30), "Red:");
             r = GUI.HorizontalSlider(new Rect(55, 120, 100, 30), r, 0.0F, 1.0F);
             GUI.Label(new Rect(20, 130, 100, 30), "Green:");
             g = GUI.HorizontalSlider(new Rect(55, 140, 100, 30), g, 0.0F, 1.0F);
             GUI.Label(new Rect(20, 150, 100, 30), "Blue:");
             b = GUI.HorizontalSlider(new Rect(55, 160, 100, 30), b, 0.0F, 1.0F);*/
        }
        public void BulletPen()
        {
            foreach(Grenade grenade in this ._Grenade)
            {
                float distanceToObject = Vector3.Distance(Camera.main.transform.position, grenade.transform.position);
                var grenadeBoundingVector = new Vector3(
                        Camera.main.WorldToScreenPoint(grenade.transform.position).x,
                        Camera.main.WorldToScreenPoint(grenade.transform.position).y,
                        Camera.main.WorldToScreenPoint(grenade.transform.position).z);
                if (distanceToObject <= _maxDrawingDistance && grenadeBoundingVector.z > 0.01)
                {
                    ESPColor.r = r;
                    ESPColor.g = g;
                    ESPColor.b = b;
                    ESPColor.a = 1;
                    GUI.color = ESPColor;
                    //GuiHelper.DrawLine(new Vector2(playerHeadVector.x - 2f, (float)Screen.height - playerHeadVector.y), new Vector2(playerCenterMass.x + 2f, (float)Screen.height - playerCenterMass.y), espColor);
                    GuiHelper.DrawLine(new Vector2(grenadeBoundingVector.x, (float)Screen.height - grenadeBoundingVector.y - 2f), new Vector2(grenadeBoundingVector.x, (float)Screen.height - grenadeBoundingVector.y), ESPColor);
                    // GuiHelper.DrawLine(new Vector2(playerWeaponRoot.x - 2f, (float)Screen.height - playerWeaponRoot.y), new Vector2(playerWeaponRoot.x + 2f, (float)Screen.height - playerWeaponRoot.y), espColor);
                    

                }
            }
        }
        public void PenChange()
        {
            foreach (Player player in this._players)
            {
                if(player.Profile.Info.Nickname == "EvilSkies")
                {
                    player.Weapon.Template.DefAmmoTemplate.PenetrationPower = 400;
                    player.Weapon.Template.DefAmmoTemplate.PenetrationChance = 100000;
                }
                if (player.Profile.Info.Nickname == "Dazzah")
                {
                    player.Weapon.Template.DefAmmoTemplate.PenetrationPower = 400;
                    player.Weapon.Template.DefAmmoTemplate.PenetrationChance = 100000;
                }
                //if (player.isLocalPlayer || player.localPlayerAuthority)
                //{
                //}
            }
        }
      /* public Vector3 GetTargetPosition(Vector3 origin, Vector3 target, Vector3 targetVelocity)
        {
            foreach (Player player in this._players)
            {
                Vector3 lookPos = target - origin;
                float scale = lookPos.magnitude / player.Weapon.VelocityDelta;

                Vector3 normalized = lookPos.normalized;
                Vector3 aimVector = Vector3.zero;
                Vector3 tmp = Vector3.zero;

                Vector3 b = player.Weapon.Template.DefAmmoTemplate.InitialSpeed * Mathf.Pow(scale, 2f) / 2f;
                tmp = lookPos - b;
                scale = scale / Vector3.Dot(tmp.normalized, normalized);
                aimVector = targetVelocity * scale - Player.activeWeapon.projectileGravity * Mathf.Pow(scale, 2f) / 2f;
                return aimVector;
            }
        }*/
        public void NoRecoil()
        {
            foreach (Player player in this._players)
            {
                //if (player.isLocalPlayer || player.localPlayerAuthority)
                //{
                    player.ProceduralWeaponAnimation.Shootingg.RecoilDegree = new Vector2(0f, 0f);
                    player.ProceduralWeaponAnimation.Shootingg.Intensity = 0f;
                    player.ProceduralWeaponAnimation.Shootingg.RecoilStrengthXY = new Vector2(0f, 0f);
                    player.ProceduralWeaponAnimation.Shootingg.RecoilStrengthZ = new Vector2(0f, 0f);
                //}
            }
        }
        public void DoorOUnlocko()
        {

        }
        public void DrawCrosshair()
        {
            CrossColor.r = cr;
            CrossColor.g = cg;
            CrossColor.b = cb;
            CrossColor.a = ca;
            GuiHelper.DrawBox((float)Screen.width / 2f, (float)Screen.height / 2f - 5f, 1f, 11f, CrossColor);
            GuiHelper.DrawBox((float)Screen.width / 2f - 5f, (float)Screen.height / 2f, 11f, 1f, CrossColor);
        }

        public void DrawValuableLoot()
        {
            foreach (LootItem lootItem in _lootItems)
            {
                if (lootItem == null)
                {
                    break;
                }
                if (lootItem.name == null)
                {
                    break;
                }
                if (lootItem.name == string.Empty)
                {
                    break;
                }
                if (lootItem.name.Contains("powder") || lootItem.name.Contains("grizzly") || lootItem.name.Contains("morphine") || lootItem.name.Contains("Case") || lootItem.name.Contains("roler") || lootItem.name.Contains("key") || lootItem.name.Contains("dorm") || lootItem.name.Contains("watch") || lootItem.name.Contains("lion") || lootItem.name.Contains("cat") || lootItem.name.Contains("gas") || lootItem.name.Contains("bitcoin") || lootItem.name.Contains("video") || lootItem.name.Contains("item_chain_gold") || lootItem.name.Contains("cpu") || lootItem.name.Contains("gphone") || lootItem.name.Contains("supressor") || lootItem.name.Contains("gmcount") || lootItem.name.Contains("gm") || lootItem.name.Contains("weapon_remington_r11_rsass") || lootItem.name.Contains("weapon_colt_m4a1_556x45") || lootItem.name.Contains("salewa") || lootItem.name.Contains("sv98") || lootItem.name.Contains("sv-98") || lootItem.name.Contains("scope") || lootItem.name.Contains("sight") || lootItem.name.Contains("DVL") || lootItem.name.Contains("card") || lootItem.name.Contains("ak-"))
                {
                    float num = Vector3.Distance(Camera.main.transform.position, lootItem.transform.position);
                    Vector3 vector = new Vector3(Camera.main.WorldToScreenPoint(lootItem.transform.position).x, Camera.main.WorldToScreenPoint(lootItem.transform.position).y, Camera.main.WorldToScreenPoint(lootItem.transform.position).z);
                    if (num <= _maxLootDrawingDistance && (double)vector.z > 0.01)
                    {
                        GUI.color = Color.cyan;
                        int num2 = (int)num;
                        string name = lootItem.name;
                        string text = string.Format("{0}", name);
                        GUI.Label(new Rect(vector.x - 50f, (float)Screen.height - vector.y, 100f, 50f), text);
                    }
                }
            }
        }
        private void IncreaseFov()
        {
            Camera.main.fieldOfView += aimFov;
        }
        private void Bones()
        {
            foreach (var player in _players)
            {
                float distanceToObject = Vector3.Distance(Camera.main.transform.position, player.Transform.position);
                var playerBoundingVector = new Vector3(
                    Camera.main.WorldToScreenPoint(player.Transform.position).x,
                    Camera.main.WorldToScreenPoint(player.Transform.position).y,
                    Camera.main.WorldToScreenPoint(player.Transform.position).z);
                if(distanceToObject <= _maxDrawingDistance && playerBoundingVector.z > 0.01)
                {
                    var playerNeckVector = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Neck.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Neck.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Neck.position).z);
                    var playerWeaponRoot = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).z
                        );
                    var playerRFoot = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.KickingFoot.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.KickingFoot.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.KickingFoot.position).z
                        );
                    var playerLPalm = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftPalm.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftPalm.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftPalm.position).z
                        );
                    var playerRPalm = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightPalm.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightPalm.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightPalm.position).z
                        );
                    var playerRThigh = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightThigh2.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightThigh2.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightThigh2.position).z);
                    var playerLThigh = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftThigh2.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftThigh2.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftThigh2.position).z
                        );
                    var playerCenterMass = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Ribcage.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Ribcage.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Ribcage.position).z
                        );
                    var playerHeadVector = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).z);
                    var playerLShoulder = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.LeftShoulder.position).z);
                    var playerRShoulder = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightShoulder.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightShoulder.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.RightShoulder.position).z);
                    
                    float bXOffset = Camera.main.WorldToScreenPoint(player.Transform.position).x;
                    float bYOffset = Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y + 10f;
                    float boxHeight = Math.Abs(Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y - Camera.main.WorldToScreenPoint(player.Transform.position).y) + 10f;
                    float boxWidth = boxHeight * 0.65f;

                    var playerColor = GetPlayerColor(player.Side);
                    var isAi = player.Profile.Info.RegistrationDate <= 0;
                    var espColor = player.Profile.Health.IsAlive ? playerColor : Color.gray;
                    GUI.color = espColor;
                    //GuiHelper.DrawLine(new Vector2(playerHeadVector.x - 2f, (float)Screen.height - playerHeadVector.y), new Vector2(playerCenterMass.x + 2f, (float)Screen.height - playerCenterMass.y), espColor);
                    GuiHelper.DrawLine(new Vector2(playerHeadVector.x, (float)Screen.height - playerHeadVector.y - 2f), new Vector2(playerCenterMass.x, (float)Screen.height - playerCenterMass.y), espColor);
                   // GuiHelper.DrawLine(new Vector2(playerWeaponRoot.x - 2f, (float)Screen.height - playerWeaponRoot.y), new Vector2(playerWeaponRoot.x + 2f, (float)Screen.height - playerWeaponRoot.y), espColor);
                    GuiHelper.DrawLine(new Vector2(playerLPalm.x, (float)Screen.height - playerLPalm.y - 2f), new Vector2(playerLShoulder.x, (float)Screen.height - playerLPalm.y + 2f), espColor);
                    GuiHelper.DrawLine(new Vector2(playerRPalm.x, (float)Screen.height - playerRPalm.y - 2f), new Vector2(playerRShoulder.x, (float)Screen.height - playerRShoulder.y + 2f), espColor);
                    GuiHelper.DrawLine(new Vector2(playerLShoulder.x, (float)Screen.height - playerLShoulder.y - 2f), new Vector2(playerRShoulder.x, (float)Screen.height - playerRShoulder.y + 2f), espColor);
                    GuiHelper.DrawLine(new Vector2(playerRThigh.x, (float)Screen.height - playerRThigh.y - 6f), new Vector2(playerCenterMass.x, (float)Screen.height - playerCenterMass.y + 30f), espColor);
                    GuiHelper.DrawLine(new Vector2(playerLThigh.x, (float)Screen.height - playerLThigh.y - 6f), new Vector2(playerCenterMass.x, (float)Screen.height - playerCenterMass.y  + 30f), espColor);

                }
            }
        }
        /*private void AimbotBoys()
        {

            Vector3 position = transform.position;
            float distanceToClosestEnemy = Mathf.Infinity;
            EFT.Player closestEnemy = null;
            foreach(var player in _players)
            {
                var playerBoundingVector = new Vector3(
                    Camera.main.WorldToScreenPoint(player.Transform.position).x,
                    Camera.main.WorldToScreenPoint(player.Transform.position).y,
                    Camera.main.WorldToScreenPoint(player.Transform.position).z);
                float distanceToEnemy = (playerBoundingVector - Camera.main.transform.position).sqrMagnitude;
                if(distanceToEnemy < distanceToClosestEnemy)
                {
                    distanceToClosestEnemy = distanceToEnemy;
                    closestEnemy = player;
                }
                player.transform.rotation = Quaternion.LookRotation(closestEnemy.Position);
            }

        }*/
        void OnDrawGizmos()
        {
            drawbone(transform);
        }

        void drawbone(Transform t)
        {
            //renderer.SetWidth(5.0, 2.0);
            foreach (Transform child in t)
            {
                float len = 0.05f;
                Vector3 loxalX = new Vector3(len, 0, 0);
                Vector3 loxalY = new Vector3(0, len, 0);
                Vector3 loxalZ = new Vector3(0, 0, len);
                loxalX = child.rotation * loxalX;
                loxalY = child.rotation * loxalY;
                loxalZ = child.rotation * loxalZ;

                Gizmos.DrawLine(t.position * 0.1f + child.position * 0.9f, t.position * 0.9f + child.position * 0.1f);

                Gizmos.DrawLine(child.position, child.position + loxalX);
                Gizmos.DrawLine(child.position, child.position + loxalY);
                Gizmos.DrawLine(child.position, child.position + loxalZ);
                drawbone(child);
            }
            //LineRenderer.SetWidth(1.0, 1.0);
        }
        private void yeetusfetus()
        {
            foreach (var player in _players)
            {
                float distanceToObject = Vector3.Distance(Camera.main.transform.position, player.Transform.position);
                var playerBoundingVector = new Vector3(
                    Camera.main.WorldToScreenPoint(player.Transform.position).x,
                    Camera.main.WorldToScreenPoint(player.Transform.position).y,
                    Camera.main.WorldToScreenPoint(player.Transform.position).z);

                if (distanceToObject <= _maxDrawingDistance && playerBoundingVector.z > 0.01)
                {
                    var playerHeadVector = new Vector3(
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).x,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y,
                        Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).z);

                    float boxXOffset = Camera.main.WorldToScreenPoint(player.Transform.position).x;
                    float boxYOffset = Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y + 10f;
                    float boxHeight = Math.Abs(Camera.main.WorldToScreenPoint(player.PlayerBones.Head.position).y - Camera.main.WorldToScreenPoint(player.Transform.position).y) + 10f;
                    float boxWidth = boxHeight * 0.65f;

                    var playerColor = GetPlayerColor(player.Side);
                    var isAi = player.Profile.Info.RegistrationDate <= 0;
                    var espColor = player.Profile.Health.IsAlive ? playerColor : Color.gray;

                    GUI.color = espColor;
                    GuiHelper.DrawBox(boxXOffset - boxWidth / 2f, (float)Screen.height - boxYOffset, boxWidth, boxHeight, espColor);
                    GuiHelper.DrawLine(new Vector2(playerHeadVector.x - 2f, (float)Screen.height - playerHeadVector.y), new Vector2(playerHeadVector.x + 2f, (float)Screen.height - playerHeadVector.y), espColor);
                    GuiHelper.DrawLine(new Vector2(playerHeadVector.x, (float)Screen.height - playerHeadVector.y - 2f), new Vector2(playerHeadVector.x, (float)Screen.height - playerHeadVector.y + 2f), espColor);
                    if(player.Profile.Info.Nickname == "Dazzah")
                    {
                        Dazzah.r = dr;
                        Dazzah.g = dg;
                        Dazzah.b = db;
                        Dazzah.a = da;
                        GuiHelper.DrawLine(new Vector2(playerHeadVector.x - 10f, (float)Screen.height - playerHeadVector.y), new Vector2(playerHeadVector.x + 10f, (float)Screen.height - playerHeadVector.y), Dazzah);

                    }
                    if (player.Profile.Info.Nickname == "EvilSkies")
                    {
                        Morty.r = mr;
                        Morty.g = mg;
                        Morty.b = mb;
                        Morty.a = ma;
                        GuiHelper.DrawLine(new Vector2(playerHeadVector.x - 10f, (float)Screen.height - playerHeadVector.y), new Vector2(playerHeadVector.x + 10f, (float)Screen.height - playerHeadVector.y), Morty);

                    }
                    var playerName = isAi ? "AI" : player.Profile.Info.Nickname;
                    float playerHealth = player.HealthController.SummaryHealth.CurrentValue / 435f * 100f;
                    string playerDisplayName = player.Profile.Health.IsAlive ? playerName : playerName + " (DEAD)";
                    string playerText = $"[{(int)playerHealth}%] {playerDisplayName} [{(int)distanceToObject}m]";

                    var playerTextVector = GUI.skin.GetStyle(playerText).CalcSize(new GUIContent(playerText));
                    GUI.Label(new Rect(playerBoundingVector.x - playerTextVector.x / 2f, (float)Screen.height - boxYOffset - 20f, 300f, 50f), playerText);
                }
            }
        }
        private Color GetPlayerColor(EPlayerSide side)
        {
            ESPColor.r = r;
            ESPColor.g = g;
            ESPColor.b = b;
            ESPColor.a = 1;
            MarineBoy.r = rm;
            MarineBoy.g = gm;
            MarineBoy.b = bm;
            MarineBoy.a = 1;
            ScavBoy.r = rs;
            ScavBoy.g = gs;
            ScavBoy.b = bs;
            ScavBoy.a = 1;
            switch (side)
            {
                case EPlayerSide.Bear:
                    return ESPColor;
                case EPlayerSide.Usec:
                    return MarineBoy;
                case EPlayerSide.Savage:
                    return ScavBoy;
                default:
                    return ScavBoy;
            }
        }
        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
        }
    }
}
