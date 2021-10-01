﻿using MMR.Randomizer.Models.Settings;
using System;
using System.Drawing;
using System.Linq;

namespace MMR.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bopen = new System.Windows.Forms.Button();
            this.openROM = new System.Windows.Forms.OpenFileDialog();
            this.openLogic = new System.Windows.Forms.OpenFileDialog();
            this.loadSettings = new System.Windows.Forms.OpenFileDialog();
            this.saveSettings = new System.Windows.Forms.SaveFileDialog();
            this.tROMName = new System.Windows.Forms.TextBox();
            this.tSettings = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tOtherCustomizations = new System.Windows.Forms.TabControl();
            this.tOtherCustomization = new System.Windows.Forms.TabPage();
            this.cStartingItems = new System.Windows.Forms.ComboBox();
            this.lStartingItems = new System.Windows.Forms.Label();
            this.cProgressiveUpgrades = new System.Windows.Forms.CheckBox();
            this.cDEnt = new System.Windows.Forms.CheckBox();
            this.cMixSongs = new System.Windows.Forms.CheckBox();
            this.cEnemy = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.bToggleTricks = new System.Windows.Forms.Button();
            this.cMode = new System.Windows.Forms.ComboBox();
            this.bLoadLogic = new System.Windows.Forms.Button();
            this.lMode = new System.Windows.Forms.Label();
            this.tbUserLogic = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tJunkLocationsList = new System.Windows.Forms.TextBox();
            this.bJunkLocationsEditor = new System.Windows.Forms.Button();
            this.lJunkLocationsAmount = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tStartingItemList = new System.Windows.Forms.TextBox();
            this.lCustomStartingItemAmount = new System.Windows.Forms.Label();
            this.bStartingItemEditor = new System.Windows.Forms.Button();
            this.tabItemPool = new System.Windows.Forms.TabPage();
            this.lItemPoolText = new System.Windows.Forms.Label();
            this.bItemPoolEdit = new System.Windows.Forms.Button();
            this.tItemPool = new System.Windows.Forms.TextBox();
            this.tableItemPool = new System.Windows.Forms.TableLayoutPanel();
            this.tabGimmicks = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cFDAnywhere = new System.Windows.Forms.CheckBox();
            this.cBlastCooldown = new System.Windows.Forms.ComboBox();
            this.cUnderwaterOcarina = new System.Windows.Forms.CheckBox();
            this.cSunsSong = new System.Windows.Forms.CheckBox();
            this.lBlastMask = new System.Windows.Forms.Label();
            this.lNutAndStickDrops = new System.Windows.Forms.Label();
            this.cNutAndStickDrops = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cDType = new System.Windows.Forms.ComboBox();
            this.lDType = new System.Windows.Forms.Label();
            this.cDeathMoonCrash = new System.Windows.Forms.CheckBox();
            this.cByoAmmo = new System.Windows.Forms.CheckBox();
            this.cDMult = new System.Windows.Forms.ComboBox();
            this.lDMult = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cFloors = new System.Windows.Forms.ComboBox();
            this.lFloors = new System.Windows.Forms.Label();
            this.lGravity = new System.Windows.Forms.Label();
            this.cGravity = new System.Windows.Forms.ComboBox();
            this.cContinuousDekuHopping = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lIceTraps = new System.Windows.Forms.Label();
            this.cIceTraps = new System.Windows.Forms.ComboBox();
            this.cIceTrapsAppearance = new System.Windows.Forms.ComboBox();
            this.cIceTrapQuirks = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cClockSpeed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cHideClock = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabComfort = new System.Windows.Forms.TabPage();
            this.gSpeedUps = new System.Windows.Forms.GroupBox();
            this.cFasterBank = new System.Windows.Forms.CheckBox();
            this.cSkipBeaver = new System.Windows.Forms.CheckBox();
            this.cFasterLabFish = new System.Windows.Forms.CheckBox();
            this.cGoodDogRaceRNG = new System.Windows.Forms.CheckBox();
            this.cGoodDampeRNG = new System.Windows.Forms.CheckBox();
            this.gHints = new System.Windows.Forms.GroupBox();
            this.lGossip = new System.Windows.Forms.Label();
            this.cGossipHints = new System.Windows.Forms.ComboBox();
            this.cFreeHints = new System.Windows.Forms.CheckBox();
            this.cClearHints = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lLink = new System.Windows.Forms.Label();
            this.cLink = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cImprovedPictobox = new System.Windows.Forms.CheckBox();
            this.cElegySpeedups = new System.Windows.Forms.CheckBox();
            this.cCloseCows = new System.Windows.Forms.CheckBox();
            this.cArrowCycling = new System.Windows.Forms.CheckBox();
            this.cFreestanding = new System.Windows.Forms.CheckBox();
            this.cFastPush = new System.Windows.Forms.CheckBox();
            this.cQText = new System.Windows.Forms.CheckBox();
            this.cShopAppearance = new System.Windows.Forms.CheckBox();
            this.cEponaSword = new System.Windows.Forms.CheckBox();
            this.cUpdateChests = new System.Windows.Forms.CheckBox();
            this.cDisableCritWiggle = new System.Windows.Forms.CheckBox();
            this.cQuestItemStorage = new System.Windows.Forms.CheckBox();
            this.cNoDowngrades = new System.Windows.Forms.CheckBox();
            this.tabShortenCutscenes = new System.Windows.Forms.TabPage();
            this.tShortenCutscenes = new System.Windows.Forms.TabControl();
            this.tabCosmetics = new System.Windows.Forms.TabPage();
            this.gCosmeticOther = new System.Windows.Forms.GroupBox();
            this.cInstantPictobox = new System.Windows.Forms.CheckBox();
            this.cTatl = new System.Windows.Forms.ComboBox();
            this.lTatl = new System.Windows.Forms.Label();
            this.cTargettingStyle = new System.Windows.Forms.CheckBox();
            this.gCosmeticMusicSound = new System.Windows.Forms.GroupBox();
            this.lMusic = new System.Windows.Forms.Label();
            this.cMusic = new System.Windows.Forms.ComboBox();
            this.cSFX = new System.Windows.Forms.CheckBox();
            this.cCombatMusicDisable = new System.Windows.Forms.CheckBox();
            this.cEnableNightMusic = new System.Windows.Forms.CheckBox();
            this.cLowHealthSFXComboBox = new System.Windows.Forms.ComboBox();
            this.lLowHealthSFXComboBox = new System.Windows.Forms.Label();
            this.cHUDGroupBox = new System.Windows.Forms.GroupBox();
            this.cHueShiftMiscUI = new System.Windows.Forms.CheckBox();
            this.cHUDTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cHUDHeartsComboBox = new System.Windows.Forms.ComboBox();
            this.cHeartsLabel = new System.Windows.Forms.Label();
            this.cMagicLabel = new System.Windows.Forms.Label();
            this.cHUDMagicComboBox = new System.Windows.Forms.ComboBox();
            this.btn_hud = new System.Windows.Forms.Button();
            this.tFormCosmetics = new System.Windows.Forms.TabControl();
            this.cDrawHash = new System.Windows.Forms.CheckBox();
            this.gGameOutput = new System.Windows.Forms.GroupBox();
            this.cHTMLLog = new System.Windows.Forms.CheckBox();
            this.cPatch = new System.Windows.Forms.CheckBox();
            this.cSpoiler = new System.Windows.Forms.CheckBox();
            this.cN64 = new System.Windows.Forms.CheckBox();
            this.cVC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bApplyPatch = new System.Windows.Forms.Button();
            this.saveROM = new System.Windows.Forms.SaveFileDialog();
            this.cEnergy = new System.Windows.Forms.ColorDialog();
            this.cTunic = new System.Windows.Forms.ColorDialog();
            this.bRandomise = new System.Windows.Forms.Button();
            this.saveWad = new System.Windows.Forms.SaveFileDialog();
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mCustomise = new System.Windows.Forms.ToolStripMenuItem();
            this.mDPadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLogicEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openBROM = new System.Windows.Forms.OpenFileDialog();
            this.pProgress = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lStatus = new System.Windows.Forms.Label();
            this.tSeed = new System.Windows.Forms.TextBox();
            this.lSeed = new System.Windows.Forms.Label();
            this.cDummy = new System.Windows.Forms.CheckBox();
            this.openPatch = new System.Windows.Forms.OpenFileDialog();
            this.ttOutput = new System.Windows.Forms.TabControl();
            this.tpOutputSettings = new System.Windows.Forms.TabPage();
            this.tpPatchSettings = new System.Windows.Forms.TabPage();
            this.tPatch = new System.Windows.Forms.TextBox();
            this.bLoadPatch = new System.Windows.Forms.Button();
            this.tSettings.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tOtherCustomizations.SuspendLayout();
            this.tOtherCustomization.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabItemPool.SuspendLayout();
            this.tabGimmicks.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabComfort.SuspendLayout();
            this.gSpeedUps.SuspendLayout();
            this.gHints.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabShortenCutscenes.SuspendLayout();
            this.tabCosmetics.SuspendLayout();
            this.gCosmeticOther.SuspendLayout();
            this.gCosmeticMusicSound.SuspendLayout();
            this.cHUDGroupBox.SuspendLayout();
            this.cHUDTableLayoutPanel.SuspendLayout();
            this.gGameOutput.SuspendLayout();
            this.mMenu.SuspendLayout();
            this.ttOutput.SuspendLayout();
            this.tpOutputSettings.SuspendLayout();
            this.tpPatchSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // bopen
            // 
            this.bopen.Location = new System.Drawing.Point(16, 579);
            this.bopen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bopen.Name = "bopen";
            this.bopen.Size = new System.Drawing.Size(128, 41);
            this.bopen.TabIndex = 0;
            this.bopen.Text = "Open ROM";
            this.bopen.UseVisualStyleBackColor = true;
            this.bopen.Click += new System.EventHandler(this.bopen_Click);
            // 
            // openROM
            // 
            this.openROM.Filter = "ROM files|*.z64";
            // 
            // openLogic
            // 
            this.openLogic.Filter = "Logic File|*.txt";
            // 
            // tROMName
            // 
            this.tROMName.Location = new System.Drawing.Point(158, 584);
            this.tROMName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tROMName.Name = "tROMName";
            this.tROMName.ReadOnly = true;
            this.tROMName.Size = new System.Drawing.Size(730, 27);
            this.tROMName.TabIndex = 1;
            // 
            // tSettings
            // 
            this.tSettings.Controls.Add(this.tabMain);
            this.tSettings.Controls.Add(this.tabItemPool);
            this.tSettings.Controls.Add(this.tabGimmicks);
            this.tSettings.Controls.Add(this.tabComfort);
            this.tSettings.Controls.Add(this.tabShortenCutscenes);
            this.tSettings.Controls.Add(this.tabCosmetics);
            this.tSettings.Location = new System.Drawing.Point(5, 37);
            this.tSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tSettings.Name = "tSettings";
            this.tSettings.SelectedIndex = 0;
            this.tSettings.Size = new System.Drawing.Size(901, 519);
            this.tSettings.TabIndex = 10;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tOtherCustomizations);
            this.tabMain.Controls.Add(this.groupBox9);
            this.tabMain.Controls.Add(this.groupBox6);
            this.tabMain.Controls.Add(this.groupBox4);
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabMain.Size = new System.Drawing.Size(893, 486);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main Settings";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tOtherCustomizations
            // 
            this.tOtherCustomizations.Controls.Add(this.tOtherCustomization);
            this.tOtherCustomizations.Location = new System.Drawing.Point(8, 148);
            this.tOtherCustomizations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tOtherCustomizations.Name = "tOtherCustomizations";
            this.tOtherCustomizations.SelectedIndex = 0;
            this.tOtherCustomizations.Size = new System.Drawing.Size(435, 213);
            this.tOtherCustomizations.TabIndex = 22;
            // 
            // tOtherCustomization
            // 
            this.tOtherCustomization.Controls.Add(this.cStartingItems);
            this.tOtherCustomization.Controls.Add(this.lStartingItems);
            this.tOtherCustomization.Controls.Add(this.cProgressiveUpgrades);
            this.tOtherCustomization.Controls.Add(this.cDEnt);
            this.tOtherCustomization.Controls.Add(this.cMixSongs);
            this.tOtherCustomization.Controls.Add(this.cEnemy);
            this.tOtherCustomization.Location = new System.Drawing.Point(4, 29);
            this.tOtherCustomization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tOtherCustomization.Name = "tOtherCustomization";
            this.tOtherCustomization.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tOtherCustomization.Size = new System.Drawing.Size(427, 180);
            this.tOtherCustomization.TabIndex = 0;
            this.tOtherCustomization.Text = "Other";
            this.tOtherCustomization.UseVisualStyleBackColor = true;
            // 
            // cStartingItems
            // 
            this.cStartingItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cStartingItems.FormattingEnabled = true;
            this.cStartingItems.Items.AddRange(new object[] {
            "None",
            "Random",
            "Allow Temporary Items"});
            this.cStartingItems.Location = new System.Drawing.Point(7, 95);
            this.cStartingItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cStartingItems.Name = "cStartingItems";
            this.cStartingItems.Size = new System.Drawing.Size(182, 28);
            this.cStartingItems.TabIndex = 27;
            this.cStartingItems.SelectedIndexChanged += new System.EventHandler(this.cStartingItems_SelectedIndexChanged);
            // 
            // lStartingItems
            // 
            this.lStartingItems.AutoSize = true;
            this.lStartingItems.Location = new System.Drawing.Point(7, 75);
            this.lStartingItems.Name = "lStartingItems";
            this.lStartingItems.Size = new System.Drawing.Size(101, 20);
            this.lStartingItems.TabIndex = 22;
            this.lStartingItems.Text = "Starting Items";
            // 
            // cProgressiveUpgrades
            // 
            this.cProgressiveUpgrades.AutoSize = true;
            this.cProgressiveUpgrades.BackColor = System.Drawing.Color.Transparent;
            this.cProgressiveUpgrades.ForeColor = System.Drawing.Color.Black;
            this.cProgressiveUpgrades.Location = new System.Drawing.Point(221, 13);
            this.cProgressiveUpgrades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cProgressiveUpgrades.Name = "cProgressiveUpgrades";
            this.cProgressiveUpgrades.Size = new System.Drawing.Size(174, 24);
            this.cProgressiveUpgrades.TabIndex = 21;
            this.cProgressiveUpgrades.Text = "Progressive Upgrades";
            this.cProgressiveUpgrades.UseVisualStyleBackColor = false;
            this.cProgressiveUpgrades.CheckedChanged += new System.EventHandler(this.cProgressiveUpgrades_CheckedChanged);
            // 
            // cDEnt
            // 
            this.cDEnt.AutoSize = true;
            this.cDEnt.BackColor = System.Drawing.Color.Transparent;
            this.cDEnt.ForeColor = System.Drawing.Color.Black;
            this.cDEnt.Location = new System.Drawing.Point(7, 13);
            this.cDEnt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDEnt.Name = "cDEnt";
            this.cDEnt.Size = new System.Drawing.Size(159, 24);
            this.cDEnt.TabIndex = 7;
            this.cDEnt.Text = "Dungeon entrances";
            this.cDEnt.UseVisualStyleBackColor = false;
            this.cDEnt.CheckedChanged += new System.EventHandler(this.cDEnt_CheckedChanged);
            // 
            // cMixSongs
            // 
            this.cMixSongs.AutoSize = true;
            this.cMixSongs.BackColor = System.Drawing.Color.Transparent;
            this.cMixSongs.ForeColor = System.Drawing.Color.Black;
            this.cMixSongs.Location = new System.Drawing.Point(7, 48);
            this.cMixSongs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cMixSongs.Name = "cMixSongs";
            this.cMixSongs.Size = new System.Drawing.Size(169, 24);
            this.cMixSongs.TabIndex = 3;
            this.cMixSongs.Text = "Mix songs with items";
            this.cMixSongs.UseVisualStyleBackColor = false;
            this.cMixSongs.CheckedChanged += new System.EventHandler(this.cMixSongs_CheckedChanged);
            // 
            // cEnemy
            // 
            this.cEnemy.AutoSize = true;
            this.cEnemy.BackColor = System.Drawing.Color.Transparent;
            this.cEnemy.ForeColor = System.Drawing.Color.Black;
            this.cEnemy.Location = new System.Drawing.Point(221, 48);
            this.cEnemy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cEnemy.Name = "cEnemy";
            this.cEnemy.Size = new System.Drawing.Size(138, 24);
            this.cEnemy.TabIndex = 9;
            this.cEnemy.Text = "Enemies (BETA!)";
            this.cEnemy.UseVisualStyleBackColor = false;
            this.cEnemy.CheckedChanged += new System.EventHandler(this.cEnemy_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bToggleTricks);
            this.groupBox9.Controls.Add(this.cMode);
            this.groupBox9.Controls.Add(this.bLoadLogic);
            this.groupBox9.Controls.Add(this.lMode);
            this.groupBox9.Controls.Add(this.tbUserLogic);
            this.groupBox9.Location = new System.Drawing.Point(8, 9);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox9.Size = new System.Drawing.Size(433, 131);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Generation Settings";
            // 
            // bToggleTricks
            // 
            this.bToggleTricks.Location = new System.Drawing.Point(310, 31);
            this.bToggleTricks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bToggleTricks.Name = "bToggleTricks";
            this.bToggleTricks.Size = new System.Drawing.Size(110, 36);
            this.bToggleTricks.TabIndex = 19;
            this.bToggleTricks.Text = "Toggle Tricks";
            this.bToggleTricks.UseVisualStyleBackColor = true;
            this.bToggleTricks.Click += new System.EventHandler(this.bToggleTricks_Click);
            // 
            // cMode
            // 
            this.cMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMode.FormattingEnabled = true;
            this.cMode.Items.AddRange(new object[] {
            "Casual",
            "Glitched",
            "Vanilla Layout",
            "User Logic",
            "No Logic"});
            this.cMode.Location = new System.Drawing.Point(110, 32);
            this.cMode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cMode.Name = "cMode";
            this.cMode.Size = new System.Drawing.Size(190, 28);
            this.cMode.TabIndex = 1;
            this.cMode.SelectedIndexChanged += new System.EventHandler(this.cMode_SelectedIndexChanged);
            // 
            // bLoadLogic
            // 
            this.bLoadLogic.Location = new System.Drawing.Point(15, 73);
            this.bLoadLogic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bLoadLogic.Name = "bLoadLogic";
            this.bLoadLogic.Size = new System.Drawing.Size(90, 37);
            this.bLoadLogic.TabIndex = 17;
            this.bLoadLogic.Text = "Open Logic";
            this.bLoadLogic.UseVisualStyleBackColor = true;
            this.bLoadLogic.Click += new System.EventHandler(this.bLoadLogic_Click);
            // 
            // lMode
            // 
            this.lMode.AutoSize = true;
            this.lMode.BackColor = System.Drawing.Color.Transparent;
            this.lMode.ForeColor = System.Drawing.Color.Black;
            this.lMode.Location = new System.Drawing.Point(11, 40);
            this.lMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lMode.Name = "lMode";
            this.lMode.Size = new System.Drawing.Size(93, 20);
            this.lMode.TabIndex = 0;
            this.lMode.Text = "Mode/Logic:";
            // 
            // tbUserLogic
            // 
            this.tbUserLogic.Location = new System.Drawing.Point(110, 77);
            this.tbUserLogic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbUserLogic.Name = "tbUserLogic";
            this.tbUserLogic.ReadOnly = true;
            this.tbUserLogic.Size = new System.Drawing.Size(309, 27);
            this.tbUserLogic.TabIndex = 18;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tJunkLocationsList);
            this.groupBox6.Controls.Add(this.bJunkLocationsEditor);
            this.groupBox6.Controls.Add(this.lJunkLocationsAmount);
            this.groupBox6.Location = new System.Drawing.Point(450, 128);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Size = new System.Drawing.Size(431, 111);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enforce Junk Locations";
            // 
            // tJunkLocationsList
            // 
            this.tJunkLocationsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tJunkLocationsList.Location = new System.Drawing.Point(15, 68);
            this.tJunkLocationsList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tJunkLocationsList.Name = "tJunkLocationsList";
            this.tJunkLocationsList.Size = new System.Drawing.Size(353, 27);
            this.tJunkLocationsList.TabIndex = 26;
            this.tJunkLocationsList.Text = "--";
            this.tJunkLocationsList.TextChanged += new System.EventHandler(this.tJunkLocationsList_TextChanged);
            // 
            // bJunkLocationsEditor
            // 
            this.bJunkLocationsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bJunkLocationsEditor.Location = new System.Drawing.Point(365, 67);
            this.bJunkLocationsEditor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bJunkLocationsEditor.Name = "bJunkLocationsEditor";
            this.bJunkLocationsEditor.Size = new System.Drawing.Size(53, 33);
            this.bJunkLocationsEditor.TabIndex = 26;
            this.bJunkLocationsEditor.Text = "Edit";
            this.bJunkLocationsEditor.UseVisualStyleBackColor = true;
            this.bJunkLocationsEditor.Click += new System.EventHandler(this.bJunkLocationsEditor_Click);
            // 
            // lJunkLocationsAmount
            // 
            this.lJunkLocationsAmount.AutoSize = true;
            this.lJunkLocationsAmount.Location = new System.Drawing.Point(11, 37);
            this.lJunkLocationsAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lJunkLocationsAmount.Name = "lJunkLocationsAmount";
            this.lJunkLocationsAmount.Size = new System.Drawing.Size(154, 20);
            this.lJunkLocationsAmount.TabIndex = 27;
            this.lJunkLocationsAmount.Text = "0/0 locations selected";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tStartingItemList);
            this.groupBox4.Controls.Add(this.lCustomStartingItemAmount);
            this.groupBox4.Controls.Add(this.bStartingItemEditor);
            this.groupBox4.Location = new System.Drawing.Point(450, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(431, 111);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extra Starting Items";
            // 
            // tStartingItemList
            // 
            this.tStartingItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tStartingItemList.Location = new System.Drawing.Point(15, 69);
            this.tStartingItemList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tStartingItemList.Name = "tStartingItemList";
            this.tStartingItemList.Size = new System.Drawing.Size(353, 27);
            this.tStartingItemList.TabIndex = 26;
            this.tStartingItemList.Text = "--";
            this.tStartingItemList.TextChanged += new System.EventHandler(this.tStartingItemList_TextChanged);
            // 
            // lCustomStartingItemAmount
            // 
            this.lCustomStartingItemAmount.AutoSize = true;
            this.lCustomStartingItemAmount.Location = new System.Drawing.Point(11, 39);
            this.lCustomStartingItemAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lCustomStartingItemAmount.Name = "lCustomStartingItemAmount";
            this.lCustomStartingItemAmount.Size = new System.Drawing.Size(130, 20);
            this.lCustomStartingItemAmount.TabIndex = 27;
            this.lCustomStartingItemAmount.Text = "0/0 items selected";
            // 
            // bStartingItemEditor
            // 
            this.bStartingItemEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartingItemEditor.Location = new System.Drawing.Point(366, 68);
            this.bStartingItemEditor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bStartingItemEditor.Name = "bStartingItemEditor";
            this.bStartingItemEditor.Size = new System.Drawing.Size(53, 33);
            this.bStartingItemEditor.TabIndex = 26;
            this.bStartingItemEditor.Text = "Edit";
            this.bStartingItemEditor.UseVisualStyleBackColor = true;
            this.bStartingItemEditor.Click += new System.EventHandler(this.bStartingItemEditor_Click);
            // 
            // tabItemPool
            // 
            this.tabItemPool.Controls.Add(this.lItemPoolText);
            this.tabItemPool.Controls.Add(this.bItemPoolEdit);
            this.tabItemPool.Controls.Add(this.tItemPool);
            this.tabItemPool.Controls.Add(this.tableItemPool);
            this.tabItemPool.Location = new System.Drawing.Point(4, 29);
            this.tabItemPool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabItemPool.Name = "tabItemPool";
            this.tabItemPool.Size = new System.Drawing.Size(893, 486);
            this.tabItemPool.TabIndex = 6;
            this.tabItemPool.Text = "Item Pool";
            this.tabItemPool.UseVisualStyleBackColor = true;
            // 
            // lItemPoolText
            // 
            this.lItemPoolText.AutoSize = true;
            this.lItemPoolText.Location = new System.Drawing.Point(8, 45);
            this.lItemPoolText.Name = "lItemPoolText";
            this.lItemPoolText.Size = new System.Drawing.Size(130, 20);
            this.lItemPoolText.TabIndex = 25;
            this.lItemPoolText.Text = "0/0 items selected";
            // 
            // bItemPoolEdit
            // 
            this.bItemPoolEdit.Location = new System.Drawing.Point(797, 4);
            this.bItemPoolEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bItemPoolEdit.Name = "bItemPoolEdit";
            this.bItemPoolEdit.Size = new System.Drawing.Size(86, 33);
            this.bItemPoolEdit.TabIndex = 24;
            this.bItemPoolEdit.Text = "Edit";
            this.bItemPoolEdit.UseVisualStyleBackColor = true;
            this.bItemPoolEdit.Click += new System.EventHandler(this.bItemPoolEdit_Click);
            // 
            // tItemPool
            // 
            this.tItemPool.Location = new System.Drawing.Point(8, 5);
            this.tItemPool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tItemPool.Name = "tItemPool";
            this.tItemPool.Size = new System.Drawing.Size(781, 27);
            this.tItemPool.TabIndex = 23;
            this.tItemPool.TextChanged += new System.EventHandler(this.tItemPool_TextChanged);
            // 
            // tableItemPool
            // 
            this.tableItemPool.AutoScroll = true;
            this.tableItemPool.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableItemPool.ColumnCount = 1;
            this.tableItemPool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableItemPool.Location = new System.Drawing.Point(3, 213);
            this.tableItemPool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableItemPool.Name = "tableItemPool";
            this.tableItemPool.RowCount = 1;
            this.tableItemPool.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableItemPool.Size = new System.Drawing.Size(885, 264);
            this.tableItemPool.TabIndex = 22;
            // 
            // tabGimmicks
            // 
            this.tabGimmicks.Controls.Add(this.groupBox12);
            this.tabGimmicks.Controls.Add(this.groupBox11);
            this.tabGimmicks.Controls.Add(this.groupBox10);
            this.tabGimmicks.Controls.Add(this.groupBox5);
            this.tabGimmicks.Controls.Add(this.groupBox1);
            this.tabGimmicks.Controls.Add(this.label4);
            this.tabGimmicks.Location = new System.Drawing.Point(4, 29);
            this.tabGimmicks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabGimmicks.Name = "tabGimmicks";
            this.tabGimmicks.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabGimmicks.Size = new System.Drawing.Size(893, 486);
            this.tabGimmicks.TabIndex = 3;
            this.tabGimmicks.Text = "Gimmicks";
            this.tabGimmicks.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cFDAnywhere);
            this.groupBox12.Controls.Add(this.cBlastCooldown);
            this.groupBox12.Controls.Add(this.cUnderwaterOcarina);
            this.groupBox12.Controls.Add(this.cSunsSong);
            this.groupBox12.Controls.Add(this.lBlastMask);
            this.groupBox12.Controls.Add(this.lNutAndStickDrops);
            this.groupBox12.Controls.Add(this.cNutAndStickDrops);
            this.groupBox12.Location = new System.Drawing.Point(216, 123);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox12.Size = new System.Drawing.Size(431, 347);
            this.groupBox12.TabIndex = 34;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Other";
            // 
            // cFDAnywhere
            // 
            this.cFDAnywhere.AutoSize = true;
            this.cFDAnywhere.BackColor = System.Drawing.Color.Transparent;
            this.cFDAnywhere.ForeColor = System.Drawing.Color.Black;
            this.cFDAnywhere.Location = new System.Drawing.Point(169, 100);
            this.cFDAnywhere.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFDAnywhere.Name = "cFDAnywhere";
            this.cFDAnywhere.Size = new System.Drawing.Size(265, 24);
            this.cFDAnywhere.TabIndex = 23;
            this.cFDAnywhere.Text = "Allow Fierce Deity\'s Mask anywhere";
            this.cFDAnywhere.UseVisualStyleBackColor = false;
            this.cFDAnywhere.CheckedChanged += new System.EventHandler(this.cFDAnywhere_CheckedChanged);
            // 
            // cBlastCooldown
            // 
            this.cBlastCooldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBlastCooldown.FormattingEnabled = true;
            this.cBlastCooldown.Items.AddRange(new object[] {
            "Default",
            "Instant",
            "Very short",
            "Short",
            "Long",
            "Very Long"});
            this.cBlastCooldown.Location = new System.Drawing.Point(8, 47);
            this.cBlastCooldown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cBlastCooldown.Name = "cBlastCooldown";
            this.cBlastCooldown.Size = new System.Drawing.Size(140, 28);
            this.cBlastCooldown.TabIndex = 20;
            this.cBlastCooldown.SelectedIndexChanged += new System.EventHandler(this.cBlastCooldown_SelectedIndexChanged);
            // 
            // cUnderwaterOcarina
            // 
            this.cUnderwaterOcarina.AutoSize = true;
            this.cUnderwaterOcarina.BackColor = System.Drawing.Color.Transparent;
            this.cUnderwaterOcarina.Location = new System.Drawing.Point(169, 29);
            this.cUnderwaterOcarina.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cUnderwaterOcarina.Name = "cUnderwaterOcarina";
            this.cUnderwaterOcarina.Size = new System.Drawing.Size(163, 24);
            this.cUnderwaterOcarina.TabIndex = 22;
            this.cUnderwaterOcarina.Text = "Underwater Ocarina";
            this.cUnderwaterOcarina.UseVisualStyleBackColor = false;
            this.cUnderwaterOcarina.CheckedChanged += new System.EventHandler(this.cUnderwaterOcarina_CheckedChanged);
            // 
            // cSunsSong
            // 
            this.cSunsSong.AutoSize = true;
            this.cSunsSong.BackColor = System.Drawing.Color.Transparent;
            this.cSunsSong.ForeColor = System.Drawing.Color.Black;
            this.cSunsSong.Location = new System.Drawing.Point(169, 64);
            this.cSunsSong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cSunsSong.Name = "cSunsSong";
            this.cSunsSong.Size = new System.Drawing.Size(151, 24);
            this.cSunsSong.TabIndex = 21;
            this.cSunsSong.Text = "Enable Sun\'s Song";
            this.cSunsSong.UseVisualStyleBackColor = false;
            this.cSunsSong.CheckedChanged += new System.EventHandler(this.cSunsSong_CheckedChanged);
            // 
            // lBlastMask
            // 
            this.lBlastMask.AutoSize = true;
            this.lBlastMask.Location = new System.Drawing.Point(9, 24);
            this.lBlastMask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lBlastMask.Name = "lBlastMask";
            this.lBlastMask.Size = new System.Drawing.Size(151, 20);
            this.lBlastMask.TabIndex = 19;
            this.lBlastMask.Text = "Blast Mask Cooldown";
            // 
            // lNutAndStickDrops
            // 
            this.lNutAndStickDrops.AutoSize = true;
            this.lNutAndStickDrops.Location = new System.Drawing.Point(9, 83);
            this.lNutAndStickDrops.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lNutAndStickDrops.Name = "lNutAndStickDrops";
            this.lNutAndStickDrops.Size = new System.Drawing.Size(141, 20);
            this.lNutAndStickDrops.TabIndex = 25;
            this.lNutAndStickDrops.Text = "Nut and Stick Drops";
            // 
            // cNutAndStickDrops
            // 
            this.cNutAndStickDrops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cNutAndStickDrops.FormattingEnabled = true;
            this.cNutAndStickDrops.Items.AddRange(new object[] {
            "Default",
            "Light",
            "Medium",
            "Extra",
            "Mayhem"});
            this.cNutAndStickDrops.Location = new System.Drawing.Point(8, 104);
            this.cNutAndStickDrops.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cNutAndStickDrops.Name = "cNutAndStickDrops";
            this.cNutAndStickDrops.Size = new System.Drawing.Size(140, 28);
            this.cNutAndStickDrops.TabIndex = 26;
            this.cNutAndStickDrops.SelectedIndexChanged += new System.EventHandler(this.cNutAndStickDrops_SelectedIndexChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cDType);
            this.groupBox11.Controls.Add(this.lDType);
            this.groupBox11.Controls.Add(this.cDeathMoonCrash);
            this.groupBox11.Controls.Add(this.cByoAmmo);
            this.groupBox11.Controls.Add(this.cDMult);
            this.groupBox11.Controls.Add(this.lDMult);
            this.groupBox11.Location = new System.Drawing.Point(655, 251);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox11.Size = new System.Drawing.Size(226, 219);
            this.groupBox11.TabIndex = 33;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Challenges";
            // 
            // cDType
            // 
            this.cDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDType.FormattingEnabled = true;
            this.cDType.Items.AddRange(new object[] {
            "Default",
            "Fire",
            "Ice",
            "Shock",
            "Knockdown",
            "Random"});
            this.cDType.Location = new System.Drawing.Point(8, 109);
            this.cDType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDType.Name = "cDType";
            this.cDType.Size = new System.Drawing.Size(210, 28);
            this.cDType.TabIndex = 0;
            this.cDType.SelectedIndexChanged += new System.EventHandler(this.cDType_SelectedIndexChanged);
            // 
            // lDType
            // 
            this.lDType.AutoSize = true;
            this.lDType.Location = new System.Drawing.Point(8, 88);
            this.lDType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDType.Name = "lDType";
            this.lDType.Size = new System.Drawing.Size(114, 20);
            this.lDType.TabIndex = 1;
            this.lDType.Text = "Damage effects";
            // 
            // cDeathMoonCrash
            // 
            this.cDeathMoonCrash.AutoSize = true;
            this.cDeathMoonCrash.BackColor = System.Drawing.Color.Transparent;
            this.cDeathMoonCrash.ForeColor = System.Drawing.Color.Black;
            this.cDeathMoonCrash.Location = new System.Drawing.Point(8, 151);
            this.cDeathMoonCrash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDeathMoonCrash.Name = "cDeathMoonCrash";
            this.cDeathMoonCrash.Size = new System.Drawing.Size(168, 24);
            this.cDeathMoonCrash.TabIndex = 25;
            this.cDeathMoonCrash.Text = "Death is Moon Crash";
            this.cDeathMoonCrash.UseVisualStyleBackColor = false;
            this.cDeathMoonCrash.CheckedChanged += new System.EventHandler(this.cDeathMoonCrash_CheckedChanged);
            // 
            // cByoAmmo
            // 
            this.cByoAmmo.AutoSize = true;
            this.cByoAmmo.BackColor = System.Drawing.Color.Transparent;
            this.cByoAmmo.ForeColor = System.Drawing.Color.Black;
            this.cByoAmmo.Location = new System.Drawing.Point(8, 187);
            this.cByoAmmo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cByoAmmo.Name = "cByoAmmo";
            this.cByoAmmo.Size = new System.Drawing.Size(107, 24);
            this.cByoAmmo.TabIndex = 24;
            this.cByoAmmo.Text = "BYO Ammo";
            this.cByoAmmo.UseVisualStyleBackColor = false;
            this.cByoAmmo.CheckedChanged += new System.EventHandler(this.cByoAmmo_CheckedChanged);
            // 
            // cDMult
            // 
            this.cDMult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDMult.FormattingEnabled = true;
            this.cDMult.Items.AddRange(new object[] {
            "Default",
            "2x",
            "4x",
            "1-hit KO",
            "Doom"});
            this.cDMult.Location = new System.Drawing.Point(8, 51);
            this.cDMult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDMult.Name = "cDMult";
            this.cDMult.Size = new System.Drawing.Size(210, 28);
            this.cDMult.TabIndex = 0;
            this.cDMult.SelectedIndexChanged += new System.EventHandler(this.cDMult_SelectedIndexChanged);
            // 
            // lDMult
            // 
            this.lDMult.AutoSize = true;
            this.lDMult.Location = new System.Drawing.Point(8, 29);
            this.lDMult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDMult.Name = "lDMult";
            this.lDMult.Size = new System.Drawing.Size(109, 20);
            this.lDMult.TabIndex = 1;
            this.lDMult.Text = "Damage mode";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cFloors);
            this.groupBox10.Controls.Add(this.lFloors);
            this.groupBox10.Controls.Add(this.lGravity);
            this.groupBox10.Controls.Add(this.cGravity);
            this.groupBox10.Controls.Add(this.cContinuousDekuHopping);
            this.groupBox10.Location = new System.Drawing.Point(655, 9);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox10.Size = new System.Drawing.Size(226, 232);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Movement";
            // 
            // cFloors
            // 
            this.cFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFloors.FormattingEnabled = true;
            this.cFloors.Items.AddRange(new object[] {
            "Default",
            "Sand",
            "Ice",
            "Snow",
            "Random"});
            this.cFloors.Location = new System.Drawing.Point(8, 104);
            this.cFloors.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFloors.Name = "cFloors";
            this.cFloors.Size = new System.Drawing.Size(210, 28);
            this.cFloors.TabIndex = 0;
            this.cFloors.SelectedIndexChanged += new System.EventHandler(this.cFloors_SelectedIndexChanged);
            // 
            // lFloors
            // 
            this.lFloors.AutoSize = true;
            this.lFloors.Location = new System.Drawing.Point(8, 83);
            this.lFloors.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lFloors.Name = "lFloors";
            this.lFloors.Size = new System.Drawing.Size(82, 20);
            this.lFloors.TabIndex = 1;
            this.lFloors.Text = "Floor types";
            // 
            // lGravity
            // 
            this.lGravity.AutoSize = true;
            this.lGravity.Location = new System.Drawing.Point(8, 24);
            this.lGravity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lGravity.Name = "lGravity";
            this.lGravity.Size = new System.Drawing.Size(111, 20);
            this.lGravity.TabIndex = 1;
            this.lGravity.Text = "Gravity / Speed";
            // 
            // cGravity
            // 
            this.cGravity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGravity.FormattingEnabled = true;
            this.cGravity.Items.AddRange(new object[] {
            "Default",
            "High speed (many softlocks)",
            "Super low gravity",
            "Low gravity",
            "High gravity"});
            this.cGravity.Location = new System.Drawing.Point(8, 47);
            this.cGravity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cGravity.Name = "cGravity";
            this.cGravity.Size = new System.Drawing.Size(210, 28);
            this.cGravity.TabIndex = 0;
            this.cGravity.SelectedIndexChanged += new System.EventHandler(this.cGravity_SelectedIndexChanged);
            // 
            // cContinuousDekuHopping
            // 
            this.cContinuousDekuHopping.AutoSize = true;
            this.cContinuousDekuHopping.BackColor = System.Drawing.Color.Transparent;
            this.cContinuousDekuHopping.ForeColor = System.Drawing.Color.Black;
            this.cContinuousDekuHopping.Location = new System.Drawing.Point(8, 147);
            this.cContinuousDekuHopping.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cContinuousDekuHopping.Name = "cContinuousDekuHopping";
            this.cContinuousDekuHopping.Size = new System.Drawing.Size(206, 24);
            this.cContinuousDekuHopping.TabIndex = 26;
            this.cContinuousDekuHopping.Text = "Continuous Deku Hopping";
            this.cContinuousDekuHopping.UseVisualStyleBackColor = false;
            this.cContinuousDekuHopping.CheckedChanged += new System.EventHandler(this.cContinuousDekuHopping_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lIceTraps);
            this.groupBox5.Controls.Add(this.cIceTraps);
            this.groupBox5.Controls.Add(this.cIceTrapsAppearance);
            this.groupBox5.Controls.Add(this.cIceTrapQuirks);
            this.groupBox5.Location = new System.Drawing.Point(8, 9);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox5.Size = new System.Drawing.Size(200, 232);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ice Traps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Appearance";
            // 
            // lIceTraps
            // 
            this.lIceTraps.AutoSize = true;
            this.lIceTraps.Location = new System.Drawing.Point(8, 24);
            this.lIceTraps.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lIceTraps.Name = "lIceTraps";
            this.lIceTraps.Size = new System.Drawing.Size(62, 20);
            this.lIceTraps.TabIndex = 28;
            this.lIceTraps.Text = "Amount";
            // 
            // cIceTraps
            // 
            this.cIceTraps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cIceTraps.FormattingEnabled = true;
            this.cIceTraps.Items.AddRange(new object[] {
            "None",
            "Normal",
            "Extra",
            "Mayhem",
            "Onslaught"});
            this.cIceTraps.Location = new System.Drawing.Point(8, 47);
            this.cIceTraps.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cIceTraps.Name = "cIceTraps";
            this.cIceTraps.Size = new System.Drawing.Size(182, 28);
            this.cIceTraps.TabIndex = 26;
            this.cIceTraps.SelectedIndexChanged += new System.EventHandler(this.cIceTraps_SelectedIndexChanged);
            // 
            // cIceTrapsAppearance
            // 
            this.cIceTrapsAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cIceTrapsAppearance.FormattingEnabled = true;
            this.cIceTrapsAppearance.Items.AddRange(new object[] {
            "Major Items",
            "Junk Items",
            "Anything"});
            this.cIceTrapsAppearance.Location = new System.Drawing.Point(8, 104);
            this.cIceTrapsAppearance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cIceTrapsAppearance.Name = "cIceTrapsAppearance";
            this.cIceTrapsAppearance.Size = new System.Drawing.Size(182, 28);
            this.cIceTrapsAppearance.TabIndex = 27;
            this.cIceTrapsAppearance.SelectedIndexChanged += new System.EventHandler(this.cIceTrapsAppearance_SelectedIndexChanged);
            // 
            // cIceTrapQuirks
            // 
            this.cIceTrapQuirks.AutoSize = true;
            this.cIceTrapQuirks.BackColor = System.Drawing.Color.Transparent;
            this.cIceTrapQuirks.ForeColor = System.Drawing.Color.Black;
            this.cIceTrapQuirks.Location = new System.Drawing.Point(8, 147);
            this.cIceTrapQuirks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cIceTrapQuirks.Name = "cIceTrapQuirks";
            this.cIceTrapQuirks.Size = new System.Drawing.Size(121, 24);
            this.cIceTrapQuirks.TabIndex = 29;
            this.cIceTrapQuirks.Text = "Enable Quirks";
            this.cIceTrapQuirks.UseVisualStyleBackColor = false;
            this.cIceTrapQuirks.CheckedChanged += new System.EventHandler(this.cIceTrapQuirks_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cClockSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cHideClock);
            this.groupBox1.Location = new System.Drawing.Point(5, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(203, 219);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock";
            // 
            // cClockSpeed
            // 
            this.cClockSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cClockSpeed.FormattingEnabled = true;
            this.cClockSpeed.Items.AddRange(new object[] {
            "Default",
            "1/3x",
            "2/3x",
            "2x",
            "3x",
            "6x"});
            this.cClockSpeed.Location = new System.Drawing.Point(8, 53);
            this.cClockSpeed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cClockSpeed.Name = "cClockSpeed";
            this.cClockSpeed.Size = new System.Drawing.Size(187, 28);
            this.cClockSpeed.TabIndex = 15;
            this.cClockSpeed.SelectedIndexChanged += new System.EventHandler(this.cClockSpeed_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Speed";
            // 
            // cHideClock
            // 
            this.cHideClock.AutoSize = true;
            this.cHideClock.BackColor = System.Drawing.Color.Transparent;
            this.cHideClock.ForeColor = System.Drawing.Color.Black;
            this.cHideClock.Location = new System.Drawing.Point(8, 96);
            this.cHideClock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHideClock.Name = "cHideClock";
            this.cHideClock.Size = new System.Drawing.Size(81, 24);
            this.cHideClock.TabIndex = 17;
            this.cHideClock.Text = "Hide UI";
            this.cHideClock.UseVisualStyleBackColor = false;
            this.cHideClock.CheckedChanged += new System.EventHandler(this.cHideClock_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 80);
            this.label4.TabIndex = 14;
            this.label4.Text = "WARNING!\r\nMost of these settings are not considered in logic\r\nand some can cause " +
    "the seed to be unbeatable.\r\nUse at your own risk!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabComfort
            // 
            this.tabComfort.Controls.Add(this.gSpeedUps);
            this.tabComfort.Controls.Add(this.gHints);
            this.tabComfort.Controls.Add(this.groupBox8);
            this.tabComfort.Controls.Add(this.groupBox7);
            this.tabComfort.Location = new System.Drawing.Point(4, 29);
            this.tabComfort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabComfort.Name = "tabComfort";
            this.tabComfort.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabComfort.Size = new System.Drawing.Size(893, 486);
            this.tabComfort.TabIndex = 1;
            this.tabComfort.Text = "Comfort";
            this.tabComfort.UseVisualStyleBackColor = true;
            // 
            // gSpeedUps
            // 
            this.gSpeedUps.Controls.Add(this.cFasterBank);
            this.gSpeedUps.Controls.Add(this.cSkipBeaver);
            this.gSpeedUps.Controls.Add(this.cFasterLabFish);
            this.gSpeedUps.Controls.Add(this.cGoodDogRaceRNG);
            this.gSpeedUps.Controls.Add(this.cGoodDampeRNG);
            this.gSpeedUps.Location = new System.Drawing.Point(8, 9);
            this.gSpeedUps.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gSpeedUps.Name = "gSpeedUps";
            this.gSpeedUps.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gSpeedUps.Size = new System.Drawing.Size(481, 324);
            this.gSpeedUps.TabIndex = 37;
            this.gSpeedUps.TabStop = false;
            this.gSpeedUps.Text = "Speed Ups";
            // 
            // cFasterBank
            // 
            this.cFasterBank.AutoSize = true;
            this.cFasterBank.Location = new System.Drawing.Point(11, 103);
            this.cFasterBank.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFasterBank.Name = "cFasterBank";
            this.cFasterBank.Size = new System.Drawing.Size(105, 24);
            this.cFasterBank.TabIndex = 4;
            this.cFasterBank.Text = "Faster Bank";
            this.cFasterBank.UseVisualStyleBackColor = true;
            this.cFasterBank.CheckedChanged += new System.EventHandler(this.cFasterBank_CheckedChanged);
            // 
            // cSkipBeaver
            // 
            this.cSkipBeaver.AutoSize = true;
            this.cSkipBeaver.Location = new System.Drawing.Point(11, 32);
            this.cSkipBeaver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cSkipBeaver.Name = "cSkipBeaver";
            this.cSkipBeaver.Size = new System.Drawing.Size(166, 24);
            this.cSkipBeaver.TabIndex = 0;
            this.cSkipBeaver.Text = "Skip Younger Beaver";
            this.cSkipBeaver.UseVisualStyleBackColor = true;
            this.cSkipBeaver.CheckedChanged += new System.EventHandler(this.cSkipBeaver_CheckedChanged);
            // 
            // cFasterLabFish
            // 
            this.cFasterLabFish.AutoSize = true;
            this.cFasterLabFish.Location = new System.Drawing.Point(11, 68);
            this.cFasterLabFish.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFasterLabFish.Name = "cFasterLabFish";
            this.cFasterLabFish.Size = new System.Drawing.Size(126, 24);
            this.cFasterLabFish.TabIndex = 2;
            this.cFasterLabFish.Text = "Faster Lab Fish";
            this.cFasterLabFish.UseVisualStyleBackColor = true;
            this.cFasterLabFish.CheckedChanged += new System.EventHandler(this.cFasterLabFish_CheckedChanged);
            // 
            // cGoodDogRaceRNG
            // 
            this.cGoodDogRaceRNG.AutoSize = true;
            this.cGoodDogRaceRNG.Location = new System.Drawing.Point(197, 68);
            this.cGoodDogRaceRNG.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cGoodDogRaceRNG.Name = "cGoodDogRaceRNG";
            this.cGoodDogRaceRNG.Size = new System.Drawing.Size(171, 24);
            this.cGoodDogRaceRNG.TabIndex = 3;
            this.cGoodDogRaceRNG.Text = "Good Dog Race RNG";
            this.cGoodDogRaceRNG.UseVisualStyleBackColor = true;
            this.cGoodDogRaceRNG.CheckedChanged += new System.EventHandler(this.cGoodDogRaceRNG_CheckedChanged);
            // 
            // cGoodDampeRNG
            // 
            this.cGoodDampeRNG.AutoSize = true;
            this.cGoodDampeRNG.Location = new System.Drawing.Point(197, 31);
            this.cGoodDampeRNG.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cGoodDampeRNG.Name = "cGoodDampeRNG";
            this.cGoodDampeRNG.Size = new System.Drawing.Size(155, 24);
            this.cGoodDampeRNG.TabIndex = 1;
            this.cGoodDampeRNG.Text = "Good Dampe RNG";
            this.cGoodDampeRNG.UseVisualStyleBackColor = true;
            this.cGoodDampeRNG.CheckedChanged += new System.EventHandler(this.cGoodDampeRNG_CheckedChanged);
            // 
            // gHints
            // 
            this.gHints.Controls.Add(this.lGossip);
            this.gHints.Controls.Add(this.cGossipHints);
            this.gHints.Controls.Add(this.cFreeHints);
            this.gHints.Controls.Add(this.cClearHints);
            this.gHints.Location = new System.Drawing.Point(8, 343);
            this.gHints.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gHints.Name = "gHints";
            this.gHints.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gHints.Size = new System.Drawing.Size(297, 119);
            this.gHints.TabIndex = 36;
            this.gHints.TabStop = false;
            this.gHints.Text = "Gossip Stone Hints";
            // 
            // lGossip
            // 
            this.lGossip.AutoSize = true;
            this.lGossip.BackColor = System.Drawing.Color.Transparent;
            this.lGossip.ForeColor = System.Drawing.Color.Black;
            this.lGossip.Location = new System.Drawing.Point(14, 32);
            this.lGossip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lGossip.Name = "lGossip";
            this.lGossip.Size = new System.Drawing.Size(117, 20);
            this.lGossip.TabIndex = 20;
            this.lGossip.Text = "Hint distribution";
            // 
            // cGossipHints
            // 
            this.cGossipHints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGossipHints.FormattingEnabled = true;
            this.cGossipHints.Items.AddRange(new object[] {
            "Default",
            "Random",
            "Relevant",
            "Competitive"});
            this.cGossipHints.Location = new System.Drawing.Point(17, 52);
            this.cGossipHints.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cGossipHints.Name = "cGossipHints";
            this.cGossipHints.Size = new System.Drawing.Size(153, 28);
            this.cGossipHints.TabIndex = 19;
            this.cGossipHints.SelectedIndexChanged += new System.EventHandler(this.cGossipHints_SelectedIndexChanged);
            // 
            // cFreeHints
            // 
            this.cFreeHints.AutoSize = true;
            this.cFreeHints.BackColor = System.Drawing.Color.Transparent;
            this.cFreeHints.ForeColor = System.Drawing.Color.Black;
            this.cFreeHints.Location = new System.Drawing.Point(182, 27);
            this.cFreeHints.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFreeHints.Name = "cFreeHints";
            this.cFreeHints.Size = new System.Drawing.Size(94, 24);
            this.cFreeHints.TabIndex = 15;
            this.cFreeHints.Text = "Free hints";
            this.cFreeHints.UseVisualStyleBackColor = false;
            this.cFreeHints.CheckedChanged += new System.EventHandler(this.cFreeHints_CheckedChanged);
            // 
            // cClearHints
            // 
            this.cClearHints.AutoSize = true;
            this.cClearHints.BackColor = System.Drawing.Color.Transparent;
            this.cClearHints.ForeColor = System.Drawing.Color.Black;
            this.cClearHints.Location = new System.Drawing.Point(182, 61);
            this.cClearHints.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cClearHints.Name = "cClearHints";
            this.cClearHints.Size = new System.Drawing.Size(100, 24);
            this.cClearHints.TabIndex = 16;
            this.cClearHints.Text = "Clear hints";
            this.cClearHints.UseVisualStyleBackColor = false;
            this.cClearHints.CheckedChanged += new System.EventHandler(this.cClearHints_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lLink);
            this.groupBox8.Controls.Add(this.cLink);
            this.groupBox8.Location = new System.Drawing.Point(313, 343);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox8.Size = new System.Drawing.Size(566, 119);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cosmetic Customization";
            // 
            // lLink
            // 
            this.lLink.AutoSize = true;
            this.lLink.BackColor = System.Drawing.Color.Transparent;
            this.lLink.ForeColor = System.Drawing.Color.Black;
            this.lLink.Location = new System.Drawing.Point(5, 36);
            this.lLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lLink.Name = "lLink";
            this.lLink.Size = new System.Drawing.Size(96, 20);
            this.lLink.TabIndex = 9;
            this.lLink.Text = "Player model";
            // 
            // cLink
            // 
            this.cLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLink.FormattingEnabled = true;
            this.cLink.Items.AddRange(new object[] {
            "Link (MM)",
            "Link (OoT)",
            "Adult Link (Risky!)",
            "Kafei"});
            this.cLink.Location = new System.Drawing.Point(8, 56);
            this.cLink.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cLink.Name = "cLink";
            this.cLink.Size = new System.Drawing.Size(147, 28);
            this.cLink.TabIndex = 10;
            this.cLink.SelectedIndexChanged += new System.EventHandler(this.cLink_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cImprovedPictobox);
            this.groupBox7.Controls.Add(this.cElegySpeedups);
            this.groupBox7.Controls.Add(this.cCloseCows);
            this.groupBox7.Controls.Add(this.cArrowCycling);
            this.groupBox7.Controls.Add(this.cFreestanding);
            this.groupBox7.Controls.Add(this.cFastPush);
            this.groupBox7.Controls.Add(this.cQText);
            this.groupBox7.Controls.Add(this.cShopAppearance);
            this.groupBox7.Controls.Add(this.cEponaSword);
            this.groupBox7.Controls.Add(this.cUpdateChests);
            this.groupBox7.Controls.Add(this.cDisableCritWiggle);
            this.groupBox7.Controls.Add(this.cQuestItemStorage);
            this.groupBox7.Controls.Add(this.cNoDowngrades);
            this.groupBox7.Location = new System.Drawing.Point(497, 9);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox7.Size = new System.Drawing.Size(382, 324);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Comfort Options";
            // 
            // cImprovedPictobox
            // 
            this.cImprovedPictobox.AutoSize = true;
            this.cImprovedPictobox.Location = new System.Drawing.Point(11, 173);
            this.cImprovedPictobox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cImprovedPictobox.Name = "cImprovedPictobox";
            this.cImprovedPictobox.Size = new System.Drawing.Size(157, 24);
            this.cImprovedPictobox.TabIndex = 38;
            this.cImprovedPictobox.Text = "Improved Pictobox";
            this.cImprovedPictobox.UseVisualStyleBackColor = true;
            this.cImprovedPictobox.CheckedChanged += new System.EventHandler(this.cImprovedPictobox_CheckedChanged);
            // 
            // cElegySpeedups
            // 
            this.cElegySpeedups.AutoSize = true;
            this.cElegySpeedups.Location = new System.Drawing.Point(197, 281);
            this.cElegySpeedups.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cElegySpeedups.Name = "cElegySpeedups";
            this.cElegySpeedups.Size = new System.Drawing.Size(134, 24);
            this.cElegySpeedups.TabIndex = 37;
            this.cElegySpeedups.Text = "Elegy speedups";
            this.cElegySpeedups.UseVisualStyleBackColor = true;
            this.cElegySpeedups.CheckedChanged += new System.EventHandler(this.cElegySpeedups_CheckedChanged);
            // 
            // cCloseCows
            // 
            this.cCloseCows.AutoSize = true;
            this.cCloseCows.Location = new System.Drawing.Point(11, 140);
            this.cCloseCows.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cCloseCows.Name = "cCloseCows";
            this.cCloseCows.Size = new System.Drawing.Size(106, 24);
            this.cCloseCows.TabIndex = 36;
            this.cCloseCows.Text = "Close Cows";
            this.cCloseCows.UseVisualStyleBackColor = true;
            this.cCloseCows.CheckedChanged += new System.EventHandler(this.cCloseCows_CheckedChanged);
            // 
            // cArrowCycling
            // 
            this.cArrowCycling.AutoSize = true;
            this.cArrowCycling.Location = new System.Drawing.Point(197, 247);
            this.cArrowCycling.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cArrowCycling.Name = "cArrowCycling";
            this.cArrowCycling.Size = new System.Drawing.Size(121, 24);
            this.cArrowCycling.TabIndex = 35;
            this.cArrowCycling.Text = "Arrow cycling";
            this.cArrowCycling.UseVisualStyleBackColor = true;
            this.cArrowCycling.CheckedChanged += new System.EventHandler(this.cArrowCycling_CheckedChanged);
            // 
            // cFreestanding
            // 
            this.cFreestanding.AutoSize = true;
            this.cFreestanding.Location = new System.Drawing.Point(197, 104);
            this.cFreestanding.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFreestanding.Name = "cFreestanding";
            this.cFreestanding.Size = new System.Drawing.Size(175, 24);
            this.cFreestanding.TabIndex = 34;
            this.cFreestanding.Text = "Update world models";
            this.cFreestanding.UseVisualStyleBackColor = true;
            this.cFreestanding.CheckedChanged += new System.EventHandler(this.cFreestanding_CheckedChanged);
            // 
            // cFastPush
            // 
            this.cFastPush.AutoSize = true;
            this.cFastPush.Location = new System.Drawing.Point(11, 104);
            this.cFastPush.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cFastPush.Name = "cFastPush";
            this.cFastPush.Size = new System.Drawing.Size(164, 24);
            this.cFastPush.TabIndex = 31;
            this.cFastPush.Text = "Increase push speed";
            this.cFastPush.UseVisualStyleBackColor = true;
            this.cFastPush.CheckedChanged += new System.EventHandler(this.cFastPush_CheckedChanged);
            // 
            // cQText
            // 
            this.cQText.AutoSize = true;
            this.cQText.BackColor = System.Drawing.Color.Transparent;
            this.cQText.ForeColor = System.Drawing.Color.Black;
            this.cQText.Location = new System.Drawing.Point(11, 69);
            this.cQText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cQText.Name = "cQText";
            this.cQText.Size = new System.Drawing.Size(97, 24);
            this.cQText.TabIndex = 6;
            this.cQText.Text = "Quick text";
            this.cQText.UseVisualStyleBackColor = false;
            this.cQText.CheckedChanged += new System.EventHandler(this.cQText_CheckedChanged);
            // 
            // cShopAppearance
            // 
            this.cShopAppearance.AutoSize = true;
            this.cShopAppearance.BackColor = System.Drawing.Color.Transparent;
            this.cShopAppearance.ForeColor = System.Drawing.Color.Black;
            this.cShopAppearance.Location = new System.Drawing.Point(197, 33);
            this.cShopAppearance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cShopAppearance.Name = "cShopAppearance";
            this.cShopAppearance.Size = new System.Drawing.Size(122, 24);
            this.cShopAppearance.TabIndex = 21;
            this.cShopAppearance.Text = "Update shops";
            this.cShopAppearance.UseVisualStyleBackColor = false;
            this.cShopAppearance.CheckedChanged += new System.EventHandler(this.cShopAppearance_CheckedChanged);
            // 
            // cEponaSword
            // 
            this.cEponaSword.AutoSize = true;
            this.cEponaSword.BackColor = System.Drawing.Color.Transparent;
            this.cEponaSword.ForeColor = System.Drawing.Color.Black;
            this.cEponaSword.Location = new System.Drawing.Point(197, 176);
            this.cEponaSword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cEponaSword.Name = "cEponaSword";
            this.cEponaSword.Size = new System.Drawing.Size(139, 24);
            this.cEponaSword.TabIndex = 22;
            this.cEponaSword.Text = "Fix Epona sword";
            this.cEponaSword.UseVisualStyleBackColor = false;
            this.cEponaSword.CheckedChanged += new System.EventHandler(this.cEponaSword_CheckedChanged);
            // 
            // cUpdateChests
            // 
            this.cUpdateChests.AutoSize = true;
            this.cUpdateChests.BackColor = System.Drawing.Color.Transparent;
            this.cUpdateChests.ForeColor = System.Drawing.Color.Black;
            this.cUpdateChests.Location = new System.Drawing.Point(197, 69);
            this.cUpdateChests.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cUpdateChests.Name = "cUpdateChests";
            this.cUpdateChests.Size = new System.Drawing.Size(124, 24);
            this.cUpdateChests.TabIndex = 23;
            this.cUpdateChests.Text = "Update chests";
            this.cUpdateChests.UseVisualStyleBackColor = false;
            this.cUpdateChests.CheckedChanged += new System.EventHandler(this.cUpdateChests_CheckedChanged);
            // 
            // cDisableCritWiggle
            // 
            this.cDisableCritWiggle.AutoSize = true;
            this.cDisableCritWiggle.BackColor = System.Drawing.Color.Transparent;
            this.cDisableCritWiggle.Location = new System.Drawing.Point(11, 33);
            this.cDisableCritWiggle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDisableCritWiggle.Name = "cDisableCritWiggle";
            this.cDisableCritWiggle.Size = new System.Drawing.Size(155, 24);
            this.cDisableCritWiggle.TabIndex = 29;
            this.cDisableCritWiggle.Text = "Disable crit wiggle";
            this.cDisableCritWiggle.UseVisualStyleBackColor = false;
            this.cDisableCritWiggle.CheckedChanged += new System.EventHandler(this.cDisableCritWiggle_CheckedChanged);
            // 
            // cQuestItemStorage
            // 
            this.cQuestItemStorage.AutoSize = true;
            this.cQuestItemStorage.BackColor = System.Drawing.Color.Transparent;
            this.cQuestItemStorage.Location = new System.Drawing.Point(197, 211);
            this.cQuestItemStorage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cQuestItemStorage.Name = "cQuestItemStorage";
            this.cQuestItemStorage.Size = new System.Drawing.Size(194, 24);
            this.cQuestItemStorage.TabIndex = 30;
            this.cQuestItemStorage.Text = "Quest item extra storage";
            this.cQuestItemStorage.UseVisualStyleBackColor = false;
            this.cQuestItemStorage.CheckedChanged += new System.EventHandler(this.cQuestItemStorage_CheckedChanged);
            // 
            // cNoDowngrades
            // 
            this.cNoDowngrades.AutoSize = true;
            this.cNoDowngrades.BackColor = System.Drawing.Color.Transparent;
            this.cNoDowngrades.ForeColor = System.Drawing.Color.Black;
            this.cNoDowngrades.Location = new System.Drawing.Point(197, 140);
            this.cNoDowngrades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cNoDowngrades.Name = "cNoDowngrades";
            this.cNoDowngrades.Size = new System.Drawing.Size(137, 24);
            this.cNoDowngrades.TabIndex = 18;
            this.cNoDowngrades.Text = "No downgrades";
            this.cNoDowngrades.UseVisualStyleBackColor = false;
            this.cNoDowngrades.CheckedChanged += new System.EventHandler(this.cNoDowngrades_CheckedChanged);
            // 
            // tabShortenCutscenes
            // 
            this.tabShortenCutscenes.Controls.Add(this.tShortenCutscenes);
            this.tabShortenCutscenes.Location = new System.Drawing.Point(4, 29);
            this.tabShortenCutscenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabShortenCutscenes.Name = "tabShortenCutscenes";
            this.tabShortenCutscenes.Size = new System.Drawing.Size(893, 486);
            this.tabShortenCutscenes.TabIndex = 5;
            this.tabShortenCutscenes.Text = "Shorten Cutscenes";
            this.tabShortenCutscenes.UseVisualStyleBackColor = true;
            // 
            // tShortenCutscenes
            // 
            this.tShortenCutscenes.Location = new System.Drawing.Point(9, 7);
            this.tShortenCutscenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tShortenCutscenes.Name = "tShortenCutscenes";
            this.tShortenCutscenes.SelectedIndex = 0;
            this.tShortenCutscenes.Size = new System.Drawing.Size(866, 429);
            this.tShortenCutscenes.TabIndex = 0;
            // 
            // tabCosmetics
            // 
            this.tabCosmetics.Controls.Add(this.gCosmeticOther);
            this.tabCosmetics.Controls.Add(this.gCosmeticMusicSound);
            this.tabCosmetics.Controls.Add(this.cHUDGroupBox);
            this.tabCosmetics.Controls.Add(this.tFormCosmetics);
            this.tabCosmetics.Location = new System.Drawing.Point(4, 29);
            this.tabCosmetics.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCosmetics.Name = "tabCosmetics";
            this.tabCosmetics.Size = new System.Drawing.Size(893, 486);
            this.tabCosmetics.TabIndex = 4;
            this.tabCosmetics.Text = "Cosmetics";
            this.tabCosmetics.UseVisualStyleBackColor = true;
            // 
            // gCosmeticOther
            // 
            this.gCosmeticOther.Controls.Add(this.cInstantPictobox);
            this.gCosmeticOther.Controls.Add(this.cTatl);
            this.gCosmeticOther.Controls.Add(this.lTatl);
            this.gCosmeticOther.Controls.Add(this.cTargettingStyle);
            this.gCosmeticOther.Location = new System.Drawing.Point(342, 4);
            this.gCosmeticOther.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gCosmeticOther.Name = "gCosmeticOther";
            this.gCosmeticOther.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gCosmeticOther.Size = new System.Drawing.Size(535, 199);
            this.gCosmeticOther.TabIndex = 47;
            this.gCosmeticOther.TabStop = false;
            this.gCosmeticOther.Text = "Other";
            // 
            // cInstantPictobox
            // 
            this.cInstantPictobox.AutoSize = true;
            this.cInstantPictobox.BackColor = System.Drawing.Color.Transparent;
            this.cInstantPictobox.Location = new System.Drawing.Point(11, 120);
            this.cInstantPictobox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cInstantPictobox.Name = "cInstantPictobox";
            this.cInstantPictobox.Size = new System.Drawing.Size(222, 24);
            this.cInstantPictobox.TabIndex = 42;
            this.cInstantPictobox.Text = "Instant Pictobox on Emulator";
            this.cInstantPictobox.UseVisualStyleBackColor = false;
            this.cInstantPictobox.CheckedChanged += new System.EventHandler(this.cInstantPictobox_CheckedChanged);
            // 
            // cTatl
            // 
            this.cTatl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTatl.FormattingEnabled = true;
            this.cTatl.Items.AddRange(new object[] {
            "Default",
            "Dark",
            "Hot",
            "Cool",
            "Random",
            "Rainbow (cycle)"});
            this.cTatl.Location = new System.Drawing.Point(11, 44);
            this.cTatl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cTatl.Name = "cTatl";
            this.cTatl.Size = new System.Drawing.Size(171, 28);
            this.cTatl.TabIndex = 41;
            this.cTatl.SelectedIndexChanged += new System.EventHandler(this.cTatl_SelectedIndexChanged);
            // 
            // lTatl
            // 
            this.lTatl.AutoSize = true;
            this.lTatl.BackColor = System.Drawing.Color.Transparent;
            this.lTatl.ForeColor = System.Drawing.Color.Black;
            this.lTatl.Location = new System.Drawing.Point(8, 24);
            this.lTatl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lTatl.Name = "lTatl";
            this.lTatl.Size = new System.Drawing.Size(78, 20);
            this.lTatl.TabIndex = 40;
            this.lTatl.Text = "Tatl theme";
            // 
            // cTargettingStyle
            // 
            this.cTargettingStyle.AutoSize = true;
            this.cTargettingStyle.BackColor = System.Drawing.Color.Transparent;
            this.cTargettingStyle.Location = new System.Drawing.Point(11, 87);
            this.cTargettingStyle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cTargettingStyle.Name = "cTargettingStyle";
            this.cTargettingStyle.Size = new System.Drawing.Size(177, 24);
            this.cTargettingStyle.TabIndex = 37;
            this.cTargettingStyle.Text = "Default Hold Z-Target";
            this.cTargettingStyle.UseVisualStyleBackColor = false;
            this.cTargettingStyle.CheckedChanged += new System.EventHandler(this.cTargettingStyle_CheckedChanged);
            // 
            // gCosmeticMusicSound
            // 
            this.gCosmeticMusicSound.Controls.Add(this.lMusic);
            this.gCosmeticMusicSound.Controls.Add(this.cMusic);
            this.gCosmeticMusicSound.Controls.Add(this.cSFX);
            this.gCosmeticMusicSound.Controls.Add(this.cCombatMusicDisable);
            this.gCosmeticMusicSound.Controls.Add(this.cEnableNightMusic);
            this.gCosmeticMusicSound.Controls.Add(this.cLowHealthSFXComboBox);
            this.gCosmeticMusicSound.Controls.Add(this.lLowHealthSFXComboBox);
            this.gCosmeticMusicSound.Location = new System.Drawing.Point(9, 212);
            this.gCosmeticMusicSound.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gCosmeticMusicSound.Name = "gCosmeticMusicSound";
            this.gCosmeticMusicSound.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gCosmeticMusicSound.Size = new System.Drawing.Size(325, 260);
            this.gCosmeticMusicSound.TabIndex = 46;
            this.gCosmeticMusicSound.TabStop = false;
            this.gCosmeticMusicSound.Text = "Music / Sound";
            // 
            // lMusic
            // 
            this.lMusic.AutoSize = true;
            this.lMusic.BackColor = System.Drawing.Color.Transparent;
            this.lMusic.ForeColor = System.Drawing.Color.Black;
            this.lMusic.Location = new System.Drawing.Point(5, 132);
            this.lMusic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lMusic.Name = "lMusic";
            this.lMusic.Size = new System.Drawing.Size(47, 20);
            this.lMusic.TabIndex = 43;
            this.lMusic.Text = "Music";
            // 
            // cMusic
            // 
            this.cMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMusic.FormattingEnabled = true;
            this.cMusic.Items.AddRange(new object[] {
            "Default",
            "Random",
            "None"});
            this.cMusic.Location = new System.Drawing.Point(8, 152);
            this.cMusic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cMusic.Name = "cMusic";
            this.cMusic.Size = new System.Drawing.Size(178, 28);
            this.cMusic.TabIndex = 42;
            this.cMusic.SelectedIndexChanged += new System.EventHandler(this.cMusic_SelectedIndexChanged);
            // 
            // cSFX
            // 
            this.cSFX.AutoSize = true;
            this.cSFX.BackColor = System.Drawing.Color.Transparent;
            this.cSFX.ForeColor = System.Drawing.Color.Black;
            this.cSFX.Location = new System.Drawing.Point(8, 31);
            this.cSFX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cSFX.Name = "cSFX";
            this.cSFX.Size = new System.Drawing.Size(134, 24);
            this.cSFX.TabIndex = 36;
            this.cSFX.Text = "Randomize SFX";
            this.cSFX.UseVisualStyleBackColor = false;
            this.cSFX.CheckedChanged += new System.EventHandler(this.cSFX_CheckedChanged);
            // 
            // cCombatMusicDisable
            // 
            this.cCombatMusicDisable.AutoSize = true;
            this.cCombatMusicDisable.Location = new System.Drawing.Point(8, 101);
            this.cCombatMusicDisable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cCombatMusicDisable.Name = "cCombatMusicDisable";
            this.cCombatMusicDisable.Size = new System.Drawing.Size(180, 24);
            this.cCombatMusicDisable.TabIndex = 45;
            this.cCombatMusicDisable.Text = "Disable Combat Music";
            this.cCombatMusicDisable.UseVisualStyleBackColor = true;
            this.cCombatMusicDisable.CheckedChanged += new System.EventHandler(this.cCombatMusicDisable_CheckedChanged);
            // 
            // cEnableNightMusic
            // 
            this.cEnableNightMusic.AutoSize = true;
            this.cEnableNightMusic.Location = new System.Drawing.Point(8, 67);
            this.cEnableNightMusic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cEnableNightMusic.Name = "cEnableNightMusic";
            this.cEnableNightMusic.Size = new System.Drawing.Size(153, 24);
            this.cEnableNightMusic.TabIndex = 38;
            this.cEnableNightMusic.Text = "Enable Night BGM";
            this.cEnableNightMusic.UseVisualStyleBackColor = true;
            this.cEnableNightMusic.CheckedChanged += new System.EventHandler(this.cEnableNightMusic_CheckedChanged);
            // 
            // cLowHealthSFXComboBox
            // 
            this.cLowHealthSFXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLowHealthSFXComboBox.FormattingEnabled = true;
            this.cLowHealthSFXComboBox.Location = new System.Drawing.Point(8, 217);
            this.cLowHealthSFXComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cLowHealthSFXComboBox.Name = "cLowHealthSFXComboBox";
            this.cLowHealthSFXComboBox.Size = new System.Drawing.Size(159, 28);
            this.cLowHealthSFXComboBox.TabIndex = 25;
            this.cLowHealthSFXComboBox.SelectedIndexChanged += new System.EventHandler(this.cLowHealthSFXComboBox_SelectedIndexChanged);
            // 
            // lLowHealthSFXComboBox
            // 
            this.lLowHealthSFXComboBox.AutoSize = true;
            this.lLowHealthSFXComboBox.Location = new System.Drawing.Point(5, 189);
            this.lLowHealthSFXComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lLowHealthSFXComboBox.Name = "lLowHealthSFXComboBox";
            this.lLowHealthSFXComboBox.Size = new System.Drawing.Size(112, 20);
            this.lLowHealthSFXComboBox.TabIndex = 25;
            this.lLowHealthSFXComboBox.Text = "Low Health SFX";
            // 
            // cHUDGroupBox
            // 
            this.cHUDGroupBox.Controls.Add(this.cHueShiftMiscUI);
            this.cHUDGroupBox.Controls.Add(this.cHUDTableLayoutPanel);
            this.cHUDGroupBox.Location = new System.Drawing.Point(342, 212);
            this.cHUDGroupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHUDGroupBox.Name = "cHUDGroupBox";
            this.cHUDGroupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHUDGroupBox.Size = new System.Drawing.Size(535, 260);
            this.cHUDGroupBox.TabIndex = 44;
            this.cHUDGroupBox.TabStop = false;
            this.cHUDGroupBox.Text = "HUD";
            // 
            // cHueShiftMiscUI
            // 
            this.cHueShiftMiscUI.AutoSize = true;
            this.cHueShiftMiscUI.Location = new System.Drawing.Point(11, 121);
            this.cHueShiftMiscUI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHueShiftMiscUI.Name = "cHueShiftMiscUI";
            this.cHueShiftMiscUI.Size = new System.Drawing.Size(270, 24);
            this.cHueShiftMiscUI.TabIndex = 1;
            this.cHueShiftMiscUI.Text = "Randomize Hue of Miscellaneous UI";
            this.cHueShiftMiscUI.UseVisualStyleBackColor = true;
            this.cHueShiftMiscUI.CheckedChanged += new System.EventHandler(this.cHueShiftMiscUI_CheckedChanged);
            // 
            // cHUDTableLayoutPanel
            // 
            this.cHUDTableLayoutPanel.ColumnCount = 3;
            this.cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cHUDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.cHUDTableLayoutPanel.Controls.Add(this.cHUDHeartsComboBox, 1, 0);
            this.cHUDTableLayoutPanel.Controls.Add(this.cHeartsLabel, 0, 0);
            this.cHUDTableLayoutPanel.Controls.Add(this.cMagicLabel, 0, 1);
            this.cHUDTableLayoutPanel.Controls.Add(this.cHUDMagicComboBox, 1, 1);
            this.cHUDTableLayoutPanel.Controls.Add(this.btn_hud, 2, 0);
            this.cHUDTableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.cHUDTableLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHUDTableLayoutPanel.Name = "cHUDTableLayoutPanel";
            this.cHUDTableLayoutPanel.RowCount = 2;
            this.cHUDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cHUDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cHUDTableLayoutPanel.Size = new System.Drawing.Size(523, 88);
            this.cHUDTableLayoutPanel.TabIndex = 0;
            // 
            // cHUDHeartsComboBox
            // 
            this.cHUDHeartsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cHUDHeartsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cHUDHeartsComboBox.FormattingEnabled = true;
            this.cHUDHeartsComboBox.Location = new System.Drawing.Point(71, 4);
            this.cHUDHeartsComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHUDHeartsComboBox.Name = "cHUDHeartsComboBox";
            this.cHUDHeartsComboBox.Size = new System.Drawing.Size(343, 28);
            this.cHUDHeartsComboBox.TabIndex = 32;
            this.cHUDHeartsComboBox.SelectedIndexChanged += new System.EventHandler(this.cHUDHeartsComboBox_SelectedIndexChanged);
            // 
            // cHeartsLabel
            // 
            this.cHeartsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cHeartsLabel.AutoSize = true;
            this.cHeartsLabel.Location = new System.Drawing.Point(5, 12);
            this.cHeartsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cHeartsLabel.Name = "cHeartsLabel";
            this.cHeartsLabel.Size = new System.Drawing.Size(55, 20);
            this.cHeartsLabel.TabIndex = 33;
            this.cHeartsLabel.Text = "Hearts:";
            // 
            // cMagicLabel
            // 
            this.cMagicLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cMagicLabel.AutoSize = true;
            this.cMagicLabel.Location = new System.Drawing.Point(5, 56);
            this.cMagicLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cMagicLabel.Name = "cMagicLabel";
            this.cMagicLabel.Size = new System.Drawing.Size(53, 20);
            this.cMagicLabel.TabIndex = 34;
            this.cMagicLabel.Text = "Magic:";
            // 
            // cHUDMagicComboBox
            // 
            this.cHUDMagicComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cHUDMagicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cHUDMagicComboBox.FormattingEnabled = true;
            this.cHUDMagicComboBox.Location = new System.Drawing.Point(71, 48);
            this.cHUDMagicComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHUDMagicComboBox.Name = "cHUDMagicComboBox";
            this.cHUDMagicComboBox.Size = new System.Drawing.Size(343, 28);
            this.cHUDMagicComboBox.TabIndex = 35;
            this.cHUDMagicComboBox.SelectedIndexChanged += new System.EventHandler(this.cHUDMagicComboBox_SelectedIndexChanged);
            // 
            // btn_hud
            // 
            this.btn_hud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hud.AutoSize = true;
            this.btn_hud.Location = new System.Drawing.Point(424, 15);
            this.btn_hud.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_hud.Name = "btn_hud";
            this.cHUDTableLayoutPanel.SetRowSpan(this.btn_hud, 2);
            this.btn_hud.Size = new System.Drawing.Size(94, 57);
            this.btn_hud.TabIndex = 31;
            this.btn_hud.Text = "Customize";
            this.btn_hud.UseVisualStyleBackColor = true;
            this.btn_hud.Click += new System.EventHandler(this.btn_hud_Click);
            // 
            // tFormCosmetics
            // 
            this.tFormCosmetics.Location = new System.Drawing.Point(8, 4);
            this.tFormCosmetics.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tFormCosmetics.Name = "tFormCosmetics";
            this.tFormCosmetics.SelectedIndex = 0;
            this.tFormCosmetics.Size = new System.Drawing.Size(326, 199);
            this.tFormCosmetics.TabIndex = 39;
            // 
            // cDrawHash
            // 
            this.cDrawHash.AutoSize = true;
            this.cDrawHash.BackColor = System.Drawing.Color.Transparent;
            this.cDrawHash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cDrawHash.Location = new System.Drawing.Point(151, 99);
            this.cDrawHash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDrawHash.Name = "cDrawHash";
            this.cDrawHash.Size = new System.Drawing.Size(135, 24);
            this.cDrawHash.TabIndex = 28;
            this.cDrawHash.Text = "Hash Icons .png";
            this.cDrawHash.UseVisualStyleBackColor = false;
            this.cDrawHash.CheckedChanged += new System.EventHandler(this.cDrawHash_CheckedChanged);
            // 
            // gGameOutput
            // 
            this.gGameOutput.Controls.Add(this.cHTMLLog);
            this.gGameOutput.Controls.Add(this.cPatch);
            this.gGameOutput.Controls.Add(this.cDrawHash);
            this.gGameOutput.Controls.Add(this.cSpoiler);
            this.gGameOutput.Controls.Add(this.cN64);
            this.gGameOutput.Controls.Add(this.cVC);
            this.gGameOutput.Location = new System.Drawing.Point(17, 624);
            this.gGameOutput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gGameOutput.Name = "gGameOutput";
            this.gGameOutput.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gGameOutput.Size = new System.Drawing.Size(302, 137);
            this.gGameOutput.TabIndex = 16;
            this.gGameOutput.TabStop = false;
            this.gGameOutput.Text = "Outputs";
            // 
            // cHTMLLog
            // 
            this.cHTMLLog.AutoSize = true;
            this.cHTMLLog.BackColor = System.Drawing.Color.Transparent;
            this.cHTMLLog.ForeColor = System.Drawing.Color.Black;
            this.cHTMLLog.Location = new System.Drawing.Point(151, 64);
            this.cHTMLLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cHTMLLog.Name = "cHTMLLog";
            this.cHTMLLog.Size = new System.Drawing.Size(149, 24);
            this.cHTMLLog.TabIndex = 14;
            this.cHTMLLog.Text = "Item Tracker .html";
            this.cHTMLLog.UseVisualStyleBackColor = false;
            this.cHTMLLog.CheckedChanged += new System.EventHandler(this.cHTMLLog_CheckedChanged);
            // 
            // cPatch
            // 
            this.cPatch.AutoSize = true;
            this.cPatch.BackColor = System.Drawing.Color.Transparent;
            this.cPatch.ForeColor = System.Drawing.Color.Black;
            this.cPatch.Location = new System.Drawing.Point(22, 99);
            this.cPatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cPatch.Name = "cPatch";
            this.cPatch.Size = new System.Drawing.Size(104, 24);
            this.cPatch.TabIndex = 15;
            this.cPatch.Text = "Patch .mmr";
            this.cPatch.UseVisualStyleBackColor = false;
            this.cPatch.CheckedChanged += new System.EventHandler(this.cPatch_CheckedChanged);
            // 
            // cSpoiler
            // 
            this.cSpoiler.AutoSize = true;
            this.cSpoiler.BackColor = System.Drawing.Color.Transparent;
            this.cSpoiler.ForeColor = System.Drawing.Color.Black;
            this.cSpoiler.Location = new System.Drawing.Point(151, 29);
            this.cSpoiler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cSpoiler.Name = "cSpoiler";
            this.cSpoiler.Size = new System.Drawing.Size(128, 24);
            this.cSpoiler.TabIndex = 8;
            this.cSpoiler.Text = "Spoiler log .txt";
            this.cSpoiler.UseVisualStyleBackColor = false;
            this.cSpoiler.CheckedChanged += new System.EventHandler(this.cSpoiler_CheckedChanged);
            // 
            // cN64
            // 
            this.cN64.AutoSize = true;
            this.cN64.BackColor = System.Drawing.Color.Transparent;
            this.cN64.Checked = true;
            this.cN64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cN64.ForeColor = System.Drawing.Color.Black;
            this.cN64.Location = new System.Drawing.Point(22, 28);
            this.cN64.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cN64.Name = "cN64";
            this.cN64.Size = new System.Drawing.Size(125, 24);
            this.cN64.TabIndex = 10;
            this.cN64.Text = "N64 ROM .z64";
            this.cN64.UseVisualStyleBackColor = false;
            this.cN64.CheckedChanged += new System.EventHandler(this.cN64_CheckedChanged);
            // 
            // cVC
            // 
            this.cVC.AutoSize = true;
            this.cVC.BackColor = System.Drawing.Color.Transparent;
            this.cVC.ForeColor = System.Drawing.Color.Black;
            this.cVC.Location = new System.Drawing.Point(22, 63);
            this.cVC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cVC.Name = "cVC";
            this.cVC.Size = new System.Drawing.Size(110, 24);
            this.cVC.TabIndex = 9;
            this.cVC.Text = "Wii VC .wad";
            this.cVC.UseVisualStyleBackColor = false;
            this.cVC.CheckedChanged += new System.EventHandler(this.cVC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ROM must be Majora\'s Mask (U) ending with \".z64\"";
            // 
            // bApplyPatch
            // 
            this.bApplyPatch.Location = new System.Drawing.Point(408, 13);
            this.bApplyPatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bApplyPatch.Name = "bApplyPatch";
            this.bApplyPatch.Size = new System.Drawing.Size(131, 72);
            this.bApplyPatch.TabIndex = 16;
            this.bApplyPatch.Text = "Apply Patch";
            this.bApplyPatch.UseVisualStyleBackColor = true;
            this.bApplyPatch.Click += new System.EventHandler(this.bApplyPatch_Click);
            // 
            // saveROM
            // 
            this.saveROM.DefaultExt = "z64";
            this.saveROM.Filter = "ROM files|*.z64";
            // 
            // cTunic
            // 
            this.cTunic.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
            // 
            // bRandomise
            // 
            this.bRandomise.Location = new System.Drawing.Point(408, 13);
            this.bRandomise.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bRandomise.Name = "bRandomise";
            this.bRandomise.Size = new System.Drawing.Size(131, 72);
            this.bRandomise.TabIndex = 5;
            this.bRandomise.Text = "Randomize";
            this.bRandomise.UseVisualStyleBackColor = true;
            this.bRandomise.Click += new System.EventHandler(this.bRandomise_Click);
            // 
            // saveWad
            // 
            this.saveWad.DefaultExt = "wad";
            this.saveWad.Filter = "VC files|*.wad";
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mCustomise,
            this.toolsToolStripMenuItem,
            this.mHelp});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mMenu.Size = new System.Drawing.Size(905, 30);
            this.mMenu.TabIndex = 12;
            this.mMenu.Text = "mMenu";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.loadSettingsToolStripMenuItem,
            this.mExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(46, 24);
            this.mFile.Text = "File";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings...";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.SaveSettingsToolStripMenuItem_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.loadSettingsToolStripMenuItem.Text = "Load Settings...";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.LoadSettingsToolStripMenuItem_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(191, 26);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mCustomise
            // 
            this.mCustomise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDPadConfig});
            this.mCustomise.Name = "mCustomise";
            this.mCustomise.Size = new System.Drawing.Size(92, 24);
            this.mCustomise.Text = "Customize";
            // 
            // mDPadConfig
            // 
            this.mDPadConfig.Name = "mDPadConfig";
            this.mDPadConfig.Size = new System.Drawing.Size(228, 26);
            this.mDPadConfig.Text = "D-Pad Configuration";
            this.mDPadConfig.Click += new System.EventHandler(this.mDPadConfig_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLogicEdit});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mLogicEdit
            // 
            this.mLogicEdit.Name = "mLogicEdit";
            this.mLogicEdit.Size = new System.Drawing.Size(172, 26);
            this.mLogicEdit.Text = "Logic editor";
            this.mLogicEdit.Click += new System.EventHandler(this.mLogicEdit_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mManual,
            this.mSep1,
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(55, 24);
            this.mHelp.Text = "Help";
            // 
            // mManual
            // 
            this.mManual.Name = "mManual";
            this.mManual.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mManual.Size = new System.Drawing.Size(165, 26);
            this.mManual.Text = "Manual";
            this.mManual.Click += new System.EventHandler(this.mManual_Click);
            // 
            // mSep1
            // 
            this.mSep1.Name = "mSep1";
            this.mSep1.Size = new System.Drawing.Size(162, 6);
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(165, 26);
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // openBROM
            // 
            this.openBROM.Filter = "ROM files|*.z64;*.v64;*.n64";
            // 
            // pProgress
            // 
            this.pProgress.Location = new System.Drawing.Point(17, 789);
            this.pProgress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pProgress.Name = "pProgress";
            this.pProgress.Size = new System.Drawing.Size(871, 29);
            this.pProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pProgress.TabIndex = 13;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Transparent;
            this.lStatus.Location = new System.Drawing.Point(15, 764);
            this.lStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(59, 20);
            this.lStatus.TabIndex = 13;
            this.lStatus.Text = "Ready...";
            // 
            // tSeed
            // 
            this.tSeed.Location = new System.Drawing.Point(103, 16);
            this.tSeed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tSeed.MaxLength = 10;
            this.tSeed.Name = "tSeed";
            this.tSeed.Size = new System.Drawing.Size(295, 27);
            this.tSeed.TabIndex = 2;
            this.tSeed.Enter += new System.EventHandler(this.tSeed_Enter);
            this.tSeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tSeed_KeyDown);
            this.tSeed.Leave += new System.EventHandler(this.tSeed_Leave);
            // 
            // lSeed
            // 
            this.lSeed.AutoSize = true;
            this.lSeed.BackColor = System.Drawing.Color.Transparent;
            this.lSeed.ForeColor = System.Drawing.Color.Black;
            this.lSeed.Location = new System.Drawing.Point(1, 20);
            this.lSeed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lSeed.Name = "lSeed";
            this.lSeed.Size = new System.Drawing.Size(103, 20);
            this.lSeed.TabIndex = 3;
            this.lSeed.Text = "Random seed:";
            // 
            // cDummy
            // 
            this.cDummy.AutoSize = true;
            this.cDummy.Enabled = false;
            this.cDummy.Location = new System.Drawing.Point(782, 776);
            this.cDummy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cDummy.Name = "cDummy";
            this.cDummy.Size = new System.Drawing.Size(101, 24);
            this.cDummy.TabIndex = 9;
            this.cDummy.Text = "checkBox1";
            this.cDummy.UseVisualStyleBackColor = true;
            this.cDummy.Visible = false;
            // 
            // openPatch
            // 
            this.openPatch.Filter = "MMR Patch files|*.mmr";
            // 
            // ttOutput
            // 
            this.ttOutput.Controls.Add(this.tpOutputSettings);
            this.ttOutput.Controls.Add(this.tpPatchSettings);
            this.ttOutput.Location = new System.Drawing.Point(330, 627);
            this.ttOutput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ttOutput.Name = "ttOutput";
            this.ttOutput.SelectedIndex = 0;
            this.ttOutput.Size = new System.Drawing.Size(560, 137);
            this.ttOutput.TabIndex = 15;
            this.ttOutput.SelectedIndexChanged += new System.EventHandler(this.ttOutput_Changed);
            // 
            // tpOutputSettings
            // 
            this.tpOutputSettings.Controls.Add(this.bRandomise);
            this.tpOutputSettings.Controls.Add(this.tSeed);
            this.tpOutputSettings.Controls.Add(this.lSeed);
            this.tpOutputSettings.Location = new System.Drawing.Point(4, 29);
            this.tpOutputSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpOutputSettings.Name = "tpOutputSettings";
            this.tpOutputSettings.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpOutputSettings.Size = new System.Drawing.Size(552, 104);
            this.tpOutputSettings.TabIndex = 0;
            this.tpOutputSettings.Text = "Output settings";
            this.tpOutputSettings.UseVisualStyleBackColor = true;
            // 
            // tpPatchSettings
            // 
            this.tpPatchSettings.Controls.Add(this.tPatch);
            this.tpPatchSettings.Controls.Add(this.bApplyPatch);
            this.tpPatchSettings.Controls.Add(this.bLoadPatch);
            this.tpPatchSettings.Location = new System.Drawing.Point(4, 29);
            this.tpPatchSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpPatchSettings.Name = "tpPatchSettings";
            this.tpPatchSettings.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tpPatchSettings.Size = new System.Drawing.Size(552, 104);
            this.tpPatchSettings.TabIndex = 1;
            this.tpPatchSettings.Text = "Patch settings";
            this.tpPatchSettings.UseVisualStyleBackColor = true;
            // 
            // tPatch
            // 
            this.tPatch.Location = new System.Drawing.Point(8, 53);
            this.tPatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tPatch.Name = "tPatch";
            this.tPatch.ReadOnly = true;
            this.tPatch.Size = new System.Drawing.Size(390, 27);
            this.tPatch.TabIndex = 17;
            // 
            // bLoadPatch
            // 
            this.bLoadPatch.Location = new System.Drawing.Point(7, 9);
            this.bLoadPatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bLoadPatch.Name = "bLoadPatch";
            this.bLoadPatch.Size = new System.Drawing.Size(137, 40);
            this.bLoadPatch.TabIndex = 16;
            this.bLoadPatch.Text = "Load Patch...";
            this.bLoadPatch.UseVisualStyleBackColor = true;
            this.bLoadPatch.Click += new System.EventHandler(this.BLoadPatch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bopen);
            this.Controls.Add(this.tROMName);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.gGameOutput);
            this.Controls.Add(this.ttOutput);
            this.Controls.Add(this.cDummy);
            this.Controls.Add(this.pProgress);
            this.Controls.Add(this.tSettings);
            this.Controls.Add(this.mMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.mmrMain_Load);
            this.tSettings.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tOtherCustomizations.ResumeLayout(false);
            this.tOtherCustomization.ResumeLayout(false);
            this.tOtherCustomization.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabItemPool.ResumeLayout(false);
            this.tabItemPool.PerformLayout();
            this.tabGimmicks.ResumeLayout(false);
            this.tabGimmicks.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabComfort.ResumeLayout(false);
            this.gSpeedUps.ResumeLayout(false);
            this.gSpeedUps.PerformLayout();
            this.gHints.ResumeLayout(false);
            this.gHints.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabShortenCutscenes.ResumeLayout(false);
            this.tabCosmetics.ResumeLayout(false);
            this.gCosmeticOther.ResumeLayout(false);
            this.gCosmeticOther.PerformLayout();
            this.gCosmeticMusicSound.ResumeLayout(false);
            this.gCosmeticMusicSound.PerformLayout();
            this.cHUDGroupBox.ResumeLayout(false);
            this.cHUDGroupBox.PerformLayout();
            this.cHUDTableLayoutPanel.ResumeLayout(false);
            this.cHUDTableLayoutPanel.PerformLayout();
            this.gGameOutput.ResumeLayout(false);
            this.gGameOutput.PerformLayout();
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ttOutput.ResumeLayout(false);
            this.tpOutputSettings.ResumeLayout(false);
            this.tpOutputSettings.PerformLayout();
            this.tpPatchSettings.ResumeLayout(false);
            this.tpPatchSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bopen;
        private System.Windows.Forms.OpenFileDialog openROM;
        private System.Windows.Forms.OpenFileDialog openPatch;
        private System.Windows.Forms.OpenFileDialog openLogic;
        private System.Windows.Forms.OpenFileDialog loadSettings;
        private System.Windows.Forms.TextBox tROMName;
        private System.Windows.Forms.ComboBox cMode;
        private System.Windows.Forms.Label lMode;
        private System.Windows.Forms.SaveFileDialog saveROM;
        private System.Windows.Forms.SaveFileDialog saveSettings;
        private System.Windows.Forms.ComboBox cLink;
        private System.Windows.Forms.Label lLink;
        private System.Windows.Forms.CheckBox cQText;
        private System.Windows.Forms.CheckBox cEnemy;
        private System.Windows.Forms.CheckBox cDEnt;
        private System.Windows.Forms.CheckBox cMixSongs;
        private System.Windows.Forms.ColorDialog cEnergy;
        private System.Windows.Forms.ColorDialog cTunic;
        private System.Windows.Forms.Button bRandomise;
        private System.Windows.Forms.TabControl tSettings;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabComfort;
        private System.Windows.Forms.Label lFloors;
        private System.Windows.Forms.Label lGravity;
        private System.Windows.Forms.Label lDType;
        private System.Windows.Forms.Label lDMult;
        private System.Windows.Forms.ComboBox cFloors;
        private System.Windows.Forms.ComboBox cDType;
        private System.Windows.Forms.ComboBox cDMult;
        private System.Windows.Forms.ComboBox cGravity;
        private System.Windows.Forms.SaveFileDialog saveWad;
        private System.Windows.Forms.CheckBox cVC;
        private System.Windows.Forms.CheckBox cN64;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mManual;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripSeparator mSep1;
        private System.Windows.Forms.OpenFileDialog openBROM;
        private System.Windows.Forms.ToolStripMenuItem mCustomise;
        private System.Windows.Forms.ProgressBar pProgress;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tSeed;
        private System.Windows.Forms.Label lSeed;
        private System.Windows.Forms.CheckBox cDummy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cFreeHints;
        private System.Windows.Forms.CheckBox cPatch;
        private System.Windows.Forms.Button bApplyPatch;
        private System.Windows.Forms.TabControl ttOutput;
        private System.Windows.Forms.TabPage tpOutputSettings;
        private System.Windows.Forms.TabPage tpPatchSettings;
        private System.Windows.Forms.TextBox tPatch;
        private System.Windows.Forms.Button bLoadPatch;
        private System.Windows.Forms.CheckBox cClearHints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lNutAndStickDrops;
        private System.Windows.Forms.ComboBox cNutAndStickDrops;
        private System.Windows.Forms.ComboBox cClockSpeed;
        private System.Windows.Forms.CheckBox cHideClock;
        private System.Windows.Forms.CheckBox cNoDowngrades;
        private System.Windows.Forms.Label lGossip;
        private System.Windows.Forms.ComboBox cGossipHints;
        private System.Windows.Forms.CheckBox cShopAppearance;
        private System.Windows.Forms.CheckBox cEponaSword;
        private System.Windows.Forms.CheckBox cUpdateChests;
        private System.Windows.Forms.GroupBox gGameOutput;
        private System.Windows.Forms.TextBox tbUserLogic;
        private System.Windows.Forms.Button bLoadLogic;
        private System.Windows.Forms.ComboBox cBlastCooldown;
        private System.Windows.Forms.Label lBlastMask;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bStartingItemEditor;
        private System.Windows.Forms.TextBox tStartingItemList;
        private System.Windows.Forms.Label lCustomStartingItemAmount;
        private System.Windows.Forms.CheckBox cGoodDogRaceRNG;
        private System.Windows.Forms.CheckBox cFasterLabFish;
        private System.Windows.Forms.CheckBox cGoodDampeRNG;
        private System.Windows.Forms.CheckBox cSkipBeaver;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lJunkLocationsAmount;
        private System.Windows.Forms.Button bJunkLocationsEditor;
        private System.Windows.Forms.TextBox tJunkLocationsList;
        private System.Windows.Forms.ToolStripMenuItem mDPadConfig;
        private System.Windows.Forms.CheckBox cSunsSong;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cUnderwaterOcarina;
        private System.Windows.Forms.CheckBox cDrawHash;
        private System.Windows.Forms.CheckBox cQuestItemStorage;
        private System.Windows.Forms.CheckBox cDisableCritWiggle;
        private System.Windows.Forms.CheckBox cFastPush;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gHints;
        private System.Windows.Forms.TabPage tabGimmicks;
        private System.Windows.Forms.CheckBox cHTMLLog;
        private System.Windows.Forms.CheckBox cSpoiler;
        private System.Windows.Forms.GroupBox gSpeedUps;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLogicEdit;
        private System.Windows.Forms.CheckBox cEnableNightMusic;
        private System.Windows.Forms.CheckBox cFreestanding;
        private System.Windows.Forms.CheckBox cFDAnywhere;
        private System.Windows.Forms.CheckBox cArrowCycling;
        private System.Windows.Forms.CheckBox cFasterBank;
        private System.Windows.Forms.CheckBox cCloseCows;
        private System.Windows.Forms.ComboBox cLowHealthSFXComboBox;
        private System.Windows.Forms.Label lLowHealthSFXComboBox;
        private System.Windows.Forms.Button bToggleTricks;
        private System.Windows.Forms.CheckBox cByoAmmo;
        private System.Windows.Forms.CheckBox cDeathMoonCrash;
        private System.Windows.Forms.CheckBox cElegySpeedups;
        private System.Windows.Forms.CheckBox cContinuousDekuHopping;
        private System.Windows.Forms.CheckBox cProgressiveUpgrades;
        private System.Windows.Forms.Label lIceTraps;
        private System.Windows.Forms.ComboBox cIceTrapsAppearance;
        private System.Windows.Forms.ComboBox cIceTraps;
        private System.Windows.Forms.CheckBox cIceTrapQuirks;
        private System.Windows.Forms.TabPage tabCosmetics;
        private System.Windows.Forms.CheckBox cSFX;
        private System.Windows.Forms.CheckBox cTargettingStyle;
        private System.Windows.Forms.Label lTatl;
        private System.Windows.Forms.GroupBox cHUDGroupBox;
        private System.Windows.Forms.TableLayoutPanel cHUDTableLayoutPanel;
        private System.Windows.Forms.ComboBox cHUDHeartsComboBox;
        private System.Windows.Forms.Label cHeartsLabel;
        private System.Windows.Forms.Label cMagicLabel;
        private System.Windows.Forms.ComboBox cHUDMagicComboBox;
        private System.Windows.Forms.Button btn_hud;
        private System.Windows.Forms.Label lMusic;
        private System.Windows.Forms.CheckBox cCombatMusicDisable;
        private System.Windows.Forms.ComboBox cTatl;
        private System.Windows.Forms.ComboBox cMusic;
        private System.Windows.Forms.TabControl tFormCosmetics;
        private System.Windows.Forms.CheckBox cHueShiftMiscUI;
        private System.Windows.Forms.GroupBox gCosmeticOther;
        private System.Windows.Forms.GroupBox gCosmeticMusicSound;
        private System.Windows.Forms.TabPage tabShortenCutscenes;
        private System.Windows.Forms.TabControl tShortenCutscenes;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tOtherCustomizations;
        private System.Windows.Forms.TabPage tOtherCustomization;
        private System.Windows.Forms.TabPage tabItemPool;
        private System.Windows.Forms.TableLayoutPanel tableItemPool;
        private System.Windows.Forms.Button bItemPoolEdit;
        private System.Windows.Forms.TextBox tItemPool;
        private System.Windows.Forms.Label lItemPoolText;
        private System.Windows.Forms.ComboBox cStartingItems;
        private System.Windows.Forms.Label lStartingItems;
        private System.Windows.Forms.CheckBox cInstantPictobox;
        private System.Windows.Forms.CheckBox cImprovedPictobox;
    }
}

